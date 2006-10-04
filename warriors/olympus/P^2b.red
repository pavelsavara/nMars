;redcode-94
;name P^2b
;author Anton Marsden
;strategy P-switcher
;assert CORESIZE==8000

PSTATE  EQU 666                 ; pspace location containing current state
STATES  EQU 9                   ; number of states

;T1, T2 and T3 correspond to different states a component can be in.
;In this case, T2 and T3 use the same win/loss/tie table to switch states.

T1 EQU (t1-in)
T2 EQU (t2-in)
T3 EQU (t2-in)

think   ldp.a  #0,in            ; get input value
load    ldp.a  #PSTATE,state    ; load old state
        mod.a  #STATES,state    ; brainwash protection
        add.ba *state,in        ; select correct state table
in      add.ba 0,state
store   stp.a  state,load       ; store new state

state   jmp    }0,T1            ; jump to warrior code
        dat    w1,T2            ; if state.A == 0, the A field of this 
                                ; instruction will be jumped to.
        dat    w1,T3
        dat    w2,T1
        dat    w2,T2
        dat    w2,T3
        dat    w3,T1
        dat    w3,T2
        dat    w3,T3

t2      dat    w1,1     ; loss - add 1 to the state
        dat    0,-1     ; win - subtract 1 from the state
        dat    0,0      ; tie - leave the state as it is
t1      dat    0,1      ; loss - add 1 to the state
        dat    0,0      ; win - leave the state as it is
        dat    0,0      ; tie - leave the state as it is

;Warrior code

w1:     jmp    #1,1
w2:     jmp    #2,2
w3:     jmp    #3,3

END think
