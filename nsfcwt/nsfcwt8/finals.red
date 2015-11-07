Return-Path: <bremermr@ecn.purdue.edu>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA10422; Fri, 8 Dec 95 15:17:50 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id OAA19500 for stst@idnsun.gpct.vanderbilt.edu; Fri, 8 Dec 1995 14:22:23 -0600 (CDT)
From: bremermr@ecn.purdue.edu
Received: from cartoon.ecn.purdue.edu (bremermr@cartoon.ecn.purdue.edu [128.46.147.13]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id OAA19497 for <stefan.strack@vanderbilt.edu>; Fri, 8 Dec 1995 14:22:19 -0600 (CDT)
Received: from cartoon.ecn.purdue.edu (bremermr@localhost)
	by cartoon.ecn.purdue.edu (8.6.12/3.8davy)
	for delivery to "stefan.strack@vanderbilt.edu"
	id QAA10710; Fri, 8 Dec 1995 16:25:20 -0500
Message-Id: <199512082125.QAA10710@cartoon.ecn.purdue.edu>
Date: Fri, 8 Dec 1995 16:25:20 -0500
Originally-From: "Myer R. Bremer" <bremermr@ecn.purdue.edu>
Originally-To: stefan.strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: finals:no time
Status: R

;redcode-94
;name finals: no time  
;author M R Bremer
;nsfcwt round 8 
;contact <bremermr@ecn.purdue.edu>

org boot+1

BOOTPTR EQU 13500

ptrs    dat sp1, 0
        add.f step, scan
scan    sne.i }108-3, >100-3
        djn.f -2, <-1664
sp1     spl #9, #14
        mov.i *ptrs, >scan
        mov.i *ptrs, >scan
        djn.f -2, <-40
step    dat 16, 16
        spl #8, #14
for 73
        dat last+10, last+11  
rof
boot    dat BOOTPTR, 12
        mov ptrs, }boot
        mov ptrs+1, }boot 
        mov ptrs+2, }boot
        mov ptrs+3, }boot
        mov ptrs+4, }boot
        mov ptrs+5, }boot
        mov ptrs+6, }boot
        mov ptrs+7, }boot
        mov ptrs+8, }boot
        mov ptrs+9, }boot
        mov 10, step-2
last    jmp  BOOTPTR-10
for 90
	dat 1, 1
rof
