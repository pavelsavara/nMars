;redcode-b quiet
;name Neverland
;author John Metcalf
;strategy Carpet-bombing mini-scanner (6 instructions)
;strategy 128.0 Wilkies
;assert CORESIZE==8000
step equ 4956
r:   mov.b @loop,    r-1
loop:add   #step,    p
     mov   @bomb-1,  >r-1
p:   jmz   loop,     }step-1
     jmp   r,        }1
bomb:spl   #1,       <0
     end   r
