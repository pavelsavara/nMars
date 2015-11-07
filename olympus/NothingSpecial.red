;redcode
;NSFCWT Round #9
;contact gmeadon@mit.edu
;name Nothing Special
;author G. Eadon
;strategy Mod-4 DAT Bomber + 15 process -- 5 point spiral

start	spl	launch
	SPL 	0
loop    ADD 	#3812, ptr
ptr     MOV 	bomb, 2
        JMP 	loop
bomb	dat	#0, #12
	
; 15-process 5-point spiral (coresize 8192, '88 standard)
step    equ     3277
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
lbl21   jmp     imp+0*step+1
lbl11   spl     lbl23
        jmp     imp+1*step+1
lbl23   jmp     imp+2*step+1
lbl3    spl     lbl7
        spl     lbl13
        spl     lbl25
        jmp     imp+3*step+1
lbl25   jmp     imp+4*step+1
lbl13   spl     lbl27
        jmp     imp+0*step+2
lbl27   jmp     imp+1*step+2
lbl7    spl     lbl15
        spl     lbl29
        jmp     imp+2*step+2
lbl29   jmp     imp+3*step+2
lbl15   jmp     1               ; Idle 1 cycle
        jmp     imp+4*step+2
imp     mov     0,      step
end 	start
