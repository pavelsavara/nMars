; Quick Sand II
;
; by Norman Richards
;
BOMB         SPL    BOMB
DAT1         DAT                 # 20
NUM          DAT                 # 470
INC          DAT                 # 17
NUMSAVE      DAT                 # 470
OUTERLOOP    DAT                 # 8
;
START        SPL    PART2
PART1        ADD    INC,           DAT1
             MOV    BOMB,        @ DAT1
             DJN    PART1,         NUM
             ADD  # 20,            INC
             SUB  # 50,            NUMSAVE
             MOV    NUMSAVE,       NUM
             MOV  # 20,            DAT1
             DJN    PART1,         OUTERLOOP
             MOV  # 470,           NUMSAVE
             MOV    NUMSAVE,       NUM
             MOV  # 17,            INC
             MOV  # 18,            OUTERLOOP
             JMP    PART1
PART2        CMP  @ POINT1,      @ POINT2
             JMP    NE
             MOV    PABOMB,      @ POINT1
             MOV    PABOMB,      @ POINT2
NE           CMP  < POINT1,      < POINT2
             MOV    POINT2,        POINT1
             JMZ    POINT2,        PART2
             MOV  #-40,            POINT1
             MOV    POINT1,        POINT2
             JMP    PART2,
PABOMB       DAT                 # 0
POINT1       DAT                 #-40
POINT2       DAT                 #-40
             END    START
