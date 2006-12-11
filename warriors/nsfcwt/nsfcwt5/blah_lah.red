;redcode-94
;nsfcwt round 5
;name blah blah blah
;author M R Bremer
;strategy       divine intervention.
;strategy       some mutant code from a variety of sources.
;strategy	juliet core for bombing
;strategy       pspace with heavy bombing paper.

step EQU 445
PSTEP1   EQU     1800+8000
PSTEP2   EQU     3740+8000
PSTEP3   EQU     4378
_RES    equ     #0
_STR    equ     #111    

org res

p1      spl p2, {-4000
        spl 1, <-1000
        spl 1, <-2000
        spl 1, <-3000
        spl @0, <PSTEP1 
        mov }-1, >-1
        mov gate, <4000
        spl @0, <PSTEP2
        mov }-1, >-1
        mov gate, <10000
        mov {-3, {1
        djn.f PSTEP3, <-6000
gate    dat 1, 2  
        dat 2, 3
        dat 3, 4
for 15
        dat 0, 0
rof

res     ldp.ab  _RES,   #0
str     ldp.a   _STR,   str1    ;load strategy in use
        sne.ab  #0,     res     ;check result
lost    add.a   #1,     str1    ;lost change 
        mod.a   #2,     str1    ;secure result
win     stp.ab  str1,   _STR
str1    jmp     @0,     boot+1
        dat     0,      p1
for 19
        dat 0, 0
rof
s       spl #445, <-445
        spl #0, <-446
        mov {445-1, -445+2
        add -3, -1
        djn.f -2, <-2667-500
boot    dat 9999, 0
        mov boot-1, {boot
        mov boot-2, {boot
        mov boot-3, {boot
        mov boot-4, {boot
        mov boot-5, {boot
        jmp *boot, <2000
for 15
        dat 0, 0
rof
p2      spl 1, {1000
        spl 1, {2000
        spl 1, {3000
        spl @0, <PSTEP1 
        mov }-1, >-1
        mov gate2, <4000
        spl @0, <PSTEP2
        mov }-1, >-1
        mov gate2, <10000
        mov {-3, {1
        djn.f PSTEP3, <-6000
gate2   dat 1, 2  
        dat 2, 3
        dat 3, 4
