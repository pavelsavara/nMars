;redcode-94
;name Speckle v0.1
;author Ian Oversby
;strategy 100%c anti-imping core-clear

org start

gat	DAT.F	#3,	#6	; maybe #7
	DAT.F	#3,	#6	; maybe #7
	DAT.F	#2,	#7	; maybe #8
start	SPL.B	#3,	#7	; maybe #8
loop	MOV.I	*gat,	>gat	; anti-imping dirty core-clear
	DJN.F	loop,	>gat	; SPL/SPL/DAT/DAT/... and DJN.F
