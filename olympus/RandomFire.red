;Random Fire
;
; Author: Bram Cohen
;
;
NEXTADD    ADD  # 412,         PTR
START      JMZ    NEXTADD,   @ PTR
           MOV    DATZERO,   @ PTR
           JMP    NEXTADD
PTR        DAT               # 799
DATZERO    DAT               # 0
           END    START
