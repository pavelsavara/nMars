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
