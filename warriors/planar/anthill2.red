;redcode-94xm
;name Anthill 2
;author Planar
;strategy scan, stun, paper
;assert CORESIZE==55440

magic1	equ	4575
magic2	equ	4576

	stp.a	#1, magic1
	stp.a	#1, magic2
	spl	p2

p1	spl	1
	mov.i	-1, #0
	mov.i	-1, #0
	spl	1

	spl	@0, 9847
	mov.i	}-1, >-1
	mov.i	{-2, <1
	spl	@0, 997
	dat	1, 1
	spl	#1, 1
	ldp.b	magic2, 1
	jmz.b	-2, #0
	mov.i	0, -1

FOR 5
	dat	0, 0
ROF

p2	spl	1
	mov.i	-1, #0
	mov.i	-1, #0
	spl	1

	spl	@0, -9847
	mov.i	}-1, >-1
	mov.i	{-2, <1
	spl	@0, -997
	dat	1, 1
	spl	#1, 1
	ldp.b	magic2, 1
	jmz.b	-2, #0
	mov.i	0, -1

	end
