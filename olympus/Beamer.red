;
;    Warrior: Beamer
;  File name: beamer.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Ulrich Ruckert
;
           mov     # 0,      -1
           spl      -1
           jmp      -2
target     dat                1000
start      mov       bomb,  @ target
           add     # 5,       target
           sub     # 5,       bomb
           jmn       start,   target
           add     # 15,      target
           sub     # 15,      bomb
           djn       start,   timer
           mov     # 0,       -10
           jmp       start
timer      dat               # 2
bomb       jmp                -1002
           end       start



