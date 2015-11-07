;redcode-94
;name Blizzard
;author Anders Ivner

;-Name inspired by the weather - Sweden has been covered by 3 feet of snow
;-in the last 24 hrs. Winter sucks.

;Search last 150 rounds for sequence matching the last 20 rounds
;Special test for white #6
;Attempt to cooperate with opponent by alternating STONE/PAPER
;If I'm losing -> use pseudo random


;Warrior that plays the game of Paper-Scissors-Stone in NSFCWT round 5
;Needs to be paired with one opponent exactly half the coresize apart (-d 4000)
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
RESULT	equ	#0
ROUND	equ	#1
MYLAST	equ	#2
COOP	equ	#3
ISNR6	equ	#4
SEED	equ	#5
SCORE	equ	#6
PANIC	equ	#7
MEMPT	equ	#8			;first unwritten memory cell. 0-based.
MEMBASE	equ	100

MEMLEN	equ	150
FINDLEN	equ	20

membase	equ	(start+1000)

resetter	mov	#membase-cpypt+1,	cpypt-respt

result	dat	0,	0		;no points for losing
	dat	3,	0		;3 points for winning
	dat	1,	0		;1 point for tieing

start	ldp	RESULT, result
round	ldp	ROUND,	#round
newr	add.b	round,	#1
	stp	newr,	ROUND
	jmz	first,	round

panic	ldp	PANIC,	#panic
	jmn.b	random,	panic		;if I'm losing, use random

score	ldp	SCORE,	#score
	add.ab	@result,score		;update my score
	stp	score,	SCORE

	mod	#100,	round		;test every 100 rounds
	jmn	mylast,	round
	stp	#0,	SCORE		;reset score
	slt.b	score,	#100		;am I losing?
	jmp	mylast
	stp	#1,	PANIC		;then PANIC!
	jmp	random			;this should not happen :)

mylast	ldp	MYLAST,	#mylast
hislast	mov.b	mylast,	#hislast
	add.b	result,	hislast
	mod.ab	#3,	hislast
	add.ab	#1,	hislast		;awkward calculation...
comb	mul.b	mylast,	#10
	add.b	hislast,comb		;both in one memory cell

mempt	ldp	MEMPT,	#mempt
pspt	add	mempt,	#MEMBASE
	stp.b	comb,	pspt		;store last result in pspace
	add	#1,	mempt
	mod	#MEMLEN,mempt
	stp.b	mempt,	MEMPT		;update MEMPT

;-------Attempt to cooperate with opponent by alternating STONE/PAPER
coop	ldp	COOP,	#coop
	jmn	nocoop,	coop
test	mul.b	newr,	#2
	mod.ab	#4,	test
	add	#1,	test
	seq.b	hislast,test
	jmp	failc			;cooperation failed
	mov.b	hislast,my_hand
	jmp	fin
failc	stp	#1,	COOP
nocoop	equ	failc+1

;-------Test for white #6 (1111222223333311111...)
isnr6	ldp	ISNR6,	#isnr6
	jmn.b	not6,	isnr6

test6	add	newr,	#-1		;what w#6 should've played last
	div	#5,	test6
	mod	#3,	test6
	add.ab	#1,	test6
	seq.b	hislast,test6
	jmp	fail6
new6	mov.b	newr,	#0
	div	#5,	new6
	mod	#3,	new6
	add	#1,	new6		;what it will play now
	mod	#3,	new6
	add	#1,	new6		;what I will play
	mov	new6,	my_hand
	jmp	fin

fail6	stp	#1,	ISNR6
not6	equ	fail6+1

;-------Fast coping of last MEMLEN rounds into core from pspace----
cpypt	sub.b	mempt,	#membase+MEMLEN
respt	add.b	mempt,	#memcpy
	sub.b	respt,	resetter
	mov	resetter,@respt
memcpy
i	for	MEMLEN
	ldp	#i+MEMBASE-1,	>cpypt
	rof

;-------Create Knuth-Morris-Pratt-flowchart
THISCHAR	equ	(membase+MEMLEN-2-i)
THISNODE	equ	(node1+(1+i)*5)
LASTNODE	equ	(node1+i*5)

	mov.ba	membase+MEMLEN-1,	node1
	mov.ba	membase+MEMLEN-2,	node2

i	for	FINDLEN-2

	mov.ba	THISCHAR,THISNODE	;copy char to node
	sne.a	LASTNODE,>r		;inc to point to jmp
	jmp	3
	add.ab	@r,	r		;follow vertice
	jmn.b	-3,	r
	add	#4,	r		;r++, 5 loc apart, one from inc
	add.ba	r,	THISNODE+1	;save vertice

	rof
	
r	nop	finder,	node1
;-------Knuth-Morris-Pratt-flowchart-----
finder	seq.ab	3,	<scanpt
	jmn.b	finder, @scanpt		;makes zero (EOF) match anything
	jmp	firsttime
node1	seq.ab	#0,	@scanpt
scanpt	jmp	*r,	membase+MEMLEN-1	;-1 - don't compare last

	seq.ab	3,	<scanpt
	jmn.b	*3,	@scanpt		;makes zero (EOF) match anything
	jmp	firsttime
node2	seq.ab	#0,	@scanpt
	jmp	-6

i	for	FINDLEN-2
	seq.ab	3,	<scanpt
	jmn.b	*3,	@scanpt		;makes zero (EOF) match anything
	jmp	firsttime
	seq.ab	#0,	@scanpt
	jmp	r
	rof

;-------Keep track of longest found string-----
firsttime
	jmz	scandone,@scanpt	;if EOF
newnode	add	#5,	#finder+2-5
	mov.a	#3,	@newnode	;set jmp to next node
len	add	#1,	#0
	mov.ba	scanpt,	longest		;save address to found
	add.ba	len,	longest		;adjust to start
	djn	@newnode,#FINDLEN	

;-------Scan is complete, decide on what to do---
scandone
	jmz.a	random,	longest		;nothing found -> use random
longest	mov	#0,	scanpt
hismove	mov	@scanpt,#hismove
	mod	#10,	hismove		;decode memory
	mod	#3,	hismove
mymove	add	hismove,#1
	mov	mymove,	my_hand
	jmp	fin		

;-------First round
first	mov	STONE,	my_hand
	jmp	fin

;-------Random will ensure 33/33/33--------
random	ldp	SEED,	#random
	add	#237,	random
	mul	#253,	random
	stp	random,	SEED
	mod.ab	#3,	random
	add.ab	#1,	random
	mov.b	random,	my_hand

fin	stp	my_hand,MYLAST

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

