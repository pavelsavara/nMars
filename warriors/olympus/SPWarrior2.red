;redcode-94
;name S/P Warrior #2
;author G. Eadon
;NSFCWT 3
;contact gmeadon@mit.edu
;strategy Mod-5 Stone

pos	dat	0, 0	
;start	SPL	0, <5142
	MOV	db, *pos
	MOV	db, @pos	
start	SPL	-2, <5142
     	ADD.f	inc, pos
	JMP	start, <5140
db     	DAT	<5140, <5140
inc     DAT	3195, 535
end start
