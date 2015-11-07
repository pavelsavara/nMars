;redcode-b
;name Diamond
;author WFB
;strategy Bomber based on Blue Funk.  I'm making it mainly for a p-spacer...
;stratey I hope it isn't too much of a copy...
;assert CORESIZE==8000
step    equ 3044
for 48
dat }2667,}-2667
rof
spl #1234
diamond spl #-step,<step
stone   mov >-step,step+1
        add diamond,stone
        djn.f  stone,<diamond-50
        dat #0,#0
        dat #-7
for 45
dat <-2667,<2667
rof
end diamond
