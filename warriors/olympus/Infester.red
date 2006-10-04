;
;    Warrior: Infester
;  File name: infester.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Gerald Frost
;
;  Procedure: standard crawl-around-in-the-core
;               warrior but, it is rather nasty
;
start     MOV    n,           100           ; hate to waist free shots
          MOV    n,          -100
          MOV    n,           200
          MOV    n,          -200
          MOV    n,           300
          MOV    n,          -300
          MOV    n,           400
          MOV    n,          -400
          MOV    n,           500
          MOV    n,          -500
          MOV    n,           600
          MOV    n,          -600
          MOV    n,           700
          MOV    n,          -700
          MOV    n,           800
          MOV    n,          -800
          MOV    n,           900
          MOV    n,          -900
          MOV    n,           1000
          MOV    n,          -1000
          MOV    n,           1100
          MOV    n,          -1100
          MOV    n,           1200
          MOV    n,          -1200
          MOV    n,           1300
          MOV    n,          -1300
          MOV    n,           1400
          MOV    n,          -1400
          MOV    n,           1500
          MOV    n,          -1500
          MOV    n,           1600
          MOV    n,          -1600
          MOV    n,           1700
          MOV    n,          -1700
          MOV    n,           1800
          MOV    n,          -1800
          MOV    n,           1900
          MOV    n,          -1900
          MOV    n,           2000
          MOV    n,          -2000
          MOV    n,           2100
          MOV    n,          -2100
          MOV    n,           2200
          MOV    n,          -2200
          MOV    n,           2300
          MOV    n,          -2300
          MOV    n,           2400
          MOV    n,          -2400
          SPL                 top
copy      MOV  # 12,          n
          MOV  # 0,           from
          ADD    to,          to
loop      MOV  < from,      < to
          DJN    loop,        n
          SPL    copy
          JMP  @ to
to        DAT               # 2617
top       MOV  #-15,          bombme
again     MOV    to,        @ bombme
          DJN    again,     < bombme
from      DAT               # 0
n         DAT               # 12
bombme    DAT               #-15
          END    start
