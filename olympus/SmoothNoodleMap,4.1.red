;redcode
;name Smooth Noodle Map, 4.1
;author Matt Hastings

start	MOV	s7,	<ptr1
	MOV	s6,	<ptr1
	MOV	s5,	<ptr1
arb	MOV	s4,	<ptr1
	MOV	s3,	<ptr1
	MOV	s2,	<ptr1
	MOV	s1,	<ptr1
	MOV	r5,	<ptr2
	MOV	r4,	<ptr2
	MOV	r3,	<ptr2
	MOV	r2,	<ptr2
	MOV	r1,	<ptr2
	MOV	ro,	<ptr2
	MOV	rm,	<ptr2
	JMP	start+300,	<ptr1
	DAT	#0,	#0
s1	ADD	3,	1
s2	MOV	<2589,	-2583
s3	DJN	-2,	#998
s4	SPL	2584,	-2584
s5	SPL	0,	-1
s6	MOV	2,	<-1
s7	JMP	-1,	0
rm	MOV	#12,	0
ro	MOV	<-1,	<3
r1	MOV	<-2,	<2
r2	JMN	ro,	-3
r3	SPL	@0,	-833
r4	JMZ	rm,	rm
r5	MOV	0,	-1
ptr1	DAT	#0,	#start+307
ptr2	DAT	#0,	#arb+307+2584

i FOR MAXLENGTH-CURLINE
	DAT	#i,	#1
ROF
