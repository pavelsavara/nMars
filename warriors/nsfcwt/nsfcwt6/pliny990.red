;redcode-94
;name PlinySwitch - 2990
;author G. Eadon
;NSFCWT Round 6
;contact gmeadon@mit.edu
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
seed	dat	0, 0
roundnum dat	0, 0
strategy dat 	0, 0
res	dat	0, 0
temp	dat	0, 0
;p-space locs
RESULT	equ	#0
ROUND	equ	#1
PSEED	equ	#2
STRAT	equ	#3
LOSSES	equ	#4
PROBE	equ	#5
LPLAY	equ	#6

;strategys
WW1_9	equ	#2
WW2_8	equ	#3
WW3_7	equ	#1
WW4	equ	#4
WW5	equ	#5
WW6	equ	#6
WW10	equ	#2		; Treat WW 10 as if it were WW 1
RAND	equ	#8

start	ldp	ROUND, roundnum
	add	#1, roundnum
	stp	roundnum, ROUND

	slt	#6, roundnum	; Probe during rounds 1-6
	jmp	probe		; (Play: 112233)

	sne	#7, roundnum	; Round 7: Check Probe Results
	jmp	check_ww

	ldp	RESULT, res
	seq	res, #1		; should always win
	jmp	lstrat

ch_strat ldp	STRAT, strategy
	sne	strategy, RAND
	jmp	rand
	
	slt	strategy, #4
	jmp	next

	sne	strategy, WW1_9
	mov.i	ww19, strat1
	sne	strategy, WW2_8
	mov.i	ww28, strat1
	sne	strategy, WW3_7
	mov.i	ww37, strat1
	jmp	strat1
next	sne	strategy, WW5
	jmp	strat2
	sne	strategy, WW4
	jmp	strat4
	sne	strategy, WW6
	jmp	strat3

lstrat	ldp	STRAT, strategy
	ldp	LOSSES, temp
	add	#1, temp
	stp	temp, LOSSES
worry	slt	strategy, #4
	jmp	alldone
	jmp	adjust
alldone	stp	RAND, STRAT
;********
rand	ldp	RESULT, res
	ldp	LPLAY, strategy
	sub	#1, res
	jmz	again, res
	ldp     PSEED, strategy
        mul     #5, strategy
        add     #91, strategy
        stp     strategy, PSEED
        mod     #3, strategy
        add     #1, strategy
again	mov	strategy, my_hand
	stp	strategy, LPLAY
	jmp	wait
;********
strat1  mov	WW1_9, my_hand
	jmp	wait

ww19	mov	SCISSORS, (my_hand - strat1)
ww28	mov	STONE, (my_hand - strat1)
ww37	mov	PAPER, (my_hand - strat1)
;********
adjust	ldp	STRAT, strategy
	slt	temp, #2
	jmp	go_rand
	sne	strategy, WW1_9
	mov.i	turn3, go_rand
	sne	strategy, WW2_8
	mov.i	turn3, go_rand
	sne	strategy, WW3_7
	mov.i	turn1, go_rand
go_rand	stp	RAND, STRAT
	stp	#1, #0
	jmp	ch_strat
turn3	stp	WW3_7, STRAT
turn1	stp	WW1_9, STRAT
;********
strat2	ldp	ROUND, temp
	add	#1, temp
	mod	#3, temp
	add	#1, temp
	mov	temp, my_hand
	jmp	wait
;********
strat3	ldp	ROUND, temp
	div	#5, temp
	add	#1, temp
	mod	#3, temp
	add	#1, temp
	mov	temp, my_hand
	jmp	wait
;********
strat4	ldp	PSEED, temp
	add	#2, temp
	mod	#3, temp
	stp	temp, PSEED
	add	#1, temp
	mov	temp, my_hand
	jmp	wait
;********
probe	ldp	PROBE, res
	mul	#3, res
	ldp	RESULT, temp
	add	temp, res
	stp	res, PROBE
	sub	#1, roundnum
	div	#2, roundnum
	add	#1, roundnum
	mov	roundnum, my_hand
	jmp	wait
;********
check_ww ldp	RESULT, temp
	ldp	PROBE, res
	mul	#3, res
	add	temp, res
	stp	res, PROBE
	stp	#2, PSEED
	stp	RAND, STRAT
	sne.b	res, @x1
	stp.ab	@x1, STRAT
	add	#1, x1
	djn	-3, #(x1-str_tab) 

	jmp	ch_strat
str_tab	dat	RAND, #0
	dat	WW1_9, #7955
	dat	WW2_8, #7347
	dat	WW3_7, #7603
	dat	WW4  , #7584
	dat	WW5  , #7403
	dat	WW6  , #7959
	dat	WW10 , #7362
x1	dat	0, str_tab
;********
	
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



