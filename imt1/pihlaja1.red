;redcode
;name Variations 1
;author M. J. Pihlaja
;strategy Cooperation with gradual retaliation.
;assert CORESIZE==8000

; entry for IMT #1


;---------
;CARBONITE
;---------

Stone
	spl	killstps
	jmp	carbo


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

Paper	spl	killstps

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
; A sort of tit for tat based on meta cooperation, with gradual
; retaliation.


; I don't want to be mean to TimeScape, so I use dats instead of spls
; in all tables.
	dat	#0	,	init-state
in	dat	#0	,	loss_table-state
	dat	#0	,	win_table-state
	dat	#0	,	tie_table-state

;states
SRCH	equ	dat	Stone	,	0
RET0	equ	dat	retaliate_init,	1
RET1	equ	dat	retaliate_doit,	2
RET2	equ	dat	Paper	,	3 ; dummy which moves to SRCH always
COOP0	equ	dat	Paper	,	4
COOP1	equ	dat	Su	,	5
NSTATES	equ	6



win_table
	COOP1		; <- SRCH
	RET1		; <- RET0
	RET1		; <- RET1
init	SRCH		; <- RET2
	COOP1		; <- COOP0
	SRCH		; <- COOP1	[1]


loss_table
	COOP0		; <- SRCH
	RET1		; <- RET0
	RET1		; <- RET1
	SRCH		; <- RET2
	SRCH		; <- COOP0	[2]
	COOP0		; <- COOP1

tie_table
	RET0		; <- SRCH
	RET1		; <- RET0
	RET1		; <- RET1
	SRCH		; <- RET2
	RET0		; <- COOP0
	SRCH		; <- COOP1	[1]


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






; retaliate:
;	When I think that I'm being exploited, I play N papers in a row,
;	where N is the number of defections played by my opponent so far.
;	I'm not sure how to feel about the opponents defection during my
;	retaliation period.  I think I'll ignore them for now.
;
;

RETCNT	equ	2
NDEFECTS equ	3


rcnt	dat	0	,	0

retaliate_doit
	ldp.a	#RETCNT	,	rcnt
	djn.a	ret_store1,	rcnt

	mov.ab	#PSTATE	,	ret_store1
	mov.a	#5	,	rcnt		;  pretend we were in RET2
	mov.a	#Su-ret_store1-1,ret_store1+1
	jmp	ret_store1

retaliate_init
	ldp.ab	#NDEFECTS,	rcnt
	add	#1	,	rcnt
	mov.ba	rcnt	,	rcnt

ret_store2
	stp.b	rcnt	,	#NDEFECTS
ret_store1
	stp.ab	rcnt	,	#RETCNT
	jmp	Paper


killstps
	mov	datzero	,	ret_store2
	mov	datzero	,	ret_store1
datzero


z	for	8
	dat	0	,	0
	rof

Su	djn	0	,	#50		; wait for the opponent to
	dat	0	,	0		; finish thinking

z	for	7
	dat	0	,	0
	rof

; the dat's are here so that I will terminate if I am overwriten by an
; incomplete paper.


	end	think


-----------------

