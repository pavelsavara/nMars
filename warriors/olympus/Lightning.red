;
;    Warrior: Lightning
;  File name: lightnin.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: C. Butcher / New Zealand
;
num       dat  # 0
start     spl    copy
          cmp  # 0,         @ a       ; was CMP @ a  # 0 - CWS'88 violation - WRB/ICWS.DO
          jmp    bomb
          add  # 5,           a
          jmp    start+1
bomb      mov  # 20,          bombnum
          sub  # 10,          a
          mov  # 0,         < a
          djn   -1,           bombnum
          add  # 20,          a
          jmp    start+1
a         dat  # 10
address   dat  #-833
copy      mov  # 20,          num
          mov  @ num,       < address
          djn   -1,           num
          spl  @ address
          sub  # 653,         address
bombnum   dat  # 0
          end    start
