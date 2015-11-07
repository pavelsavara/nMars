Return-Path: <graham@colossus.mathcs.rhodes.edu>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA10501; Fri, 8 Dec 95 19:56:59 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id TAA20574 for stst@idnsun.gpct.vanderbilt.edu; Fri, 8 Dec 1995 19:01:31 -0600 (CDT)
From: graham@colossus.mathcs.rhodes.edu
Received: from colossus.mathcs.rhodes.edu (colossus.mathcs.rhodes.edu [198.78.24.11]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id TAA20571 for <Stefan.Strack@vanderbilt.edu>; Fri, 8 Dec 1995 19:01:29 -0600 (CDT)
Received: from hal.mathcs.rhodes.edu (hal.mathcs.rhodes.edu [198.78.24.13]) by mathcs.rhodes.edu (8.6.9/8.6.9) with ESMTP id UAA02203 for <Stefan.Strack@vanderbilt.edu>; Fri, 8 Dec 1995 20:01:11 -0600
Received: by hal.mathcs.rhodes.edu (8.6.9) id UAA20024; Fri, 8 Dec 1995 20:01:21 -0600
Date: Fri, 8 Dec 1995 20:01:21 -0600
Originally-From: <graham@colossus.mathcs.rhodes.edu>
Message-Id: <199512090201.UAA20024@hal.mathcs.rhodes.edu>
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: I suck in Round 8
Status: R

;redcode-94x
;author Randy Graham
;name Illusion-94/55
;kill Illusion-94/55
;contact graham@mathcs.rhodes.edu
;NSFCWT round 8
;assert 1
;strategy Original '88 illusion with '94 optimizations and 55440 core
;strategy one-shot f-scanner with spl/spl/dat/dat... coreclear

OPT     equ    22964
GATE    equ    (sweep3-1)

sweep3  dat.f  #GATE-10, repeat-GATE+5
sweep2  spl.a  #GATE-10, repeat-GATE+5
sweep1  spl.a  #GATE-10, repeat-GATE+5
        dat.f  #0,       #0         ;danger
adder   add.ab #OPT,     seat
check   jmz.f  adder,    @seat
setup   add.b  seat,     GATE
seat    spl.a  0,        #OPT       ;danger
clean   mov.i  @repeat,  >GATE
repeat  djn.b  clean,    {sweep1
end check
