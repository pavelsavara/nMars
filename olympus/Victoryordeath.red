;redcode-94
;name Victory or death
;author Anders Ivner
;strategy Catch opponent at startup by throwing two jumps to a brainwashing
;strategy pit at him. If he is not caught, change target positions, and
;strategy suicide to protect pspace from brainwash.
;strategy If opponent has a startup longer than 6 instructions, I should
;strategy be guaranteed to catch him before round 50.
;strategy I have no idea if this will work...nothing to test against.


VSTEP	equ	74

s
i	for	145
	mov	<-i,<pit
	mov	{-2,	<4		;imitate boot
	rof

pit	spl	#0,	{0
	stp	#0,	#0
	mov	b,	>500
	jmp	-3,	>-2

bait1	jmp	@4000-250,	-250
bait2	jmp	@4000
b	dat	0,1

start	ldp	#250,	baitpt
	mov	bait1,	<baitpt
baitpt	mov	bait2,	@0

	sub	#4251+(s-baitpt),baitpt
	add	#VSTEP+1,	baitpt
	mod	#250,		baitpt
	add	#4251+(s-baitpt),baitpt
	djn	#0,		#7	;wait for opponent to catch bait
b1	jmn.a	caught,		pit
	stp	baitpt,		#250
	dat	0,0			;Only way to avoid brainwash :-(
caught	jmp	0			;wait for opponent to suicide

	for	90
	mov	{s,	<s
	mov	<s,	{s
	rof

	end	start
