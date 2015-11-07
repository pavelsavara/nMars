entryway	JMP	@0
counter		DAT	20
databomb	DAT	0
scan		ADD	#108,outptr		; assumes corsize multiple of 4
start		JMZ	scan,@outptr		; scan till enemy found
		ADD	#10,outptr
NOOP		JMP	1			; noops are placed to avoid
						; sighting self
		MOV	#1,entryway		; place jump into trap 10
		SUB	outptr,entryway		; spots ahead of enemy
		MOV	entryway,@outptr	; position
		JMP	1
		MOV	#20,counter		; create path of 20 NOOPs
noopbomb	MOV	NOOP,<outptr		; which lead to jump into trap
		DJN	noopbomb,counter
		JMP	1
		ADD	#10,outptr		; restart scan where left off
		JMP	scan
bombptr		DAT	entryway		; pointer for trapped enemies
outptr		DAT	0
trap		SPL	0			; occupy all lines of execution
		MOV	databomb,<bombptr	; bomb every square
		JMP	trap			; commit suicide when bombing
						; wraps around and hits self
		END	start
