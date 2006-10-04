;redcode-b
;Name Cmp-Hunter
;Author Randy W. Graham
;assert 1

OPT     equ     44              ;mod 4
LEN     equ     (fini-adder)
DIFF    equ     13
BOMBS   equ     DIFF+setup-adder

adder   add.f   spltrap,        cmper           ;increment pointers
cmper   cmp.i   adder-DIFF-OPT, adder-OPT       ;small scan distance
        slt.ab  #LEN+BOMBS,     cmper   ;don't bomb ourself unless @adder
        djn.i   adder,  <-381   ;need to check -381 for better value
setup   mov.ab  #BOMBS, traps   ;set up djn line
        mov.i   spltrap,        }cmper  ;bomb a-field
traps   djn.b   -1,     #0
        sub.a   #BOMBS, cmper   ;reset scan line a-field
        jmz.i   adder,  adder-1 ;fall out when we bomb ourself
spltrap spl.a   #0-OPT, <0-OPT  ;here and datadd after sweep make gate
dosweep mov.i   1,      <traps
datadd  dat.f   <-1-OPT,        <-1-OPT+2667
fini    end     cmper
