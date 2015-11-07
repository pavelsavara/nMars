;redcode
;name Laugh-all-you-like
;author John Metcalf
;strategy Trying to write something unexpected again! Comprehensive
;strategy testing showed it neither suicides or refuses to assemble.
;assert 1
 
for 0
  Unrolled stun bombing loop with p-spaced entry-point, -> dclear.
  Slightly better scorewise than no enty at all! Doesn't throw a
  bomb until the four cycle and no doubt everyone else will throw
  a bomb on their second by storing the location to bomb in
  p-space :-( However, it probably has one advantage over all other
  entries! It took me 20 mins to write, and I can go cycling while
  everyone else is still coding ;-)
rof
 
      org  start
enemy equ first+4000
pLoc equ 92
 
first:a for 34
      dat   0,0  ; spacer
      rof
 
; [p-space routine]
bomb: spl   0,       {3
start:ldp.a #0,      enemy+8
      ldp.a #pLoc,   str
      jmn.a @str,    enemy+8
      add.a #13,     str
      mod.a #100,    str
      stp.a str,     #pLoc
str:  jmp   0,       }0
 
 
; [worthless stun bombing]
circ: a for 100
      mov   bomb,    enemy+(85*a-75)%500
      rof
      djn   circ,    #2
      jmp   clear,   {enemy+13
 
      a for 100
      dat   0,0  ; spacer
      rof
 
; [d-clear]
gate: dat   0,enemy-10
      dat   0,0
cBmb: dat   {5,      {10
clear:spl   #0,      {enemy+18
      mov   cBmb,    >gate
      djn.f -1,      >gate
 
      a for 100
      dat   0,0  ; spacer
      rof
 
; [decoy]
      a for 150
      sne   enemy+(71*a)%500,enemy+(71*a+35)%500
      rof
      end
