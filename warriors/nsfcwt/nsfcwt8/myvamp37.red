Return-Path: <mpn@ifm.liu.se>
Received: from strutter.cc.vanderbilt.edu ([129.59.1.18]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA09115; Sun, 3 Dec 95 09:22:55 CST
Received: (from daemon@localhost) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) id JAA22797 for stst@idnsun.gpct.vanderbilt.edu; Sun, 3 Dec 1995 09:30:53 -0600 (CDT)
Received: from ifm.liu.se (root@ifm.liu.se [130.236.160.6]) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) with SMTP id JAA22793 for <Stefan.Strack@vanderbilt.edu>; Sun, 3 Dec 1995 09:30:49 -0600 (CDT)
Received: from [130.236.16.3] (pool3.lidac.liu.se [130.236.16.3]) by ifm.liu.se (8.6.9/8.6.9) with SMTP id QAA01196 for <Stefan.Strack@vanderbilt.edu>; Sun, 3 Dec 1995 16:30:47 +0100
Date: Sun, 3 Dec 1995 16:30:47 +0100
Message-Id: <199512031530.QAA01196@ifm.liu.se>
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
From: mpn@ifm.liu.se (Magnus Paulsson)
X-Sender: mapau@ifm.liu.se (Unverified)
Subject: myvamp
Status: R

;At least I spent one hour on optimizing the new constants!
;redcode-94
;name myVamp v3.7
;author Paulsson
;strategy Throw jmp's around at 2/3c.
;strategy Then a spl/spl/dat and djn coreclear.
;strategy All in the tiny space of 14 bytes!
;strategy New constants   
;contact mpn@ifm.liu.se
;NSFCWT Round 8

step    equ 13808
boot    equ     13816
org     start

trap    jmp             11
i       for     10
                dat.f   0, 0
rof
                spl             #0,<trap
                spl             5,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                jmp             -4,0
                
i       for     39-16
                dat.i   #1, i
rof
start   mov.i   }ptr,>ptr
i for 13
                mov.i   }ptr,>ptr
rof
                jmp             st+boot+trap-c,1
ptr             dat.f   c2,trap+boot+c2-c

c2      spl.f   #b1, b2+2
st      add.f   s, c
                mov.i   c, @c
                jmz.a   st, *c
                mov.i   @0,*c
                mov.x   *c,*c
exit    jmz.b   st, c-boot
b1      spl     #b2-c2, b2-c2+2
                mov.i   *c2, >c2
                djn.f   -1, {c2-b2+c2-2
b3      dat.f   <55440/3, <55440/7
b2      spl     #b3-c2, b2-c2+2
c       jmp     *-boot, 0
s       dat.f   -step, step
i for 13
                dat.i   #1,1
                dat.f   1,#1
rof
