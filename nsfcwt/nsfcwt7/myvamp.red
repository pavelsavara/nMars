Return-Path: <mpn@ifm.liu.se>
Received: from strutter.cc.vanderbilt.edu ([129.59.1.18]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA07602; Wed, 29 Nov 95 07:33:20 CST
Received: (from daemon@localhost) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) id HAA04446 for stst@idnsun.gpct.vanderbilt.edu; Wed, 29 Nov 1995 07:41:19 -0600 (CDT)
Received: from ifm.liu.se (root@ifm.liu.se [130.236.160.6]) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) with SMTP id HAA04442 for <Stefan.Strack@vanderbilt.edu>; Wed, 29 Nov 1995 07:41:15 -0600 (CDT)
Received: from [130.236.16.5] (pool5.lidac.liu.se [130.236.16.5]) by ifm.liu.se (8.6.9/8.6.9) with SMTP id OAA12515; Wed, 29 Nov 1995 14:41:11 +0100
Date: Wed, 29 Nov 1995 14:41:11 +0100
Message-Id: <199511291341.OAA12515@ifm.liu.se>
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
From: mpn@ifm.liu.se (Magnus Paulsson)
X-Sender: mapau@ifm.liu.se (Unverified)
Subject: myVamp3.7
Cc: sieben@imap1.asu.edu
Status: R

;Since I don't have time for any new programming myVamp has
;to be enough.
;Note that I have sent the warrior to both Stefan and Nador.
;(Can't find your the rules anywhere :-)
;You can publish it if you want to, thought I'd publish it when it's
;survived 500 rounds but ... I'll publish it anyway with some more 
;comments later. So Ivner can't complain!
;BTW Have as many rounds as you wish in the tournament, I'll fight to the
;bitter end :-) (loosing)

;redcode-94
;name myVamp v3.7
;author Paulsson
;strategy Throw jmp's around at 2/3c.
;strategy Then a spl/spl/dat and djn coreclear.
;strategy All in the tiny space of 14 bytes!
;strategy Submitted: 30 september 95     
;assert CORESIZE > 1
;contact mpn@ifm.liu.se
;NSFCWT Round 7? or something :-)

step    equ 3024
boot    equ     8*200
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
                jmp             st+boot,1
ptr             dat.f   c2,boot+c2

c2      spl.f   #b1, b2+2
st      add.f   s, c
                mov.i   c, @c
                jmz.a   st, *c
                mov.i   @0,*c
                mov.x   *c,*c
exit    jmz.b   st, trap-boot
b1      spl     #b2-c2, b2-c2+2
                mov.i   *c2, >c2
                djn.f   -1, {c2-b2+c2-2
b3      dat.f   <-2666, <2667
b2      spl     #b3-c2, b2-c2+2
c       jmp     *trap-boot, 0
s       dat.f   -step, step
i for 13
                dat.i   #1,1
                dat.f   1,#1
rof
