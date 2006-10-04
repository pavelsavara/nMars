;redcode-ICWS
;name Turkey
;author Beppe Bezzi
;contact bezzi@iol.it
;NSFCWT round 9
;strategy stone imp
;strategy Ready to be eaten next week
;assert CORESIZE==8192

bstep   equ     3428
step    equ     3511
bomb	equ	start-1

start   spl     launch
	spl     0
stone   add     #bstep, 1
	mov     bomb,   stone-1  
	jmp     stone
for 51
	dat     #0
rof
;Thanx to Jay Han for his makeimp, it saved me a lot of time

launch
	spl     lbl3
	spl     lbl5
	spl     lbl9
	spl     lbl17
	jmp     imp+0*step+0
lbl17   jmp     imp+1*step+0
lbl9    spl     lbl19
	jmp     imp+2*step+0
lbl19   jmp     imp+3*step+0
lbl5    spl     lbl11
	spl     lbl21
	jmp     imp+4*step+0
lbl21   jmp     imp+5*step+0
lbl11   spl     lbl23
	jmp     imp+6*step+0
lbl23   jmp     imp+0*step+1
lbl3    spl     lbl7
	spl     lbl13
	spl     lbl25
	jmp     imp+1*step+1
lbl25   jmp     imp+2*step+1
lbl13   spl     lbl27
	jmp     imp+3*step+1
lbl27   jmp     imp+4*step+1
lbl7    spl     lbl15
	spl     lbl29
	jmp     imp+5*step+1
lbl29   jmp     imp+6*step+1
lbl15   spl     lbl31
	jmp     imp+0*step+2
lbl31   jmp     imp+1*step+2
imp     mov     0,      step
end     start
