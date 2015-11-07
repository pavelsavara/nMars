;redcode
;name Bubbles
;author John Metcalf
;strategy Put together in 15 minutes, just before the deadline...
;strategy I *will* find time to enter the next round properly
;assert 1
     org psw
psw: ldp.a   #1,    tab
     ldp.a   #0,   1002
     add.a  1001,   tab
     mod.a    #6,   tab
     stp.b  }tab,    #1
tab: jmp      *0,     3
     dat     wr2,     6
     dat     wr1,     3
     dat     wr2,     6
     dat     wr1,     3
     dat     wr2,     6
     dat     wr1,   123
wr1:
step     equ   54
count    equ   2000
gate EQU (sp-7)
for 9
mov }gon,>gon
rof
gon:mov sp,psw-370
jmp psw-370

sp   spl   #-1-step,#-step
in   sub   #step+step,1
msm  mov   sm,*tgt+(step*count)-17228
msp  mov   sp,@msm
tgt  jmz.b in,#0
clr  mov   wipe,>gate
cp   djn.f clr,>gate
wipe dat   <2667,wipe-gate+2
     dat   0,0
sm   mov   step+1,>step+1
wr2:
z for 6
spl 10,{-(1500+z*300)
spl 1,{-(1600+z*300)
mov -1,0
spl 1,{-(1700+z*300)
spl @0,>1196+z*440
mov }-1,>-1
mov 3,<4002
mov {-2,<1
jmp @0,>3132+z*240
dat <3,<0
rof
end
