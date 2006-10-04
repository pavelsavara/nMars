;redcode-94m verbose
;name test jtm10a
;author Beppe Bezzi
;kill test
;strategy bug fix
;assert CORESIZE == 8000
org     think                   ;v 09 T v1.8

PIN     1956

_RES    equ     #0
_STR    equ     #314
_MULTI  equ     #169
impsize equ     2667
impdspl equ     300
impsiz7 equ     1143
impdsp7 equ     400
step    equ     85         
count   equ     533
away    equ     -3750

A0      equ     3488
A1      equ     1860
A2      equ     3740
att0a   equ     123   
att1a   equ     1001
att2a   equ     2042

b0      equ     2928
b1      equ     3312
b2      equ     944

marcia
	spl     spiral, <1000   ;activate imp spiral

	spl     1,      <300    ;\
	spl     1,      <600    ;-\ generate 16 
	spl     1,      <500    ;-/ parallel processes
	spl     1,      <400    ;/

silk    spl     @0,     }A0     ;split 
	mov.i   }-1,    >-1     ;copy 
att0    mov.i   bomb1,  >att0a  ;bombing
silk2   spl     @0,     }A1     ;split
	mov.i   }-1,    >-1     ;copy
att1    mov.i   bomb1,  >att1a  ;bombing
att2    mov.i   bomb ,  }att2a  ;A-indirect bombing
	mov.i   {silk2, <silk3  ;copy
silk3   jmp     @0,     >A2     ;jmp new copy 
bomb    dat.f   >2667,  >5334   ;anti-imp bomb
bomb1   dat     >1,     }1      ;anti clear bomb
for 5
	dat     0,0
rof


;warrior for use in multi 
multiw
	spl     spiral7
	spl     1
	mov     -1,     0       ;6 processes
	spl     1

mw1     spl     @0,     }b0     ;split 
	mov.i   }-1,    >-1     ;copy 
mw2     spl     @0,     }b1     ;split
	mov.i   }-1,    >-1     ;copy
	mov.i   {mw2,   <mw3    ;copy
mw3     jmp     @0,     >b2     ;jmp new copy 



think
res     ldp.ab  _RES,   #0
multi   ldp.ab  _MULTI, #0      ;check if multi player
	jmn.b   multiw, multi   ;if multi -> replicator
sne.b   res,    #-1             ;check if multiplay
	jmp     multiw          ;first round multiw
slt.b   res,    #3              ;check to set multiplay
stp.ab  res,    _MULTI
str     ldp.a   _STR,   str1    ;load strategy in use
duel    sne.ab  #0,     res     ;check result
lost    add.a   #1,     str1    ;lost change 
	mod.a   #2,     str1    ;secure result
win     stp.ab  str1,   _STR
str1    jmp     @0,     marcia
	dat     0,      tornado


for 0   ;6
	dat     0,0
rof

tornado         ;Firestorm
bootgt  mov     gate,   away
	mov     gate+1, away 
	mov     bombs,  away+23
	mov     bombm,  away+23

boot    mov     djmp,   away+8
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	jmp     @boot


gate    
	dat     #-10,   #30
	spl     #-10,   #30
;4 linee
start   
	mov     bombm+12,@stone
	mov     bombs+12,*stone
stone   mov     2*step+1,*(2*step)+2
	sub     incr    ,stone           
jump    djn.b   start,  #count 
incr    spl     #-2*step,<-2*step      
;-break
clr     mov     @1,     >gate-4
djmp    djn.b   clr,    {gate-2

;12 spaces
bombs   spl     #-step+1, #1
bombm   mov     step,   }step           


a for   MAXLENGTH-CURLINE-26
	dat     0,0
rof
spiral                  ;3 points * 8 processes spiral
	mov     imp,    imp+impdspl
	spl     1      ,#0
	spl     1      ,#0
	spl     <0     ,#vector+1
	djn.a   @vector,#0

imp     mov.i   #0,impsize
	jmp     imp+impsize*7+impdspl,  imp+impsize*6+impdspl 
	jmp     imp+impsize*5+impdspl,  imp+impsize*4 +impdspl
	jmp     imp+impsize*3+impdspl,  imp+impsize*2+impdspl 
vector  jmp     imp+impsize+impdspl  ,  imp+impdspl

spiral7                 ;7 points * 16 processes spiral
	spl     spiral
	mov     imp7,   imp+impdsp7
	spl     1,      #0
	spl     1      ,#0
	spl     1      ,#0
	spl     <0     ,#vect7+1
	djn.a   @vect7 ,#0

imp7    mov.i   #0,impsiz7
	jmp     imp+impsiz7*15+impdsp7, imp+impsiz7*14+impdsp7 
	jmp     imp+impsiz7*13+impdsp7, imp+impsiz7*12+impdsp7
	jmp     imp+impsiz7*11+impdsp7, imp+impsiz7*10+impdsp7 
	jmp     imp+impsiz7*9+impdsp7,  imp+impsiz7*8 +impdsp7
	jmp     imp+impsiz7*7+impdsp7,  imp+impsiz7*6+impdsp7
	jmp     imp+impsiz7*5+impdsp7,  imp+impsiz7*4 +impdsp7
	jmp     imp+impsiz7*3+impdsp7,  imp+impsiz7*2+impdsp7 
vect7   jmp     imp+impsiz7+impdsp7,    imp+impdsp7

end
