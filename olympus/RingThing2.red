;redcode
;name RingThing2
;author Anders Ivner
;assert (CORESIZE == 8192)
;strategy 5 point spiral / 33% spl 0 bombing stone -> backward
;strategy 3 point spiral killing coreclear


ISTEP	equ	3277		;5 points
A	equ	c
OFFSET	equ	(ISTEP*2)

c	spl	0,	12
loop1	add	c,	pt
pt	mov	@c,	A
j	jmp	loop1

b	spl	0,	(-8193/3)	;3 points backward

boot	mov	c,	c+OFFSET
	mov	loop1,	loop1+OFFSET
	mov	pt,	pt+OFFSET
	mov	j,	j+OFFSET
	mov	b,	c+OFFSET+12

l000	spl	l1000
	spl	l100
	spl	l010
	spl	l001

	jmp	imp+(ISTEP*0)
l001	jmp	imp+(ISTEP*1)
l010	spl	l011
	jmp	imp+(ISTEP*2)
l011	jmp	imp+(ISTEP*3)
l100	spl	l110
	spl	l101
	jmp	imp+(ISTEP*4)
l101	jmp	imp+(ISTEP*5)
l110	spl	l111
	jmp	imp+(ISTEP*6)
l111	jmp	imp+(ISTEP*7)

l1000	jmp	1
	spl	l1010
	spl	l1001
	jmp	imp+(ISTEP*8)
l1001	jmp	imp+(ISTEP*9)
l1010	spl	l1011
	jmp	imp+(ISTEP*10)
l1011	jmp	c+OFFSET

imp	mov	0,	ISTEP

	end	boot
