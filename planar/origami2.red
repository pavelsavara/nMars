;redcode-94x
;name Origami 2
;author Planar
;strategy paper
;assert 1

; version 2: anti-imp paper.

step1	equ	12345
step2	equ	4567
step3	equ	1234
step4	equ	345

	spl	1, 1
	spl	1, 1
	spl	1, 1
	spl	1, 1

paper	spl	@0, >step1
	mov.i	>paper, }-1
	mov.i	<paper, {1
	spl	step2, 0
	spl	@0, >step3
	mov.i	>paper, }-1
	mov.i	<paper, {1
	spl	step4, 0
	dat	0, 0

	mov.i	#1, <1
	mov.i	#1, {1
	mov.i	#1, <1
	mov.i	#1, {1
	mov.i	#1, <1
	mov.i	#1, {1
	dat	1, 1

	end
