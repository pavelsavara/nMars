Return-Path: <morrell@math.utah.edu>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA12625; Fri, 15 Dec 95 09:25:25 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id IAA15594 for stst@idnsun.gpct.vanderbilt.edu; Fri, 15 Dec 1995 08:30:01 -0600 (CDT)
From: morrell@math.utah.edu
Received: from csc-sun.math.utah.edu (root@csc-sun.math.utah.edu [128.110.198.2]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with ESMTP id IAA15591 for <Stefan.Strack@vanderbilt.edu>; Fri, 15 Dec 1995 08:29:57 -0600 (CDT)
Received: from jeeves.math.utah.edu (morrell@jeeves.math.utah.edu [128.110.198.84]) by csc-sun.math.utah.edu (8.7.1/8.7.1) with ESMTP id IAA01865 for <Stefan.Strack@vanderbilt.edu>; Fri, 15 Dec 1995 08:33:27 -0700 (MST)
Originally-From: "Steven C. Morrell" <morrell@math.utah.edu>
Received: (from morrell@localhost) by jeeves.math.utah.edu (8.7.1/8.7.1) id IAA23520 for Stefan.Strack@vanderbilt.edu; Fri, 15 Dec 1995 08:33:26 -0700
Date: Fri, 15 Dec 1995 08:33:26 -0700
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: Round 9 Entry
Message-Id: <CMM.0.90.2.819041605.morrell@jeeves.math.utah.edu>
Status: R


;redcode-icws verbose
;name  Chris
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSCWT Round 9
;strategy  Minimalist Code Vampire
;assert CORESIZE == 8192
;macro

step equ 3006
clstep equ 3823

boot mov x+7,boot+6512
     mov x+6,boot+6511
     mov x+5,boot+6510
     mov x+4,boot+6509
     mov x+3,boot+499
     mov x+2,boot+498
     mov x+1,boot+497
     mov x  ,boot+496
     mov fang,boot+4327
     mov d  ,boot+2689
     mov h1 ,boot+7331
     mov h2 ,boot+3235
     mov safe,boot+3781
     spl boot+496
     jmp boot+3781

x  spl 0,2731
   mov 4327-497,@4327-497
   add 2689-498,4327-498
   jmp -2,2731

   spl 0,6512-6509+clstep
   mov 2689-6510,@-1
   add #clstep,-2
   jmp -3,2731

fang jmp @7331-6510-step,6510-4327+step
d  dat #-step+4096,#step
h1 dat #2731,#6509-7331
h2 dat #2731,#6509-3235

safe jmp 0,0

for 70
    dat #h2,#2731
rof
