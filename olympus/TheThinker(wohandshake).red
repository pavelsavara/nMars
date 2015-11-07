;redcode-94
;name The Thinker (w/o handshake)  
;strategy	Think about what you want to do then do it.
;strategy       Actually, keep track of what opponent does next 
;strategy       after each situation (ie Me-Rock/Him-Paper) and 
;strategy       choose the strategy that beats what opponent does
;strategy       most often.  
;strategy       I hope it is good enough.  Still having a few problems 
;strategy       with white #6, but haven't had time to try anything else.
;author Karl Lewin
;contact lewin@netcom.com
;NSFCWT Entry for Round 6

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
;---BEGIN-VARIABLE-PART----------------------------------------------------
WIN	EQU	#1
LOSS	EQU	#0
TIE	EQU	#2

P_off	EQU	#-3
S_off	EQU	#-2
R_off	EQU	#-1

ROCK	EQU	#3

_RES	EQU	#0

_RND	EQU	#5
_MYLST1	EQU	#1
_MYLST2	EQU	#2
_OPLST1	EQU	#3
_OPLST2	EQU	#4

PP_P_S	EQU	#111
PP_S_R	EQU	#112
PP_R_P	EQU	#113
PS_P_S	EQU	#121
PS_S_R	EQU	#122
PS_R_P	EQU	#123
PR_P_S	EQU	#131
PR_S_R	EQU	#132
PR_R_P	EQU	#133

SP_P_S	EQU	#211
SP_S_R	EQU	#212
SP_R_P	EQU	#213
SS_P_S	EQU	#221
SS_S_R	EQU	#222
SS_R_P	EQU	#223
SR_P_S	EQU	#231
SR_S_R	EQU	#232
SR_R_P	EQU	#233

RP_P_S	EQU	#311
RP_S_R	EQU	#312
RP_R_P	EQU	#313
RS_P_S	EQU	#321
RS_S_R	EQU	#322
RS_R_P	EQU	#323
RR_P_S	EQU	#331
RR_S_R	EQU	#332
RR_R_P	EQU	#333

start
round	ldp.ab	_RND,	round
	nop	>round
	stp.b	round,	_RND
wlt	ldp.b	_RES,	wlt
	seq.ab	#-1,	wlt
	jmp	dtrmopp
for 1
	stp.ab	#1,	PP_S_R
	stp.ab	#1,	PS_S_R
	stp.ab	#1,	PR_S_R
	stp.ab	#1,	SP_R_P
	stp.ab	#1,	SS_R_P
	stp.ab	#1,	SR_R_P
	stp.ab	#1,	RP_P_S
	stp.ab	#1,	RS_P_S
	stp.ab	#1,	RR_P_S
rof	
	mov.a	ROCK,	choice
	jmp	store
dtrmopp	
mylst1	ldp.ab	_MYLST1,mylst1
mylst2	ldp.ab	_MYLST2,mylst2
oplst2	ldp.ab	_OPLST2,oplst2
oplst1	nop	0,	0
	sne.ab	WIN,	wlt
	jmp	win
	sne.ab	TIE,	wlt
	jmp	tie
loss	sne.ab	ROCK,	mylst1
	jmp	op_is_P
	sne.ab	PAPER,	mylst1
	jmp	op_is_S
	sne.ab	SCISSORS,mylst1
	jmp	op_is_R
win	sne.ab	ROCK,	mylst1
	jmp	op_is_S
	sne.ab	PAPER,	mylst1
	jmp	op_is_R
	sne.ab	SCISSORS,mylst1
	jmp	op_is_P
tie	sne.ab	ROCK,	mylst1
	jmp	op_is_R
	sne.ab	PAPER,	mylst1
	jmp	op_is_P
	sne.ab	SCISSORS,mylst1
	jmp	op_is_S

op_is_R	mov	ROCK,	oplst1
	jmp	prjct
op_is_P	mov	PAPER,	oplst1
	jmp	prjct
op_is_S	mov	SCISSORS,oplst1
	jmp	prjct
table
val1	dat	0,	0
val2	dat	0,	0
val3	dat	0,	0
comploc	dat	val3,	val2
prjct
	slt.ab	#2,	round
	jmp	hunds1
hunds0	mul.b	mylst2,	#100
tens0	mul.b	oplst2,	#10
ones0	add.b	oplst1,	ones0
	add.b	hunds0,	ones0
	add.b	tens0,	ones0
wght	ldp.b	ones0,	wght
	nop	>wght
	stp.b	wght,	ones0
hunds1	mul.b	mylst1,	#100	
tens1	mul.b	oplst1,	#10
	add.b	hunds1,	tens1
	nop	>tens1
P	ldp	tens1,	val1
	nop	>tens1
S	ldp	tens1,	val2
	nop	>tens1
R	ldp	tens1,	val3
check	slt.b	@comploc,*comploc
	mov.ba	comploc,comploc
	seq.i	@comploc,table-1
	jmp	check,	<comploc
choose	sne.a	P_off,	comploc
	mov.a	SCISSORS,choice
	sne.a	S_off,	comploc
	mov.a	ROCK,	choice
	sne.a	R_off,	comploc
	mov.a	PAPER,	choice

store	stp.b	mylst1,	_MYLST2
choice	stp.ab	#0,	_MYLST1
	stp.b	oplst1,	_OPLST2
	mov.ab	choice,	my_hand


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
