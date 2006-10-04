;name  paratrooper2
;author Vincent Li (vli@atom.mpr.ca)
;strategy duplicates imps into core as fast as possible
;strategy added a bomber to the split
;
start   mov     imp, @ptr
        spl     @ptr,0
        mov     return,<ptr
        mov     bomber,<ptr
        spl     @ptr,0
        add     #2125, ptr
        djn     start, count
        jmp     bomber,0
count   DAT     #20
ptr     DAT     #4025
bomber  mov     ptr, <ptr
return  jmp     bomber,0
imp     mov     imp, imp+1
        end     start
