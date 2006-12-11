Return-Path: <pan0178@comune.bologna.it>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA10388; Fri, 8 Dec 95 13:56:46 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id NAA18907 for stst@idnsun.gpct.vanderbilt.edu; Fri, 8 Dec 1995 13:01:18 -0600 (CDT)
Received: from accursio.comune.bologna.it (accursio.comune.bologna.it [193.207.1.1]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id NAA18904 for <Stefan.Strack@vanderbilt.edu>; Fri, 8 Dec 1995 13:01:11 -0600 (CDT)
Message-Id: <199512081901.NAA18904@helios.Vanderbilt.Edu>
Received: from async-3.iperbole.bologna.it by accursio.comune.bologna.it with SMTP
	(1.38.193.5/16.2) id AA11147; Fri, 8 Dec 1995 21:05:45 +0100
Date: Fri, 8 Dec 1995 21:05:45 +0100
X-Sender: pan0178@iperbole.bologna.it (Unverified)
X-Mailer: Windows Eudora Version 1.4.4
Mime-Version: 1.0
Content-Type: text/plain; charset="us-ascii"
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
From: pan0178@comune.bologna.it (MV)
Subject: my warrior for round #8
Status: R

;redcode-94
;name Cocktail
;author Maurizio Vittuari
;contact pan0178@iperbole.bologna.it
;NSFCWT Round 8 
;strategy Switching between Taking Names and a paper
;strategy according to Father and Son strategy
;strategy No time to do better :(

; 1=win, 2=tie, 0=loss
; Son   : 1 -> stay, else goto father
; Father: 0 -> goto son, else stay
; Son = paper		 Father = TT


son_str	equ	#413	; son id
fat_str	equ	#0	; father id
s_slot	equ 	#210	; strategy slot


; * * * Thinking routines * * *

res	ldp	#0,	0
strat	ldp	s_slot,	0
	sne	son_str,strat	
	djn	father, res	
	jmn	father,	res	

;	* * * Son * * *

step1	equ	3743
step2	equ 	1567
step3	equ	1349

son	stp	son_str,s_slot
r_count	spl	1,	<last+1
	mov	-1,	0
	mov	-1,	0
r_boot	spl	1,	<b_dist
s1	spl	step1,	#0
	mov	>-1,	}-1
	mov	bomb,	>1942
s2	spl	step2,	#0
	mov	>-1,	}-1
	mov	bomb,	}1842
	mov	bomb,	>2000
	mov	<s2,	<s3
s3	jmp 	@0,	}step3
bomb	dat	<1,	{1


;	 * * * Father * * *

b_dist	equ	6000

father	stp	fat_str,s_slot
for 22
	mov	<r_count,<r_boot	; boot
rof
	jmp	b_dist+r_boot-(last-comp+1),	{b_dist/2

step    equ    98
soap	equ	2

bw	stp	#soap,	#20	; spl spl spl stp jmp  bomb!
clrptr  dat	last+2

jmp4	jmp	-4,	<-1
reset   dat	#step-4,#step
spl2	spl	-2,	<1
spl1	spl	-1,	<2

attack	mov	jmp4,	*comp
compptr	mov	bw,	{comp
	mov	spl2,	{comp
	mov	spl1,	{comp
	mov	spl0,	{comp
	sub	reset,	@compptr

scan	add	spl0,	@compptr
comp	sne	2*step,	3*step
	add	spl0,	@compptr
	seq	*comp,	@comp
	slt	#100+step,@compptr
ctr	djn	scan,	#2500*8
	jmn	attack,	-1

spl0	spl.i	#(2*step),#(2*step)
clear	mov	reset,	>clrptr
last	jmp	-1
end res
