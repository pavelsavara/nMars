; E-Call.s
;
; CatFace
;
MAIN     MOV     MIS,      @ P
         ADD   # 8,          P
         MOV     MISM,       MT
         JMP     MAIN
MIS      JMP    -8
COUNT    DAT                 64
CE       DAT               #-30
P        DAT                 13
MISM     JMP    -3
AD       SPL     0
         DJN     POOL,       COUNT
         JMP     CLOSE
MT       JMP     AD
CLOSE    MOV     AD,       @ C
         CMP   # 30,         C
         DJN     POOL,       C
         MOV   #-30,         C
         JMP     CH
DG       JMP    -8
CH       SPL     AD
         JMP     POOL
C        DAT                -30
         END     MAIN
