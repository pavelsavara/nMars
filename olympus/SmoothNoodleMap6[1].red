;redcode
;name Smooth Noodle Map 6
;author Matt Hastings

	MOV	s5,	<ptr1
start	MOV	s4,	<ptr1
arb	MOV	s3,	<ptr1
	MOV	s2,	<ptr1
	MOV	s1,	<ptr1
	MOV	s0,	<ptr1
	MOV	s7,	start-307
	MOV	r4,	<ptr2
	MOV	r3,	<ptr2
	MOV	r2,	<ptr2
	MOV	r1,	<ptr2
	MOV	ro,	<ptr2
	MOV	rm,	<ptr2
	MOV	r4a,	<ptr3
	MOV	r3,	<ptr3
	MOV	r2a,	<ptr3
	MOV	r1,	<ptr3
	MOV	ro,	<ptr3
	MOV	rm,	<ptr3
	JMP	start-314-1,	<ptr1
s0	SPL	0,	2
s1	ADD	3,	1
s2	MOV	<2586,	2586
s3	DJN	-2,	#477
s4	SPL	-2584,	2584
s5	JMP	-4807+440+4,	0
s7	DAT	#-4,	#-28
rm	MOV	#7,	7
ro	MOV	<-1,	<2
r1	JMN	-1,	-2
r2	SPL	@0,	1273
r3	JMZ	rm,	rm
r4	MOV	@1,	r1+1
r2a	SPL	@0,	1833
r4a	MOV	@1,	-3
ptr1	DAT	#0,	#start-307-2
ptr2	DAT	#0,	#arb-2891
ptr3	DAT	#0,	#start-4668

i FOR MAXLENGTH-CURLINE
	DAT	#i,	#1
ROF
