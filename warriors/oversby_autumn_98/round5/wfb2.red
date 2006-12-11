;redcode-b test
;name ImpToad3
;author WFB
;strategy paper/imp
;assert CORESIZE==8000

start   spl csnot
        spl cs2
cs      spl   #0
        spl   imp+5334
        spl   imp+2667
imp     mov.i #2667 ,*0
for 77
dat 0,0
rof
csnot   spl 1,<-200
        spl 1,<-400
        spl 1,<-800
s1      spl @0,}1100 ;experimenting with values-original is 1100
        mov }-1,>-1   
s2      spl @0,{1870 ;original value is 1870
        mov }-1,>-1
        mov snot,<88 ;88
s3      mov {-3,<1
        spl @0,}-639 ;-639
        mov 2,<-2
        jmp -1,<-13
snot    dat <1,<1
cs2     spl   #0
        spl   imp2+5334
        spl   imp2+2667
imp2    mov.i #2667 ,*0

end start
