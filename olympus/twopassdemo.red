;redcode
;name two pass demo
;author dm
;assert 1

gate equ -10
step equ 1252
time equ 1930

stone  spl  0,     <gate+1
       mov  stone, @2
       add #step,   1
       mov  dbomb, <1-(step*time)
       jmp  -3,     0
       mov  1,     <stone-16
dbomb  dat <gate-2,<gate-3

end stone
