;redcode
;name P-Space test #1
;assert MAXCYCLES>=1500
load0 z	for 0
	rof

dat0	equ	(load0-10)

FAILFLAG equ	2
COUNTER	equ	1

;- Test that P[0] is correct for single warrior battles.
;
;  Expected results for mars -r 100 ptest6.rc:
;	80 wins, 20 losses.

p0:	ldp	#0, #0
	seq	#-1, -1
	jmp	main

; init counter and die.
reset:	stp	#5, #COUNTER
	dat.x	0,0

; not the first round
main:
flg:	ldp	#FAILFLAG, #0	; suicide if something's gone wrong.
	jmn	fail,	flg

cnt:	ldp	#COUNTER, #0
	seq	#5,	cnt
	jmp	else
	   jmn	fail,	p0
	jmp	then	
else:	   jmz	fail,	p0
then:
	djn	stall,	cnt
	jmp	reset

stall:	stp	cnt,	#COUNTER
	jmp	0

fail:	stp	#1, #FAILFLAG
	div.x	#0,#0
	end
