Hi, here is my round 9 entry. The final one!
Hopefully the strategy isn't too predictable.
It should still be a good all-arounder in any case.

BTW, thanks for your work on koth.c, I've been using it a lot!
(actually a slightly modified version).

- David


;redcode-94 or redcode-lp
;name The Question
;author David Moore
;strategy q^2 or not q^2 ?  A dilemma worthy of Shakespeare.
;strategy in this case I choose faster bootstrap.
;strategy If LP then run Snake Pit else boot a scanner.
;assert 1

org start

sbd equ 4829
cbd equ 2800
vc  equ 4020

vamp   add.f #-2-jb, jb
       mov @0, >jb
       mov ji, }jb
       jmp vamp, 0

     for 3
       dat 0,0
     rof

ji     jmp #1, 1

     for 4
       dat 0,0
     rof

jb     jmp trap-vc, vc

       dat 0,0

wait   mov 1, trap
       jmp {0, }0

     for 9
       dat 0,0
     rof

       mov @0, <-31
       spl #0, 0
       jmp -2, 0
trap   jmp {0, }0

     for 42
       dat 0,0
     rof

scan   mov.b 2, #0+(723*2206)
       mov 4, >-1
       add #-723, #0+(723*2206)
       jmz.f -2, @-1
       jmn -4, * -4
       spl 0, 0
       mov 2, > -9
       djn.f -1, > -10
       dat 0, 13

stone  mov  > 7968, 2727
       add.f  1,  -1
       jmp   -2, < 2726

       dat 0,0

s3     mov dbomb, switch
       jmp cbp+cbd+3, vamp+sbd+0
dbomb  dat 0, wait
       dat 0, vamp+1
start  spl s2, vamp+0
       spl 1, vamp+3
       spl 1, vamp+2
jt     spl 1, vamp+1
       mov }cbp, >cbp
switch jmp @jt, {0
s2     mov stone+0, >3
       mov stone+1, >2
       spl s3,  >-500
       mov stone+2, vamp+sbd
cbp    mov scan, cbd
       jmz vamp+sbd+0, switch

end
