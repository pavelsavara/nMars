Return-Path: <gmeadon@MIT.EDU>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA10476; Fri, 8 Dec 95 17:25:47 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id QAA20067 for stst@idnsun.gpct.vanderbilt.edu; Fri, 8 Dec 1995 16:30:20 -0600 (CDT)
Received: from MIT.EDU (PACIFIC-CARRIER-ANNEX.MIT.EDU [18.69.0.28]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id QAA20064 for <stefan.strack@vanderbilt.edu>; Fri, 8 Dec 1995 16:30:17 -0600 (CDT)
Received: from M16-034-12.MIT.EDU by MIT.EDU with SMTP
	id AA10016; Fri, 8 Dec 95 18:32:39 EST
Received: by m16-034-12.MIT.EDU (AIX 3.2/UCB 5.64/4.7) id AA18340; Fri, 8 Dec 1995 18:33:48 -0500
Message-Id: <9512082333.AA18340@m16-034-12.MIT.EDU>
Originally-To: stefan.strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: NSFCWT #8
Date: Fri, 08 Dec 1995 18:33:47 EST
From: George M Eadon <gmeadon@MIT.EDU>
Status: R

;redcode-94x
;name Paper8-IV (54400)
;strategy 8-Process Paper
;author G. Eadon
;NSFCWT #8
;contact gmeadon@mit.edu

start	spl   	1, <2000
	spl	1, <4000
	spl	1, <6000

silk1   spl     11620, #0      	;split to new copy
        mov.i   >-1, }-1     	;copy self to new location
	mov	<silk1, {copy2
copy2	spl	15660, #0
	mov.i	bomb1, {3000
	mov.i	bomb1, <2000
	jmz	-2, silk1
bomb1 	dat.f   0, 0

	end	start







