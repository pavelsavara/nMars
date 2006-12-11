Return-Path: <pan0178@comune.bologna.it>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA12630; Fri, 15 Dec 95 09:31:05 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id IAA15607 for stst@idnsun.gpct.vanderbilt.edu; Fri, 15 Dec 1995 08:35:41 -0600 (CDT)
Received: from accursio.comune.bologna.it (accursio.comune.bologna.it [193.207.1.1]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id IAA15604 for <Stefan.Strack@vanderbilt.edu>; Fri, 15 Dec 1995 08:35:31 -0600 (CDT)
Message-Id: <199512151435.IAA15604@helios.Vanderbilt.Edu>
Received: from async-10.iperbole.bologna.it by accursio.comune.bologna.it with SMTP
	(1.38.193.5/16.2) id AA03644; Fri, 15 Dec 1995 16:39:54 +0100
Date: Fri, 15 Dec 1995 16:39:54 +0100
X-Sender: pan0178@iperbole.bologna.it (Unverified)
X-Mailer: Windows Eudora Version 1.4.4
Mime-Version: 1.0
Content-Type: text/plain; charset="us-ascii"
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
From: pan0178@comune.bologna.it (MV)
Subject: my warrior for round 9
Status: R

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
