;redcode-94
;name test c1b
;author Planar
;assert CORESIZE == 8000
;kill test

step1	equ	2197
step2	equ	(-226)

xx	equ	(3+step1)
yy	equ	(2-2766*step2)

start	spl	#step1, <step2
	mov.i	}xx, yy
	add.f	-2, -1
	dat	0, 0
	mov.i	1, <-2

	end	start

; version a:     mov.i 1, <-6
; version b:     mov.i 1, <-2
