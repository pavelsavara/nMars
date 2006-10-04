;redcode
;name Medusa's v2.1
;author Mintardjo & Stefan

CDIST   equ 12
IVAL    equ 28
FIRST   equ scan-OFFSET+IVAL
OFFSET  equ 5324

scan    sub data,comp
comp    cmp FIRST-CDIST,FIRST
        slt #data-comp+CDIST+1,comp
        djn scan,<FIRST+163
        mov #CDIST-1,count
split   mov bomb,<comp
count   djn split,#0
        add #CDIST-1,comp
        jmz scan,scan-1
bomb    spl 0, <0-IVAL+1
incr    mov data, <bomb-1
        jmp incr, <0-IVAL-1
data    DAT <0-IVAL, <0-IVAL

        end comp
