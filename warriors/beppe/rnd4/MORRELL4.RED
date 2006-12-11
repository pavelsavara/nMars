 
;redcode
;BDECWT Round4
;name Time Vacuum
;author Steven Morrell
;strategy  Imp/d-clear
;assert CORESIZE == 8000
 
for 0

Notes: This is the best I could whip up in ten minutes.  Tested against
Torch, Tornado and Impish.

rof

org start
 
impnum equ 2667
 
clearoff equ (first+3000)
impoff equ (first+1000)
gate equ clear-7

 
first:
start:
   mov imp,impoff
clearp:
   mov clear+2,clearoff+2
   mov {clearp,<clearp
   mov {clearp,<clearp
   spl 1
   spl 1
   spl impdo
   jmp @clearp
clear:
   spl #0,<gate
   mov data-clearoff+clear,}gate
   djn.a -2,}gate
data:
   dat 23,1
imp:
   mov.i #-4,impnum
impdo:
   spl #0,<-20
   add.a #impnum,1
   djn.f impoff-(8*impnum),<-22
 
for 84
   dat 1,1
rof
 
