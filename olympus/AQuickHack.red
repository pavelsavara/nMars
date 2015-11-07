;redcode-94
;name A Quick Hack
;author Karl Lewin
;contact lewin@netcom.com
;NSFCWT Round 5

;strategy  I really don't know how this will do.  Just threw
;strategy  some pieces together that might do ok.  Hopefully not
;strategy  finish in last anyway.

;assert 1

D0	EQU	2600
D1	EQU	745
D2	EQU	5185
STEP	EQU	14
	ORG	start

head	dat	#0,	#tail+100
d1	dat	<0,	<tail-head+5
incr	spl.a	#-STEP,	<-STEP
go	mov.i	@tail,	>head
  	mov.i	@tail,	>head
tail	djn.b	go,	{d1

start	spl	incr
 	spl	1
	mov	-1,	0
	spl	1
is10	spl	@0,	}D0
im10	mov.i	}is10,	>is10
is11	spl	D1,	0
im11	mov	>is11,	}is11
im12	mov	<is11,	<is12
is12	jmp	@0,	}-D2
