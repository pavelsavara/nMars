STEP    equ 68                      ;scan constants:
DIST    equ 34                      ;small, so can be reused in core clear
FIRST   equ comp-(STEP*93)          ;determines duration of scan

scan    add incr,comp
comp    cmp FIRST-DIST,FIRST
        slt #incr-comp+DIST+1,comp  ;don't hit self (and in shadow)
	djn scan,<FIRST+189
        mov jump,@comp
        mov split,<comp
        add switch,comp             ;switch A- and B-fields
jump    jmz @-1,0                   ;continue if not decremented, else
split   spl 0,0                     ;clear core
switch  mov @0-DIST,<1-DIST
incr    dat #0-STEP,#0-STEP
