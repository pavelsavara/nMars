;redcode
;name P-Space test #1
;assert MAXCYCLES>=1500
load0 z	for 0
	rof

dat0	equ	(load0-10)

;- Assert that p-space is initialised to 0, excluding P[0].

; Expected result for mars -br 10 ptest1.red :
;	10 ties

loop:	ldp.ab	#PSPACESIZE-1, #0
	jmn	dat0,	loop
	djn.a	loop,	loop
	jmp	0
	end
