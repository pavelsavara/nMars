;redcode-94
;name Neuromancer
;author M R Bremer
;strategy       record history of matches.
;strategy       look at last 3 matches.
;strategy       find identical 3 match set in history
;strategy       check what he played in the 4th match and play to win
;strategy       if failing-->play strategy-1
;strategy       if that's failing-->go psuedo random
;strategy       aaarrrrghhh!  i keep mixing up redcode with mips instructions
;strategy       i have no idea if this works or not; minimal testing
;strategy       Neuromancer is a cool book by William Gibson by the way

;Needs to be paired with one opponent exactly half the coresize apart (-d 4000)
;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80

;my/your_hand are used to communicate between players
your_hand   equ (my_hand+CORESIZE/2)

;ME_HE EQU CODE  ( my strategy _ his strategy )
ST_SC EQU #1
ST_PA EQU #2
ST_ST EQU #3
SC_PA EQU #4
SC_ST EQU #5
SC_SC EQU #6
PA_ST EQU #7
PA_SC EQU #8
PA_PA EQU #9

;MY STRATEGIES EXTERNAL
PAPER       equ #1              ;some useful constants
SCISSORS    equ #2
STONE       equ #3

;MY STRATEGIES INTERNAL
ST EQU #1
SC EQU #4
PA EQU #7

_RESULT EQU #0
_ROUND EQU #499
_MYPLAY EQU #498
_DEFENSE EQU #497
_RANDOM EQU #496
_WHITE EQU #495
_SPVAR EQU #494
_WINS EQU #493
_LOSSES EQU #492
_GIVEUP EQU #491
_SEED EQU #1321

org         start
my_hand     dat 0,0
;
;           Variable part starts here. This is were I decide what hand to
;           use next. I can use the value of the RESULTS cell (0 if lost,
;           1 if won, 2 if tied last round) and any other values I chose
;           to store in pspace. The hand I decide to show is stored in the
;           B-field of instruction 'my_hand'.
;---BEGIN-VARIABLE-PART-----------------------------------------------------

; ***** Download Variables *****
start
result  ldp _RESULT, #result
round   ldp _ROUND, #round
myplay  ldp _MYPLAY, #myplay
white   ldp _WHITE, #white
wins    ldp _WINS, #wins
losses  ldp _LOSSES, #losses
defense ldp _DEFENSE, #defense
giveup  ldp _GIVEUP, #giveup

hmmm    jmz.b sane, giveup
        jmp random
sane    sne.ab #0, round
        jmp init                ;go to initialization section
        slt.b round, #485
        jmp init

; ***** Upload Results from Last Round *****
        mov.b myplay, 1
combo   add.b result, #combo
        stp.b combo, round
        mov.ba result, 1
        jmp @0, loser
        dat winner
        dat wwc
winner  add.ab #1, wins
        stp.b wins, _WINS
        jmp wwc
loser   add.ab #1, losses
        stp.b losses, _LOSSES
; ***** White Warrior #6 Check *****
wwc     sne.ab #4, round
        jmp kill6
        seq.b white, #6
        jmp def
        slt #10, losses 
        jmp code6

; ***** Defense *****
def     mov.b losses, 1
        sub.b wins, #0
        seq.ab #20, -1
        jmp next             
        stp.ab #3, _DEFENSE
next    sne.ab #40, -4
        stp.ab #1, _GIVEUP

; ***** Initial Search Engine *****
se      add.ba round, runner
        mov.b round, anchor

        mov.b round, loop1
        slt.b round, #50
        mov.ab #50, loop1

runner  ldp.ab #-1, #runner
        sne.b combo, runner
anchor  jmp match, #0
        sub.a #1, runner
loop1   djn.b runner, #0

; ***** No Match, Play Random *****
random  ldp     _SEED,   #random
        add     #117,   random
        mul     #17,   random
        stp     random, _SEED
        mod.ab  #3,     random
        add.ab  #1,     random
        mov.ba  random, table
        jmp table

; ***** Match:  Do Secondary Search *****
match   add.ba anchor, ptr
        add.ab runner, ptr
a       ldp.ab ptr, #a    ;load anchor value
r       ldp.b ptr, #r    ;load runner value
        seq.b a, r
        jmp not         ;not a good enough match
        add inc, ptr
        djn.b a, #1
        jmp ready       ;found a match!
not     mov.ab #1, -2
        mov.a #-1, ptr
        jmp loop1
ptr     nop -1, -1      ;a->anchor b->runner        
inc     nop -1, -1      ;increment

; ***** Get What to Play *****
ready   add.b ptr, #3
        ldp.ba ready, table
        add.ba defense, table
        mod.a #9, table
table   jmp @0, scstrat
        dat scstrat
        dat ststrat
        dat pastrat
        dat pastrat
        dat scstrat
        dat ststrat
        dat ststrat
        dat pastrat

; ***** Upload Events; Play Hand *****
pastrat
        add.ab #1, round
        stp round, _ROUND
        stp PA, _MYPLAY
        mov.ab PAPER, my_hand
        jmp wait
ststrat
        add.ab #1, round
        stp round, _ROUND
        stp ST, _MYPLAY
        mov.ab STONE, my_hand
        jmp wait
scstrat
        add.ab #1, round
        stp round, _ROUND
        stp SC, _MYPLAY
        mov.ab SCISSORS, my_hand
        jmp wait

; ***** Initialization *****
init    stp #1, _ROUND
        mov.ab #0, round
        sne.b white, #6
        jmp code6, }code6+1     ;cheap hack
        jmp scstrat

; ***** Kill White Warrior #6! ******
kill6   ldp.b #5, #0
        add.b kill6, #0
        djn.a kill6, kill6
        seq.ab #12, -2
        jmp se                  ;no match for white #6
        stp.ab #6, _WHITE
code6   ldp.a _SPVAR, j6
        add.a #1, j6
        mod.a #15, j6
        stp.ab j6, _SPVAR
j6      jmp @0, scstrat
        dat ststrat
        dat ststrat
        dat ststrat
        dat ststrat
        dat ststrat
        dat pastrat
        dat pastrat
        dat pastrat
        dat pastrat
        dat pastrat
        dat scstrat
        dat scstrat
        dat scstrat
        dat scstrat

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
