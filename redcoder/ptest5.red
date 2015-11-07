;redcode
;name P-Space test #1
;assert 1
load0 z	for 0
	rof

dat0	equ	(load0-10)

;- Assert that the various stp modifiers work.

KEY	equ	543
LOC	equ	123

	nop	k=KEY

	stp.ab	#k=k+1, #LOC
	ldp.ab	#LOC,	#0
	seq.f	-1,  	1
	dat.x	LOC,	k

	stp.a	#KEY, #0
	ldp.ab	#KEY, #0
	seq.f	-1,  	1
	dat.x	KEY,	KEY
	
	stp.ba	#LOC,	#k=k+1
	ldp.ab	#LOC,	#0
	seq.f	-1,  	1
	dat.x	LOC,	k

	stp.b	#0,	#k=k+1
	ldp.ab	#k,	#0
	seq.f	-1,  	1
	dat.x	k,	k

	stp.f	#0,	#k=k+1
	ldp.ab	#k,	#0
	seq.f	-1,  	1
	dat.x	k,	k

	stp.x	#0,	#k=k+1
	ldp.ab	#k,	#0
	seq.f	-1,  	1
	dat.x	k,	k

	stp.i	#0,	#k=k+1
	ldp.ab	#k,	#0
	seq.f	-1,  	1
	dat.x	k,	k

	jmp	0

	end
