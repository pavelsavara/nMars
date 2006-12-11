Return-Path: <d91andiv@und.ida.liu.se>
Received: from und.ida.liu.se ([130.236.186.13]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA07958; Thu, 30 Nov 95 15:31:58 CST
Received: from su6-1.ida.liu.se by und.ida.liu.se (5.65b/ida.minimaster-V1.0b6d5)
	id AA06227; Thu, 30 Nov 95 22:40:02 +0100
From: Anders Ivner <d91andiv@und.ida.liu.se>
Received: by su6-1.ida.liu.se (5.x/ida.slave-V1.0b6d6S2)
	id AA02344; Thu, 30 Nov 1995 22:40:02 +0100
Date: Thu, 30 Nov 1995 22:40:02 +0100
Message-Id: <9511302140.AA02344@su6-1.ida.liu.se>
To: stst@idnsun.gpct.Vanderbilt.Edu
Subject: Re: NSFCWT- rules for round 7
Mime-Version: 1.0
Content-Type: text/plain; charset="us-ascii"
Status: R

Here's my warrior for round 7.

/Anders

;redcode-94
;name Victory or death
;author Anders Ivner
;strategy Catch opponent at startup by throwing two jumps to a brainwashing
;strategy pit at him. If he is not caught, change target positions, and
;strategy suicide to protect pspace from brainwash.
;strategy If opponent has a startup longer than 6 instructions, I should
;strategy be guaranteed to catch him before round 50.
;strategy I have no idea if this will work...nothing to test against.


VSTEP	equ	74

s
i	for	145
	mov	<-i,<pit
	mov	{-2,	<4		;imitate boot
	rof

pit	spl	#0,	{0
	stp	#0,	#0
	mov	b,	>500
	jmp	-3,	>-2

bait1	jmp	@4000-250,	-250
bait2	jmp	@4000
b	dat	0,1

start	ldp	#250,	baitpt
	mov	bait1,	<baitpt
baitpt	mov	bait2,	@0

	sub	#4251+(s-baitpt),baitpt
	add	#VSTEP+1,	baitpt
	mod	#250,		baitpt
	add	#4251+(s-baitpt),baitpt
	djn	#0,		#7	;wait for opponent to catch bait
b1	jmn.a	caught,		pit
	stp	baitpt,		#250
	dat	0,0			;Only way to avoid brainwash :-(
caught	jmp	0			;wait for opponent to suicide

	for	90
	mov	{s,	<s
	mov	<s,	{s
	rof

	end	start
