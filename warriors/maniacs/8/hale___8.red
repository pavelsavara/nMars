From robert.hale@lmco.com Wed Apr  8 18:03:51 1998
Return-Path: <robert.hale@lmco.com>
Received: from relay-14.mail.demon.net ([194.217.242.138])
 by kendalls.demon.co.uk with SMTP id <Nr3MwqA336K1Aw2o@kendalls.demon.co.uk>
 for <pak21@kendalls.demon.co.uk> ; Wed, 8 Apr 1998 18:03:51 +0100
Received: from punt-1.mail.demon.net by mailstore for pak21@kendalls.demon.co.uk
          id 892053190:09:26980:1; Wed, 08 Apr 98 16:33:10 GMT
Received: from violet.csi.cam.ac.uk ([131.111.8.58]) by punt-1.mail.demon.net
           id aa0926975; 8 Apr 98 16:33 GMT
Received: from mailgw1a.lmco.com [192.31.106.7] 
	by violet.csi.cam.ac.uk with esmtp (Exim 1.73 #1)
	id 0yMxlo-00041k-00; Wed, 8 Apr 1998 17:32:16 +0100
Received: from emss02g01.ems.lmco.com (emss02g01.ems.lmco.com [198.7.15.39])
	by mailgw1a.lmco.com (8.8.8/8.8.8) with ESMTP id KAA20639
	for <pak21@hermes.cam.ac.uk>; Wed, 8 Apr 1998 10:32:08 -0600 (MDT)
Return-receipt-to: "Hale, Robert" <robert.hale@lmco.com>
Received: from emss02m01.ems.lmco.com ([198.7.15.48])
 by lmco.com (PMDF V5.1-10 #20543) with ESMTP id <0ER300GYQSLGVG@lmco.com> for
 pak21@hermes.cam.ac.uk; Wed,  8 Apr 1998 10:32:07 -0600 (MDT)
Received: by emss02m01.ems.lmco.com with Internet Mail Service (5.0.1460.8)
 id <2QSN9Z5S>; Wed, 08 Apr 1998 10:32:03 -0600
Content-return: allowed
Date: Wed, 08 Apr 1998 10:29:48 -0600
From: "Hale, Robert" <robert.hale@lmco.com>
Subject: RCMT Round #8 entry
To: "'Kendall, Philip'" <pak21@hermes.cam.ac.uk>
Message-id: <5104C9F8B0B5D1118C250000F80625371332BA@emss02m13.ems.lmco.com>
MIME-version: 1.0
X-Mailer: Internet Mail Service (5.0.1460.8)
Content-type: text/plain; charset="iso-8859-1"

;redcode-94
;name The Paperboy and his silver bullet
;author Robert Hale
;assert CORESIZE == 8000
;Strategy  qscan, PSpaced -> Paper, scanner killer

QB EQU (start+1800)
QS EQU (QD*2)
QD EQU 100

GAP EQU 12
REP EQU 8

datz EQU (table-3)

for 0
head	spl 	1,0
        spl 	1,>-2000
        spl 	1,>-1000

    	spl     @0,     <pstep1
   	mov     }-1,    >-1
        spl     @0,     <pstep2
        mov     }-1,    >-1
        spl     @0,     <pstep3
        mov     }-1,    >-1
	mov     >1000,      <6335
	mov     >2000,      <4667
rof

	 dat    10*QS, 2*QS ; can get 21 values from this table
table:   dat     4*QS, 1*QS ; and can also use the initial value
	 dat    23*QS, 3*QS ; of fnd

qinc:    spl    #GAP,-GAP
tab:     add.a  table,table
slow:    add.a  @tab,fnd
fast:    add.ba *tab,@slow
which:   sne.i  datz,*fnd
	 add.a  #QD,fnd
	 mov.i  bombb,*fnd
	 add.ab fnd,fnd

fnd:    mov.i  QB,GAP/2
        add.f  qinc,fnd
	mov.i  bombb,*fnd
	djn.b  fnd,#REP
	jmp    brain,}QS*13

start:
	    ; WHICH
	seq.i  QB+QS*0,QB+QS*0+QD
	jmp    which,}QB+QS*0+QD/2
	    
	     ; FAST
	 seq.i  QB+QS*1,QB+QS*1+QD
	 jmp    fast,}QB+QS*1+QD/2
	    
	 seq.i  QB+QS*13,QB+QS*13+QD
	 jmp    fast,{fast
	 seq.i  QB+QS*2,QB+QS*2+QD
	 jmp    fast,{tab
	 seq.i  QB+QS*3,QB+QS*3+QD
	 jmp    fast,}tab
	    
	    ; SLOW
	 seq.i  QB+QS*4,QB+QS*4+QD
	 jmp    >fast,}QB+QS*4+QD/2
	 seq.i  QB+QS*5,QB+QS*5+QD
	 jmp    slow,}QB+QS*5+QD/2
	    
	 seq.i  QB+QS*6,QB+QS*6+QD
	 jmp    slow,{tab
	 seq.i  QB+QS*7,QB+QS*7+QD
	 jmp    slow,}tab
	 seq.i  QB+QS*10,QB+QS*10+QD
	 jmp    >fast,<tab
	 seq.i  QB+QS*11,QB+QS*11+QD
	 jmp    slow,<tab
	 seq.i  QB+QS*12,QB+QS*12+QD
	 djn.f  slow,tab
	 seq.i  QB+QS*23,QB+QS*23+QD
	 jmp    >fast,>tab
	 seq.i  QB+QS*24,QB+QS*24+QD
	 jmp    slow,>tab
	 seq.i  QB+QS*17,QB+QS*17+QD
	 jmp    slow,{fast
	    
	    ; TAB
	    
	 seq.i  QB+QS*8,QB+QS*8+QD
	 jmp    <fast,}QB+QS*8+QD/2
	 seq.i  QB+QS*9,QB+QS*9+QD
	 jmp    tab,}QB+QS*9+QD/2

         seq.i  QB+QS*15,QB+QS*15+QD
	 jmp    tab,<tab
	    
	 seq.i  QB+QS*16,QB+QS*16+QD
	 jmp    tab,{tab
	 seq.i  QB+QS*20,QB+QS*20+QD
	 djn.f  <fast,tab

;*************************************************
;********** The Brain ****************************
;*************************************************
;8 instructions

_RES    equ     0
_STR    equ     72

brain
res     ldp.ab  #_RES, #0
        ldp.a   #_STR, str1
        sne.ab  #0, res        ;switch on loss
;        seq.ab  #1, res        ;switch no win
lost    add.a   #1, str1
        mod.a   #3,     str1		;sol, 4 stts, 2908
        stp.ab  str1, #_STR		;sonw, 4 stts,2851
str1    jmp     @0, sboot		;sol, 3 stt, 3034
        dat     0, tboot		;sonw, 3 stt, 2965
        dat     0, tboot		;sol, 4 sttt, 2888

;*************************************************
;************* The Stone *************************
;*************************************************
;7instruction

saway		equ		3432

sboot		mov		Stone, saway
		mov		Stone+1, saway
		mov		Stone+2, saway
		jmp		saway+sboot

sStep	equ	3174
Stone     	mov    	{1545     ,1-sStep
          	sub.x  	#sStep   ,-1
          	jmp    	-2       ,}-2
;*************************************************
;************* The Paper *************************
;*************************************************
; instruction


A0      equ     3488
A1      equ     1860
A2      equ     3740
B0      equ     3620
B1      equ     1270
B2      equ     -350

tboot	  				
        spl     1,      <300    ;
        spl     1,      <400    ;
        mov     -1,     0       ;

silkb   spl     @0,     }B0     ;split 
        mov.i   }-1,    >-1     ;copy 
        mov.i   }-2,    >-2     ;copy 
        mov.i   bombb,  }113    ;bombing
silk2b  spl     @0,     }B1     ;split 
        mov.i   }-1,    >-1     ;copy 
        mov.i   bombb,  >1001   ;bombing
        mov.i   bombb,  }2042   ;A-indirect bombing
        mov.i   {silk2b,<silk3b ;copy 
silk3b  jmp     @silk3b,>B2     ;jmp new copy 
bombb   dat.f   >2667,  >5334   ;anti-imp bomb

	end start




