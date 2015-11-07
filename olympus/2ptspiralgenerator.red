;redcode
;name 2 pt spiral generator
;author David Moore
;assert CORESIZE==8000
;can you think of any use for this?

step equ 4001

start
     mov   imp, <ptr
     mov imp-1, <ptr
     mov imp-2, <ptr
     mov imp-3, <ptr
ptr  spl    @0, imp+step
     spl     2,    0
     jmp    -1,    0
     spl imp+step, 0
imp  mov     0, step

end start
