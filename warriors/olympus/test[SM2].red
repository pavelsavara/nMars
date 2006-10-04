;redcode-94 verbose
;name  test
;author  Steven Morrell
;strategy  Score low.
;strategy  Sort of a Nimbus rip-off.

org boot

step equ 381
impoff equ 7015+2667
ccoff equ 7000

for 57
  stp #0,<cc-50
rof

cc dat -1,8
   spl #-3825,340
   spl #334,-573
   mov @1,>-5
   djn.f -1,{-2

imp mov.i #step,*0

boot mov imp,cc+impoff
     mov cc+4,cc+ccoff+4
     mov {-1,<-1
     mov {-2,<-2
     mov {-3,<-3
     mov {-4,<-4
     spl 1
     mov -1,0
     spl 1
     spl 1
     spl 1
     spl <0,last+1
     jmp @last,{0
     jmp cc+ccoff+4,cc+ccoff+3
     jmp cc+impoff+step*45,cc+impoff+step*44
     jmp cc+impoff+step*43,cc+impoff+step*42
     jmp cc+impoff+step*41,cc+impoff+step*40
     jmp cc+impoff+step*39,cc+impoff+step*38
     jmp cc+impoff+step*37,cc+impoff+step*36
     jmp cc+impoff+step*35,cc+impoff+step*34
     jmp cc+impoff+step*33,cc+impoff+step*32
     jmp cc+impoff+step*31,cc+impoff+step*30
     jmp cc+impoff+step*29,cc+impoff+step*28
     jmp cc+impoff+step*27,cc+impoff+step*26
     jmp cc+impoff+step*25,cc+impoff+step*24
     jmp cc+impoff+step*23,cc+impoff+step*22
     jmp cc+impoff+step*21,cc+impoff+step*20
     jmp cc+impoff+step*19,cc+impoff+step*18
     jmp cc+impoff+step*17,cc+impoff+step*16
     jmp cc+impoff+step*15,cc+impoff+step*14
     jmp cc+impoff+step*13,cc+impoff+step*12
     jmp cc+impoff+step*11,cc+impoff+step*10
     jmp cc+impoff+step*9,cc+impoff+step*8
     jmp cc+impoff+step*7,cc+impoff+step*6
     jmp cc+impoff+step*5,cc+impoff+step*4
     jmp cc+impoff+step*3,cc+impoff+step*2
last jmp cc+impoff+step,cc+impoff 

end
