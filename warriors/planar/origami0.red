;redcode-94x
;name Origami 0
;author Planar
;strategy paper
;assert 1

; version 0: (almost) pure paper

step1	equ	12345
step2	equ	6789

length	equ	8

	spl	1, 1
	spl	1, 1
	spl	1, 1

	spl	step1, 0
	mov.i	>-1, }-1
	seq.ab	#length, -2
	dat	<2*step1-2, 0
	mov.i	<-4, {1
	spl	step2, 0
	mov.i	-3, <-5
	mov.i	-4, }-5
