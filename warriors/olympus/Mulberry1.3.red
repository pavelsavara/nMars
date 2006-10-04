;name Mulberry 1.3
;author Ansel G. Sermersheim
;strategy Standard paper

step    equ     5766

        org     start
        
start   spl     2
        spl     1
        jmp     inst
ptr1    dat     step,  0
inst    mov     >ptr1,  }ptr1
cplst   jmp     inst+step
