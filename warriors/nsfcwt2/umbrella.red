;redcode-94
;name Umbrella
;author Beppe Bezzi
;contact bezzi@iol.it
;NSFCWT round 2
;strategy core-sweep with umbrella
;assert 1

deathz  equ     60      
width   equ     deathz/stp2
stp2    equ     1
defrnd  equ     75
org prv

gate     dat    #4000   ,3000
wipe4    dat    #4000   ,clr-gate+7
wipe3    dat    #4000   ,clr-gate+7
wipe2    spl    #4000   ,clr-gate+7  ;W. T. wipers
wipe1    spl    #3050   ,clr-gate+7
split2  spl     #-1874-1800,#30

newpnt  dat     #deathz,#deathz
prv     spl     clr
predef  mov     bomb2, *danger
	mov     bomb2, @danger
danger  mov     {last+3-3740,@last+3-1800         
	sub     step2,  danger
loop1   djn     predef,#width
	add.f   newpnt, danger
	mov.ab  #width,loop1
dfcnt   djn     predef,#defrnd
bomb2   spl     #1,#+1874+1800+deathz+gate-40  ;-5
	mov     clear2,>-2
	jmp     -1
clear2  dat     #10,#4
step2   spl     #stp2,#stp2
clr     
	 mov    @2,>gate
	 mov    @1,>gate
	 djn.b  -2,{wipe1
last     jmp    -2

for 10
	dat     1000,1000
rof

for MAXLENGTH-CURLINE
	dat     #1000,}10
rof
end
