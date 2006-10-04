;
;    Warrior: Ju Jit Su
;  File name: jujitsu.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Stephen Tavener
;
start   SPL   6
        MOV # 0,      @ 2
        DJN  -1,        1
        DAT            -3
        SPL   0
        DAT            -1
        SUB # 5,        -1
        MOV  -3,      @-2
        JMP  -2
        END   start
