;redcode
;name No.6
;author Automatic Player

CDIST   EQU     23 ;13 ;23  ; 13
IVAL    EQU     994 ;114 ; 106

scan    ADD     incr,   comp
comp    CMP     0,      CDIST
        SLT     #incr-comp+CDIST+(bptr-comp)+1,comp
        JMP     scan
        MOV     #CDIST+(bptr-comp)+1,count
        MOV     comp,    bptr
bptr    DAT     #0
split   MOV     bomb,   <bptr
count   DJN     split,  #0
        JMN     scan,   scan
bomb    SPL     0
        MOV     2,<-1
incr    DAT     #IVAL,  #IVAL

        END     scan
