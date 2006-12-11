Return-Path: <PK6811S@ACAD.DRAKE.EDU>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA12774; Fri, 15 Dec 95 14:17:09 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id NAA16459 for stst@idnsun.gpct.vanderbilt.edu; Fri, 15 Dec 1995 13:21:46 -0600 (CDT)
From: PK6811S@ACAD.DRAKE.EDU
Received: from ACAD.DRAKE.EDU (acad.drake.edu [204.42.32.1]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with ESMTP id NAA16455 for <Stefan.Strack@Vanderbilt.edu>; Fri, 15 Dec 1995 13:21:43 -0600 (CDT)
Originally-From: PK6811S@ACAD.DRAKE.EDU
Received: from ACAD.DRAKE.EDU by ACAD.DRAKE.EDU (PMDF V5.0-4 #11108)
 id <01HYU8CSQJY800CGGF@ACAD.DRAKE.EDU> for Stefan.Strack@Vanderbilt.edu; Fri,
 15 Dec 1995 14:25:07 -0500 (CDT)
Date: Fri, 15 Dec 1995 14:25:07 -0500 (CDT)
Subject: round 9 entry
Originally-To: Stefan.Strack@Vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Message-Id: <01HYU8CSR38I00CGGF@ACAD.DRAKE.EDU>
X-Vms-To: IN%"Stefan.Strack@Vanderbilt.edu"
Mime-Version: 1.0
Content-Transfer-Encoding: 7BIT
Status: R

;redcode-icws
;name Nine
;kill Nine
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 9
;assert CORESIZE == 8192
;strategy boot 50% bomber and repeating forward coreclear
;strategy hopefully everyone else will have imps and tie
;strategy one another, lowering their scores :-)
boot     equ     (-3300)
step     equ     19
count    equ     1280
imp3     equ     2731
imp7     equ     3511
imp21    equ     3901

start    mov     bomb1+0,bomb1+0+boot  ; boot bombers
         mov     bomb1+1,bomb1+1+boot
         mov     bomb1+2,bomb1+2+boot
         mov     bomb1+3,bomb1+3+boot
         mov     bomb1+4,bomb1+4+boot
         mov     bomb1+5,bomb1+5+boot
         mov     bomb1+6,bomb1+6+boot
         mov     b1+0,b1+0+32+boot
         mov     b1+1,b1+1+32+boot
         mov     b1+2,b1+2+32+boot
         mov     b1+3,b1+3+32+boot
         mov     b1+4,b1+4+32+boot
         mov     b1+5,b1+5+32+boot
         jmp     stone-1+boot
         
bomb1    jmp     35,step               ; bomber
bomb2    jmp     1*step,1;mov     step*2,1
inc      add     #2*step,stone
         mov     bomb1,@stone
stone    mov     bomb2,@-(2*step)*count
         jmp     inc
         jmp     33
                  
b1       spl     0,0                   ; core-clear
b2       mov     bdat,@b1-15
         mov     bdat,@b1-14
         add     #1,@b2
         jmp     b2,0
bdat     dat     #0,#21

         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat,#0
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         dat     #bdat
         
         end     start
         

Paul Kline
pk6811s@acad.drake.edu
