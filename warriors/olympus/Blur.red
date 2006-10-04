;redcode-94
;name Blur
;author Anton Marsden
;assert CORESIZE==8000
;strategy 0.5c scan, 0.25c carpet -> SPL/DAT core clear
;strategy Mirage 2 with a better step and some other changes.
;strategy This product is PSpace Free :-)
;kill Blur

ptr:  dat.f  $0,$step+5
      dat.f  $0,$0
      dat.f  $0,$0
      dat.f  >0,#btm-ptr+3
cc:   spl.i  #0,#btm-ptr+3     ; DJN stream protection
top:  mov.i  $cc,>ptr          ; Putting this line here enhances protection
scan: seq.i  $2*step,}2*step+5 ; A-indirect ensures B field is attacked with
      mov.b  $scan,$ptr        ; no delay. Also leaves decoy for scanners
a:    add.f  $inc,$scan
      jmn.a  $top,$scan        ; Falls through when all locations scanned
inc:  spl.a  #step,>step
      mov.i  @1,>ptr
btm:  djn.b  $inc+1,{cc
