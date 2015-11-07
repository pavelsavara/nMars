;redcode-94x
;name  Dying to Know %0
;dist %240 rnd 0
;author Dave Hillis
;strategy - Experimenting with P^3 tables
;assert CORESIZE==55440

;The number of ties against the sleeper 
;(minus the round number)
;is the answer = starting position%240

;
PIN 5339

_RESULT equ #0          
_ROUNDS equ #2236       
_BOOT   equ #2237
_FRIEND equ #2240
_ENEMY  equ #2242
_LOSE   equ #2256
_WIN    equ _LOSE+1                                                      
           
_SANE   equ #2245
_TEST   equ #2260
notmad  equ #3276

_SLEEP          equ #555
S_CODE          equ #200
_COUNTER        equ # 193  
_DIST           equ #12; holds the distance from first rnd
WRAP            equ   110
THE_RND equ #0
        
first   stp     S_CODE, _SLEEP       ; activate the sleeper
thecnt  ldp _COUNTER, #0     ;increment a round counter 
        add.ab #1, -1
        stp.b -2, _COUNTER      

;       seq.ab  #1, thecnt
        seq.ab  THE_RND +1, thecnt
        jmp report
;scan till I find the other warrior
        jmz #0, }first
        add.a   #-1, first
;falls through when it finds something
;       div.a   #240, first
        mod.a   #240, first
        stp.ab  first, _DIST
        

report
        ldp     _DIST, #0
;       slt.ab # WRAP, $ thecnt
        slt.b $ -1, $ thecnt
doze    jmp #0, #0

kill    spl #0, #0
        mov 1, }1
        dat 100, 100
;
