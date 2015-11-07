;redcode-94
;name SETI
;author JKW
;assert (CORESIZE == 8000)
;strategy Double scanner

STEP	equ	3044
DIST	equ	10
A	equ	(pt)
ISTEP	equ	(8001/21)
LEN	equ	3

	org	start

start	sub	c,	pt
pt	cmp.f	A,	A+DIST
	slt.ab	#40,	pt
cnt	djn	-3,	#0
len	mov	#LEN,	#1000
	mov	pt,	pt-3
	mov	glue,	}pt
	mov	glue,	>pt
	djn	-2,	len
	mov	pt-3,	pt
	jmn.b	cnt,	cnt
	add.a   #ISTEP+1,cpt
	mov	@-1,	{cpt
	jmp     -2
 	dat	-10,	-10
c 	dat	-STEP,	-STEP
glue	spl	#0,	#0
cpt	spl	#2,	#3
