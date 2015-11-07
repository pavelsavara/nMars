Return-Path: <bezzi@iol.it>
Received: from iol-mail.iol.it ([194.20.24.2]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA10032; Thu, 7 Dec 95 08:15:26 CST
Received: from sw24-130.iol.it (sw24-130.iol.it [194.20.24.130]) by iol-mail.iol.it (8.6.11/8.6.11) with SMTP id PAA13784 for <stst@idnsun.gpct.Vanderbilt.Edu>; Thu, 7 Dec 1995 15:22:50 +0100
Date: Thu, 7 Dec 1995 15:22:50 +0100
Message-Id: <199512071422.PAA13784@iol-mail.iol.it>
X-Sender: bezzi@popmail
X-Mailer: Windows Eudora Light Version 1.5.2
Mime-Version: 1.0
Content-Type: text/plain; charset="us-ascii"
To: stst@idnsun.gpct.Vanderbilt.Edu (Stefan Strack)
From: Beppe Bezzi <bezzi@iol.it>
Subject: Round 8 entry
Status: R

Good old Jack for the big core. The hill semms down so no chance to work at
something else.

-Beppe

;redcode-94x
;name Jack in the (big) box
;author Beppe Bezzi
;contact bezzi@iol.it
;NSFCW tournament round 8
;strategy Good old Jack adapted for big core
;strategy big core version 1.1
;assert CORESIZE == 55440
;kill Jack in the (big) box

org     think                   

PIN     1956

_RES    equ     #0
_STR    equ     #314

step    equ     185
away    equ     23750
djnoff  equ     -5000

A0      equ     16120
A1      equ     20060
A2      equ     9580
   
marcia
	spl     starta, <1000
	
	spl     1,      <300    ;\
	mov     -1,     0       ;-\ generate 10 
	mov     -1,     0       ;-/ consecutive processes
	spl     1,      <400    ;/

silk    spl     @0,     }A0     ;split 
	mov.i   }-1,    >-1     ;copy 
	mov.i   bomb,   {123    ;bombing
silk2   spl     @0,     }A1     ;split
	mov.i   }-1,    >-1     ;copy
	mov.i   bomb,   >1001   ;bombing
	mov.i   bomb,   }2042   ;A-indirect bombing
	mov.i   {silk2, <silk3  ;copy
silk3   jmp     @0,     >A2     ;jmp new copy 
bomb    dat.f   >34117,  >-34117   ;anti-imp bomb 13pt imp

for 30
	dat     0,0
rof

think
res     ldp.ab  _RES,   #0
str     ldp.a   _STR,   str1    ;load strategy in use
	sne.ab  #0,     res     ;check result
lost    add.a   #1,     str1    ;lost change 
	mod.a   #2,     str1    ;secure result
win     stp.ab  str1,   _STR
str1    jmp     @0,     tornado
	dat     0,      marcia


for 50
	dat     0,0
rof


tornado
	mov     last,  away
for 12
	mov     {tornado, <tornado
rof        
	jmp     @tornado, <tornado

warr
gate    
	nop     split,  100 ;(clear start)
   
incr    spl     #3*step,#3*step      
start1  add     incr    ,stone           
stone   mov     *step+jump-5, *(2*step)+jump-5
	mov     bombm,   @stone
	mov     bombs,   *stone
jump    djn.f   start1, <djnoff
clr     mov     *gate,  >gate
djmp    djn.f   clr,    {gate-20
wip     dat     #wip-gate,  <20
split   spl     #wip-gate,  #wip-gate+5
bombm   mov     step,   1
last
bombs   spl     #step,   #1

for 50
	dat     0,0
rof

starta        
	spl     1,      <300    ;\
	mov     -1,     0       ;-\ generate 10 
	mov     -1,     0       ;-/ consecutive processes
	spl     1,      <400    ;/

silka   spl     @0,     }3620   ;split 
	mov.i   }-1,    >-1     ;copy 
	mov.i   bomba,  }113    ;bombing
silk2a  spl     @0,     }1270   ;split 
	mov.i   }-1,    >-1     ;copy 
	mov.i   bomba,  >1001   ;bombing
	mov.i   bomba,  }2042   ;A-indirect bombing
	mov.i   {silk2a,<silk3a ;copy 
silk3a  jmp     @silk3a,>-350   ;jmp new copy 
bomba   dat.f   >34117, >-34117 ;anti-imp bomb 13pt imp

end

