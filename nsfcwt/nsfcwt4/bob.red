;redcode-94
;name Shell Sort
;author Robert Macrae
;strategy  Binary end-find, Shell sort, Half-smart deletion.
;strategy  (and all in structured redcode..?)
;assert CORESIZE == 8000


Pointer DAT     #512, #4521  
   ; Stores Old, New for sort routine. Initialised with Step/Ptr for findend.

Length  EQU     Pointer-1       ; Remaining variables defined via EQU to 
NumNews EQU     Pointer-2       ; shorten code.
ListEnd EQU     Pointer-3
LastListEnd 
        EQU     Pointer-4
Temp    EQU     Pointer-5

Tbdes  SLT.b   *Pointer-testb, @Pointer-testb
Tades  SLT.a   *Pointer-testa, @Pointer-testa      
				       ; Tests to use for down sort

start  JMZ.b   dels,     Pointer+4000  ; Check .a or .b
       MOV.i   Tades,    testa
       MOV.i   Tbdes,    testb         ; exchange test for up or down sort.
dels   SNE.a   #0,       Pointer+4000
       MOV.i   last+1,   deldups   

findend
       SEQ.i   @Pointer, last+1          ; Add or sub Pointer.a/2 from Pointer.b         
       ADD.ab  Pointer,  Pointer         ; until it points to first blank 
       DIV.a   #2,       Pointer         ; after the data.
       SUB.ab  Pointer,  Pointer         ; Takes around 47 cycles.
       JMN.a   findend,  Pointer
       MOV.b   Pointer,  Length         
       SUB.ab  #-3999,   Length          ; Store result in Length

findstep                                ; Step initialised to 1093
       DIV     #3,       Step           ; as Length always less than 1000.
       SLT     Step,     Length          
Step   JMP     findstep, #1093          ; Step is a VARIABLE (to save space).                

pass
       MOV     Length,   NumNews	; Start of sort proper
       SUB     Step,     NumNews
       MOV     #-3999,   ListEnd        ; Current list to examine
       MOV     #-3999,   LastListEnd
       ADD.b   NumNews,  LastListEnd    ; Final list to examine

nextnew
       MOV.ba  ListEnd,  Pointer

insert
       MOV.ab  Pointer,  Pointer        ; Pointer.A contains Old
       ADD.b   Step,     Pointer        ; Pointer.B contains Old+Step
test   SNE.b   *Pointer, @Pointer
       JMP     testa
testb  SLT.b   @Pointer, *Pointer       ; Exchange for direction
       JMP     noswap
       JMP     swap
testa  SLT.a   @Pointer, *Pointer       ; Exchange for direction
       JMP     noswap
swap   MOV.i   *Pointer, Temp
       MOV.i   @Pointer, *Pointer
       MOV.i   Temp,     @Pointer
       SUB.ba  Step,     Pointer
       SLT.ab  Pointer,  #-3999 	; Skip when Pointer out of 
data
       JMP     insert

noswap ADD.ab  #1,       ListEnd
       SEQ.b   ListEnd,  LastListEnd
       JMP     nextnew

       DIV     #3,       Step
       JMN     pass,     Step		; Continue until Step=0, finishing sort.

deldups
       MOV.ab  #-3999,   Pointer	; Re-use Pointer for duplicate deletion.
       MOV.a   #-3999,   Pointer

copy   
       MOV.i   >Pointer, *Pointer
check
       SEQ.f   @Pointer, *Pointer
       JMP     copy,     }Pointer   ; if .f!=, copy on.
       SNE.i   last+1,   @Pointer
       DAT     #0,       #0         ; if blank, finished.
       SNE.i   @Pointer, *Pointer
       JMP     check,    >Pointer   ; if .i==, nudge pointer and check next.
       MOV.f   Pointer,  Pointer+1  ; make temp pointer to possible repeats.
replace
       SNE.i   @Pointer+1, *Pointer
       MOV.i   @Pointer,   @Pointer+1 

          ; Replaces any subsequent .i==*Pointer with @Pointer, which
          ; I can deal with later. Eg 1,1  1,<1  1,1  =>  1,1  1,<1  1,<1

       ADD.ab  #1,       Pointer+1  ; Oh! The shame... 
       SNE.f   @Pointer+1, *Pointer
       JMP     replace              ; Continue replacing until no more are .f== 
       JMP     copy,     }Pointer

last   END     start


; I have made various assumptions, notably that numbers are treated 
; as mod 8000, so -1 > 1 > 0 

; "start" uses flag to disable deldups and determine direction of 
sort.
; "findend" uses a binary search to find the first blank after the 
data.
; "findstep" finds a sensible step for the first pass of the Shell 
Sort.
; "pass" conducts one insertion-sort pass treating the data as 
interleaved
;    lists each with spacing of Step. Each successive pass uses a 
smaller
;    step, finishing with a plain step=1 insertion sort.
; "deldups" deletes duplicates. "copy" handles most cases, but 
"replace" is
;    needed to deal with duplicates which are not adjacent.  


; Pascal below was used to guide the sort above and explains the 
algorithm
; better than my comments. I like the compactness of this code; 
operations
; go as n^1.25 (according to Numerical Recipes, the original source) 
which  
; by my calculation should only be 30-50% slower than n log n sorts 
up to
; n=1000... This program started in Fortran, was machine translated 
to Pascal,
; had C improvements incorporated and ended in Redcode. Unusual.


program Shell5;

{ Sorts an array using shell algorithm as given in C version; note 
improved
  step-choice. Version 5 is modified to use red-like constructs. }

uses WinCRT;

CONST
   Start=4001;
   Length=19;
TYPE
   glnarray = ARRAY [Start..Start+Length] OF extended;
VAR
   Pass,Step,Log2Len,New,NumNews,
   ListEnd,LastListEnd,Old: longint;
   temp: extended;
   arr : glnarray;
LABEL 3;

BEGIN
   randomize;
   FOR New := Start to Start+Length do
      arr[New] := random;


   Step := 1093;
   repeat
      Step := Step div 3;         { 4,13,40,121,364 are alternatives 
in our case. }
   until Step<Length;             { Down recursion (15-3 in 4) beats 
lookup (4-8 in 8)? }
                                  { and up recursion (4-20 in 5)? }

{pass}
   repeat
      NumNews := Length-Step;                { Number of New items 
which will be checked }
      LastListEnd := Start+NumNews;

      ListEnd := Start;
{nextnew}
      repeat                                 { For each one }
         BEGIN
         Old := ListEnd;                     { Old is last member of 
(ready-sorted) list }
{insert}
3:       New := Old+Step;                    { New is candidate to 
slot in }
         IF (arr[New] < arr[Old]) THEN       { If New is out of 
order, swap with Old... }
            BEGIN
            temp     := arr[Old];
            arr[Old] := arr[New];
            arr[New] := temp;
            Old := Old-Step;                 { and test against Old's 
predecessor }
            IF (Old >= Start) THEN GOTO 3
            END
         END;
      inc(ListEnd);                          { loop through rest of 
ListEnds }
      until ListEnd = LastListEnd;

      Step := Step DIV 3;                    { reduce step and 
re-sort. }
   until Step = 0;

   FOR New := Start to Start+Length do
      write (arr[New]:8:4, ' ');
end.


