;redcode
;name Lost boy
;author Chris Lindensmith
;assert MAXPROCESSES == 64

start	JMP	CLOOP
btarg	DAT	0,	2	; bombing location
bomb	JMP	@bomb,	1	; the jump to the trap bomb

; The Trap

trap	ADD	#-1,	tcount	; decrement the counter
tloop	SPL	trap		; create more victims
	JMN	tloop,	tcount	; still victims available ?
	MOV	tcount,	tloop	; no, so commit suicide
tcount	DAT	0,	64	; the counter and suicide
	DAT	0,	0

; The Bomber

cloop	ADD	#-20,	bomb	; decrement the bomb
	ADD	#20,	btarg	; increment the target by same
	SLT	#15,	btarg	; do not bomb self
	JMP	cloop		; repeat as necessary
	MOV	bomb,	@btarg	; throw the bomb
	JMP	cloop		; repeat
