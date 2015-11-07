;name myImp
;author Paulsson
;strategy Funnier that myZizzor, but won't beat anyone.
;contact mpn@ifm.liu.se
;NSFCWT Round 5
org st

test    equ             b -1
test2   equ             b-2
b

st              nop             <test,}test
a               mov.f   test,test2
                mod.ab  <ptr,test2
                jmz.b   cont,test2
                sub.a   @ptr,test2
                mod.a   @ptr,test2
                jmn.a   a,test2
                mov.f   test,test2
                sub.a   @ptr,test2
                div.a   @ptr,test2
                nop             }test2
                mov.ab  test2,imp
                jmp             launch
cont    mov.f   test,test2
                div.ab  @ptr,test2
                sub.b   test2,imp
launch  spl             1
                spl             1
                spl             1
                spl             1
                spl             1
                spl             2
                jmp             imp
                add.ba  imp,-1
                dat             0,0
imp             mov.i   #0,0
                dat             1,0
ptr             dat             2,8
                dat             3,0
                dat             5,0
                dat             7,0
                dat             11,0
                dat             13,0
                dat             17,0
                dat             19,0
