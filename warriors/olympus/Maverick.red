;redcode-94
;name Maverick
;author Randy Graham
;contact graham@mathcs.rhodes.edu
;NSFCWT round 6
;Warrior that plays the game of Paper-Scissors-Stone in NSFCWT round 6
;Needs to be paired with one opponent exactly half the coresize apart (-d 4000)
;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
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
RAND_DATA   equ (your_hand+2)   ;used to generate a "Random" number
_RESLT      equ #0
LAST        equ #10  ;what was most recently played by me
RESULT      equ #30  ;how I did vs. him

HIS_DATA    equ (live+2) ;stack to keep his stuff
HIS_LAST    equ #99  ;what he played last
HIS_PAPER   equ #100 ;what follows paper from him
HIS_SCISSOR equ #200 ;what follows scissors from him
HIS_STONE   equ #300 ;what follows stone from him
KEEPS       equ 20   ;how many of his to keep (not / by 3)
ADD_STACK   equ (live+KEEPS+5)  ;to add up our scores

;watch what he does.  Start checking what he does most after each
;play (i.e. what most often follows stone) and play to beat that.
start       ldp.ab _RESLT,    #0     ;find out how we did last time
            seq.ab #-1,       start  ;if the first round, just play
            jmp.a  notfirst,  #0
firstround  mov.ab #3,        #0
            stp.b  firstround,    LAST
            stp.ab #2,        HIS_LAST
            mov.b  firstround,    my_hand
            jmp.a  wait,      0

;see what he did so we can make our choice
notfirst    ldp.ab LAST,      #0
get_his     slt.b  start,     #2     ;if not a tie, leave it
            jmp.a  tie,       0
            jmz.b  loss,      start
win         sub.ab #2,        notfirst ;sub 2, since next line always runs
loss        add.ab #1,        notfirst ;add 1
            mod.ab #3,        notfirst ;get it in legal range
            jmn.b  2,         notfirst ;if valid strategy, leave it
            add.ab #3,        notfirst ;else make it a stone

;Load our memory of what he did other times after he used this strategy
tie         ldp.a  HIS_LAST,  goto
            stp.b  notfirst,  HIS_LAST
goto        mul.a  #0,        load_his
            mul.ab goto,      save_his

            mov.ab #2,        HIS_DATA
load_his    ldp.ab #100,      >HIS_DATA
            nop.a  }-1,       0
            djn.b  load_his,  #KEEPS
;add in what he did last time
            mov.b  notfirst,  HIS_DATA+1

;and update out memory
            mov.ab #1,        HIS_DATA
save_his    stp.b  >HIS_DATA, #100
            nop    >-1,       0
            djn.b  save_his,  #KEEPS
            sne.ab goto,      firstround  ;do we have the current strategy?
            jmp.a  count_em,  0   ;yes, so lets see what to do
new_mem     mul.ba notfirst,  recall    ;no, load the right thing

            mov.ab #1,        HIS_DATA
recall      ldp.ab #100,      >HIS_DATA
            nop.a  }-1,       0
            djn.b  recall,    #KEEPS

;See if there is a pattern of <4 or more of one strategy> followed by
;  <a different strategy>.  See if this is repeated.  If yes, use
;  whatever the different strategy is  (should get points on pssc6.red)

            jmz.b  count_em,   HIS_DATA+1  ;only if we have some memory
scanner     seq.b  HIS_DATA+1, HIS_DATA+2  ;look for differences
            jmp.a  check_rpt,  0
            add.ab #1,         scanner
            jmz.b  count_em,   @scanner  ;end of line, no repeat - count
            jmp.a  scanner,    0
check_rpt   mov.f  scanner,    #0
            sub.ab check_rpt,  check_rpt
            slt.ab #3,         check_rpt  ;only check runs of 4 or more
            jmp.a  count_em,   0
first_find  mov.b  >scanner,   #first_find
find_again  sne.b  *scanner,   @scanner  ;now find another starting point
            jmp.a  find_next,  0
            add.ab #1,         scanner
            jmz.b  count_em,   @scanner
            jmp.a  find_again, 0
find_next   add.b  scanner,    second_look
            mov.ba second_look,second_look
second_look seq.b  scanner,    scanner      ;will point to 1st repeat
            jmp.a  check_size, 0
            add.ab #1,         second_look
            jmz.b  count_em,   @second_look
            jmp.a  second_look,0
check_size  mov.f  second_look,#0
            sub.ab check_size, check_size
            seq.b  check_rpt,  check_size
            jmp.a  count_em,   0
            seq.b  first_find, @second_look
            jmp.a  count_em,   0
            mov.ba @second_look, got_him
got_him     jmp.a  @0,         0
            dat.f  0,          his1
            dat.f  0,          his2
            dat.f  0,          his3

;count what he did in the past after this strategy.  Play to beat that
count_em    mov.ab #1,        HIS_DATA
memory      mov.b  >HIS_DATA, ADD_STACK
            add.ab #1,        @ADD_STACK
            djn.b  memory,    #KEEPS

;now we know what he does, let's try to beat him
greater12   slt.b  ADD_STACK+1, ADD_STACK+2
            jmp.a  greater13, 0
greater23   slt.b  ADD_STACK+2, ADD_STACK+3
            jmp.a  his2,      0
            jmp.a  his3,      0
greater13   slt.b  ADD_STACK+1, ADD_STACK+3
            jmp.a  his1,      0
his3        mov.ab #1,        firstround  ;he plays 3, I play 1
            jmp.a  fini,      0
his1        mov.ab #2,        firstround  ;he plays 1, I play 2
            jmp.a  fini,      0
his2        mov.ab #3,        firstround  ;he plays 2, I play 3


fini        stp.b  firstround, LAST
            mov.b  firstround, my_hand
            
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

