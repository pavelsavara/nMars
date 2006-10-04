;redcode-b
;name Kobald Killer
;author Simon Wainwright
;assert 1
;strategy My entry for RMT's WIN WIN WIN round.
;strategy not enough time and no simulator to test with - hence:
;strategy  Pswitcher by Brett G
;strategy   Imp Ring by John M
;strategy   Sad Silk by Me
;strategy Sad Bomber by Me (-:
st:
ldp #0,st-1000
ldp #99,st-2000
slt st-2000,#4000
add #3,p
add st-1000,p
add @p,st-2000
stp st-2000,#99
slt #4000,st-2000
p:jmp two,tab
qio:spl 1,<-3000
spl 1,<-4000
spl 1,<-5000
pap:spl 1800,0
mov >-1,}-1
add.a #19,-2
mov b1,>b1+1004
mov b2,>b2+2003
jmp -5,<-5
b1:dat <2667,>2667*2
b2:mov 0,10
two:
spl imp,<-1000
mov bomb,@bomb
mov bomb,*bomb
add qff,bomb
jmp -3
bomb:dat >-1+4*911,<-3+8*911
qff:dat 8*911,8*911
imp:
mov i2,i2+2667
mov i2,i2+2667*2
spl 1,<-500
mov 1,0
spl 1,<-800
jmp @vect,{0
dat i2+2667*2
dat i2+2667
dat i2
dat i1+2667*2
dat i1+2667
vect:dat i1
i2:mov.i #-3,2668
mov.i #-3,2668
dat 0,0
mov.i #2667,}0
i1:mov.i #2667,}0
 
dat #0
tab:dat #-40
dat #40
dat #-35
dat #40
dat #-40
dat #35
;a draws is as good as a loss in this round but we slightly
;prefer a draw because the opponent scores less (-:
end
