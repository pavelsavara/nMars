Return-Path: <pan0178@comune.bologna.it>
Received: from strutter.cc.vanderbilt.edu ([129.59.1.18]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA08004; Thu, 30 Nov 95 17:28:57 CST
Received: (from daemon@localhost) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) id RAA12208 for stst@idnsun.gpct.vanderbilt.edu; Thu, 30 Nov 1995 17:36:55 -0600 (CDT)
Received: from accursio.comune.bologna.it (accursio.comune.bologna.it [193.207.1.1]) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) with SMTP id RAA12204 for <Stefan.Strack@vanderbilt.edu>; Thu, 30 Nov 1995 17:36:48 -0600 (CDT)
Message-Id: <199511302336.RAA12204@strutter.cc.vanderbilt.edu>
Received: from async-7.iperbole.bologna.it by accursio.comune.bologna.it with SMTP
	(1.38.193.5/16.2) id AA22017; Fri, 1 Dec 1995 00:37:41 +0100
Date: Fri, 1 Dec 1995 00:37:41 +0100
X-Sender: pan0178@iperbole.bologna.it (Unverified)
X-Mailer: Windows Eudora Version 1.4.4
Mime-Version: 1.0
Content-Type: text/plain; charset="us-ascii"
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
From: pan0178@comune.bologna.it (MV)
Subject: my warrior for round 7
Status: R

BTW I have no preferences between 9 or 10 rounds...
I hope just they will be cruel ones...
(I prefer kill enemy, after killed maybe I can also sort him...;-)

regards

Maurizio


;redcode-94
;name Settete
;author Maurizio Vittuari
;contact pan0178@iperbole.bologna.it
;NSFCWT Round 7 
;strategy Copy a core-clear near to the enemy, and then...
;strategy switch between paper and bomber (Flint)
;strategy according to the "Father & Son" strategy
;assert CORESIZE == 8000

; ***  Father & Son strategy  ***

; 1=win, 2=tie, 0=loss
; Son   : 1 -> stay, else goto father
; Father: 0 -> goto son, else stay
; Here Flint is the father


son_str	equ	#517	; Son identifier
fat_str	equ	#0	; Father identifier
s_slot	equ 	#297	; strategy slot


boot1	equ	ref+4000+250	; boot distance
ref	equ	m3-300

for 300					; decoy
	dat	<1,	{1
rof
m3	dat	#0,	{-10
m1	mov	m3,	{m3
m2	djn.f	m1,	<250
start	mov.i	m3,	boot1-1		; copy core-clear near to the enemy
	mov.i	m1,	boot1
	mov.i	m2,	boot1+1
	spl	boot1,	{boot1-100

; * * * Thinking routines * * *

res	ldp	#0,	0
strat	ldp	s_slot,	0
	sne	son_str,strat	; skip if father
	djn	father, res	; if son, goto father if res<>1
	jmn	father,	res	; if father, stay if not loose
				; NOTE If I'd been in son -->res=0
				; owing to djn: goto son
;	jmp 	son		; goto son if father loose
				; or stay if I won



;	* * * Son * * *

step1	equ	3743
step2	equ 	1567
step3	equ	1349

son	stp	son_str,s_slot

r_count	spl	1,	<last+1	; a well known paper
	mov	-1,	0
r_boot	spl	1,	<b_dist
	mov	-1,	0
s1	spl	step1,	#0
	mov	>-1,	}-1
	mov	bomb,	}1942
s2	spl	step2,	#0
	mov	>-1,	}-1
	mov	bomb,	}1842
	mov	bomb,	}1900
	mov	bomb,	}2000
	mov	<s2,	<s3
s3	jmp 	@0,	}step3
bomb	dat	<2667,	<5334	;anti imp bomb
sbomb	mov	55,	1	;sort of incendiary bomb


;	 * * * Father * * *

b_dist	equ	2000		; Flint boot distance

father	stp	fat_str,s_slot
for 8				; booting routine
	mov	<r_count,<r_boot
rof
	mov	ptr2,	b_dist+r_boot-12-1
	mov	ptr2+1,	b_dist+r_boot-12
	mov	sbomb,	b_dist+r_boot+12
	jmp	b_dist+r_boot-(last-sstart+1),	{b_dist/2

ptr2	dat	#1,	#30		; "compressed" Flint
	spl	#1,	#30

sstart	mov	20,	@ptr	;sbomb
	mov	s,	*ptr
ptr	mov	*57,	*112
	sub.f	s,	ptr
	djn	sstart,	#533
s	spl	#-165,	<-165
rast	mov	@last,	>-11-1	;ptr2-1
last	djn.f	rast,	{-12+1	;ptr2+1

for	148				; decoy
	dat	<1,	{1
rof
end start
