Return-Path: <graham@colossus.mathcs.rhodes.edu>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA12828; Fri, 15 Dec 95 17:34:52 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id QAA17145 for stst@idnsun.gpct.vanderbilt.edu; Fri, 15 Dec 1995 16:39:28 -0600 (CDT)
From: graham@colossus.mathcs.rhodes.edu
Received: from colossus.mathcs.rhodes.edu (colossus.mathcs.rhodes.edu [198.78.24.11]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id QAA17142 for <Stefan.Strack@vanderbilt.edu>; Fri, 15 Dec 1995 16:39:25 -0600 (CDT)
Received: from hal.mathcs.rhodes.edu (hal.mathcs.rhodes.edu [198.78.24.13]) by mathcs.rhodes.edu (8.6.9/8.6.9) with ESMTP id RAA20121 for <Stefan.Strack@vanderbilt.edu>; Fri, 15 Dec 1995 17:38:58 -0600
Received: by hal.mathcs.rhodes.edu (8.6.9) id RAA07738; Fri, 15 Dec 1995 17:39:15 -0600
Date: Fri, 15 Dec 1995 17:39:15 -0600
Originally-From: <graham@colossus.mathcs.rhodes.edu>
Message-Id: <199512152339.RAA07738@hal.mathcs.rhodes.edu>
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: Round 9
Status: R

;redcode-icws
;name Baby Swing
;kill Baby Swing
;author Randy Graham
;contact graham@mathcs.rhodes.edu
;NSFCWT round 9
;assert 1
;strategy Another in the Swing family - this time, minimalist coded
;strategy 75% bomb/scan once-thru with spl/spl/perpetual dat core-clear

STEP     equ  12

site1    dat  #0,        #sweep1
site2    dat  #0,        #-STEP

subber   sub  datadd,    cmper
bomber   mov  site2,     @cmper
cmper    cmp  subber-STEP*4-1, @subber-STEP*5-1
starter  jmp  setup,     0
looper   jmp  subber,    0

datadd   dat  #STEP*3,   #STEP*3
setup    add  cmper,     site2
seat     spl  0,         0
newsite  add  #1,        site2
clean    mov  @site1,    @site2
repeat   jmp  newsite,   0
sweep3   dat  #0,        #sweep3-site1
sweep2   spl  -1,        #sweep3-site1
sweep1   spl  -1,        #sweep2-site1

end bomber
