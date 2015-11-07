;redcode
;name PIN test #1 B
;assert 1
load0 z	for 0
	rof

; NOTE: pMARS doesn't output the PIN number of a warrior
; in the assembly listing, so the PIN pseudo-op needs to be
; added manually to the output of
;
;	pmars -r 0 warrior.red > warrior.rc

	PIN	1234

dat0	equ	(load0-10)

;- Assert that PIN sharing works.  PIN #1 A polls
;  a p-space location until PIN #1 B writes to it.
;  PIN #1 A subsequently suicides.

; Expected result for mars -br 10 pin1a.red pin1b.red:
;	0/10/0

loop:	stp	#1, #1
	jmp	0
	end
