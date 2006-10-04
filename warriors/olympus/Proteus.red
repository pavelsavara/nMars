;redcode
;name Proteus
;author Matt Hastings

ptr	DAT	#0,	#0
mouse	MOV	#12,	ptr
loop	MOV	@ptr,	<copy
	DJN	loop,	ptr
	SPL	@copy,	0
	ADD	#653,	copy
	JMZ	-5,	ptr
copy	DAT	0,	833
	MOV	-50,	@-50
	ADD	#636,	-51
	DJN	-2,	<450
	SPL	1000,	0
	JMP	-4,	1
	DAT	0,	0
start	MOV	#1,	1250
	MOV	#1,	1150
	MOV	-8,	1000
	MOV	-8,	1000
	MOV	-8,	1000
arb	MOV	-8,	1000
	MOV	-8,	1000
	MOV	-8,	1000
	MOV	mouse,	arb+2000
	MOV	mouse+1,	arb+2001
	MOV	mouse+2,	arb+2002
	MOV	mouse+3,	arb+2003
	MOV	mouse+4,	arb+2004
	MOV	mouse+5,	arb+2005
	MOV	mouse+6,	arb+2006
	JMP	arb+997
	END	start
