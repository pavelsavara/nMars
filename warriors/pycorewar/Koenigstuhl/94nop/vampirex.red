;REDCODE-94
;NAME 	Vampire-X
;AUTHOR Neogryzor
; <neogryzormail@mixmail.com>
;ASSERT CORESIZE==8000

;STARTEGY	JMP-Vampire, based on Radar-X

	S EQU 210
	I EQU 127
	N EQU 762

J:	JMP -I+TRAP,I
LOOP:	ADD.F STEP,J
SCAN:	MOV.I J,@J
DEC:	DJN LOOP,#N
CLEAR:	MOV.I -5,<-5
	DJN CLEAR,#7991
	JMP CLEAR,<CLEAR

	DAT 0,0

TRAP:	SPL 0
	JMP TRAP
STEP:	DAT #-S,#S

	END SCAN

