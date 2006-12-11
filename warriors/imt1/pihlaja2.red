;redcode
;name Variations 4
;author M. J. Pihlaja
;strategy Cooperates until the opponent defects, then
;strategy make a permanent switch to AllD.
;assert CORESIZE==8000

; entry for IMT #1


;---------
;CARBONITE
;---------

Stone	equ	carbo

dbomb	dat	>-1, >1
carbo	spl	#0, <-100
	mov	dbomb, tar-197*3500
tar	add	#197, -1		; gets bombed to start coreclear
	djn.f	-2, <-1151

	for	8
	dat	0	,	0
	rof



;---------
;TIMESCAPE
;---------

Paper	equ	time

TSTEP equ 1800
CSTEP equ 3740
NSTEP equ -1922
FSTEP equ 1870

time    spl     1,              <-200
        spl     1,              <-300
        mov.i   -1,             0

tim1    spl     @tim1,          }TSTEP
        mov.i   }tim1,          >tim1
cel1    spl     @cel1,          }CSTEP
        mov.i   }cel1,          >cel1
        mov.i   {-FSTEP,        <FSTEP
        mov.i   {cel1,          <ncl1
ncl1    jmp     @ncl1,          >NSTEP

	for	2
	dat	0	,	0
	rof


;*****
; Brains
;*****


	dat	#0	,	init-state
in	dat	#0	,	loss_table-state
	dat	#0	,	win_table-state
	dat	#0	,	tie_table-state

;states
SRCH	equ	dat	Stone	,	0
COOP0	equ	dat	Paper	,	1
COOP1	equ	dat	Su	,	2
SPITE	equ	dat	Paper	,	3
NSTATES	equ	4



win_table
	COOP1		; <- SRCH
	COOP1		; <- COOP0
	SRCH		; <- COOP1	[1]
	SPITE		; <- SPITE

loss_table
	COOP0		; <- SRCH
	SRCH		; <- COOP0	[2]
	COOP0		; <- COOP1
	SPITE		; <- SPITE

tie_table
init	SRCH		; <- SRCH
	SPITE		; <- COOP0
	SRCH		; <- COOP1	[1]
	SPITE		; <- SPITE


; [1]	I have had to think this one over.  When we were supposed to suicide
;	but we won, we only can assume that the other player suicided
;	first.  This is why playing SRCH isn't all that bad of an idea.
;	However, when a tie is found, I don't really know what to think.
;	At the moment, we move SRCH state.
;
;
; [2]	When we play Paper and lose, then we suspect (according to
;	statistics anyway) that we played Stone.  We move into
;	SRCH state.
;


PSTATE	equ	1
think	ldp.a	#0	,	in
load	ldp.a	#PSTATE	,	state
	mod.a	#NSTATES,	state
	add.ba	*in	,	state
	stp.ba	*state	,	load
	mov	0	,	-1
state	jmp	*0




z	for	8
	dat	0	,	0
	rof

Su	djn	0	,	#50
	dat	0	,	0

z	for	7
	dat	0	,	0
	rof


	end	think


