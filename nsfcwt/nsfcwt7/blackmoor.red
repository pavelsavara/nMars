Return-Path: <PK6811S@ACAD.DRAKE.EDU>
Received: from strutter.cc.vanderbilt.edu ([129.59.1.18]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA06432; Sat, 25 Nov 95 17:47:15 CST
Received: (from daemon@localhost) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) id RAA19220 for stst@idnsun.gpct.vanderbilt.edu; Sat, 25 Nov 1995 17:55:13 -0600 (CDT)
From: PK6811S@ACAD.DRAKE.EDU
Received: from ACAD.DRAKE.EDU (acad.drake.edu [204.42.32.1]) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) with ESMTP id RAA19216 for <Stefan.Strack@vanderbilt.edu>; Sat, 25 Nov 1995 17:55:09 -0600 (CDT)
Originally-From: PK6811S@ACAD.DRAKE.EDU
Received: from ACAD.DRAKE.EDU by ACAD.DRAKE.EDU (PMDF V5.0-4 #11108)
 id <01HY2HN2S5G0001HVA@ACAD.DRAKE.EDU> for Stefan.Strack@vanderbilt.edu; Sat,
 25 Nov 1995 17:55:14 -0500 (CDT)
Date: Sat, 25 Nov 1995 17:55:14 -0500 (CDT)
Subject: Round 7 Entry
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Message-Id: <01HY2HN2T80Y001HVA@ACAD.DRAKE.EDU>
X-Vms-To: IN%"Stefan.Strack@vanderbilt.edu"
Mime-Version: 1.0
Content-Transfer-Encoding: 7BIT
Status: R

Unfortunately I am away from home all next week, so here is my hurriedly
prepared entry for round 7.  Sounds like a good theory anyway, and 
under these rules beats standard non-paper programs about 98%.

;redcode-94
;name BlackMoor
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 6
;strategy round 7 entry
;
;Plan is to boot a bomber out there and adjust the boot distance
;until I start winning.  Eventually I should catch opponent early
;enough no matter what he is doing.

bootp    equ  (result+1425)
step     equ  239

         org  result
starter  dat    4000+10,4000+15
     for 200
         dat    4000+ender/2,4000
         dat    4000,4000+ender/2
     rof
result   ldp.ab #0  ,#0
adjust   ldp.ab #140,#0
         seq    #1,result
         add    #1,adjust
         mov    #5*63,bootp
         stp.ba adjust,adjust
         mul.b  adjust,bootp
         spl    1,4001
         mov    <bootf,<bootp
         mov    <bootf,<bootp
         mov    <bootf,<bootp
         mov    <bootf,<bootp
bootf    djn    @bootp,stone+8
         dat    4000,4005
stone    mov    bomb,@1
         mov    bomb,*3+step
         add    #2*step,-1
         djn    stone,#900
         spl    #4001,#4005
         mov    2,}stone
bomb     mov    step,1
     for 38
         dat    4000+ender/2,4000
         dat    4000,4000+ender/2
     rof
ender    dat    3998,4000-490

         end

Paul Kline
pk6811s@acad.drake.edu
