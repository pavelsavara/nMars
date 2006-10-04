;redcode
;name  Winner
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSFCWT Round 6
;assert VERSION >= 80

;my/your_hand are used to communicate between players
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

maxpattern EQU 37

result_  EQU #0
losses_  EQU #1
outcome_ EQU #2
move_    EQU #3
lma_     EQU #4
step_    EQU #5
key1_    EQU #6
key2_    EQU #7
table_   EQU  8
record_  EQU table_+27

result      dat 0,0
lma         dat 0,0
losses      dat 0,0
lastoutcome dat 0,0
lastmove    dat 0,0
enemymove   dat 0,0
outcome     dat 0,0
temp        dat 0,0
table_1     dat 0,table_
table_2     dat 0,table_
entry       dat 0,0
max         dat 0,0
move        dat 0,0

record_1    dat record_,record+1
record_2    dat record,record_

record      dat 0,1
for maxpattern-1
            dat 0,1
rof

rp2first    dat 0,0
step        dat 0,0
rp3         dat 0,record-1
key1        dat 0,0
key2        dat 0,0

start       ldp result_,result
            sne #-1,result
              jmp firstround
            
            ldp losses_,losses
            slt losses,#100
              jmp stochastic
            
            jmn noloss,result
              add #1,losses
              stp losses,losses_

noloss      ldp lma_,lma
            ldp outcome_,lastoutcome
            ldp move_,lastmove
            mov lastmove,enemymove
            add result,enemymove
            add lma,enemymove
            add #1,enemymove
            mod #3,enemymove
            
            mov result,outcome
;            add lma,outcome
;            mod #3,outcome
            mul #3,outcome
            add enemymove,outcome
            stp outcome,outcome_
            
            mov enemymove,temp
            mul #9,temp
            add temp,table_1
            add lastoutcome,table_1
            ldp table_1,entry
            add #1,entry
            stp entry,table_1
            
            add outcome,table_2
            mov #1,move
            ldp table_2,max
            add #9,table_2
            ldp table_2,entry
            slt max,entry
            jmp label1
              mov entry,max
              mov #2,move
label1      add #9,table_2
            ldp table_2,entry
            slt max,entry
            jmp label2
              mov entry,max
              mov #0,move

label2      mov result,record
            add lma,record
loop1         ldp.ab record_1,@record_1
              nop }record_1,>record_1
            djn loop1,#maxpattern-1

            sne result,#1
            jmp dolma
            
            mov rp2,rp2first
            
rp1         seq record,record+1
            jmp label3
              mov rp1,step
              sub.ab step,step
              
              mov rp2first,rp2
              add.b step,rp2
              mov #10,timer

rp2           seq record+1,record+1
              jmp label3
                nop }rp2,>rp2
timer           djn rp2,#10
                stp step,step_
                jmp dolma
            
label3      nop 0,>rp1
            djn rp1,#maxpattern-10
            stp #0,step_

dolma       ldp step_,step
            jmn label4,step
              mov #0,lma
              jmp loop2

label4      add.b step,rp3
            mov @rp3,lma
            add #2,lma           
            
loop2         stp.b *record_2,record_2
              nop }record_2,>record_2
            djn loop2,#maxpattern-1
  
            stp move,move_
            stp lma,lma_
            add lma,move
            mod #3,move
            
            add #1,move
            mov move,my_hand
            jmp wait

firstround  stp #2557,key1_
            stp #2883,key2_
            stp #1,#table_+10
            stp #1,#table_+13
            stp #1,#table_+16
            stp #1,#table_+19
            stp #1,#table_+20
            stp #1,#table_+22
            stp #1,#table_+23
            stp #1,#table_+25
            stp #1,#table_+26
            jmp loop2

stochastic  ldp key1_,key1
            ldp key2_,key2
            mul #2,key1
            mul #2,key2
            slt key1,#4000
            add #1,key1
            slt key1,#4000
            add #1,key2
            slt key2,#4000
            add #1,key1
            stp key1,key1_
            stp key2,key2_
            mod #3,key1
            add #1,key1
            mov key1,my_hand
            jmp wait

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
