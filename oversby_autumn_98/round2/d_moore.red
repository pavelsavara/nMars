;redcode-94x
;name Waxer
;author David Moore
;strategy dirty clear
;assert CORESIZE==800 && MAXPROCESSES==800 && MAXCYCLES==16000 && MAXLENGTH==20

what  equ (main+25)
where equ (main-23)

boot  mov.f init, what
      sub.f {0, }0
      mov.ba init, where
      sub.f {0, }0
init  mov.f (main-where)+15, {250
      sub.f {0, }0

      ;;  sub.f boot, }0  ; another way to hide things
      ;;  jmn.a   {0, }0

main  spl 0,0
      mov.f what, }where
      djn.f -1, }where

end boot

