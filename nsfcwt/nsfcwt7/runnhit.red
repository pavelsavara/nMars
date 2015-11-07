Return-Path: <bezzi@iol.it>
Received: from iol-mail.iol.it ([194.20.24.2]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA08198; Fri, 1 Dec 95 17:37:03 CST
Received: from sw24-198.iol.it (sw24-198.iol.it [194.20.24.198]) by iol-mail.iol.it (8.6.11/8.6.11) with SMTP id AAA03565 for <stst@idnsun.gpct.Vanderbilt.Edu>; Sat, 2 Dec 1995 00:44:46 +0100
Date: Sat, 2 Dec 1995 00:44:46 +0100
Message-Id: <199512012344.AAA03565@iol-mail.iol.it>
X-Sender: bezzi@popmail
X-Mailer: Windows Eudora Light Version 1.5.2
Mime-Version: 1.0
Content-Type: text/plain; charset="us-ascii"
To: stst@idnsun.gpct.Vanderbilt.Edu (Stefan Strack)
From: Beppe Bezzi <bezzi@iol.it>
Subject: Round 7 entry
Status: R

I had very little time to finish it and no time to test.
All components work well alone, the cocktail should be deadly, just hope not
for me :-)

-Beppe
;--------------------

;redcode-94
;name run and hit
;author Beppe Bezzi
;contact bezzi@iol.it
;NSFCWT round 7 entry
;assert CORESIZE == 8000 && MINDIST == 4000
;strategy flee then shot (not always :-)

org     start
RES     equ     #0
STR     equ     #299

vstep   equ     8      
proc    equ     8
disp1   equ     0
disp2   equ     70
disp3   equ     140
disp4   equ     210
disp5   equ     280
disp6   equ     350
disp7   equ     420
disp8   equ     -100
spacer  equ     0
A0      equ     1800
A1      equ     3740
A2      equ     -2024

;Tornado equ
step    equ     95               
count   equ     530
away    equ     4456
djnoff  equ     -2000

;juliet equs
ptr     EQU     -1333

;Paper equ

dest0   equ     2200
dest1   equ     3740
dest2   equ     -1278   
range   equ     933

;vector bomber equ

target  equ     (zero+4000+20)

zero   
q for 20
	dat     q%7,    1
rof

point1  dat     vbomb,  vbomb+A0

vboot
	spl     1,      <pit    
	spl     1,      <-10
	spl     bclear  
	spl     1,      <-10   
	mov.i   {point1,<point1         ;copy
	jmp     @point1
;break
shot1   mov     >0,     @vector1-A0
	mov     >0,     @vector2-A0
	mov     >0,     @vector3-A0
	mov     >0,     @vector4-A0
	mov     >0,     @vector5-A0
	mov     >0,     @vector6-A0
	mov     >0,     @vector7-A0     ;vector bombing
;break
	jmp     clear1+A2-A0-5
vbomb   dat     10,     10

point2  dat     clear1+4,A2
bclear  mov     {point2,<point2

clear1  dat     #10,    #10
	spl     #0,     #100
	mov     -2,     >-5
	djn.f   -1,     <-100
	
vector1
s for proc
	jmp     pit-zero+4000-vstep-disp1,zero+4000+s*vstep+disp1
rof
vector2
s for proc
	jmp     pit-zero+4000-vstep-disp2,zero+4000+s*vstep+disp2
rof
vector3
s for proc
	jmp     pit-zero+4000-vstep-disp3,zero+4000+s*vstep+disp3
rof
vector4
s for proc
	jmp     pit-zero+4000-vstep-disp4,zero+4000+s*vstep+disp4
rof
vector5
s for proc
	jmp     pit-zero+4000-vstep-disp5,zero+4000+s*vstep+disp5
rof
vector6
s for proc
	jmp     pit-zero+4000-vstep-disp6,zero+4000+s*vstep+disp6
rof
vector7
s for proc
	jmp     pit-zero+4000-vstep-disp7,zero+4000+s*vstep+disp7
rof
vector8
s for proc
	jmp     pit-zero+4000-vstep-disp8,zero+4000+s*vstep+disp8
rof

pit     mov     -1000, <zero+3500
	stp     #0,     #0
for 30
	spl     pit,    <pit+1
	spl     pit,    {pit+1
	rof
for 50
	dat     zero,   zero+500
rof
;****** START *********

start
res     ldp.ab  RES,    #0      ;load result last match
str     ldp.a   STR,    str1    ;load strategy in use
	seq.ab  #1,     res     ;check result, win OK
lost    add.a   #1,     str1    ;lost change
	mod.a   #5,     str1    ;secure jump     
win     stp.ab  str1,   STR     ;save strategy
str1    jmp     @0,     vboot   ;booted vector bomber + clear
	dat     0,      vector  ;static vector bomber
	dat     0,      tornado ;
	dat     0,      juliet
	dat     0,      paper
for 20
	dat     1,1
rof
tornado
	mov     bombm,  away
for 12
	mov     {tornado,<tornado
rof        
	jmp     @tornado,<tornado

warr
gate    
	nop     split,  100 ;(clear start)
   
incr    spl     #3*step,#3*step      
start1  add     incr    ,stone           
stone   mov     step+jump, *(2*step)+jump
	mov     bombm,   @stone
	mov     bombs,   *stone
jump    djn.f   start1, <djnoff

clr     mov     *gate,  >gate
djmp    djn.f   clr,    {gate-20
wip     dat     <2667,  <20
split   spl     #wip-gate,  #wip-gate+5
bombs   spl     #step,   #1
;break
bombm   mov     step,   1
for 50
	dat     zero,   zero+500
rof

;juliet storm (sorry Myer I'm very short of time :-)

jgate   dat <-445, <-446
s       spl #445, <-445
	spl #0, <-446
	mov {445-1, -445+2
	add -3, -1
	djn.f -2, <-2667-500
	mov 32, <-20
go      dat     #0,     #ptr
juliet  mov     {-1,    <-1
	mov     {-2,    <-2
	mov     {-3,    <-3
	mov     {-4,    <-4
	mov     {-5,    <-5
	mov     {-6,    <-6
	mov     jgate,  ptr+24 
	mov     jgate,  ptr+24
	jmp     @go,    <4000
for 50
	dat     1,1
	rof
paper
	spl     1,      <300    ;\
	spl     1,      <400    ;-> generate 8 consecutive processes
	spl     1,      <500  

silk    spl     @0,     {dest0
	mov.i   }-1,    >-1 
silk1   spl     @0,     <dest1  ;split to new copy
	mov.i   }-1,    >-1     ;copy self to new location
	mov.i   bomba,  }range
	mov     {silk1, <silk2
silk2   jmp     @0,     >dest2
bomba   dat     <2667,  <1


;linear vector bomber

vector
	mov     <target+50, target+100
	mov     <target+450,target+300
	mov     <target+150,target+200
	mov     <target+250,target+400
	mov     <target+350,target

	mov     <target+130,target+330
	mov     <target+230,target+430
	mov     <target+30, target+370
	mov     <target+270,target+70
	mov     <target+170,target+220
;now it's sure escaped
step1   equ     85         
count1  equ     533
away1   equ     -3750

	mov     bm,     djmp1+away1+31
	mov     bd,     djmp1+away1+32
	mov     *tptr,  @tptr
	mov     {tptr,  <tptr
	mov     {tptr,  <tptr
	mov     {tptr,  <tptr
	mov     {tptr,  <tptr
	mov     {tptr,  <tptr
	mov     {tptr,  <tptr
	mov     {tptr,  <tptr
	jmp     @tptr,  <tptr

tptr    dat     djmp1,   away1+djmp1

bomber1 mov     bd+30,  *stone1
	mov     bm+30,  @stone1
stone1  mov     *step1+2,*(2*step1)+2         
	add     incr1,   stone1           
jump1   djn.b   bomber1, #count1
incr1   spl     #3*step1,#3*step1        
clr1    mov     -12,    }bomber1+1
djmp1   djn     clr1,   <bomber1-5
bm      mov.i   #step1, 1        
bd      dat     #step1, #1

a for (MAXLENGTH-CURLINE-1) /3
	dat     zero,   a
	dat     1,1
	dat     fine,   a
rof
fine    jmp     zero

end
