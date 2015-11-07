;redcode
;name Smooth Noodle Map
;author Matt Hastings

	MOV	<112,	-125
	ADD	2,	-1
	DJN	-2,	-2
	SPL	cloop,	-cloop+1
	JMP	-2,	<-3
FOR 32
	DAT	#0,	#0
ROF
cloop	ADD	<start,	7
	DJN	-1,	#8
	JMN	strt2,	5
start	MOV	#16,	7
loop	MOV	@-2,	<6
	MOV	<-3,	<5
	DJN	loop,	-4
	SPL	@-669,	-1
	ADD	#653,	2
	JMZ	start,	-7
copy	DAT	0,	833
FOR 28
	DAT	#0,	#0
ROF
ptr2	DAT	0,	0
strt2	MOV	#16,	ptr2
loop2	MOV	@ptr2,	<copy2
	MOV	<ptr2,	<copy2
	DJN	loop2,	ptr2
	SPL	@copy2,	0
	ADD	#653,	copy2
	JMZ	strt2,	ptr2
	DAT	0,	0
copy2	DAT	0,	833
