Return-Path: <PK6811S@ACAD.DRAKE.EDU>
Received: from ACAD.DRAKE.EDU ([204.42.32.1]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA10344; Fri, 8 Dec 95 12:01:21 CST
Received: from ACAD.DRAKE.EDU by ACAD.DRAKE.EDU (PMDF V5.0-4 #11108)
 id <01HYKBKB2A000086SX@ACAD.DRAKE.EDU> for stst@idnsun.gpct.Vanderbilt.Edu;
 Fri, 08 Dec 1995 12:09:01 -0500 (CDT)
Date: Fri, 08 Dec 1995 12:09:01 -0500 (CDT)
From: PK6811S@ACAD.DRAKE.EDU
Subject: round 8
To: stst@idnsun.gpct.Vanderbilt.Edu
Message-Id: <01HYKBKB45IQ0086SX@ACAD.DRAKE.EDU>
X-Vms-To: IN%"stst@idnsun.gpct.Vanderbilt.Edu"
Mime-Version: 1.0
Content-Transfer-Encoding: 7BIT
Status: R

;redcode-94x
;name MSweep
;kill MSweep
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 8
;assert CORESIZE == 55440
;strategy pair of core-sweeps

coresz   equ    55440
boot1    equ    clr-300
boot2    equ    clr-310+(coresz/2)
        
         dat    #gate-10     ,clr-gate+7
gate     dat    #coresz/3-10 ,300+(coresz/2)
wipe2    dat    #coresz/3-10 ,clr-gate+7
wipe1    spl    #coresz/3-400,clr-gate+7
clr      spl    #0,>-20
         mov    @2,>gate
         mov    @1,>gate
         djn.b  -2,{wipe1
copyf    dat    0,0
start    spl    1
         spl    1
         spl    1
         spl    3
         mov    <copyf,<jump1
jump1    jmp    boot1,copyf-300
         mov    @copyf,<jump2
jump2    jmp    boot2,copyf-310+(coresz/2)
         end    start

Paul Kline
pk6811s@acad.drake.edu
