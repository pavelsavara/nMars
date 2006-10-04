impsz     equ     1143
points    equ     7
pStart    spl     1      ; create (points+1)/2 processes
          spl     1
pump      spl     #impsz*2,#impsz*2
          add     pump    ,jmp2
jmp1      spl     @jmp2
jmp2      jmp     imp-impsz*(points+1)*2,imp+impsz-impsz*(points+1)*2
imp       mov.i   #impsz,*0
