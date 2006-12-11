;redcode-94m test
;name Blur Copy
;author Robert Macrae
;assert CORESIZE==8000
;strategy 0.5c scan, 0.25c SPL carpet -> D-clear

step  EQU 70; mod-10
gate  EQU top

ptr:  mov.i  inc+1,>step ; New DJN protection... better than a SPL?
top:  mov.i  inc,>ptr    ;                       Or worse?      
scan: seq.i  2*step+5,2*step
chg:  mov.b  scan,@top
a:    add.f  inc,scan
      djn.b  top,#800
inc:  spl.i  #step,#step
      mov.i  clr,>gate
btm:  djn.f  -1,>gate
clr:  dat.f  >5335,#clr-gate+2

      end    scan
