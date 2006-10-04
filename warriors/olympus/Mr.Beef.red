;
;    Warrior: Mr. Beef
;  File name: mrbeef.red
; Torunament: ICWST'90
;   Standard: CWS'88
;     Author: Gerald Frost
;
;  Procedure: win by capturing enemy, and
;                  using them as slaves
;
start     SPL    mrbeef
landpat   MOV    pitguid,    runway
          ADD  # 1,          landpat
          DJN    landpat,    leangth
leangth   DAT                257
pitguid   JMP   -37
here      DAT                0
          DAT                0
imper     MOV    bomb,       here
          JMP    imper,    < here
trap      JMP   -102       # 2
bomb      DAT                0
n         DAT              # 77
mrbeef    ADD  # 102,        net
net       MOV    trap,       slave
          DJN    mrbeef,     n
          SUB  # 7845,       net
          MOV  # 77,         n
          DJN    mrbeef,     bigloop
          SPL                pit
          JMP    imper
bigloop   DAT                34
where     DAT                here
slave     MOV    bomb,     < where        ; haaaa-ha-ha-ha-ha (maniacal laughter)
pit       SPL                slave
          MOV    bomb,      < where
          MOV    bomb,      < where
          JMP    slave
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
          JMP    pit
runway    JMP    pit                      ; that's all fokes!
          END    start
