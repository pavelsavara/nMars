;redcode-94
;name The Gray Killer
;author Christian Schmidt
;strategy against stone/paper/imp's a
;strategy small oneshot could give top
;strategy results. Ok, here is a backward
;strategy scanning ssd-oneshot, which is
;strategy a tournament optimized version of
;strategy van Dam's Scanny Boy.
;assert 1

            org     cAdd

cStep       equ     20
cOff        equ     (cAdd-201)

cAdd        add.f   cIncr,   cScan
cScan       sne.i   cOff,    cOff+10
            djn.f   cAdd,    cAdd-(2*cStep)
cIncr       spl.f   #-cStep, >-cStep
            mov.i   @cBomb,  }cScan
            djn.f   -1,      <cScan
cBomb       dat     #8,      #1
            spl     #7,      #-85
            dat     0,       0
   for   (MAXLENGTH-CURLINE)
            spl     #0,      #0
   rof
            end
