;redcode-94
;name Machiavelli
;author Maurizio Vittuari
;contact pan0178.iperbole.bologna.it
;NSFCWT round 6
;strategy Handshaking...? Noo! (that means...  Yeah! ;-)
;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80

;my/your_hand are used to communicate between players
your_hand   equ (my_hand+CORESIZE/2)
PAPER       equ #1              ;some useful constants
SCISSORS    equ #2
STONE       equ #3

org         start
my_hand     dat 0,0
;
;           Variable part starts here. This is were I decide what hand to
;           use next. I can use the value of the RESULTS cell (0 if lost,
;           1 if won, 2 if tied last round) and any other values I chose
;           to store in pspace. The hand I decide to show is stored in the
;           B-field of instruction 'my_hand'.
;---BEGIN-VARIABLE-PART-----------------------------------------------------

RES_S	equ	#0		;last result
RND_S	equ	#1		;round_number slot
RAND_S	equ	#2		;pseudo random number generation
STRAT_S	equ	#3		;my last strategy (0,4,5,169,etc.)
M123_S	equ	#4		;my last move (1,2,3)

start
round	ldp	RND_S,	#0
res	ldp	RES_S,	#0
strat	ldp	STRAT_S,#0	; 0,4,5,169,28,37,etc.
lmove	ldp	M123_S,	#0
	jmn	go,	strat	;strat is yet decided!
	jmz	first,	round	;round #0
	sne	#1,	round
	jmp	second		;goto second
	sne	#2,	round
	jmp	third

go	sne	#28,	strat	;goto selected strategy
	jmp	go28
	sne	#347,	strat
	jmp	go347a
	sne	#50,	strat
	jmp	go50
	sne	#5,	strat
	jmp	go5
	sne	#169,	strat
	jmp	go169
	sne	#19,	strat
	jmp	go19
	sne	#37,	strat
	jmp	go28
	sne	#6,	strat
	jmp	go6
	sne	#4,	strat
	jmp	go4
	sne	#113,	strat
	jmp	goa

gor	ldp	RAND_S,	#0	;pseudo random number generation
	add	#1,	gor
	mul	#3,	gor
	add	#5,	gor
	mul	#7,	gor
	stp.b	gor,	RAND_S
	mod	#11,	gor
	add.b	gor,	ptr
num	mov.b	@ptr,	0
	mod	#3,	num
	add	#1,	num
	mov.ba	num,	last
	jmp	fine,	>round
ptr	dat	0,	1	;random table
	dat	0,	3
	dat	0,	2
	dat	0,	1
	dat	0,	1
	dat	0,	2
	dat	0,	3
	dat	0,	1
	dat	0,	3
	dat	0,	2
	dat	0,	1
	dat	0,	3
	dat	0,	2

go28	sne	#1,	res
	jmp	ok28
check28	seq	#501,	round
	jmp	setr
	add	#1,	lmove
	mod	#3,	lmove
ok28	mov.ba	lmove,	last
	jmp	fine,	>round

go19	sne	#1,	res
	jmp	ok19
check19	seq	#501,	round
	jmp	setr
	add	#2,	lmove
	mod	#3,	lmove
ok19	mov.ba	lmove,	last
	jmp	fine,	>round

go169	sne	#1,	res
	jmp	ok169
	sne	#5,	round
	jmp	set6
	jmp	set19
ok169	slt	round,	#10
	jmp	set19
	mov.ba	lmove,last
	jmp	fine,	>round

go6	seq	#1,	res
	jmp	setr
	add	#1,	lmove
	stp	lmove,	M123_S
	div	#5,	lmove
	add	#2,	lmove
	mod	#3,	lmove
	add	#1,	lmove
	mov.ba	lmove,	last
	jmp	fine+1,	>round

go50	sne	#1,	res
	jmp	ok0
	sne	#4,	round
	seq	#2,	res
	jmp	setr
	jmp	set5
ok0	mov.ba	lmove,	last
	jmp	fine,	>round

go5	seq	#1,	res
	jmp	setr
	add	#1,	lmove
	mod.a	#3,	lmove
	mov.ba	lmove,	last
	jmp	fine,	>round
go347a	sne	#1,	res
	jmp	set4		;res=1 --> goto set4
	jmz	seta,	res	;res=0 --> goto seta
	jmp	set37		;res=2 --> goto set37

go4	seq	#1,	res
	jmp	setr
	add	#1,	lmove
	mod	#3,	lmove
	add	#1,	lmove
	mov.ba	lmove,	last
	jmp	fine,	>round

goa	mov	round,	data	;guess why...;-)
	mod	#2,	data
	jmz	uno,	data
	seq	#1,	res
	jmp	setr
	mov	#3,	last
	jmp	fine,	>round
uno	jmn	setr,	res
	mov.a	#1,	last
	jmp	fine,	>round
data	dat	0,	0


set347a	stp	#347,	STRAT_S	;set a strategy
	mov.a	#3,	last
	jmp	fine,	>round
set50	stp	#50,	STRAT_S
	mov.a	#2,	last
	jmp	fine,	>round
set5	stp	#5,	STRAT_S
	mov.a	#1,	last
	jmp	fine,	>round
set19	stp	#19,	STRAT_S
	mov.a	#2,	last
	jmp	fine,	>round
set37	stp	#37,	STRAT_S
	mov.a	#1,	last
	jmp	fine,	>round
set169	stp	#169,	STRAT_S
	mov.a	#2,	last
	jmp	fine,	>round
set28	stp	#28,	STRAT_S
	mov.a	#3,	last
	jmp	fine,	>round
set6	stp	#6,	STRAT_S
	mov	#0,	lmove
	jmp	go6+2
setr	stp	#-1,	STRAT_S
	stp	#6,	RAND_S
	mov.a	#3,	last
	jmp	fine,	>round
seta	stp	#113,	STRAT_S	;guess why...;-)
	mov.a	#1,	last
	jmp	fine,	>round
set4	stp	#4,	STRAT_S
	mov.a	#2,	last
	jmp	fine,	>round


first	mov.a	#1,	last
	jmp	fine,	>round

second	sne	#1,	res
	jmp	set347a		;if win set 347a
	mov.a	#2,	last	;else don't set any strat yet
	jmp	fine,	>round

third	sne	#2,	res
	jmp	set28
	sne	#1,	res
	jmp	set169
	jmp	set50


fine	stp.ab	last,	M123_S
	stp.b	round,	RND_S
last	mov	#1,	my_hand
;---END-VARIABLE PART-------------------------------------------------------
;           End of variable part. I wait for the other player to show his hand.
;           I then analyze the outcome of the game.
;
wait        jmz.b wait,your_hand
work        mov.b your_hand,#work
            sub.b my_hand,work          ;your_hand minus my_hand, loss=1,-2
            add #2,work                 ;loss=3,0
            mod #3,work                 ;loss=0
live        jmn live,work               ;die if lost, live if won or tied

            end

