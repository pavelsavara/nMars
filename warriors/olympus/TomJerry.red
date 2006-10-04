;redcode-94
;contact pan0178@iperbole.bologna.it
;NSFCWT Round #1
;name Tom&Jerry
;author Maurizio Vittuari
;assert CORESIZE==8000

; This is my strategy:

;	Status	    Future status	    Action
;		|		    |
;	Jerry	| res=0   --> None  |   fight with Tom
;		| res>0	  --> Jerry |   fight with Jerry
;	Tom	| stay in Tom	    |   fight with Tom
;	None	| res=0   --> None  |   fight with Tom
;		| res=1,2 --> Jerry |   fight with Jerry
;		| res>2   --> Tom   |   fight with Tom
;		| res=-1  --> None  |   fight with Tom  (1st round!)

; Tom is just a paper, and it's designed to challenge mainly
; in 94m (main purpose: survive!)

; Jerry is a fast scanbomber very similar to Porch Swing
; (just very few changes, Randy forgive me, please ;-)
; it's designed to challenge in 94 (main purpose: kill papers (=mice) !)

; (BTW maybe Tom should kill mices, and Jerry survive... but these things
; work well just in cartoons... ;-)

; by the way I never tested this code at koth! not enought time! :(

Tom_str	equ	#3131	; Tom identifier
Jer_str	equ	#1313	; Jerry identifier
s_slot	equ 	#313	; strategy slot


; * * * Thinking routines * * *

setNone	stp	#0,	s_slot
	jmp	Tom+1,	{-150

strat	ldp	s_slot,	#0
	sne	Tom_str,strat
	jmp	Tom+1,	{-200	; goto Tom (stay in "Tom" status)
res	ldp	#0,	#0
	jmz	setNone,res	; goto Tom (status "None")
	sne	Jer_str,strat	; skip if we're in "None" status
	jmp	Jerry+1,{-250	; goto Jerry (stay in "Jerry" status)
	sne	#2,	res
	jmp	Jerry,	{-350	; if res=2 goto Jerry in "Jerry" status
	sne	#1,	res
	jmp	Jerry,	{-400	; set Jer_str and goto Jerry (res=1)
	sne	#-1,	res
	jmp	Tom+1,	{-300	; 1st round! (goto Tom in "None" status)

;	jmp	Tom		; set Tom_str and goto Tom (res>2)
	

;	 * * * Tom * * *

step1	equ	3743
step2	equ 	1567
step3	equ	1349
istep1	equ	2667
istep2	equ	2668

Tom	stp	Tom_str,s_slot
	mov.i	imp2,	Jerry	; NOTE: without this 2 lines PSpace
				; routines WILL NOT work properly
	mov.i	imp2,	setNone	; (remember we're 36 warriors!!!!)
	spl	boot,	<400
	spl	1,	<300
	spl	1,	<500
	mov	-1,	0
s1	spl	step1,	#0
	mov.i	>-1,	}-1
s2	spl	step2,	#0
	mov.i	>-1,	}-1
	mov.i	<s2,	<s3
s3	spl 	@0,	}step3
	mov.i	#-13,	1

boot	spl	lnch1,	{200	;launching spiral
	spl	lnch3,	{210

lnch2 	spl	8,	{220
	spl	4,	{230
	spl	2,	{240
	jmp	imp2+(istep2*0),{250
	jmp	imp2+(istep2*1),{260
	spl	2,	{270
	jmp	imp2+(istep2*2),{280
	jmp	imp2+(istep2*3),{290
	spl	4,	{300
	spl	2,	{310
	jmp	imp2+(istep2*4),{320
	jmp	imp2+(istep2*5),{330
	spl	2,	{340
	jmp	imp2+(istep2*6),{350
	jmp	imp2+(istep2*7),{360
lnch3   spl	8,	{370
	spl	4,	{380
	spl	2,	{390
	jmp	imp3+(istep2*0),{400
	jmp	imp3+(istep2*1),{-200
	spl	2,	{-210
	jmp	imp3+(istep2*2),{-220
	jmp	imp3+(istep2*3),{-230
	spl	4,	{-240
	spl	2,	{-250
	jmp	imp3+(istep2*4),{-260
	jmp	imp3+(istep2*5),{-270
	spl	2,	{-280
	jmp	imp3+(istep2*6),{-290
	jmp	imp3+(istep2*7),{-300
lnch1   spl	8,	{-310
	spl	4,	{-320
	spl	2,	{-330
	jmp	imp1+(istep1*0),	{-340
	jmp	imp1+(istep1*1),	{-350
	spl	2,	{-360
	jmp	imp1+(istep1*2),{-370
	jmp	imp1+(istep1*3),{-380
	spl	4,	{-390
	spl	2,	{-400
	jmp	imp1+(istep1*4),{-420
	jmp	imp1+(istep1*5),{-430
	spl	2,	{-440
	jmp	imp1+(istep1*6),{-450
	jmp	imp1+(istep1*7),{-460


;	 * * * Jerry * * *

JSTEP	equ    13
EXTRA	equ    9
DJNOFF	equ    (-426-EXTRA)

	dat	#gate-10,step-gate+5
gate	dat	#gate-(EXTRA+4+6),ptr-JSTEP+1
dat2	dat	#gate-20,step-gate+5
dat1	dat	#gate-25,step-gate+5
site2	spl	#gate-30,step-gate+5
site	spl	#gate-40,step-gate+5

imp1    mov.i	#-13,	istep1
for 3
	dat	0,	0
rof
imp2    mov.i	#-13,	istep2	; -13 to avoid "mov.i bomb,{cost"
	mov.i	#-13,	istep2	; #13 also as porte-bonheur ;-)
imp3    mov.i	#-13,	istep2
;	mov.i	#-13,	istep2

Jerry	stp	Jer_str,s_slot	; this will become a mov.i !
loop	sub.f	inc,	ptr
	mov.i	step,	*ptr
	mov.i	step,	@ptr
ptr	sne	@gate+JSTEP*6-1-EXTRA, *gate+JSTEP*3-EXTRA
	djn.f	loop,     <DJNOFF
	add.f	ptr,     gate
inc	spl	#-JSTEP*4+1,<-JSTEP*4+1
clear	mov	@shift,>gate
shift	djn	clear,	{site
step	dat	<JSTEP,	<-JSTEP

end strat
