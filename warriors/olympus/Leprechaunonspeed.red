;redcode-94
;name Leprechaun on speed
;author Anders Ivner
;contact d91andiv@und.ida.liu.se
;NSFCWT Round 1
;kill Leprechaun on speed
;strategy Quickscanner -> Leprechaun deluxe
;strategy Optimizing carpet launch

STEP	equ	(-5741)
A	equ	(loop2+5-STEP)
lep	equ	check
gate	equ	(loop2-3)
offset	equ	5230; CENSOR

QSTEP	equ	105
q0	equ	(pt+QSTEP)

start	cmp	q0+QSTEP*(-start),	q0+QSTEP*(-start+1)
	mov	#QSTEP*(-start-1)+q0-pt,pt
	for	7
	cmp	q0+QSTEP*(-start),	q0+QSTEP*(-start+1)
	mov	#QSTEP*(-start-1)+q0-pt,pt
	rof
	jmn	attack,	pt

	for	8
	cmp	q0+QSTEP*(-start),	q0+QSTEP*(-start+1)
	mov	#QSTEP*(-start-1)+q0-pt,pt
	rof
	jmn	attack,	pt

	for	8
	cmp	q0+QSTEP*(-start),	q0+QSTEP*(-start+1)
	mov	#QSTEP*(-start-1)+q0-pt,pt
	rof
	jmn	attack,	pt

	for	8
	cmp	q0+QSTEP*(-start),	q0+QSTEP*(-start+1)
	mov	#QSTEP*(-start-1)+q0-pt,pt
	rof
	jmz	lep,	pt	

attack	jmn.f	2,	@pt
	add	#QSTEP,	pt
pt	add.ba	#69,	#0
	mov.f	pt,	pt-23
	mov.f	pt,	pt-46
loop	mov	sb,	{pt
	mov	sb,	<pt
	mov	sb,	{pt-23
	mov	sb,	<pt-23
	mov	sb,	{pt-46
	mov	sb,	<pt-46
	djn	loop,	#19

	jmp	lep

	for	3
	dat	0,0
	rof

	; scan A, glue A+STEP, bomb A+STEP+STEP

loop2	sub	const,@dp
	mov	sb,	@pt2
pt2	mov	A,	@A+STEP
check	jmz.a	loop2,	*pt2
dp	mov	mb,	*pt2
	jmn.a	loop2,	check
sb	spl	#-STEP+1,STEP
clr	mov	bmb,	>gate
	djn.f	clr,	{gate

	dat	0,0
	dat	0,0
const	dat	-STEP*3,-STEP*3
mb	mov	@0,	}STEP
	dat	0,0
	dat	0,0
bmb	dat	-1,	18

	end	start
