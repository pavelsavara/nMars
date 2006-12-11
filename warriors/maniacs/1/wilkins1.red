;redcode-94
;author JKW
;name test 
;assert (MAXLENGTH == 50) && (CORESIZE == 8000)
;contact jkw@koth.org
; Hopefully qscans won't be a problem...

org start

w0 equ scan
w1 equ boot

step EQU 70; mod-10
gate EQU top

ptr:  mov.i  inc+1,>step ; New DJN protection... better than a SPL?
top:  mov.i  inc,>ptr    ;                       Or worse?
scan: seq.i  2*step+5,2*step+0
chg:  mov.b  scan,@top
a:    add.f  inc,scan
      djn.b  top,#800
inc:  spl.i  #step,#step
      mov.i  clr,>gate
btm:  djn.f  -1,>gate
clr:  dat.f  <1,#clr-gate+2

        dat     0,      0
        dat     0,      0
        dat     0,      0
        dat     0,      0
        dat     0,      3

in      dat     0,      loss_table-state
boot    spl     1,      win_table-state
        spl     1,      tie_table-state
        ; 7 processes replace 9 in CCPaper
        ; for cost of extra Mov in launcher.
        mov -1, 0

len     EQU 9
fcp     EQU 3039
scp     EQU 2365
tcp     EQU 777

frog    spl @0,         <fcp-len
        mov }-1,        >-1
        mov }-2,        >-2
        spl @0,         <scp
        mov }-1,        >-1
        spl @0,         <tcp
        mov }-1,        >-1
y       mov 2,          <-fcp+len+1   ; Wipe uncle.
        jmp -1,         <-10
        dat <2667,      <2667*2

start
think ldp.a  #0,in              ; get input value
load  ldp.a  #PSTATE,state      ; load old state
      mod.a  #STATES,state      ; brainwash protection
      add.ba *in,state          ; select correct state table
store stp.a  *state,load        ; store new state

win_table
tie_table      
state jmp    @0,w0      ; 0 hsa
      spl    #0,w0      ; 1
      spl    #1,w0      ; 2
      spl    #2,w0      ; 3

      spl    #4,w1      ; 4 carbon
      spl    #4,w1      ; 5
      spl    #5,w1      ; 6
      spl    #6,w1      ; 7
loss_table      
      spl    #1,w0      ; 0
      spl    #2,w0      ; 1
      spl    #3,w0      ; 2
      spl    #7,w1      ; 3

      spl    #5,w1      ; 4
      spl    #6,w1      ; 5
      spl    #7,w1      ; 6
      spl    #3,w0      ; 7

PSTATE EQU 250 ; pspace location containing current state
STATES EQU 8  ; maximum number of states (for brainwash protection)


