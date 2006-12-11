Return-Path: <morrell@math.utah.edu>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA10539; Fri, 8 Dec 95 21:24:29 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id UAA20825 for stst@idnsun.gpct.vanderbilt.edu; Fri, 8 Dec 1995 20:29:03 -0600 (CDT)
From: morrell@math.utah.edu
Received: from csc-sun.math.utah.edu (root@csc-sun.math.utah.edu [128.110.198.2]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with ESMTP id UAA20821 for <Stefan.Strack@vanderbilt.edu>; Fri, 8 Dec 1995 20:28:59 -0600 (CDT)
Received: from jeeves.math.utah.edu (morrell@jeeves.math.utah.edu [128.110.198.84]) by csc-sun.math.utah.edu (8.7.1/8.7.1) with ESMTP id UAA03100 for <Stefan.Strack@vanderbilt.edu>; Fri, 8 Dec 1995 20:32:30 -0700 (MST)
Originally-From: "Steven C. Morrell" <morrell@math.utah.edu>
Received: (from morrell@localhost) by jeeves.math.utah.edu (8.7.1/8.7.1) id UAA07895 for Stefan.Strack@vanderbilt.edu; Fri, 8 Dec 1995 20:32:27 -0700
Date: Fri, 8 Dec 1995 20:32:27 -0700
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: Round 8 Entry
Message-Id: <CMM.0.90.2.818479946.morrell@jeeves.math.utah.edu>
Status: R

;redcode-94
;name  Frontwards v2
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSCWT Round 8
;strategy  One-shot/two-pass
;assert CORESIZE == 55440
;assert VERSION >= 80

;; (55440-offset) mod 13 = 0
;; (55440-(first-stream)) mod 26 is in [14,25]
;; (55440-(first-stream)) mod 27 is in [13,0]
;; first mod 13 = 1
;  (55440-(first-lead instruction)) mod 26 is in [0,12]
;  (55440-(first-lead instruction)+200) mod 26 is in [1,13]

; 55440+909-2224 = 54125 mod 26 = 19
;                        mod 27 = 21
; lead instruction = -159 from cc
; 55440+909+159 = 56508 mod 26 = 10
; 200 mod 26 = 18
step equ 13
offset equ 1009
stream equ (cc-1925)
first equ (cc-offset+100) ;=-909

; stp equ nop

org boot

      stp.b @1,{1
      stp.b @1,}1
      stp.ab *1,{1
for 12
      stp.ab #1,{1
      stp.ab #1,}1
      stp.b #1,{1
      stp.b #1,}1
      stp.ab 1,{1
      stp.ab 1,}1
      stp.b 1,{1
      stp.b 1,}1
      stp.ab @1,{1
      stp.ab @1,}1
      stp.b @1,{1
      stp.b @1,}1
      stp.ab *1,{1
rof

p     dat #first,{first+step
      dat #31,{-1
      dat #31,{-2
      stp.b #31,{-3
cc    spl 31,stream-4264

      stp.ab 1,}1

boot  mov top+5,top+offset+5

for 5
      mov {boot,<boot
rof
boot2 mov cc,cc+offset
for 4
      mov {boot2,<boot2
rof
      jmp x+offset
      
      stp.ab 1,}1
      stp.b 1,{1
      stp.b 1,}1
      stp.ab @1,{1
      stp.ab @1,}1
      stp.b @1,{1
      stp.b @1,}1
      
top   sub x,@x
x     sne *p,@p
      djn.f top,<stream
      spl #0,<p
      mov @1,}p
      djn -1,<cc

      stp.ab 1,}1
      stp.b 1,{1
      stp.b 1,}1
      stp.ab @1,{1
      stp.ab @1,}1
      stp.b @1,{1
      stp.b @1,}1
      stp.ab *1,{1
      stp.ab #1,{1
      stp.ab #1,}1
;      stp.b #1,{1
     
end
