;redcode-94
;name P^(1/2)
;author Christian Schmidt
;strategy P-Warrior which uses a P^(1/2) switcher :-)
;strategy this means switch on win
;strategy it runs complementary to Electric Head
;strategy but use only 3 compounds
;strategy <---------------------------------------------->
;strategy <    BLUR 2        ----->    THE CORE CLEAR    >
;strategy <    CARBONITE     ----->    MINI HSA          >
;strategy <    BLUR 2        ----->    MINI PAPER        >
;strategy <    CC PAPER      ----->    CARBONITE         >
;strategy <---------------------------------------------->
;assert CORESIZE==8000


;This was easy done by changing the input value.
;It sounds really good but there is a main problem. The brainwash 
;of the papers. In a good run it scores up to 2550 Pts (1000 fights)
;on a bad run unfortunatly less than 2000 Pts.
;Ok, I'll pray for a better result than in the first round ;-)

;------------------------------------------------------
;---------------------CC-PAPER-------------------------
;------------------------------------------------------

len     EQU     9

fcp     EQU     3039
scp     EQU     2365
tcp     EQU     777

ccb     spl     1,      <-3000
	mov     -1,     0
	mov     -1,     0
	mov     -1,     0

frog    spl     @0,     <fcp-len
	mov     }-1,    >-1
	spl     @0,     <scp
	mov     }-1,    >-1
	spl     @0,     <tcp
	mov     }-1,    >-1
	mov     2,      <-1
	jmp     -1,     <-10
bm      dat     <2667,  <2667*2

;---------------------------------------------------
;--------------P^(1/2)-SWITCHER---------------------
;---------------------------------------------------

dbomb dat    >-1,    >1

in      dat    0, win_table-state  ;<-- changed !!!!!!
	dat    1, loss_table-state ;<------/
	dat    1, tie_table-state

PSTATE  EQU    250       ; pspace location containing current state
STATES  EQU    10        ; maximum number of states (for brainwash protection)
			 ;NOTE: state values go from 0 to STATES-1
w0      EQU    ccb       ; CC PAPER
w1      EQU    scan      ; BLUR 2
w3      EQU    cboot     ; CARBONITE

think   ldp.a  #0,      in         ; get input value
load    ldp.a  #PSTATE, state      ; load old state
	mod.a  #STATES, state      ; brainwash protection
	add.ba *in,     state      ; select correct state table
store   stp.a  *state,  load       ; store new state

win_table
state   jmp    @0,      w0         ; jump to warrior code

init_state;           /----Electric Heads states !!!!!!!!!
      spl    #0,w1  ;w0
      spl    #0,w1  ;w0
      spl    #3,w3  ;w1
      spl    #3,w3  ;w1
      spl    #4,w3  ;w1
      spl    #6,w1  ;w2
      spl    #7,w0  ;w3
      spl    #7,w0  ;w3
      spl    #8,w0  ;w3

tie_table      
      spl    #1,w1  ;w0
      spl    #2,w1  ;w0
      spl    #3,w3  ;w1
      spl    #3,w3  ;w1
      spl    #4,w3  ;w1
      spl    #5,w3  ;w1
      spl    #0,w1  ;w0
      spl    #7,w0  ;w3
      spl    #8,w0  ;w3
      spl    #9,w0  ;w3

loss_table      
      spl    #1,w1  ;w0
      spl    #2,w1  ;w0
      spl    #3,w3  ;w1
      spl    #4,w3  ;w1
      spl    #5,w3  ;w1
      spl    #6,w1  ;w2
      spl    #7,w0  ;w3
      spl    #8,w0  ;w3
      spl    #9,w0  ;w3
      spl    #3,w3  ;w1

;--------------------------------------------------
;------------------CARBONITE++---------------------
;--------------------------------------------------

caway EQU    (-100) 

cboot mov    tar+1,  <cdest
      mov    tar,    <cdest
      mov    tar-1,  <cdest
cdest mov    dbomb,  *caway
      spl    <cdest, <2000
      mov    tar-2,  @cdest
      div.f  #0,     cdest
      spl    #0,     <-1151+3
      mov    197,    tar-197*3500
tar   add.ab {0,     }0    
      djn.f  -2,     <-1151

;------------------------------------------------------
;---------------------BLUR-2---------------------------
;------------------------------------------------------

step    EQU     70
gate    EQU     top

ptr     mov.i  inc+1,   >step 
top     mov.i  inc,     >ptr          
scan    seq.i  2*step+5,2*step
chg     mov.b  scan,    @top
a       add.f  inc,     scan
	djn.b  top,     #800
inc     spl.i  #step,   #step
	mov.i  clr,     >gate
btm     djn.f  -1,      >gate
clr     dat.f  <1,      #clr-gate+2

      END    think


;redcode-94
;name Shelter 1f3
;author Ilmari Karonen
;strategy Anton Marsden's tournament round 2 entry:
;strategy  hide from HSA behind a decoy, and catch
;strategy  it with a brainwashing 1c forward clear
;date Jul 31, 1997
;planar clear, pspace
;assert CORESIZE == 8000

PSTATE  equ     250     ; from EH
STATES  equ     10      ; from EH
BWASH   equ     2

hsastep equ     9       ; from EH's mini HSA
proglen equ     7

cend    equ     (cptr+BWASH+2*STATES)

	org     start

decoy   z for   (MAXLENGTH-19)
	spl     #-z, 4000+z
	rof

dgap    dat.f   0, 0    ; next scan will land at dgap+hsastep+1
	dat.f   0, 0    ; or at dgap+hsastep+2
	dat.f   0, 0
cptr    dat.f   0, 0
	dat.f   0, 0
	dat.f   0, 0
	dat.f   0, 0
	dat.f   0, 0
cbmb    dat.f   {1234, {BWASH+2*STATES
cwsh    stp.ba  #250, #BWASH+2*STATES
	dat.f   0, 0    ; this will be scanned
	dat.f   0, 0    ; or this

start   spl     #0, 0
loop    mov.i   cbmb, >cptr
	mov.i   cwsh, >cptr
	mov.i   cwsh, >cptr
	mov.i   cwsh, >cptr
	djn.f   loop, >cptr

	end
