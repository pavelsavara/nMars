Return-Path: <bremermr@ecn.purdue.edu>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA12806; Fri, 15 Dec 95 15:47:14 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id OAA16850 for stst@idnsun.gpct.vanderbilt.edu; Fri, 15 Dec 1995 14:51:50 -0600 (CDT)
From: bremermr@ecn.purdue.edu
Received: from cartoon.ecn.purdue.edu (bremermr@cartoon.ecn.purdue.edu [128.46.147.13]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id OAA16847 for <stefan.strack@vanderbilt.edu>; Fri, 15 Dec 1995 14:51:46 -0600 (CDT)
Received: from cartoon.ecn.purdue.edu (bremermr@localhost)
	by cartoon.ecn.purdue.edu (8.6.12/3.8davy)
	for delivery to "stefan.strack@vanderbilt.edu"
	id QAA25153; Fri, 15 Dec 1995 16:55:15 -0500
Message-Id: <199512152155.QAA25153@cartoon.ecn.purdue.edu>
Date: Fri, 15 Dec 1995 16:55:15 -0500
Originally-From: "Myer R. Bremer" <bremermr@ecn.purdue.edu>
Originally-To: stefan.strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: No Hope
Status: R

;redcode
;name No Hope
;author M R Bremer
;strategy be small, bomb core
;nsfcwt round 9
;contact <bremermr@ecn.purdue.edu>
;written in '88 redcode

STEP EQU 3044
b       spl 0, -STEP 
stone   mov STEP-1, @STEP*2-1
        mov b, @-1
        add inc, stone
inc     jmp -3, STEP*2

        dat #0, #0
        dat #0, #0
        dat #0, #0
c       jmp 0, 0
        mov -2, inc
        sub #2731, -1
        jmp -2, 0
l       spl b
        jmp c
end l
