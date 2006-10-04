;redcode
;name Froggy
;author C. L. Gonsalves
;strategy Will try to jump over attackers approaching from lower memory
;strategy (ie: imps)
dat 0
dat -252
start mov #7, -98
cmp -99, #7
jmp -1
mov @-5, @-4
cmp -6, #12
jmp 4
add #1, -8
add #1, -8
jmp -5
mov #-252, -261
jmp -261

end start
