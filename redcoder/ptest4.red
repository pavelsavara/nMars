;redcode
;name P-Space test #1
;assert 1
load0 z	for 0
	rof

dat0	equ	(load0-10)
KEY	equ	543
LOC	equ	123
XXX	equ	332
YYY	equ	111
ZZZ	equ	331

;- Assert that the various ldp modifiers work.
;
	stp	#KEY, #LOC
	stp	#YYY, #XXX
	stp	#ZZZ, #KEY

	ldp.ab	#LOC, #XXX
	seq.f	1, -1
	dat	LOC, KEY

	ldp.a	#LOC, #XXX
	seq.f	1, -1
	dat	KEY, XXX

	ldp.ba	#XXX, #LOC
	seq.f	1, -1
	dat	KEY, LOC

	ldp.b	#XXX, #LOC
	seq.f	1, -1
	dat	XXX, KEY

	ldp.f	#XXX, #LOC
	seq.f	1, -1
	dat	XXX, KEY

	ldp.x	#XXX, #LOC
	seq.f	1, -1
	dat	XXX, KEY

	ldp.i	#XXX, #LOC
	seq.f	1, -1
	dat	XXX, KEY

	jmp	0
	end
