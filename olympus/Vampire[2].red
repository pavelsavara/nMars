;
; Vampire -- seek out the enemy, drain the
; life out of him, and then erase him in his
; weakened condition
;

nprc  dat 0,500  ;The number of dummy processes
;                 that the enemy will be forced
;                 to make.
spin  spl 0,0
trap  djn 0,nprc
;
      mov null,trap
      mov nprc,spin
null  jmp 0,0

fang  jmp @1,0
bite  dat 0,1000

      dat 0,0
      dat 0,0
      dat 0,0
      dat 0,0
      dat 0,0
      dat 0,0
      dat 0,0

start mov #(spin-bite),@bite
      sub bite,@bite  ;adjust address of fang
      sub #1,bite
      mov fang,@bite
      add #7,bite
;
      cmp #500,nprc   ;have we caught anybody?
      jmp caught,0    ;yes!
      jmp start,0     ;nope.
;
; the enemy has been caught, and is currently
; being drained of energy.  So start the
; process of erasing the world.
;
caught mov #0,bite  ;start near here.
erase mov bite,@bite ;erase everything and
      sub #1,bite    ;hope he dies before we
      jmp erase,0    ;kill ourselves

end   start
