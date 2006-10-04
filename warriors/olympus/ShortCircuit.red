;redcode-94
;name Short Circuit
;strategy Get Electric Head to it's Mini-HSA component,
;strategy then beat that & brainwash it so it says active
;strategy Is around 95% wins, 2900 points over 1000 rounds
;strategy good enough?
;author Philip Kendall
;assert CORESIZE==8000
;planar clear,scan,boot,pspace
;Anton's Tournament Round 2

;This warrior has two components: firstly, Paul Kline's Clisson,
;which is used to beat the Core Clear component of Electric Head
;(it gets around 80% wins), and force Electric Head to its Mini-HSA
;component. Then comes the dirty tricks :-)

;The anti-Mini HSA component is a variant on a d-clear: a length 20
;decoy followed by two blanks cells before the d-clear ensures that
;Mini-HSA bombs the decoy, then steps over the actual d-clear. Then,
;Mini-HSA finds more decoy, with my d-clear starting at the end of
;that. As Mini-HSA bombs at 0.67c, but the d-clear moves at c, this
;keeps Mini-HSA in its bombing loop. Therefore the d-clear hits the
;executing body of Mini-HSA before Mini-HSA can do any damage to me.
;The d-clear bomb used is stp.ab #13,#250, which brainwashes
;Electric Head so that it stays on its Mini-HSA component for all
;time. This kills as it is only placed every second instruction, with
;rubbish being left inbetween, which is what Mini-HSA actually
;terminates on.

;The switcher used basically P^2: the first three entries are for
;Clisson, and are used to maintain Short Circuit in exactly the same
;state as Electric Head, until we force the switch to Mini-HSA, at
;which point, Short Circuit changes to the d-clear component and stays
;there (unless brainwashed). The switcher also erases its own pspace
;value, which cut down the number of times I brainwash myself, and
;also throws out a bomb which lands in Mini-HSA's boot routine if
;it is a location which would boot on top of me.

Epspace equ     250     ; Electric Head's pspace cell

; the anti Mini-HSA component
; a dclear and a nasty trick

first
dummy   for     20
	dat.f   10,20
	rof

dCstart equ     13      ; must be congruent to 3 mod 10

	dat.f   0,0     ; these two lines are crucial. Do not change
	dat.f   0,0     ; any field to non-zero under any circumstances!

dPtr    spl.a   (MAXLENGTH-CURLINE),0
dStart  spl.a   #0,>dPtr
dClear  mov.i   dBomb,}dPtr
	djn.f   dClear,}dPtr
	dat.f   0,0
dBomb   stp.ab  #dCstart,#Epspace

; the anti-Core Clear component
; credit for this bit to Paul Kline

cStart    mov.ab #86,66
cClisson  sne    {cWatch1,{cWatch1    ; Clisson to beat fast bombers
	  jmz.f  -1,@64
	  add.a  #3,cWatch1
	  mov    <cWatch1,{cWatch1
	  djn    -1,#5
	  add.a  #1,cWatch1
cWatch1   jmp    -200,cQb+5

cQb       dat    #1 ,-3               ; Clisson's killer
cQ1       spl    #0 ,#0
	  mov    cQb ,<cQ4
cQ4       djn    -1 ,#cQb

w0      equ     cStart          ; Clisson
w1      equ     dStart          ; d-clear

loss_table
init_state
      spl    #0,w0
      spl    #0,w0
      spl    #0,w0
      spl    #3,w1

win_table
tie_table
      spl    #1,w0
      spl    #2,w0
      spl    #3,w1
      spl    #3,w1

PSTATE  EQU 125         ; pspace location containing current state
STATES  EQU 4           ; maximum number of states (for brainwash protection)

;NOTE: state values go from 0 to STATES-1

	dat     0,init_state-state
in      dat     0,loss_table-state
	dat     0,win_table-state
	dat     0,tie_table-state

; bomb so to reduce the chances that Electric Head will
; boot the mini-HSA on top of me

start   mov.i   first,(first+4036+31)

think   ldp.a   #0,in              ; get input value
load    ldp.a   #PSTATE,state      ; load old state
	mod.a   #STATES,state      ; brainwash protection
	add.ba  *in,state          ; select correct state table
store   stp.a   *state,load        ; store new state
	mov.i   first,load         ; prevent me being brainwashed
state   jmp     @0                 ; jump to warrior code

	for     (MAXLENGTH-CURLINE)
	dat.f   10,20
	rof

	end     start
