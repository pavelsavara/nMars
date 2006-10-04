;redcode-icws verbose
;name  Chris
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSCWT Round 9
;strategy  Minimalist Code Vampire
;assert CORESIZE == 8192
;macro

step equ 3006
clstep equ 3823

boot mov x+7,boot+6512
     mov x+6,boot+6511
     mov x+5,boot+6510
     mov x+4,boot+6509
     mov x+3,boot+499
     mov x+2,boot+498
     mov x+1,boot+497
     mov x  ,boot+496
     mov fang,boot+4327
     mov d  ,boot+2689
     mov h1 ,boot+7331
     mov h2 ,boot+3235
     mov safe,boot+3781
     spl boot+496
     jmp boot+3781

x  spl 0,2731
   mov 4327-497,@4327-497
   add 2689-498,4327-498
   jmp -2,2731

   spl 0,6512-6509+clstep
   mov 2689-6510,@-1
   add #clstep,-2
   jmp -3,2731

fang jmp @7331-6510-step,6510-4327+step
d  dat #-step+4096,#step
h1 dat #2731,#6509-7331
h2 dat #2731,#6509-3235

safe jmp 0,0

for 70
    dat #h2,#2731
rof
