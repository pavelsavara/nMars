;redcode-94
;name Rubber wall
;author Beppe Bezzi
;NSFCW tournament round 5
;contact bezzi@iol.it
;strategy p-warrior switching: fast scan / paper
;assert 1

org think
RES     equ     #0
STR     equ     #119
st      equ     13

dest0   equ     2200
dest1   equ     3740
dest2   equ     -1278
range   equ     933  

begin
;Yes it looks very like Morrell's PGP, but a different clear

gate
comp    dat     bsweep+2*st,bsweep+st
kdh     dat     #-1000, djmp-gate+5
	dat     #-200,  djmp-gate+5
	spl     #-1000,  djmp-gate+5
wipe    spl     #-2000,  djmp-gate+5     
sweep1  sub     swstep, comp    
sweep   sne     *comp,  @comp
	sub     swstep, comp
	sne     *comp,  @comp
	sub     swstep, comp
	sne     *comp,  @comp
loop    djn.f   sweep1, <-2000

swstep  spl     #-2*st,  #-2*st
clr     mov     @djmp,  >gate
djmp    djn.b   clr,    {wipe
	jmp     -1		;to work with very few processes
	dat     0,0
	dat     0,0
;This one is Jack in box's switcher

think
res     ldp.ab  RES,    #0
str     ldp.a   STR,    str1    ;load strategy in use
	sne.ab  #0,     res     ;check result
lost    add.a   #1,     str1    ;lost change 
	mod.a   #2,     str1    ;secure result
win     stp.ab  str1,   STR
str1    jmp     @0,     sweep
	dat     0,      paper

;This one is paper 01o, something well known and light enough to work with 
;few hundreds processes
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

bsweep
	dat     0,      0
for MAXLENGTH-CURLINE-3
	dat     0,0
	rof
	dat     1,1
	dat     1,1
	dat     1,1
end        
