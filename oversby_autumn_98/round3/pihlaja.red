;redcode
;name Quick Cooking
;author M Joonas Pihlaja
;strategy Switch no loss between two backtrackers -> clear
;assert 1
load0
z for 0
  rof

; I don't have good debug facilities atm (my HD died a few days ago),
; so bugs are likely.



; Sad constants
fcp     EQU 3039
scp     EQU 2365
tcp     EQU 777



;========
; clear

gate	dat	0	,	-4000
	dat	-100	,	-100
	dat	-100	,	-100
	dat	-100	,	-100
clear	spl	#0	,	{gate
	mov	*pclr	,	>gate
	mov	*pclr	,	>gate
	mov	*pclr	,	>gate
	djn.f	-3	,	{gate
	dat	<5334	,	<2667
	dat	<5334	,	<2667
	spl	#-3	,	pclr-gate
	spl	#-2	,	pclr-gate
pclr	dat	>-1	,	>1



cbmb	equ	pclr


;============
; backtracks


;  simplest backtrack possible

scan1	jmz.f	#-2000	,	<gate
	seq	cbmb	,	@gate
	jmp	-2
	sub	#197	,	gate
	jmn.f	-1	,	@gate
	sub	#1-197*3501,	gate		; pray the clear gets
	jmp	clear				; carbo



; hope to avoid anti carbo backtrack decoy

scan2	jmz.f	#-2000	,	<ptr2
	seq	cbmb	,	@ptr2
	jmp	-2
loop	mov	bspl	,	@ptr2		; hope I don't bomb myself
ptr2	mov	bspl	,	@gate-4000
	sub	#197	,	ptr2
	jmn.a	loop	,	@ptr2		; carbo's bombs are all
						; intact, pretty please?
	mov.b	ptr2	,	gate
	sub	#gate-ptr2+1-197*3501,gate
	jmp	clear				; clear carbo body

bspl	spl	#0	,	-1+197*3501




;===========
; switcher
;

PKEY	equ	1

	dat	0	,	0
chg	dat	0	,	1		; SOL
	dat	0	,	0
	dat	0	,	0

think
in	ldp.ab	#PKEY	,	#0
	ldp.a	#0	,	chg
	add.b	*chg	,	in
	mod.ab	#2	,	in
	stp.b	in	,	#PKEY
	jmz	scan1	,	in
	jmp	scan2

	end	think



