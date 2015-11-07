;redcode
;name Dwarf
;author A. K. Dewdney
bomblen:        equ     progend - bomb
bomb:   dat     #0
start:  add     #bomblen,bomb
        mov     bomb,@bomb
        jmp     start
progend:
        end     start
