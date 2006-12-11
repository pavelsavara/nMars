Return-Path: <bremermr@ecn.purdue.edu>
Received: from strutter.cc.vanderbilt.edu ([129.59.1.18]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA08204; Fri, 1 Dec 95 18:01:16 CST
Received: (from daemon@localhost) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) id SAA18502 for stst@idnsun.gpct.vanderbilt.edu; Fri, 1 Dec 1995 18:09:14 -0600 (CDT)
From: bremermr@ecn.purdue.edu
Received: from cartoon.ecn.purdue.edu (bremermr@cartoon.ecn.purdue.edu [128.46.147.13]) by strutter.cc.vanderbilt.edu (8.7.1/8.7.1) with SMTP id SAA18498 for <stefan.strack@vanderbilt.edu>; Fri, 1 Dec 1995 18:09:10 -0600 (CDT)
Received: from cartoon.ecn.purdue.edu (bremermr@localhost)
	by cartoon.ecn.purdue.edu (8.6.12/3.8davy)
	for delivery to "stefan.strack@vanderbilt.edu"
	id TAA23039; Fri, 1 Dec 1995 19:09:11 -0500
Message-Id: <199512020009.TAA23039@cartoon.ecn.purdue.edu>
Date: Fri, 1 Dec 1995 19:09:11 -0500
Originally-From: "Myer R. Bremer" <bremermr@ecn.purdue.edu>
Originally-To: stefan.strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Subject: Back Propagation
Status: R

;redcode-94
;name Back Propagation
;author M R Bremer
;nsfcwt round 7
;contact <bremermr@ecn.purdue.edu>
;strategy       create 10 independent vector fang bombing modules targeting
;strategy       different parts of enemy code.
;strategy       use that module from now until start to lose
;strategy       launch Phoenix (from Jippo) as backup to all
;strategy       i take _way_ too much time.  i expect to get creamed
org start

STEP EQU 50

PSTEP   equ     3520
NSTEP   equ     1520
ESTEP   equ      830

_STR    EQU #336
_RES    EQU #0

         spl mimp+5334 
launch2  spl -1                     ; continuous imp-ring launcher
         spl mimp+2667              ; activated by stone if needed
mimp     mov.i #0,2667              ;
for 23
        jmp 4000, start-5
rof
start
res     ldp.ab _RES, #0
str     ldp.a _STR, str1        ;load strategy in use
        seq.ab #1, res          ;check result
lost    add.a #1, str1          ;lost or tie --> change 
        mod.a #5, str1         ;secure result
win     stp.ab  str1, _STR
str1    jmp @0, mod1
        dat 0, mod2
        dat 0, mod3
        dat 0, mod4
        dat 0, mod5
for 17
        jmp 4075, start
rof
        spl p1, 0
pit     spl -1, 0
        jmp p2, 0
for 11
        jmp 4050, start
rof
p2      spl #0
        spl -1
        spl -2, 0
        stp.b >-1, -1
        jmp pit

for 19
        jmp 4400, start
rof

mod1    spl mod6
        mov.i m1fang, start+4000+9*STEP
        mov.i fang1, start+4000+8*STEP
        mov.i fang1, start+4000+7*STEP
        mov.i fang1, start+4000+6*STEP
        mov.i fang1, start+4000+5*STEP
        mov.i fang1, start+4000+4*STEP
        mov.i fang1, start+4000+3*STEP
        mov.i fang1, start+4000+2*STEP
        mov.i fang1, start+4000+STEP
        mov.i fang1, start+4000
        mov.i av1, *mod6         
        mov.i dat1, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang1   jmp STEP
m1fang  jmp -1*(start+4000+9*STEP)+pit
av1     mov.i #1, }1
dat1    dat 1, 1

for     12
        jmp 4250, 4350
rof

mod2    spl mod7
        mov.i m2fang, start+4005+9*STEP
        mov.i fang2, start+4005+8*STEP
        mov.i fang2, start+4005+7*STEP
        mov.i fang2, start+4005+6*STEP
        mov.i fang2, start+4005+5*STEP
        mov.i fang2, start+4005+4*STEP
        mov.i fang2, start+4005+3*STEP
        mov.i fang2, start+4005+2*STEP
        mov.i fang2, start+4005+STEP
        mov.i fang2, start+4005
        mov.i av2, *mod7         
        mov.i dat2, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang2   jmp STEP
m2fang  jmp -1*(start+4005+9*STEP)+pit
av2     mov.i #1, }1
dat2    dat 1, 1

for 19
        jmp 4400, 4090
rof

mod3    spl mod8
        mov.i m3fang, start+4010+9*STEP
        mov.i fang3, start+4010+8*STEP
        mov.i fang3, start+4010+7*STEP
        mov.i fang3, start+4010+6*STEP
        mov.i fang3, start+4010+5*STEP
        mov.i fang3, start+4010+4*STEP
        mov.i fang3, start+4010+3*STEP
        mov.i fang3, start+4010+2*STEP
        mov.i fang3, start+4010+STEP
        mov.i fang3, start+4010
        mov.i av3, *mod8         
        mov.i dat3, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang3   jmp STEP
m3fang  jmp -1*(start+4010+9*STEP)+pit 
av3     mov.i #1, }1
dat3    dat 1, 1
for 19
        jmp 4400, 4090
rof

mod4    spl mod9
        mov.i m4fang, start+4015+9*STEP
        mov.i fang4, start+4015+8*STEP
        mov.i fang4, start+4015+7*STEP
        mov.i fang4, start+4015+6*STEP
        mov.i fang4, start+4015+5*STEP
        mov.i fang4, start+4015+4*STEP
        mov.i fang4, start+4015+3*STEP
        mov.i fang4, start+4015+2*STEP
        mov.i fang4, start+4015+STEP
        mov.i fang4, start+4015
        mov.i av4, *mod9         
        mov.i dat4, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang4   jmp STEP
m4fang  jmp -1*(start+4015+9*STEP)+pit 
av4     mov.i #1, }1
dat4    dat 1, 1
for 19
        jmp 4400, 4090
rof


mod5    spl mod10
        mov.i m5fang, start+4020+9*STEP
        mov.i fang5, start+4020+8*STEP
        mov.i fang5, start+4020+7*STEP
        mov.i fang5, start+4020+6*STEP
        mov.i fang5, start+4020+5*STEP
        mov.i fang5, start+4020+4*STEP
        mov.i fang5, start+4020+3*STEP
        mov.i fang5, start+4020+2*STEP
        mov.i fang5, start+4020+STEP
        mov.i fang5, start+4020
        mov.i av5, *mod10         
        mov.i dat5, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang5   jmp STEP
m5fang  jmp -1*(start+4020+9*STEP)+pit 
av5     mov.i #1, }1
dat5    dat 1, 1
for 19
        jmp 4400, 4090
rof

mod6    mov.i m6fang, start+4025+9*STEP
        mov.i fang6, start+4025+8*STEP
        mov.i fang6, start+4025+7*STEP
        mov.i fang6, start+4025+6*STEP
        mov.i fang6, start+4025+5*STEP
        mov.i fang6, start+4025+4*STEP
        mov.i fang6, start+4025+3*STEP
        mov.i fang6, start+4025+2*STEP
        mov.i fang6, start+4025+STEP
        mov.i fang6, start+4025
        mov.i av6, *mod1+1         
        mov.i dat6, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang6   jmp STEP
m6fang  jmp -1*(start+4025+9*STEP)+pit 
av6     mov.i #1, }1
dat6    dat 1, 1
for 12
        jmp 4400, 4090
rof
        
c2      spl     1,          <start+4000+123
        mov.i   -1,         0
        mov.i   -1,         0
        mov.i   -1,         0
 
phoenix spl     @phoenix,   PSTEP
        mov.i   }phoenix,   >phoenix
nest    spl     @nest,      NSTEP
        mov.i   }nest,      >nest
egg     spl     @egg,       ESTEP
        mov.i   }egg,       >egg
        mov.i   ash,        {3999
        mov.i   ash,        }4001
ash     dat.f   <2667,      <2*2667
        dat.f   <2667,      <2*2667
        dat.f   <2667,      <2*2667
        dat.f   <2667,      <2*2667
        dat.f   <2667,      <2*2667
for 12
        jmp 4400, 4090
rof

mod7    mov.i m7fang, start+4030+9*STEP
        mov.i fang7, start+4030+8*STEP
        mov.i fang7, start+4030+7*STEP
        mov.i fang7, start+4030+6*STEP
        mov.i fang7, start+4030+5*STEP
        mov.i fang7, start+4030+4*STEP
        mov.i fang7, start+4030+3*STEP
        mov.i fang7, start+4030+2*STEP
        mov.i fang7, start+4030+STEP
        mov.i fang7, start+4030
        mov.i av7, *mod2+1
        mov.i dat7, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang7   jmp STEP
m7fang  jmp -1*(start+4030+9*STEP)+pit 
av7     mov.i #1, }1
dat7    dat 1, 1
for 12
        jmp 4400, 4090
rof

mod8    mov.i m8fang, start+4035+9*STEP
        mov.i fang8, start+4035+8*STEP
        mov.i fang8, start+4035+7*STEP
        mov.i fang8, start+4035+6*STEP
        mov.i fang8, start+4035+5*STEP
        mov.i fang8, start+4035+4*STEP
        mov.i fang8, start+4035+3*STEP
        mov.i fang8, start+4035+2*STEP
        mov.i fang8, start+4035+STEP
        mov.i fang8, start+4035
        mov.i av8, *mod3+1         
        mov.i dat8, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang8   jmp STEP
m8fang  jmp -1*(start+4035+9*STEP)+pit 
av8     mov.i #1, }1
dat8    dat 1, 1
for 12
        jmp 4400, 4090
rof

mod9    mov.i m9fang, start+4040+9*STEP
        mov.i fang9, start+4040+8*STEP
        mov.i fang9, start+4040+7*STEP
        mov.i fang9, start+4040+6*STEP
        mov.i fang9, start+4040+5*STEP
        mov.i fang9, start+4040+4*STEP
        mov.i fang9, start+4040+3*STEP
        mov.i fang9, start+4040+2*STEP
        mov.i fang9, start+4040+STEP
        mov.i fang9, start+4040
        mov.i av9, *mod4+1         
        mov.i dat9, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang9   jmp STEP
m9fang  jmp -1*(start+4040+9*STEP)+pit 
av9     mov.i #1, }1
dat9    dat 1, 1

for 12
        jmp 4400, 4090
rof

mod10   mov.i m10fang, start+4045+9*STEP
        mov.i fang10, start+4045+8*STEP
        mov.i fang10, start+4045+7*STEP
        mov.i fang10, start+4045+6*STEP
        mov.i fang10, start+4045+5*STEP
        mov.i fang10, start+4045+4*STEP
        mov.i fang10, start+4045+3*STEP
        mov.i fang10, start+4045+2*STEP
        mov.i fang10, start+4045+STEP
        mov.i fang10, start+4045
        mov.i av10, *mod5+1
        mov.i dat10, >-1
        djn.b -1, #10
        spl launch1
        jmp launch2
fang10  jmp STEP
m10fang jmp -1*(start+4045+9*STEP)+pit 
av10     mov.i #1, }1
dat10    dat 1, 1

for 12
        jmp 4400, 4090
rof


launch1 
        spl     c2
        spl     1,          <start+4000+123
        mov.i   -1,         0
        mov.i   -1,         0
        mov.i   -1,         0
 
phoenix2 spl     @phoenix2,   PSTEP
        mov.i   }phoenix2,   >phoenix2
nest2   spl     @nest2,      NSTEP
        mov.i   }nest2,      >nest2
egg2    spl     @egg2,       ESTEP
        mov.i   }egg2,       >egg2
        mov.i   ash2,        {3999
        mov.i   ash2,        }4001
ash2    dat.f   <2667,      <2*2667
        dat.f   <2667,      <2*2667
        dat.f   <2667,      <2*2667
        dat.f   <2667,      <2*2667
        dat.f   <2667,      <2*2667
        
for 12
        jmp 4400, 4090
rof
        
        spl #0, 0
p1      spl -1, 2
        mov -1, >-1
