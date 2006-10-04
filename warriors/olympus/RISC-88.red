;redcode-88
;name RISC-88
;author Maurizio Vittuari
;contact pan0178@iperbole.bologna.it
;NSFCWT Round 9 
;strategy gate busting spiral + 40%c suicidal bomber
;strategy using a subset of '88 instructions
;strategy RISC --> Reduced Istructions Set Carnage  ;-)
;assert CORESIZE == 8192

step1   equ     (2730+1)
step2   equ     (2730+2)

start	spl	bomber-1
	spl	lnch1
	spl	lnch3
	 
lnch2	SPL	8
	SPL	4
	SPL	2
	JMP	imp2+(step2*0)
	JMP	imp2+(step2*1)
	SPL	2
	JMP	imp2+(step2*2)
	JMP	imp2+(step2*3)
	SPL	4
	SPL	2
	JMP	imp2+(step2*4)
	JMP	imp2+(step2*5)
	SPL	2
	JMP	imp2+(step2*6)
	JMP	imp2+(step2*7)
	
lnch3   SPL	8
	SPL	4
	SPL	2
	JMP	imp3+(step2*0)
	JMP	imp3+(step2*1)
	SPL	2
	JMP	imp3+(step2*2)
	JMP	imp3+(step2*3)
	SPL	4
	SPL	2
	JMP	imp3+(step2*4)
	JMP	imp3+(step2*5)
	SPL	2
	JMP	imp3+(step2*6)
	JMP	imp3+(step2*7)
	
lnch1   SPL	8
	SPL	4
	SPL	2
	JMP	imp1+(step1*0)
	JMP	imp1+(step1*1)
	SPL	2
	JMP	imp1+(step1*2)
	JMP	imp1+(step1*3)
	SPL	4
	SPL	2
	JMP	imp1+(step1*4)
	JMP	imp1+(step1*5)
	SPL	2
	JMP	imp1+(step1*6)
	JMP	imp1+(step1*7)

for 100-65        
	dat     #1
rof

	spl	4
bomber	mov	-2,	@ptr	; 2-tasks 40%c simple bomber
	mov	-3,	@ptr    ; bombs are simple dat #1 
	add	#412,	ptr
	add	#412,	ptr
ptr	jmp	bomber,	#98+412


imp1    MOV	0,	step1
	DAT	#0
	DAT	#0
	DAT	#0
imp2    MOV	0,	step2
	MOV	0,	step2
imp3    MOV	0,	step2
last	MOV	0,	step2

end start
