;redcode-94
;name BlackMoor
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 6
;strategy round 7 entry
;
;Plan is to boot a bomber out there and adjust the boot distance
;until I start winning.  Eventually I should catch opponent early
;enough no matter what he is doing.

bootp    equ  (result+1425)
step     equ  239

         org  result
starter  dat    4000+10,4000+15
     for 200
         dat    4000+ender/2,4000
         dat    4000,4000+ender/2
     rof
result   ldp.ab #0  ,#0
adjust   ldp.ab #140,#0
         seq    #1,result
         add    #1,adjust
         mov    #5*63,bootp
         stp.ba adjust,adjust
         mul.b  adjust,bootp
         spl    1,4001
         mov    <bootf,<bootp
         mov    <bootf,<bootp
         mov    <bootf,<bootp
         mov    <bootf,<bootp
bootf    djn    @bootp,stone+8
         dat    4000,4005
stone    mov    bomb,@1
         mov    bomb,*3+step
         add    #2*step,-1
         djn    stone,#900
         spl    #4001,#4005
         mov    2,}stone
bomb     mov    step,1
     for 38
         dat    4000+ender/2,4000
         dat    4000,4000+ender/2
     rof
ender    dat    3998,4000-490

         end
