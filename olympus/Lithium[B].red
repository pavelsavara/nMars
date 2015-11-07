;redcode-94
;name Lithium
;kill Lithium
;author John K Wilkinson
;assert CORESIZE == 8000
;strategy vb - even faster boot - yay!

;Well, it's the little things that kill, eh?
;This version is exactly the same as the previous Lithium, with
;one difference.  The boot is now faster.
;
;You'll notice that the last line of the engine is a DJN line,
;with a pointer to the SPL that will be used in the coreclear.
;I use this pointer in my boot, to avoid leaving stray processes
;behind to clean up after splitting away.
;
;This version is currently scoring FOUR points better than Torch18
;on the -94 Pizza Hill.  I wonder if it's higher score will last,
;or if it's a quirk of the current make up of the Hill...?

org boot

step    equ     54
count   equ     2000
BOOTDIST equ     2300

dat 1, 1

for 46
dat sm2*3777, #sm2*4177
rof

boot    mov     }sptr,  }bptr
        mov     }sptr,  }bptr
        mov     }sptr,  }bptr
        mov     }sptr,  }bptr
        mov     }sptr,  }bptr
        mov     }sptr,  }bptr
        mov     }sptr,  }bptr
        mov     }sptr,  }bptr
        mov     }sptr,  *bptr
bptr    spl     @BOOTDIST, 0
        mov     0,      -1
        dat     0,      0

sm2     mov     step+1, >step+1         ; mov half of the incendiary
        dat     -10-341,    26
sp2     spl     #-1-step,-step          ; spl half of the incendiary
        sub     #step+step,1
msm2    mov     sm2,    *tgt2+(-step*2000)-17228
msp2    mov     sp2,    @msm2
tgt2    jmz     sp2+1,  #0
clr2    mov     @1,     >sm2-13
cp2     djn.b   clr2,   {sp2

sptr    dat     sm2,    0

for 30
dat sm2*3777, #sm2*4177
rof

dat 1, 1
