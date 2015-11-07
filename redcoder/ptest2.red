;redcode
;name P-Space test #1
;assert MAXCYCLES>=10
load0 z	for 0
	rof

dat0	equ	(load0-10)

;- Assert that P[0] is initialised to -1 at least once.

; Expected result for mars -br 10 ptest2.red:
;	1 win, 9 ties.

	ldp	#0, #0
	sne	#-1,-1
	jmp	0

	end
