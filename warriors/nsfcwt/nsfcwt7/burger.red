Return-Path: <lewin@netcom.com>
Received: from vuse.vanderbilt.edu ([129.59.100.1]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA08188; Fri, 1 Dec 95 17:11:18 CST
Received: from netcom2.netcom.com by vuse.vanderbilt.edu (8.7.2/SMI-4.1/VUSE-1.18)
	id RAA23423; Fri, 1 Dec 1995 17:19:20 -0600 (CST)
Received: by netcom2.netcom.com (8.6.12/Netcom)
	id PAA23175; Fri, 1 Dec 1995 15:17:35 -0800
Date: Fri, 1 Dec 1995 15:17:35 -0800 (PST)
From: Karl Lewin <lewin@netcom.com>
Subject: Round 7 entry
To: Nandor Sieben <sieben@IMAP1.ASU.EDU>,
        Stefan Strack <stst@vuse.vanderbilt.edu>
Message-Id: <Pine.3.89.9512011549.A22678-0100000@netcom2>
Mime-Version: 1.0
Content-Type: TEXT/PLAIN; charset=US-ASCII
Status: R


I didn't end up with near as much time this week as I'd hoped for,  This 
is but a guess at something that might not finish last :)

;redcode-94
;name Burger Chef & Jeff
;author Karl Lewin
;assert CORESIZE==8000
;NSFCWT Round 7 Entry
;contact lewin@netcom.com
;strategy Quick bomb run with tornado engine followed by
;strategy a very basic paper. :(

STEP	EQU	-10
TSTEP	EQU	1200
CSTEP	EQU	745
NSTEP	EQU	5185
COUNT	EQU	17

	ORG	bomber
first
i for 122
	dat	1,	1
rof
bd	dat	#STEP,	#1
incr	spl	#3*STEP,#3*STEP
	dat	0,	0
bomber	mov.i	bd,	*stone
	mov.i	bd,	@stone
stone	mov.i	*STEP+2+(first+4500),*(2*STEP)+2+(first+4500)
	add	incr,	stone
jump	djn.b	bomber,	#COUNT
	spl	1,	<6000
	spl	1,	<6100
	spl	1,	<6200
tim2	spl	@tim2, }TSTEP      
tim2a	mov.i	}tim2,	>tim2 
cel2	spl	@cel2,	}CSTEP 
cel2a	mov.i	}cel2,	>cel2
	mov.i	<-120,	<120 
ncl2a	mov.i	{cel2,	<ncl2
ncl2	jmp	@ncl2,	>NSTEP
i for 120
	dat 	i,	i*100
	mov.i	1,	100
	mov.x	100,	1
rof






