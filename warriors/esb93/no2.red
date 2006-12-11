;redcode
;name No.2
;author Automatic Player
;    Warrior: Ecstacy
;  File name: xtc.red
; Tournament: ICWST'90 Winner
;   Standard: CWS'88
;     Author: Stefan Roettger / Sandstrasse 3 / W-8525 Uttenreuth / Germany
;

loop  add #412, ptr
ptr   jmz loop, trap
      mov ptr,  dest
cnt   mov #23,  cnt
kill  mov @trap, <dest
      djn kill, cnt
      jmp loop
      dat #0
      dat #0
      dat #0
      dat #0
      dat #0
      dat #0
dest  dat #0
      dat #0
      dat #0
      dat #0
      dat #0
      dat #0
trap  dat #bomb
bomb  spl trap, trap
