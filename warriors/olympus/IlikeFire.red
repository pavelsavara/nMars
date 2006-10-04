;redcode-88
;assert 1
;name I like Fire
;(don't remember how it was named)
;author P._V._K.

        org     start
bptr    DAT     #j
start   mov     #-52,   bptr-52
        mov     #-52,   bptr-53
s       spl     0,      <-52
        sub     #(52*2),1
        mov     s,      @j
        mov     s,      @-1
j       djn     -3,     <-104-53
        mov     @bptr,  <core
        jmp     -1,     <j-52
        for     46
        dat     0,0
        rof
core    DAT #bptr-52
