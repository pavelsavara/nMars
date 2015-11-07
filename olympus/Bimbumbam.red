;redcode-94
;name Bim bum bam
;author Beppe Bezzi
;Warrior that plays the game of Paper-Scissors-Stone in NSFCWT round 5
;Needs to be paired with one opponent exactly half the coresize apart (-d 4000)
;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80
;strategy 'Bim bum bam' if what we say before showing hands when playing the
game
;strategy Catches quickly and kills all whites giving but 1 win & 1 tie on
average
;strategy Use an adaptive succession of engines to try foul and beat humans
;strategy using a -stay with good result- tactic.
;strategy Not even tried handshaking against myself, 1000 ties
;strategy No brainwashing this time :-)


;my/your_hand are used to communicate between players
your_hand   equ (my_hand+CORESIZE/2)
PAPER       equ #1              ;some useful constants
SCISSORS    equ #2
STONE       equ #3

org         start
my_hand     dat 0,0
;
;---BEGIN-VARIABLE-PART-----------------------------------------------------
;PIN 1112
;Don't change any code outside this area.  
RES     equ     #0     ;last result
;ENGINEs anti w w
;1-e1 (1,9) 2-e2 (2,8) 3-e3 (3,7) 4-e4 (4) 5-e5 (5) 6-e6 7-e10 (10) 8-eh (human)

;P-space equ
STR     equ     #1     ;last strategy
YRSTR   equ     #2     ;last opponent move
COUNT   equ     #3      ;round counter
LAST    equ     #4      ;previous round result
LENMOV  equ     #5      ;last enemy move
HSTR    equ     #6      ;anti human strategy
ENGINE  equ     #7      ;anti ww engine to use
HRND    equ     #8      ;anti human str. round to play before change
HSCORE  equ     #9      ;score with ahstr

hrounds equ     4       ;rounds to play any ahstr
hmin    equ     (hrounds*3/2)    ;minimum score allowed
;--------------
check   dat     0,0
start   
result  ldp     RES,    check
strat   ldp     STR,    #0      ;last rnd strategy
	ldp.a   ENGINE, eng     ;detected enemy ?
count   ldp.a   COUNT,  go1
	add.a   #1,     go1     ;update round counter
	jmn.a   eng,    eng     ;go for selected strategy
	sne.ab  #-1,    check   ;first round
	jmp     first           ;yes

;----non primo round
rcnt    mov.ab  go1,    #0      ;round counter
r1      seq.ab  #2,     rcnt    ;round 1 results
	jmp     r2
	mov.ba  check,  check1

check1  jmp     @0,     loss1   
	dat     0,      win1
	dat     0,      tie1

r2      seq.ab  #3,     rcnt    ;round 2 results
	jmp     r3
	mov.ba  check,  check2
check2  jmp     @0,     loss2   
	dat     0,      win2
	dat     0,      tie2

loss1   ;played 1 loss, opponent played 2, ww 2-5-8-10 human
;       stp     #1,     #102    ;next 2 ->  -win
;       stp     #1,     #105    ;next 3 ->  -tie
;       stp     #1,     #108    ;next 2 ->  -win
;       stp     #1,     #110    ;next 1 ->  -loss
	mov.a   #3,     go0      ;play 3
	jmp     go0
win1    ;played 1 win, opp played 3, ww 3-4-7 human
;       stp     #1,     #103    ;next 3 -> -tie
;       stp     #1,     #104    ;next 2 -> -win
;       stp     #1,     #107    ;next 3 -> -tie
	mov.a   #3,     go0
	jmp     go0
;
tie1    ;played 1 tie, opp played 1, ww 1-6-9 
;       stp     #1,     #101    ;next 1 -> -win
;       stp     #1,     #106    ;next 1 -> -win
;       stp     #1,     #109    ;next 1 -> -win
;       stp     #1,     HUMAN
	mov.a   #2,     go0
	jmp     go0
;
loss2   ;loss in rnd 2. 
	stp     #6,     ENGINE  ;if white is ww 10
	mov.a   #1,     go0      ;play 1
	jmp     go0

tie2    ;tie in rnd 2, ww 5 3 7
llast   ldp     LAST,   #0      ;previous result
	jmz     set5,   llast
set37   stp     #3,     ENGINE  ;ww 3 or 7
	mov.a   #1,     go0      ;beat him
	jmp     go0
set5    stp     #5,     ENGINE  ;ww 5
	mov.a   #2,     go0      ;beat him
	jmp     go0      

win2    ;win in rnd 2, ww 2-8 4 1-6-9
;
llast1  ldp     LAST,   #0      ;previous result
	jmz     set2,   llast1  ;loss in first
	djn     set1,   llast1  ;tie in first
set4    stp     #4,     ENGINE  ;win in first
	mov.a   #2,     go0
	jmp     go0
set2    stp     #2,     ENGINE
	mov.a   #3,     go0
	jmp     go0
;
set1    stp     #1,     ENGINE
	mov.a   #2,     go0
	jmp     go0
r3      
eng     jmp     @0,     eh      ;never jumps here
	dat     0,      e1      ;1
	dat     0,      e2      ;2
	dat     0,      e3      ;3
	dat     0,      e4      ;4
	dat     0,      e5      ;5
	dat     0,      e6      ;6
	dat     0,      e10     ;7
	dat     0,      eh      ;8
;--- Strategy engines
e1      
	seq.ab  #1,     check   ;we won, all right
	jmp     wrong1          ;we lost :-( what's happened
e1a     mov.a   #2,     go0
	jmp     go0
;
wrong1  sne.a   #6,     go1     ;we lost round 5
	jmp     set6            ;w w 6
	sne.a   #502,   go1     ;we lost round 501
	jmp     set9            ;ww 9
	jmp     seth
e2              
	seq.ab  #1,     check   ;we won, all right
	jmp     wrong2          ;we lost :-( what's happened
e2a     mov.a   #3,     go0
	jmp     go0
wrong2  sne.a   #502,   go1     ;we lost round 501
	jmp     set8            ;ww 8
	jmp     seth
e3      
	seq.ab  #1,     check   ;we won, all right
	jmp     wrong3          ;we lost :-( what's happened
e3a     mov.a   #1,     go0
	jmp     go0
wrong3  sne.a   #502,   go1     ;we lost round 501
	jmp     set7            ;ww 7
	jmp     seth
;
set7    stp     #1,     ENGINE  ;continue as if it were ww1
	jmp     e1a
set8    stp     #3,     ENGINE  
	jmp     e3a
set9    stp     #3,     ENGINE
	jmp     e3a
set6    stp     #6,     ENGINE 
	mov.a   #3,     go0
	jmp     go0
;
e4      ;win same loss prec. -1
	seq.ab  #1,     check   ;we won, all right
	jmp     wrong4          ;we lost :-( what's happened
e4a     mov.b   strat,  #0
	add.ab  #1,     e4a     ;round+1
	mod.ab  #3,     e4a
	add.ab  #1,     e4a
	mov.ba  e4a,    go0
	jmp     go0
wrong4
	
e5      ;231231...
	seq.ab  #1,     check   ;we won, all right
	jmp     wrong5          ;we lost :-( what's happened
e5a     mov.ab  go1,    #0
	add.ab  #1,     e5a
	mod.ab  #3,     e5a
	add.ab  #1,     e5a
	slt.b   e5a,    #4
	mod     #3,     e5a
	mov.ba  e5a,    go0
	jmp     go0
;
wrong5  seq.a   #5,     go1     ;we lost round 5
	jmp     seth            ;human
	jmp     set10           ;ww0
;-break
e6      ;1111222223333311111...
	seq.ab  #1,     check   ;we won, all right
	jmp     wrong6          ;we lost :-( what's happened
e6a     mov.ab  go1,    #0
	div.ab  #5,     e6a
	mod.ab  #3,     e6a
	add.ab  #2,     e6a
;-break
	slt.b   e6a,    #4
	mod     #3,     e6a
	
e6b     mov.ba  e6a,    go0
	jmp     go0
wrong6  jmp     seth

e10
	seq.ab  #1,     check   ;we won, all right
	jmp     wrong10         ;we lost :-( what's happened
e10a    mov.a   #3,     go0
	jmp     go0
;-break
set10   stp     #7,     ENGINE
	jmp     e10a
wrong10 jmp     seth

seth    stp     #8,     ENGINE
;-break
eh      ;human coded opponent
;calculate last enemy move
hlst    ldp     STR,    #0      ;my last move
hres    mov.ba  check,  1       ;result
	jmp     @0,     hloss
	dat     0,      hwin
	dat     0,      htie
htie    mov.b   hlst,   hmov    ;enemy played my move = hlst
	jmp     hmovfix
hwin    add.ab  #3,     hlst    ;enemy played my move -1
	sub     #1,     hlst
	mov.b   hlst,   hmov
	jmp     hmovfix
hloss                           ;enemy played my move +1
	add     #1,     hlst
	mov.b   hlst,   hmov
	jmp     hmovfix
hmov    nop     0,      0       ;.b holds last enemy move
hmovfix mod     #3,     hmov
	jmn.b   strsel, hmov
	add     #3,     hmov
strsel                          ;select strategy
hstr    ldp     HSTR,   #0      ;load anti human strategy
hrnd    ldp     HRND,   #0      ;load round to play with it
hscore  ldp     HSCORE, #0      ;load score with that strategy
	jmz.b   change, hrnd    ;some more rounds to play with it
	sub.ab  #1,     hrnd    ;yes update counter
	stp.b   hrnd,   HRND
	mov.ba  check,  uphsc   ;update score
uphsc   jmp     @0,     hloss1
	dat     0,      hwin1
	dat     0,      htie1
hwin1   add     #2,     upsch1
htie1   add     #1,     upsch1
hloss1
upsch1  add.b   hscore, #0
	stp.b   upsch1, HSCORE
	mov.ba  hstr,   hselect
;-break
hselect jmp     @0,     hs0     ;win tie same / loss next
	dat     0,      hs6     ;beat last opp.
	dat     0,      hs8     ;lose w/ last opp.
	dat     0,      hs2     ;play 2
	dat     0,      hs3     ;win same / loss tie next
	dat     0,      hs4     ;reverse anyway order 321
	dat     0,      hs5     ;stay with tie or win
	dat     0,      hs7     ;play last opp.
	dat     0,      hs6     ;beat last opp.
	dat     0,      hs1     ;paso doble
	dat     0,      hs7     ;play last opp.
	dat     0,      hs8     ;lose w/ last opp.
change                          
	slt     #hmin,  hscore   ;check score (result in hscore.b)  
	jmp     nexth            ;bad :-(
	jmp     sameh            ;good :-)
nexth   add     #1,     hstr

	mod     #11,     hstr     ;**** NUMBER OF HSTR HERE ****

	stp.b   hstr,   HSTR
sameh   stp.ab  #hrounds,HRND    ;reset rounds to max
	stp.ab  #0,     HSCORE   ;reset score
	mov.ba  hstr,   hselect
	jmp     hselect


hs0                             ;win tie same / loss next
	ldp     STR,    #0      ;strat.
hs0a    mov.b   check,  #0      ;result
	jmn.b   hs0z,   hs0a
	add     #2,     hs0
	mod     #3,     hs0
	add.ab  #1,     hs0
hs0z    mov.ba  hs0,    go0
	jmp     go0
hs1                             ;paso doble
	ldp     COUNT,  #0
	div     #2,     hs1
	mod     #3,     hs1
	add     #1,     hs1
	mov.ba  hs1,    go0
	jmp     go0

hs2     
	mov.a   #2,     go0
	jmp     go0
hs3                             ;win same / loss tie next
	ldp     STR,    #0      ;strat.
hs3a    mov.b   check,  #0      ;result
	sub     #1,     hs3a
	jmz     hs3z,   hs3a
	add     #2,     hs3
	mod     #3,     hs3
	add.ab  #1,     hs3
hs3z    mov.ba  hs3,    go0
	jmp     go0

hs4
	ldp     COUNT,  #0
hs4a    sub.b   hs4,    #1000
	mod     #3,     hs4a
	add     #1,     hs4a
	mov.ba  hs4a,   go0
	jmp     go0
hs5                             ;stay with tie or win
	ldp     STR,    #0
hs5a    mov.b   check,  #0
	jmn     hs5z,   hs5a
	add     #1,     hs5
	mod     #3,     hs5
	jmn.b   hs5z,   hs5
	add     #3,     hs5
hs5z    mov.ba  hs5,    go0
	jmp     go0
hs6                     ;beat last opponent's move
	mov.b   hmov,   #0
	mod.ab  #3,     hs6
	add.ab  #1,     hs6
	mov.ba  hs6,    go0
	jmp     go0
hs7                     ;play last opponent's move
	mov.ba  hmov,   go0
	jmp     go0
hs8                     ;lose against last opponent's move
	mov.b   hmov,   #0
	add.ab  #1,     hs7
	mod.ab  #3,     hs7
	add.ab  #1,     hs7
	mov.ba  hs7,    go0
	jmp     go0

;--fist round ---
first   
	mov.a   #1,     go0      ;to beat all those playing 3 against whites :-)

;---save data
go0     nop     0,      0
	mod.a   #3,     go0     ;normalize result
	jmn.a   go01,   go0
	add.a   #3,     go0
go01    mov.a   go0,    go
go      stp     #0,     STR     ;save used str
go1     stp     #0,     COUNT   ;update round counter
	stp.b   check,  LAST
	mov.ab  go,     my_hand
;---END-VARIABLE PART-------------------------------------------------------
;
wait        jmz.b wait,your_hand
work        mov.b your_hand,#work
	    sub.b my_hand,work          ;your_hand minus my_hand, loss=1,-2
	    add #2,work                 ;loss=3,0
	    mod #3,work                 ;loss=0
live        jmn live,work               ;die if lost, live if won or tied
