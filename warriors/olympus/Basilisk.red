;
;    Warrior: Basilisk
;  File name: basilisk.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: James T. McMahon - Renfrew / Ontario / Canada
;
LEFTCLAW   DAT   0                     ; POINTER TO FIRST ATTACK POSITION
RIGHTCLAW  DAT   2                     ; POINTER TO SECOND ATTACK POSITION
HOWFAR     DAT   63                    ; HOW FAR TO ATTACK BEFORE RESETING
HOWMANY    DAT   18                    ; HOW MANY TIMES TO ATTACK
STONE      SPL   STONE                 ; STOP AN ENEMY IN IT'S TRACKS
CLAW       DAT   0                     ; KILL AN ENEMY
ATTACK     SUB # 127,       LEFTCLAW   ; SET FIRST ATTACK POSITION
           SUB # 129,       RIGHTCLAW  ; SET SECOND ATTACK POSITION
           ADD # 129,       LEFTEYE    ; SET THIRD ATTACK POSITION
           ADD # 127,       RIGHTEYE   ; SET FOURTH ATTAK POSITION
           MOV   CLAW,    @ LEFTCLAW   ; CLAW FIRST ATTACK POSITION
           MOV   CLAW,    @ RIGHTCLAW  ; STONE SECOND ATTAK POSITION
           MOV   STONE,   @ LEFTEYE    ; STONE THIRD ATTACK POSITION
           MOV   STONE,   @ RIGHTEYE   ; CLAW FOURTH ATTACK POSITION
           DJN   ATTACK,    HOWFAR     ; AT END OF ATTACK RUN
           MOV # 63,        HOWFAR     ; RESET HOWFAR TO ATTACK
           SUB # 184,       LEFTCLAW   ; RESET FIRST ATTACK POSITION
           SUB # 58,        RIGHTCLAW  ; RESET SECOND ATTACK POSITION
           ADD # 58,        LEFTEYE    ; RESET THIRD ATTACK POSITION
           ADD # 184,       RIGHTEYE   ; RESET FOURTH ATTACK POSITION
           DJN   ATTACK,    HOWMANY    ; AT END OF ATTACK PROCESS
GOBBLE     MOV   CLAW,    < CLAW       ; CLAW AN ENEMY
           DJN   GOBBLE,  < CLAW       ; KEEP ON CLAWING
           ADD # 3,         CLAW       ; RESET CLAW
           JMP   GOBBLE                ; CONTINUE CLAWING
LEFTEYE    DAT   3                     ; THIRD ATTACK POSITION
RIGHTEYE   DAT   4                     ; FOURTH ATTACK POSITION
           END   ATTACK
