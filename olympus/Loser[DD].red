;redcode-94 quiet
;name Loser
;author Planar
;kill test
;strategy Try to lose 100%.
;assert MAXLENGTH >= 2

for 0

How to lose every time in only two instructions.

Contents of pspace[0]		action

-1 (first round)		lose on the 3rd cycle
 0 (lost)			lose on the 3rd cycle
 1 (won)			do not lose before 3rd cycle
 2 (tied)			(should not happen)

In the self-battle, on the first round the first program to play will
lose.  Then the loser will continue to lose.

rof; 0

	ldp.b	0, #0
	jmp	<-1

	end
