;redcode
;name PIN test #2 A
;assert 1
load0 z	for 0
	rof

	PIN	1234
MAGIC	equ	7227

dat0	equ	(load0-10)

;- Assert that P-space location 0 is exempt from sharing.
;  PIN #2 A polls a p-space location 0 waiting for a
;  magic value written by PIN #2 B. If it arrives, 
;  PIN #2 A subsequently suicides.

; Expected result for mars -br 10 pin2a.red pin2b.red:
;	0/0/10

loop:	ldp	#0, #0
	seq	#MAGIC, -1
	jmp	-2

	end
