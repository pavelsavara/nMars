;redcode-94 test
;name traumatic smurf 
;author bjoern guenzel
;strategy torch t18 with b-clear ( = brainwashing d-clear)
;strategy since I have nothing else at the moment...
;assert 1


shift   equ -3780
step    equ 54
count   equ 2000

sm      mov.i step+1,}step+1    
 dat 0,0
 dat 0,0
sp      spl #-step,1    
loop    sub #2*step,ptr
ptr     mov.i sp, *hit+(step*count)-17228-step-1
 mov sm,@ptr
hit     jmz.b loop,#0
clear   mov.i *bptr,>sm
 djn.f -1,>sm
last    dat 0,0
 dat 0,0
 dat 0,0
 dat #1,bptr-sm+5
bptr    stp.ab >0,#bptr-sm


boot    mov.i {source,{boptr    ;boot clear bombs
 mov.i {source,{boptr

 for 8
 mov.i <source,<boptr   ;boot main loop
 rof

 mov.i sm,@boptr2

 spl @boptr,>1000

boptr   div.f #bptr+1+shift,#last+1+shift
boptr2  div.f #0,#sm+shift

source  dat #bptr+1,#last+1

 for 10
 dat 0,0
 rof

  z     for MAXLENGTH-CURLINE
  spl #z,-z
 rof



 end boot


