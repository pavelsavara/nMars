;redcode
;name Piper
;author Chip Wendell
;strategy vampire (pit-trapper)
;history Semifinalist at the 1987 ICWS tournament
START  ADD     #65,    BAIT
LURE   MOV     BAIT,   @TARGET
       ADD     #48,    BAIT
       SUB     #48,    TARGET
       JMN     LURE,   TARGET
SET    MOV     #-12,   PTR
BOMB   MOV     PTR,    @PTR
       DJN     BOMB,   PTR
       JMP     SET,	0
BAIT   JMP     @0,	0
TARGET DAT     #0,	#-48
PTR    DAT     #0,	#-12
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
       DAT     #0,	#0
TRAP   SPL     0,	0
       JMP     TRAP,	0
