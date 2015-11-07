;redcode
;name Rostov
;author WFB
;strategy For the Oversby Tournament Round 2.
;strategy Ahh!  What to do?  Scanning, q-scan, maybe...
;strategy But how do you kill them?
;strategy Hmm...well, this is a worthless dwarf, which jumps down to a
;strategy core clear (kinda...) if it's hit (sometimes...).
;assert CORESIZE==800
start
mov.f -4,{-4
mov.x <-5,{-5
add.f -1,-2
jmn -3,-3
jmp clear,>-4
for 12
dat $0,$0
rof
clear
mov.a 0,{-100
djn -1,<-108
spl 0,{-156
end start
