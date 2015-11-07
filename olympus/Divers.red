;
;    Warrior: Divers
;  File name: divers.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Matthew Skala
;
DIVE      MOV   # 13,         LOOPCTR
LOOP      ADD   # 16,         PTR
ENTER     MOV     PTR,      @ PTR
          MOV     TRAP,     @ PTR
LOOPCTR   DJN     LOOP,     # 1
          SPL   @ PTR
          JMP     DIVE
PTR       DAT               # 1028
TRAP      JMP     0
          END     ENTER
