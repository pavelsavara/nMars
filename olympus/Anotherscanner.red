;redcode
;strategy Basic spl/jmp cmp scanner
;strategy with TWO coreclears
;strategy first coreclear spl 0 at offset of 381=8001/(7*3)
;strategy second coreclear dat 0
;strategy Problem : Two lines larger that Charon 8
      add off,1
loc   cmp 1,50
      slt #20,-1
      djn -3,<1499
      mov j,@loc
dec   mov s,<loc
      add new,@dec
      jmz -6,#0
      mov s,7+381
      add #381,0
j     djn @-1,#6900
s     spl 0
new   mov -49,<-48
off   dat <-98,<-98
