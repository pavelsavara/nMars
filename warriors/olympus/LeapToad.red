;
;    Warrior: Leap Toad
;  File name: leaptoad.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Matthew Skala
;
KILLPTR   DAT             #0
KILL      MOV  KILLPTR,   <KILLPTR
          DJN  KILL,      #1024
          MOV  #1024,     -1
START     SPL  KILL
          MOV  0,         5
          MOV  0,         5
          MOV  0,         5
          MOV  0,         5
          MOV  0,         5
          END       START
