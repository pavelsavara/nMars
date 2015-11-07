;redcode-94xm
;name Anthill 1
;author Planar
;strategy scan, stun, paper
;assert CORESIZE==55440

	org	search

steps	dat	220, 220
search	add.f	steps, 1
ptr	sne.i	<300, <410
	jmp	search
	add.f	bomb1, ptr
	mov.i	bomb1, }ptr
	mov.i	bomb2, *ptr
	mov.i	bomb1, >ptr
	mov.i	bomb2, @ptr
	djn.b	search, #30
	jmp	papers

bomb1	spl	0, 10
bomb2	mov	-1, <-1

FOR 5
	dat	0, 0
ROF

papers	spl	p2

p1	spl	1
	spl	1
	spl	1
	spl	@0, 9847
	mov.i	}-1, >-1
	mov.i	{-2, <1
	spl	@0, 997
	mov.i	2, {-1
	djn.a	-1, >1

FOR 5
	dat	0, 0
ROF

p2	spl	1
	spl	1
	spl	1
	spl	@0, -9847
	mov.i	}-1, >-1
	mov.i	{-2, <1
	spl	@0, -997
	mov.i	2, {-1
	djn.a	-1, >1
