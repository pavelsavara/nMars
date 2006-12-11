;redcode-94
;name Interloper
;author David Moore
;strategy lots of decrements + an imp
;assert 1

;not very competitive - I wonder how much Magnus will beat it by?

step equ 2667

      dat <2667, <5334
      dat <2667, <5334
anti  dat <2667, <5334
      dat <2667, <5334

start spl iboot,  0
      mov  anti, >20
      mov  anti, >20
      mov  anti, >20
      mov  anti, >20
main  spl    #0, <-20
      add   #98,  1
      djn.f  -1, <0

for 10
      dat 0, 0
rof

for 10
      dat 0, 5
rof

iboot spl 3, 0
      spl 2, 0
      mov imp, imp-step
      spl imp-step, 0
      spl imp+step, 0
imp   mov.i #0, step

end start
