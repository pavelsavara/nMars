;redcode-94
;name Swing
;kill Swing
;Author Randy Graham
;assert 1
;strategy 83.3% bomb/scan with djn stream once-thru then
;strategy multi-pass core clear

        dat.f  #gate-10,  swinger-gate+5
gate    dat.f  #gate-10,  sneer-(STEP*2)-5
dat2    dat.f  #gate-20,  swinger-gate+5
dat1    dat.f  #gate-25,  swinger-gate+5
site2   spl.a  #gate-35,  swinger-gate+5
site    spl.a  #gate-30,  swinger-gate+5

for 4
        dat.f  0,         0
rof

step    dat.f  #-12,      <-2667
spladd  spl.a  <-24,      <-24
adder   sub.f  spladd,    sneer
hitter  mov.i  step,      @sneer
sneer   sne.i  step+STEP*5, *step+STEP*4
subber  sub.f  sweeper,   sneer
sneer2  sne.i  *sneer,    @sneer
looper  djn.f  adder,     <DJNOFF
setup   add.f  sneer,     gate
sweeper spl.a  #-STEP*3,  <-STEP*3
mover   mov.i  @swinger,  >gate
swinger djn.b  mover,     {site

end     hitter
