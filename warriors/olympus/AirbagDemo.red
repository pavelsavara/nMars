;redcode-94
;name Airbag Demo
;author David Moore
;assert 1

org start

p   spl #1, 100

    dat 0,0
    dat 0,0
    dat 0,0
    dat 0,0

a   mov     {p, >p
b   mov     }p, >p
c   mov     {p, >p
d   jmn.b    a, }p  ;if a, b, or c failed, then don't jump

phase2   jmp 0

start spl s8
      spl s4
      spl 2
      jmp a  ;process #1
      jmp b  ;process #2
s4    spl 2
      jmp c  ;process #3
      jmp d  ;process #4
s8    nop 0
      nop 0
      jmp a  ;process #5

end
