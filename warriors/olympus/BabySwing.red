;redcode-icws
;name Baby Swing
;kill Baby Swing
;author Randy Graham
;contact graham@mathcs.rhodes.edu
;NSFCWT round 9
;assert 1
;strategy Another in the Swing family - this time, minimalist coded
;strategy 75% bomb/scan once-thru with spl/spl/perpetual dat core-clear

STEP     equ  12

site1    dat  #0,        #sweep1
site2    dat  #0,        #-STEP

subber   sub  datadd,    cmper
bomber   mov  site2,     @cmper
cmper    cmp  subber-STEP*4-1, @subber-STEP*5-1
starter  jmp  setup,     0
looper   jmp  subber,    0

datadd   dat  #STEP*3,   #STEP*3
setup    add  cmper,     site2
seat     spl  0,         0
newsite  add  #1,        site2
clean    mov  @site1,    @site2
repeat   jmp  newsite,   0
sweep3   dat  #0,        #sweep3-site1
sweep2   spl  -1,        #sweep3-site1
sweep1   spl  -1,        #sweep2-site1

end bomber
