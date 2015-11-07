;redcode-94
;name Round 6 Kline
;kill Round 6 Kline
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 6
;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80

your_hand   equ (my_hand+CORESIZE/2)
PAPER       equ #1              ;some useful constants
SCISSORS    equ #2
STONE       equ #3
org         start
my_hand     dat 0,0
;
;           Variable part starts here. This is were I decide what hand to
;           use next. I can use the value of the RESULTS cell (0 if lost,
;           1 if won, 2 if tied last round) and any other values I chose
;           to store in pspace. The hand I decide to show is stored in the
;           B-field of instruction 'my_hand'.
;---BEGIN-VARIABLE-PART-----------------------------------------------------

myPaper     equ       0
myScissors  equ       1
myStone     equ       2
;
;********************************* fetch and normalize last result
;
start       ldp.a   #0 ,Tresult
            sne.a   #-1,Tresult
            mov.a   #2,Tresult
Tresult     jmp     @0,loss
            jmp     @0,win
            jmp     @0,tie
win         add.a   #2,Nresult      ;  2 for a win
tie         add.a   #2,Nresult      ;  0 for a tie
loss        sub.a   #2,Nresult      ; -2 for a loss
rndCount    ldp.ab  #-13,#0
            add.ab  #1,rndCount
            stp.ba  rndCount,rndCount
;
;********************************* track tie periodicity
;
tieLast     ldp.ab  #-15,#0         ; count since last tie
            seq.a   #0,Nresult
            add.ab  #1,tieLast
            add.ba  tieLast,tieLook
            mod.ab  #100,tieLast
            stp.ba  tieLast,tieLast
            
tieLook     ldp.ab  #300,#0
            slt.ab  tieLook,#304
            slt.ab  #10,tieLook     ; is there a period?
            jmp     tieUpdate       ;    no
tieCheck    mov     #1,#0           ;    yes
            stp.a   #0,tieLast
            
tieUpdate   seq.a   #0,Nresult
            jmp     update
            ldp.ab  tieLook,tieLook
            add     #1,tieLook
            stp.ba  tieLook,tieLook
            stp.a   #1,tieLast
;
;********************************* update latest result in pspace
;
update      ldp.a   #-1,past1       ; |
            ldp.a   #-2,past2       ; | - opponent's previous 4 plays
            ldp.a   #-3,past3       ; |
            ldp.a   #-4,past4       ; |
            ldp.a   #-5,past5       ;   - my last play
past1       mul     #0,#1
past2       mul     #0,#3
past3       mul     #0,#9
past4       mul     #0,#27
past5       mul     #0,#81
past        add.b   past1,Sresult
            add.b   past2,Sresult
            add.b   past3,Sresult
            add.b   past4,Sresult
            add.b   past5,Sresult
            ldp.ba  Sresult,Sresult 
            sne.a   #0,Sresult
            mov.a   #2000 ,Sresult
            slt.ab  Sresult,#2001
            sub.a   #1,Sresult
            slt.a   #1999,Sresult
            add.a   #1,Sresult
Nresult     add.a   #0    ,Sresult
            slt.ab  Sresult,#2009   ; |
            mov.a   #2009,Sresult   ; | - don't overcommit
            slt.a   #1991,Sresult   ; | - in case he changes strategies
            mov.a   #1991,Sresult   ; |
Sresult     stp.ab  #0    ,#0       ;   - update long-term memory
;
;********************************* what did he play?
;
            mul.a   Tresult,oppPlay ;     result*3 + myplay = nine possibles
            add.a   past5,oppPlay
oppPlay     jmp     @3,oppSciss
            dat     #0,oppStone
            dat     #0,oppPaper
            dat     #0,oppStone
            dat     #0,oppPaper
            dat     #0,oppSciss
            dat     #0,oppPaper
            dat     #0,oppSciss
            dat     #0,oppStone
oppPaper    sub.a   #2,oppHand
oppStone    add.a   #1,oppHand
oppSciss    add.a   #1,oppHand
oppHand     stp.ab  #0   ,#-4       ; | 
            stp.ab  past4,#-3       ; |
            stp.ab  past3,#-2       ; | - record his last 4
            stp.ab  past2,#-1       ; |
;
;********************************* check long-term memory
;
long1       mul.ab  past2,#1        ; fetch record of his last 4
long2       mul.ab  past3,#3        ; and my previous results with pa/sc/st
long3       mul.ab  past4,#9
long4       mul.ab  oppHand,#27
longT       add.b   long1,longT
            add.b   long2,longT
            add.b   long3,longT
            add.b   long4,longT
            ldp.b   longT,paperP
            add.ab  #81,longT
            ldp.b   longT,scissP
            add.ab  #81,longT
            ldp.b   longT,stoneP
longTest    add.b   paperP,longTest
            add.b   scissP,longTest
            add.b   stoneP,longTest
;
;********************************* pick a play
;
pick        sne     #0,paperP       ; normalize at 2000
            mov     #2000,paperP
            mov     paperP,paperQ
            sne     #0,scissP
            mov     #2000,scissP
            mov     scissP,scissQ
            sne     #0,stoneP
            mov     #2000,stoneP
            mov     stoneP,stoneQ
            slt.b   paperP,scissP   ; put best history into stoneP
            mov     paperP,scissP   ; (holdover from round 4 - bubble sort :-)
            slt.b   scissP,stoneP
            mov     scissP,stoneP
            mov.a   stoneP,myPlay
            sne.ab  #2000,stoneP    ; if best was a tie, randomize
            jmp     randomKey
            add.ba  tieCheck,myPlay
            mod.a   #3,myPlay
myPlay      jmp     @0,paperS
            jmp     @0,scissS
            jmp     @0,stoneS
paperP      dat     0,0
scissP      dat     1,0
stoneP      dat     2,0
paperQ      dat     0
scissQ      dat     0
stoneQ      dat     0
;
;********************************* pick at random
;
randomKey   ldp.ab  #-6,#randomKey
randomUp    add     #1,randomKey
            mod     #RandomE-RandomT,randomKey
            stp.b   randomKey,#-6
            add.ab  #RandomT-randomKey,randomKey
            mov.ba  @randomKey,randomSel
randomSel   jmp     @0,rnStone
            jmp     @0,rnScissors
            jmp     @0,rnPaper
rnPaper     slt     #1995,paperQ       ; don't pick a loser
            jmp     randomKey
            jmp     paperS
rnScissors  slt     #1995,scissQ
            jmp     randomKey
            jmp     scissS
rnStone     slt     #1995,stoneQ
            jmp     randomKey
            jmp     stoneS
;
;********************************* go for it
;
paperS      stp.ab  #myPaper   ,#-5
            mov     PAPER,my_hand
            jmp     wait
scissS      stp.ab  #myScissors,#-5
            mov     SCISSORS,my_hand
            jmp     wait
stoneS      stp.ab  #myStone   ,#-5
            mov     STONE,my_hand
            jmp     wait
;
;********************************* random table
;
RandomT     dat     0,0
 dat 1
 dat 2
 dat 0
 dat 2
 dat 2
 dat 1
 dat 1
 dat 2
 dat 1
 dat 2
 dat 1
 dat 1
 dat 0
 dat 1
 dat 1
 dat 0
 dat 2
 dat 2
 dat 1
 dat 0
 dat 0
 dat 0
 dat 0
 dat 2
 dat 1
 dat 2
 dat 1
 dat 2
 dat 0
 dat 2
 dat 0
 dat 1
 dat 0
 dat 0
 dat 2
 dat 2
 dat 0
 dat 0
 dat 0
 dat 0
 dat 2
 dat 2
 dat 1
 dat 1
 dat 1
 dat 1
 dat 1
 dat 1
 dat 2
 dat 1
 dat 0
 dat 1
 dat 2
 dat 1
 dat 2
 dat 0
 dat 2
 dat 2
 dat 1
 dat 1
 dat 0
 dat 2
 dat 1
 dat 0
 dat 1
 dat 2
 dat 1
 dat 0
 dat 0
 dat 2
 dat 2
 dat 1
 dat 1
 dat 2
 dat 1
 dat 2
 dat 1
 dat 1
 dat 0
 dat 1
 dat 1
 dat 0
 dat 2
 dat 2
 dat 1
 dat 0
 dat 0
 dat 0
 dat 0
 dat 2
 dat 1
 dat 2
 dat 1
 dat 2
 dat 2
 dat 1
 dat 2
 dat 2
 dat 0
 dat 2
 dat 0
 dat 2
 dat 2
 dat 0
 dat 1
 dat 2
 dat 1
 dat 0
 dat 0
 dat 0
 dat 0
 dat 2
 dat 0
 dat 0
 dat 0
 dat 0
 dat 1
 dat 1
 dat 0
 dat 2
 dat 0
 dat 1
 dat 2
 dat 1
 dat 2
 dat 2
 dat 1
 dat 1
 dat 1
 dat 1
 dat 0
 dat 0
 dat 1
 dat 0
 dat 1
 dat 1
 dat 1
 dat 1
 dat 0
 dat 1
 dat 2
 dat 0
 dat 1
 dat 1
 dat 1
 dat 1
 dat 1
 dat 2
 dat 0
 dat 2
 dat 1
 dat 0
 dat 1
 dat 1
 dat 0
 dat 1
 dat 1
 dat 0
 dat 2
 dat 0
 dat 1
 dat 1
 dat 0
 dat 2
 dat 0
 dat 2
 dat 0
 dat 0
 dat 0
 dat 2
 dat 1
 dat 1
 dat 1
 dat 0
 dat 1
 dat 1
 dat 2
 dat 0
 dat 0
 dat 1
 dat 1
 dat 0
 dat 0
 dat 2
 dat 2
 dat 0
 dat 2
 dat 0
 dat 0
 dat 0
 dat 0
 dat 2
 dat 0
 dat 2
 dat 0
 dat 2
 dat 1
 dat 0
 dat 2
 dat 1
 dat 0
 dat 1
 dat 0
 dat 1
 dat 2
 dat 0
 dat 2
 dat 2
 dat 0
 dat 1
 dat 0
 dat 2
 dat 2
 dat 2
 dat 2
 dat 2
 dat 2
 dat 1
 dat 2
 dat 1
 dat 1
 dat 0
 dat 2
 dat 2
 dat 0
 dat 0
 dat 1
 dat 2
 dat 1
 dat 1
 dat 0
 dat 0
 dat 0
 dat 2
 dat 1
 dat 0
 dat 0
 dat 2
 dat 1
 dat 2
 dat 0
 dat 2
 dat 2
 dat 2
 dat 2
 dat 1
 dat 0
 dat 2
 dat 2
 dat 2
 dat 1
 dat 1
 dat 2
 dat 2
 dat 2
 dat 1
 dat 2
 dat 0
 dat 0
 dat 1
 dat 0
 dat 1
 dat 1
 dat 2
 dat 0
 dat 1
 dat 2
 dat 2
 dat 0
 dat 0
 dat 2
 dat 2
 dat 0
 dat 1
 dat 1
 dat 2
 dat 1
 dat 2
 dat 2
 dat 0
 dat 0
 dat 1
 dat 1
 dat 0
 dat 1
 dat 1
 dat 2
 dat 0
 dat 2
 dat 2
 dat 2
 dat 1
 dat 2
 dat 0
 dat 0
 dat 2
 dat 1
 dat 1
 dat 0
 dat 2
 dat 0
 dat 0
 dat 0
 dat 2
 dat 2
 dat 2
 dat 0
 dat 1
 dat 2
 dat 1
 dat 1
 dat 2
 dat 0
 dat 1
 dat 0
 dat 1
 dat 2
 dat 2
 dat 2
 dat 1
 dat 0
RandomE     dat     0,0
;*********************************
;---END-VARIABLE PART-------------------------------------------------------
;           End of variable part. I wait for the other player to show his hand.
;           I then analyze the outcome of the game.
;
wait        jmz.b wait,your_hand
work        mov.b your_hand,#work
            sub.b my_hand,work          ;your_hand minus my_hand, loss=1,-2
            add #2,work                 ;loss=3,0
            mod #3,work                 ;loss=0
live        jmn live,work               ;die if lost, live if won or tied

            end

Paul Kline
pk6811s@acad.drake.edu
