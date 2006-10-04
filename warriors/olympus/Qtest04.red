;redcode-94 quiet
;name Qtest04
;author Beppe Bezzi
;strategy Qscan -> Tornado bomber
;strategy searching best qscan attack
;assert CORESIZE == 8000
;kill Qtest

org     start  
qstep    equ    6       ;5 - 8
qrounds equ     6       ;10
bigst   equ     99
qst     equ     qstart -(4*bigst)
qstart  equ     start+100


step    equ     95               
count   equ     530
away    equ     3456


start       ;'94 scan
s1 for 5
	sne.x   qst+4*bigst*s1, qst+4*bigst*s1+bigst*1  ;check two locations
	seq.x   qst+4*bigst*s1+bigst*2, qst+4*bigst*s1+bigst*3  
	mov.ab  #qst+4*bigst*s1-found, found  ;they differ so set pointer
     rof
;
	jmn  which,   found     ;if we have something, get it
s2 for 5
	sne.x   qst+4*bigst*(s2+5), qst+4*bigst*(s2+5)+bigst*1
	seq.x   qst+4*bigst*(s2+5)+bigst*2, qst+4*bigst*(s2+5)+bigst*3
	mov.ab  #qst+4*bigst*(s2+5)-found-bigst, found
     rof
;
	jmn  which,   found     ;if we have something, get it
s3 for 5
	sne.x   qst+4*bigst*(s3+10), qst+4*bigst*(s3+10)+bigst*1
	seq.x   qst+4*bigst*(s3+10)+bigst*2, qst+4*bigst*(s3+10)+bigst*3
	mov.ab  #qst+4*bigst*(s3+10)-found-bigst, found
     rof
;
	jmn  which,   found     ;if we have something, get it
s4 for 4
	sne.x   qst+4*bigst*(s4+15), qst+4*bigst*(s4+15)+bigst*1
	seq.x   qst+4*bigst*(s4+15)+bigst*2, qst+4*bigst*(s4+15)+bigst*3
	mov.ab  #qst+4*bigst*(s4+15)-found-bigst, found
     rof

found   jmz.b   warr    ,#0        ;skip attack if qscan found nothing
;        
	add     #bigst, -1        ;increment pointer till we get the
which   jmz.f   -1,     @found    ;right place
;break
qattack                           ;found.b punta il bersaglio       
;        mov     bombj,  @found
;        mov     bombs,  <found
	add.ba  found,  qstone
	add.b   found,  qstone

qst1    mov     qbomb,   *qstone
	mov     qbomb,   @qstone
qstone  mov     -79,     *-79+qstep
	add.f   qincr,   qstone           
	djn.b   qst1,   #qrounds      
;break        
warr



boot    mov     bombm,  away
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     gate,   away-23
	jmp     @boot,  <boot
gate    
	nop     bombs,  100 ;(clear start)
	nop     0,      0
start1   
	mov     bombm,   @stone
	mov     bombs,   *stone
stone   mov     step+2, *(2*step)+2
	add     incr    ,stone           
jump    djn.b   start1,  #count 
incr    spl     #3*step,#3*step      
clr     mov     *gate,  >gate
djmp    djn.f   clr,    {-step-bombm-1
wip     dat     <-2666,<2667
bombs   spl     #wip-gate,  #wip-gate+1
bombm   mov     step,   1

;bombj   jmp     -1,     0
;break
qbomb   dat     #qstep, #qstep
qincr   dat     #3*qstep,#3*qstep
end
	
	
	



