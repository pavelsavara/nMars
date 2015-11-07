;redcode-94
;name Perspire
;author Robert Macrae
;strategy P-space switcher for variable size arena

; Chooses between two strategies according to past performance. 
; Should work against non-p warriors, but not reactive to changes.
; Unfortunately I took so long to write switcher, I haven't 
; optimised the choices... Launches in about 55 cycles.

;remassert VERSION>=80 && ROUNDS>30 && WARRIORS=2  

            pin 8371

_RESULT     equ #0  ; initialized with the last round result
_COUNT1     equ #91 ; user-defined round counter for choice 1
_COUNT2     equ #92 ; user-defined round counter for choice 2
_POINTS1    equ #93 ; user-defined points counter for choice 1
_POINTS2    equ #94 ; user-defined points counter for choice 2
_SANITY     equ #95 ; user-defined check on brainwashing!
_BOMBRUN    equ #96 ; user-defined bomb-run length    
_STRAT      equ #97 ; user-defined last strategy used (1 or 2)
NOTMAD      equ #1784 ; check value as protection vs brainwashing

sanity  ldp     _SANITY,        #0
        seq     sanity,         NOTMAD    
score   jmp     round1,         #0       ; round1, or brainwashed.
result  ldp     _RESULT,        #0       ; Get result.

strata  ldp     _STRAT,         #0       ; Strat is 1 or 2
count1  ldp     _COUNT1,        #0       ; rounds for strat 1
count2  ldp     _COUNT2,        #0       ; rounds for strat 2 
stratb  ldp     _STRAT,         #0       ; Strat is 1 or 2
points1 ldp     _POINTS1,       #0       ; points for strat 1 
points2 ldp     _POINTS2,       #0       ; points for strat 21 
        
        jmz     update,         result   ; zero indicates loss 
        sne.ab  #1,             result
        add.ab  #2,             score    ; 3 for a win
        add.ab  #1,             score    ; 1 for a draw

update  mov.x   @strata,        storc    ; appropriate count      
       
        add.a   #1,             storc    ; increment
storc   stp     #0,             #0       ; update counter.
        mov.ab  storc,          @strata  ; and copy
        mov.x   @stratb,        storp    ; appropriate points 
        add.ba  score,          storp    ; add score
storp   stp     #0,             #0       ; update points.
        mov.ab  storp,          @stratb  ; and copy
  
merit1  mul     points1,        #10    
merit2  mul     points2,        #10    
        div.b   count1,         merit1
        div.b   count2,         merit2   ; Calculate merits
        slt.b   merit1,         merit2   ; Ties go to [1]...
        jmp     paper                    ; strategy [1]
        jmp     scanner                  ; strategy [2]
        
cleaner mov.i   #0,             1        ; Clean up STPs.

; strategy still needs to store it's name in _STRAT        
;       stp     #1,             _STRAT      
;       stp     #2,             _STRAT   ; save better strategy

round1  stp     NOTMAD,         _SANITY  
        div.a   #8,             1
        stp     #-1,            _BOMBRUN       ; use (n-1)/8. 
      
        stp     #1,             _COUNT1        ; rounds for strat 1
        stp     #1,             _COUNT2        ; rounds for strat 2 
        stp     #1,             _STRAT         ; Strat is 1 or 2
        stp     #10,            _POINTS1       ; points for strat 1 
        stp     #10,            _POINTS2       ; points for strat 2 
;       jmp     paper

; Choice of 10 initial points each rather arbitrary; it is enough to
; stop a few early losses from discrediting a good alternative, low 
; enough that bad alternatives are dropped fairly quickly. 


;  -----------------------------------------------------------------

; Paper (like nobody -- at least nobody special)
; and nowhere near finished...

STEP1   EQU     2570
STEP2   EQU     1130
STEP3   EQU     -470
BOMB1   EQU     cp1-71        ; Shouldn't hit self?
BOMB2   EQU     cp1-91                

paper   stp     #1,       _STRAT  

        mov     sboot,    storc  
        mov     sboot,    storp
        mov     sboot,    paper
        mov     sboot,    scanner

        spl     cleaner                 ; imp to remove rest of stps
        spl     1
pto     spl     1,        400
pfrom   spl     1,        cp3+1         ; 8 process

        mov     <pfrom,   <pto
        jmp     @pto                    ; boot (any QS out there?)

cp1     spl     @0,       }STEP1         
        mov.i   }-1,      >-1
cp2     spl     @0,       }STEP2
        mov.i   }-1,      >-1
bomb    mov.i   >BOMB1,   {BOMB2        ; Bomb
        add.f   #bomb+STEP2,bomb+STEP2  ; Step next Bomb
        mov.i   {cp2,     <1
cp3     jmp     @0,       >STEP3+8      ; +8 keeps code aligned...


;  ------------------------------------------------------------------

; Taken
; sne.x/seq.x scanner using spl-spl-jmp bomb and
; continuous forward-clear. P.Kline may recognise it.
; Reparametarised for random-size core?

step    equ    31                   ; Should be prime? Big enough?

scanner stp     #2,       _STRAT 
        ldp     _BOMBRUN, #0
        mov.b   -1,       ctr
         
        mov    <sboot,    {sboot
        mov    <sboot,    {sboot
        djn    -2,        #8
        jmp    sboot+291

first
jump    jmp    -2,last+2           
reset   dat    #step-2,#step        ; check this still works. 

attack  mov    jump,*comp           ; drop wide bomb on a-pointer
compptr mov    split,{comp
        mov    split,{comp          ; after bombing, reset to
        sub    reset,@compptr       ; make b-ptr the next a-ptr
        
scan    add    split,@compptr
comp    sne.i  2*step,3*step        ; take a look
        add    split,@compptr
        seq.i  *comp,@comp          ; take another look
        slt    #last-comp+step,@compptr  ; don't attack self

; Looks at .b, and .a is attacked. Is my formula right?

ctr     djn    scan,#1000           ; countdown to finish
        jmn    attack,-1

split   spl    #(2*step),#(2*step)
clear   mov    reset,>jump        
        djn.f  -1,{ctr-step         ; should decrement to ctr...
last    

sboot   dat    #300,#0
