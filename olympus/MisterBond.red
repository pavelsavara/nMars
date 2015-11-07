;redcode-94
;name Mister Bond
;NSFCWT Round 7

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy quick boot out to random position
;strategy then stun/stun/kill coreclear 
;strategy with half hearted attempt at a gate
;strategy if I won last time then boot to the
;strategy same position as last time ...

;strategy Written in '94 code.
;strategy ... even though I needn't have used Pspace.
;strategy ... if I keep this up I may even get to like it!
;strategy Submitted to NSFCWT Round 007: 1st December 1995

;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80

pRESULT equ #0
pSEED   equ #1

filler  for 217
        dat 3057+filler, 124-filler
        rof
start   
seed    ldp pSEED, #seed
        add.b seed, clear
        mov {decoy, <clear
        mov {decoy, <clear
        mov {decoy, <clear
        mov {decoy, <clear
        mov {decoy, <clear
        mov {decoy, <clear
clear   spl @clear, fini+2000
result  ldp pRESULT, #result
        mod #2, result
        add.b result, store
decoy   mov #fini, -1
        mul #5713, seed
        add #627, seed
        mod #4997, seed
store   stp seed, pSEED

aim     jmp stun-aim, fini+2
kill    dat <2667, <5334
clear2  spl #kill-aim, fini+2-aim
stun    spl #clear2-aim, fini+2-aim
loop    mov *aim, >aim
        djn.f loop, {aim-200
fini
filler  for 197
        dat 3057+filler, 124-filler
        rof

        for 20
        dat 1, 1
        rof

filler  for 10
        dat 3057+filler, 124-filler
        rof 
        
        for 10
        dat 0, 0
        rof
        
        for 20
        dat 1, 1
        rof


        end start
