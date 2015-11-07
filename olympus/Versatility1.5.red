;redcode-94
;name Versatility 1.5
;author Ross Morgan-Linial
;assert CORESIZE==8000
;strategy   brainwash-resistant table-based
;strategy   pspacer with a scanner from Chameleon, a
;strategy   paper from Grilled Octopus and tornado 3.0
;strategy
;strategy   I decided the version of tornado from
;strategy   Armory was weak...
;kill Versatility

; scanner, stolen from Chameleon
dist    EQU 66
spread  EQU dist*2     

stun    spl     #spread,        spread
w2
top     add     stun,           scan            ;start here
scan    cmp     dist+top,       top
	slt.ab  #100,           scan
	djn.f   top,            <5100
	mov     sjump,          @scan
	mov     stun,           <scan
	mov     stun,           <scan
	sub.f   half,           scan
test    jmn.b   scan,           top
	add.a   #382,           clear
	mov     @-1,            {clear
sjump   jmp     -2,             0
half    dat     <0-dist,        <0-dist-2
clear   spl     #2,             #3

; simple table-based pswitcher
; FAST! 8 instructions to get to the boot!
; brainwash protection

toffs   equ     (table-tindex)
TIDX    equ     111		;changed, for my protection

start   LDP.ab  #TIDX,          tindex
result  LDP.ab  #0,             #0
	ADD.b   result,         tindex
	SEQ.ab  #0,             tindex          ;brainwash check - zero
	SLT.b   tindex,         #endtab+1-tindex  ;brainwash check - too large
	MOV.ab  #fsttab-tindex, tindex          ;use data at fsttab on first
						;round and when brainwashed
	STP.ab  @tindex,        #TIDX
	MOV.ba  @tindex,        jump
jump    JMP     0
fsttab  DAT     #toffs+0,       #w1-jump        ;this is used for the first round
						;and when brainwashed
tindex  DAT     #0,             #0              ;index into table
table   DAT     #toffs+3,       #w2-jump        ;w1->w2 on loss
	DAT     #toffs+0,       #w1-jump        ;w1->w1 on win
	DAT     #toffs+3,       #w2-jump        ;w1->w2 on tie
	DAT     #toffs+6,       #w3-jump        ;w2->w3 on loss
	DAT     #toffs+3,       #w2-jump        ;w2->w2 on win
	DAT     #toffs+3,       #w2-jump        ;w2->w2 on tie
	DAT     #toffs+0,       #w1-jump        ;w3->w1 on loss
	DAT     #toffs+6,       #w3-jump        ;w3->w3 on win
endtab	DAT     #toffs+3,       #w2-jump        ;w3->w2 on tie

	;w1, w2, and w3 (boot points) go here


;paper module, stolen from Grilled Octopus
;non-booted (of course)
dest0   equ   2200
dest1   equ   3740
dest2   equ  -1278                   ; pmars optimized
range   equ    933                   ; pmars optimized

w3
paper   SPL.B   1,              #0    ;\
	SPL.B   1,              #0    ;-> generate 8 processes
	SPL.B   1,              #0    ;/

silk    SPL.B   @0,             {dest0
	MOV.I   }-1,            >-1
silk1   SPL.B   @0,             <dest1
	MOV.I   }-1,            >-1
	MOV.I   ibomb,          }range
	MOV.I   {silk1,         <silk2
silk2   JMP.B   @0,             >dest2
ibomb   DAT.F   <2667,          <5334

;tornado, stolen from Armory-A5

dms     equ     25
dmd     equ     -2500
step    equ     -45               
djnoff  equ     -2205
bootd	equ	1000		;changed, for my protection
B	equ	24

;boot (mine)
dta	dat	gate,	gate+bootd
w1	mov	}dta,	>dta
	djn	-1,	#8
	add.ab	#B,	dta
	mov	}dta,	>dta
	djn	-1,	#9
	jmp	bombs+bootd+B

gate    dat     -100,   100
        dat    <-10,   <2667           ;anti imp bit
        dat     -4000,   djmp-gate+2
stclr   spl     #-3000,  djmp-gate+2
tclear   mov     @djmp,  >gate
        mov     @djmp,  >gate
djmp    djn.b   clear,  {stclr
        dat     0,0
        dat     0,0

bombs   spl     #step,  -step           ;hit spl
start1  sub     incr,   @b1           
stone   mov     (0*step)+jump2,*(1*step)+jump2
b2      mov     bombs,  @stone
b1      mov     bombm,  *stone
jump2    djn.f   start1, <djnoff         ;hit by spl
        jmp     stclr-B,  0     
incr    dat     >-3*step,>-3*step      
last
bombm   mov     {step,   1

	end     start
