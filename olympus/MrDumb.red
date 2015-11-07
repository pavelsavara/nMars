;redcode-94
;name Mr Dumb
;author Maurizio Vittuari
;contact pan0178.iperbole.bologna.it
;NSFCWT round 5
;strategy Switching between a paper and Taking Trains ;-)
;assert 1

; 1=win, 2=tie, 0=lose
; Scanner	: 1 -> stay, else goto Paper
; Paper		: 0 -> goto Scanner, else stay

scn_str	equ	#313		; Scannner identifier
pap_str	equ	scn_str+4	; Paper identifier
s_slot	equ 	#131		; strategy slot


; * * * Thinking routines * * *

res	ldp	#0,	0
strat	ldp	s_slot,	0
	sne	scn_str,strat	; skip if I'm in Paper
	djn	paper, res	; I'm in CC, goto Paper if res<>1
	jmn	paper,	res	; if Paper, stay only if not loose
				; if brainwashed goto Paper

scanner	stp	scn_str,s_slot
	jmp	comp,	<-1


;	* * * Paper * * *

step1	equ	3488		; Marcia steps
step2	equ	3740

paper	stp	pap_str,s_slot
	spl	1,	<-1
	spl	1,	{400
	mov	-1,	0
s1	spl	step1,	#0
	mov	>-1,	}-1
	mov	bomb,	}2000
	mov	bomb,	}1900
	mov	<s1,	<s2
s2	jmp 	@0,	}step2
bomb	dat	{1,	<1	; anti djn bomb

for 62
	dat.f	0,	0
rof

;	* * * Scanner * * *

;the good Taking Names with little changes


step    equ    98

clrptr  dat    last+2
jmp3	jmp	-3,	<-7
reset   dat    #step-3,	#step
spl2	spl	-2,	<-6
spl1	spl	-1,	<-5

attack	mov	jmp3,	*comp
compptr	mov	spl2,	{comp
	mov	spl1,	{comp
	mov	spl0,	{comp
	sub	reset,	@compptr

scan	add	spl0,	@compptr
comp	sne	2*step,	3*step
	add	spl0,	@compptr
	seq	*comp,	@comp
	slt	#100+step,@compptr
ctr	djn	scan,	#2500
	jmn	attack,	-1

spl0	spl.i	#(2*step),#(2*step)
clear	mov	reset,	>clrptr
last	jmp	-1
end res
