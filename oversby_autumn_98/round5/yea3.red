;redcode
;name H-Bomb b1m
;author Josh Yeager
;strategy A short bombing run followed by a multipass cc.
;assert 1

bombr   sub     #4,     ptr
        mov     ptr,    @ptr
        djn     bombr,  #1970
        jmp     en,     <1000
ptr     dat     <2667,  #-100

ptr1    dat a1, en+100
a3      dat 0,  en+2+1
a2      spl #1, en+2+2
a1      spl #2, en+2+3
        mov *ptr1, >ptr1
        mov *ptr1, >ptr1
        mov *ptr1, >ptr1
en      djn.f -3, <400

end
