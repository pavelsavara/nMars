Return-Path: <morrell@math.utah.edu>
Received: from strutter.cc.vanderbilt.edu ([129.59.1.18]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA08325; Fri, 1 Dec 95 23:49:57 CST
Received: (from daemon@localhost) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) id XAA19341 for stst@idnsun.gpct.vanderbilt.edu; Fri, 1 Dec 1995 23:57:55 -0600 (CDT)
From: morrell@math.utah.edu
Received: from csc-sun.math.utah.edu (root@csc-sun.math.utah.edu [128.110.198.2]) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) with ESMTP id XAA19337 for <Stefan.Strack@vanderbilt.edu>; Fri, 1 Dec 1995 23:57:51 -0600 (CDT)
Received: from jeeves.math.utah.edu (morrell@jeeves.math.utah.edu [128.110.198.84]) by csc-sun.math.utah.edu (8.7.1/8.7.1) with ESMTP id WAA26411 for <Stefan.Strack@vanderbilt.edu>; Fri, 1 Dec 1995 22:57:55 -0700 (MST)
Originally-From: "Steven C. Morrell" <morrell@math.utah.edu>
Received: (from morrell@localhost) by jeeves.math.utah.edu (8.7.1/8.7.1) id WAA03588 for Stefan.Strack@vanderbilt.edu; Fri, 1 Dec 1995 22:57:53 -0700
Date: Fri, 1 Dec 1995 22:57:53 -0700
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: Round 7 Submission
Message-Id: <CMM.0.90.2.817883872.morrell@jeeves.math.utah.edu>
Status: R

;redcode-94
;name  Frontwards
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSCWT Round 7
;assert VERSION>=80

;strategy  Is it Friday already?!
;strategy  Well, at least entering and losing gives 1 point.

step equ 12
offset equ 608
stream equ cc-806
first equ (cc-offset+203)
gate equ -50

org boot

      stp #1,{1
for 17
      stp #1,}1
      stp.b #1,{1
      stp #1,{1
rof
      stp #1,}1

p     dat #first,{first+step
      dat #30,{-1
      stp.b #30,{-2
cc    spl #30,stream-660

      stp #1,{1
      stp #1,}1
      stp.b #1,{1

boot  mov top+5,top+offset+5
for 5
      mov {boot,<boot
rof
boot2 mov cc,cc+offset
for 3
      mov {boot2,<boot2
rof
      jmp x+offset

      stp.b #1,{1
      stp #1,{1
      stp #1,}1
      stp.b #1,{1
      stp #1,{1
      
top   sub x,@x
x     sne *p,@p
      djn.f -2,<stream
      spl #0,<p
      mov @1,}p
      djn -1,<cc

for 6
      stp #1,}1
      stp.b #1,{1
      stp #1,{1
rof
      
end
