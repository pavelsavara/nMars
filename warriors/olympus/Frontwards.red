;redcode-94
;name  Frontwards
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSCWT Round 5
;assert VERSION>=80

;strategy  No time for a new warrior this week.
;strategy  But I bet this would score better than my sort algorithm
;strategy  from last week!
;strategy  And I will win round 6.

step equ 12
offset equ 608
stream equ cc-806
first equ (cc-offset+203)
gate equ -50

org boot

      stp #1,{1
for 17
      stp #1,}1
      stp.b #1,{1
      stp #1,{1
rof
      stp #1,}1

p     dat #first,{first+step
      dat #30,{-1
      stp.b #30,{-2
cc    spl #30,stream-660

      stp #1,{1
      stp #1,}1
      stp.b #1,{1

boot  mov top+5,top+offset+5
for 5
      mov {boot,<boot
rof
boot2 mov cc,cc+offset
for 3
      mov {boot2,<boot2
rof
      jmp x+offset

      stp.b #1,{1
      stp #1,{1
      stp #1,}1
      stp.b #1,{1
      stp #1,{1
      
top   sub x,@x
x     sne *p,@p
      djn.f -2,<stream
      spl #0,<p
      mov @1,}p
      djn -1,<cc

for 6
      stp #1,}1
      stp.b #1,{1
      stp #1,{1
rof
      
end
