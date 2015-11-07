;redcode
;name PIN test #1 A
;assert 1
load0 z	for 0
	rof

	PIN	1234

dat0	equ	(load0-10)

;- Assert that PIN sharing works.  PIN #1 A polls
;  a p-space location until PIN #1 B writes to it.
;  subsequently suicides.

; Expected result for mars -br 10 pin1a.red pin1b.red:
;	0/10/0

loop:	ldp	#1, #0
	jmz	-1, -1
	end
