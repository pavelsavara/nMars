Return-Path: <d91andiv@und.ida.liu.se>
Received: from und.ida.liu.se ([130.236.186.13]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA10376; Fri, 8 Dec 95 13:45:09 CST
Received: from su9-6.ida.liu.se by und.ida.liu.se (5.65b/ida.minimaster-V1.0b6d5)
	id AA08447; Fri, 8 Dec 95 20:53:15 +0100
From: Anders Ivner <d91andiv@und.ida.liu.se>
Received: by su9-6.ida.liu.se (5.x/ida.slave-V1.0b6d6S2)
	id AA12881; Fri, 8 Dec 1995 20:53:14 +0100
Date: Fri, 8 Dec 1995 20:53:14 +0100
Message-Id: <9512081953.AA12881@su9-6.ida.liu.se>
To: stst@idnsun.gpct.Vanderbilt.Edu
Subject: Re: NSFCWT - Rules for round 8
Mime-Version: 1.0
Content-Type: text/plain; charset="us-ascii"
Status: R

Unexpected events force me to submit something lame this round...
Black & white from round 5 (?). If you still have it, the code is
identical.

/Anders

;redcode-94
;name black & white
;kill black & white
;author Anders Ivner
;strategy switch paper from white warrior with multipass coreclear.
;strategy I haven't time for anything more sophisticated. Or testing.

RESULT	equ	#0
CHOICE	equ	#1

result	ldp	RESULT,	#result
choice	ldp	CHOICE,	#choice
	add.b	result,	choice
	add	#1,	choice
	mod	#2,	choice
	stp	choice,	CHOICE
	jmn	black,	choice


white       SPL.B  $     1, $     0
       SPL.B  $     1, $     0     
       SPL.B  $     1, $     0     

       SPL.B  @     0, }  1800     
       MOV.I  }    -1, >    -1     
       SPL.B  @     0, }  3740     
       MOV.I  }    -1, >    -1     
       MOV.I  {    -2, <     1     
       JMP.B  @     0, > -1874     
       DAT.F  > -2467, >   200     
       MOV.I  $    -1, $     1     

	dat	0,0
	dat	0,0

black	mov	b,	b+3400
	for	5
	mov	{black,	<black
	rof
	jmp	s1+3400

pt	dat	#-1,	#10
d1	dat	#-2,	b+2-pt
s1	spl	#-3,	b+2-pt
	mov	@b,	>pt
	mov	@b,	>pt
b	djn	-2,	{s1

       END result
