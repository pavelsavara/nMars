Return-Path: <gmeadon@MIT.EDU>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA12744; Fri, 15 Dec 95 13:22:11 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id MAA16211 for stst@idnsun.gpct.vanderbilt.edu; Fri, 15 Dec 1995 12:26:46 -0600 (CDT)
Received: from MIT.EDU (PACIFIC-CARRIER-ANNEX.MIT.EDU [18.69.0.28]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id MAA16207 for <stefan.strack@vanderbilt.edu>; Fri, 15 Dec 1995 12:26:43 -0600 (CDT)
Received: from M16-034-7.MIT.EDU by MIT.EDU with SMTP
	id AA15227; Fri, 15 Dec 95 14:30:09 EST
Received: by M16-034-7.MIT.EDU (AIX 3.2/UCB 5.64/4.7) id AA16030; Fri, 15 Dec 1995 14:30:12 -0500
Message-Id: <9512151930.AA16030@M16-034-7.MIT.EDU>
Originally-To: stefan.strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: NSFCWT #9
Date: Fri, 15 Dec 1995 14:30:12 EST
From: George M Eadon <gmeadon@MIT.EDU>
Status: R

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




