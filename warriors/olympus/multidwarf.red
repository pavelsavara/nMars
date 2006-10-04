;redcode verbose
;name multidwarf
;author Vincent Li (vli@atom.mpr.ca)
;strategy many dwarfs working together
;strategy credits to Nandor Sieban for insights
;
start   mov     ptr,<dst
        mov     bomber,<dst
dst     spl     @dst,#3044
        add     #3044, dst
        jmp     start,0
bomber  mov     bomb, <ptr
ptr     jmp     bomber,#-2
bomb    dat     #0
        end     start
