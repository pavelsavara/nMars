;redcode-94
;name WhileAway
;author JKW
;address jwilkinson@mail.utexas.edu
;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80
;strategy Ah well.  There's still two more intelligence loops
;strategy I would have liked to add in.  But with all the
;strategy questions about what the rules, and having classes, I
;strategy really only had Sat. night to work on this.  Hmmmm...
;strategy I'm dissappointed...  I have a great AI system but no
;strategy time to implement it.  I also hope Nandor hasn't started
;strategy running rounds by the time this gets in.  That'd suck.

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
COUNT1       equ #1
COUNT

start
wins        ldp   #3, #0
ladder      ldp   #2, #0
strategy    ldp   #1, #0 
last        ldp   #0, #0
            djn.b tie, last
            jmz.b won, last

            slt.ab wins, #3000-5
            jmp    rethink, 0
lost:       sub.ab #1, wins
tie:        add.b  ladder, strategy
            slt.ab #3000-5, wins
            jmp    rethink, 0
            sub.ab #2,  wins
won:        add.ab #1,  wins
            stp.b strategy, #1
            stp.b ladder,   #2
            stp.b wins,     #3
            mod.ab #3, strategy
            mul.ab #2, strategy
            add.ba strategy, jmper             
jmper:      jmz   1, 0
            mov SCISSORS, my_hand          
            jmp wait
            mov STONE, my_hand          
            jmp wait
            mov PAPER, my_hand
            jmp wait
rethink:    add.ab #1,    ladder
            mov.ab #3000, wins
            jmp    won
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

