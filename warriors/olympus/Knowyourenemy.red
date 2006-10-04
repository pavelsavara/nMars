;redcode-94
;name Know your enemy
;author Beppe Bezzi
;strategy test single parts against for some rounds
;strategy choose best one to finish the fight
;strategy Starring: Marcia Trionfale (full size),  Tornado 1.2
;strategy 0.1 smaller strategic part, extended test time
;strategy 0.2 faster boot - 0.3 slight change in strategy
;strategy 0.4 fixed, i hope, a little bug
;kill Know
;assert CORESIZE == 8000

_RESULT         equ #0          ;last round result
_COUNTER        equ #a          ;round counter
_STRAT          equ #b          ;-strategy to test
_win0           equ #c          ;score strategy 0 Marcia
_win1           equ #c+1        ;score strategy 1 TornadoT.
_BEST           equ #d          ;best strategy
;_win0 and _win1 need to be consecutive locations
;a,b,c,d can be everywhere in p-space
;I don't want you know where *I* am ;-)

prove           equ 9           ;n. of test to choose best
endtst          equ prove*2+1   ;end of test rounds


org pensa

;---- Marcia part 1

A0      equ     3488
A1      equ     1860
A2      equ     3740

silk    spl     @0,     }A0     ;split 
	mov.i   }-1,    >-1     ;copy 
	mov.i   bomb,   {123    ;bombing
silk2   spl     @0,     }A1     ;split
	mov.i   }-1,    >-1     ;copy
	mov.i   bomb,   >1001   ;bombing
	mov.i   bomb,   }2042   ;A-indirect bombing
	mov.i   {silk2, <silk3  ;copy
silk3   jmp     @0,     >A2     ;jmp new copy 
bomb    dat.f   >2667,  >5334   ;anti-imp bomb

;---Tornado
step    equ     52    
count   equ     665 
;*** Constant guessed by Planar
away    equ     2345	;something beetween 1500 and 2500	
			;better not to tell my home address ;-) 
Tornado  ; This line added by Planar
bootgt  
	mov     incr,   away+60
	mov     bombd,  away+30
boot    mov     clr,    away+7
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	mov     {boot,  <boot
	jmp     away-6

   
start   mov     bombd+20,   *stone
	mov     bombd+20,   @stone
stone   mov     *(2*step)+1, *(3*step)+1         
	add     incr+50,stone           
jump    djn.b   start,  #count
	spl     #step,  #0
clr     mov     start-1,}start-5
incr    dat     3*step, 3*step        

bombd   dat     #step, #1

;------------------------

pensa

res     ldp     _RESULT,#0      ;load last result into B-field
	sne     #-1,    res     ;is this the first round, i.e. no result?
	jmp     first           ;setup and start with strat 0

best    ldp     _BEST,  #0
	seq.ab  #-1,    best    ;is there a winning strategy ?
	jmp     gowin           ;yes => fast boot / -1 = 7999

cnt     ldp     _COUNTER,#0     ;increment a round counter
	add     #1,     -1      ;cnt contiene n. rounds
break;
stp1    stp.b   -2,     _COUNTER
	mov     bomba, stp1     ;erase stp instructions
	sne.b   cnt,    #endtst ;round = 2*prove+1 ?
	jmp     selwin          ;yes select winning strategy

; ---- strategy testing and update
str     ldp     _STRAT  ,#0    ;load strategy 
			       ;0=Marcia 1=Tornado 
	add.ba  str,    agg    ;update strategy

agg
	ldp     _win0,  #0     ;load results strategy 
	jmz     loss,   res     ;a zero indicates a loss in the last round
	djn     tie,    res
win     add.ab  #2,     agg     ;3 points for win
			
tie     add.ab  #1,     agg    ;1 points for tie

loss                   
;str.b strategy - agg.b score
update    
	add.b   str,    stp5   ;pointer to strategy
	mov.ba  agg,    stp5   ;new result
;break
stp5    stp     #0,     _win0    ;store result strategy

rndcnt
	mov     bomba, stp5    ;erase stp instructions
	
	sne     cnt,    #prove  ;test each strat for prove rounds
	jmp     change          ;prove round then change str
	seq     cnt,    #prove*2
	jmp     select          ;select next strategy
selwin                          ;choose best strategy and save it
;
score0  ldp     _win0,  #0
score1  ldp     _win1,  #0      
	slt.b   score0, score1
	jmp     best0
;       jmp     best1         ;s1 > s2
;break
best1   stp     #1,     _BEST
	mov.ab  -1,     best
	jmp     gowin
;break
best0   stp     #0,     _BEST
	mov.ab  -1,     best
;
gowin                           ;best.b = winning strategy
	add.ba  best,   sel01
	jmp     sel0
change                          ;change strategy  for next round
;break
stp4    stp     #1,     _STRAT
	mov     bomba, stp4    ;erase stp instructions
;
select  ldp     _STRAT, #0
	add.ba  select, sel01
;
sel0    
	mov     bomba,  best0   
	mov     bomba,  best1   
	mov     bomba,  first       
	mov     bomba,  stp1        
sel01   jmp     2
	jmp     Marcia          ;redundancy added some points against  
				;djn stream using warriors
	jmp     Marcia
	jmp     Tornado
;break
first   stp     #-1,    _BEST   ;not yet a winning strategy
	mov     bomba,  stp4    ;erase stp instructions
	mov     bomba,  first   
	jmp     Marcia

Marcia  
	spl     1,      <300    ;\
	mov     -1,     0       ;-\ generate 10 
	mov     -1,     0       ;-/ consecutive processes
	spl     1,      <400    ;/

	spl     silk,   <1000

silka   spl     @0,     }3620   ;split 
	mov.i   }-1,    >-1     ;copy 
	mov.i   bomba,  }113    ;bombing
silk2a  spl     @0,     }1270   ;split 
	mov.i   }-1,    >-1     ;copy 
	mov.i   bomba,  >1001   ;bombing
	mov.i   bomba,  }2042   ;A-indirect bombing
	mov.i   {silk2a,<silk3a ;copy 
silk3a  jmp     @silk3a,>-350   ;jmp new copy 
bomba   dat.f   >2667,  >5334   ;anti-imp bomb
end
