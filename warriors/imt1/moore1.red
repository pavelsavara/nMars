;redcode-94
;name Reinforcements v0.01a beta
;author David Moore
;assert 1
;strategy Based on a reinforcement-learning technique that I used
;strategy in one of my AI classes to control robot behavior.
;strategy However, it might not apply so well to this tournament.
;strategy (especially without random actions. yuck)
;strategy Let's find out anyway.
;strategy
;strategy Has 2 round memory which gives it 36 states:
;strategy    {T,C} x {L,W,T} x {T,C} x {L,W,T}
;strategy For each state S there are two values t(S) and c(S)
;strategy If c(S) > t(S) then choose Carbonite else TimeScape.
;strategy Then in next round there will be a new State S'.
;strategy There will be some amount of reward R based on whether
;strategy we won, lost or tied.
;strategy If Carbonite had been chosen then update
;strategy   c(S)  <-  .5 c(S) + .5 (max{c(S'), t(S')} + R)
;strategy else update t(S) similarly.
;strategy
;strategy If there is a single best function that maps the 36 states to {T,C}
;strategy then hopefully Qlearner will learn it. This applies to
;strategy most simple opponents.
;strategy
;strategy Major problem: No random actions are used to help explore the
;strategy state space. This can really hurt versus DTfT
;strategy and other strategies which provide an opportunity
;strategy for using Carbonite
;strategy
;strategy Why not use only one value t(S) and choose Carbonite if t(S)<0
;strategy or TimeScape otherwise? Study the function above to find out.
;strategy Note that the program will eventually get punished for
;strategy reaching a state B which leads to a bad state C.
;strategy Then it will get punished for reaching A which leads to B.
;strategy etc. If it follows the same path more than once then
;strategy it gains the ability to plan ahead.
;strategy
;strategy I assume that brainwash pits are banned.
;strategy It would be a shame to lose the information contained
;strategy in 72 pspace locations.
;strategy
;strategy There is a major bug: a brainwash can sometimes
;strategy cause it to run Carbonite continuously forever

pStrat equ 250

zero equ 2600
vmin equ 100
vmax equ 5100

table  dat -14, 0*6
       dat -14, 1*6
       dat  22, 2*6
       dat  22, 3*6
       dat  -2, 4*6
       dat  -2, 5*6

       dat 0, 0+table-p1
index  dat 0, 0+table-p1
       dat 0, 2+table-p1
       dat 0, 4+table-p1

; *** Horribly Unoptimized P-Code by me

logic  ldp.ab  #pStrat, #0
       ldp.a   #0, index
       ldp.b  logic, table 
       mod.ab    #2, table
       add.b *index, table
       mov.b  logic, ploc
ploc   div.ab #12, #0
       add.b @table, ploc
       mul.ab #2, ploc

p0     ldp.b  ploc, #0
       add.ab #1, ploc
p1     ldp.b  ploc, #0
       add.ab #zero, p0
       add.ab #zero, p1

       slt.b p0, p1
       mov.b p0, p1
       ldp.b logic, value
value  add.b p1, #0
       div.ab #2, value

       slt.ab #vmin, value
       mov.ab #vmin, value
       slt.b  value, #vmax
       mov.ab #vmax, value

       sub.ab #zero, value
hide   stp.b value, logic

       seq.b p0, p1
       jmp strat1, >ploc

strat0 stp.ba ploc, logic
       mov dbomb, hide        ; hide stp code to avoid brainwash
       mov dbomb, strat0
       mov dbomb, strat1

; *** TimeScape by Juha Pohjalainen

TSTEP equ 1800
CSTEP equ 3740
NSTEP equ -1922
FSTEP equ 1870

time    spl     1,              <-200
        spl     1,              <-300
        mov.i   -1,             0

tim1    spl     @tim1,          }TSTEP
        mov.i   }tim1,          >tim1
cel1    spl     @cel1,          }CSTEP
        mov.i   }cel1,          >cel1
        mov.i   {-FSTEP,        <FSTEP
        mov.i   {cel1,          <ncl1
ncl1    jmp     @ncl1,          >NSTEP

	dat 0,0
	dat 0,0

strat1 stp.ba ploc, logic
       mov dbomb, hide         ; hide stp code to avoid brainwash
       mov dbomb, strat0
       mov dbomb, strat1

; *** Carbonite by Ian Sutton

dbomb   dat     >-1, >1
carbo   spl     #0, <-100
	mov     dbomb, tar-197*3500
tar     add     #197, -1        ; gets bombed to start coreclear
        djn.f   -2, <-1151

end logic

