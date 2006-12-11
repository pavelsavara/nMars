Return-Path: <mpn@ifm.liu.se>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA12668; Fri, 15 Dec 95 11:10:09 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id KAA15873 for stst@idnsun.gpct.vanderbilt.edu; Fri, 15 Dec 1995 10:14:44 -0600 (CDT)
Received: from ifm.liu.se (ifm.liu.se [130.236.160.6]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id KAA15870 for <Stefan.Strack@vanderbilt.edu>; Fri, 15 Dec 1995 10:14:41 -0600 (CDT)
Received: from [130.236.16.4] (pool4.lidac.liu.se [130.236.16.4]) by ifm.liu.se (8.6.9/8.6.9) with SMTP id SAA26117 for <Stefan.Strack@vanderbilt.edu>; Fri, 15 Dec 1995 18:18:04 +0100
Date: Fri, 15 Dec 1995 18:18:04 +0100
Message-Id: <199512151718.SAA26117@ifm.liu.se>
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
From: mpn@ifm.liu.se (Magnus Paulsson)
X-Sender: mapau@ifm.liu.se (Unverified)
Subject: myVamp3.7 :-)
Status: R

;redcode
;name myVamp3.7 :-)
;author Paulsson
;strategy Nahe, more like stone imp.
;contact mpn@ifm.liu.se
;NSFCWT Round LAST

;Almost forget to send it in, 4 3 line stones and
;a 4 process imp.
;Merry X-mass

start   spl             imp
                spl             ett
                spl             tre
fyra    
                mov             bomer,start+2000*1              
                mov             bomer+1,start+2000*1+1          
                mov             bomer+2,start+2000*1+2          
                spl             0
                jmp             start+2000*1
tre     
                mov             bomer,start+2000*2              
                mov             bomer+1,start+2000*2+1          
                mov             bomer+2,start+2000*2+2          
                spl             0
                jmp             start+2000*2

bomer   mov             -1,-4*13-1
                add             #27*4,-1
                jmp             -2
                
; Some one knows what the hell the 8 generators
;for SU(3) does? I mean like the 3 generators in
;SU(2) that generate rotations in spinspace!

tva
                mov             bomer,start+2000*3              
                mov             bomer+1,start+2000*3+1          
                mov             bomer+2,start+2000*3+2          
                spl             0
                jmp             start+2000*3
ett             spl             tva     
                mov             bomer,start+2000*4              
                mov             bomer+1,start+2000*4+1          
                mov             bomer+2,start+2000*4+2          
                spl             0
                jmp             start+2000*4

imp             spl             i1
                spl             i2
                jmp             impy
i1              spl             impy
                jmp             impy+8193/3*2
i2              jmp             impy+8193/3*1
impy    mov             0,8193/3

end start
