;redcode-94
;name Juliet Storm+Spiral
;author John Wilkinson
;strategy Ripped off Juliet Storm.  Added a slightly larger spiral.
;strategy Storm is a good stone for round 3 because it doesn't
;strategy self-destruct, and spawns lots of processes...

ptr     EQU -1333
d       equ 2667
i       equ imp

org bstone

gate2   dat <-445, <-446
s       spl #445, <-445
        spl #0, <-446
        mov {445-1, -445+2
        add -3, -1
        djn.f -2, <-2667-500
        mov 33, <-20
go      dat #0, #ptr
bstone  mov {go, <go
        mov {go, <go
        mov {go, <go
        mov {go, <go
        mov {go, <go
        mov {go, <go
        mov gate2, ptr+24
        spl @go, <-4000
        jmp imp+1, <-4013
for 10
        dat 1, 1
rof

imp:       mov.i #1,    2667
           spl.a  1,     <-200
           spl.a  1,     <-300
           spl.a  1,     <-400
ssp2:      spl    2,     S
           jmp.a @j,     {0
           jmp.a *j,     {0
           dat   #i+5,     #i+2*d+4
           dat   #i+1*d+4, #i+4
           dat   #i+2*d+3, #i+1*d+3
           dat   #i+3,     #i+2*d+2
           dat   #i+1*d+2, #i+2
           dat   #i+2*d+1, #i+1*d+1
           dat   #i+1,     #i+2*d
j:         dat   #i+1*d,   #i
