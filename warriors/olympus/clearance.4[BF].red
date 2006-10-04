;redcode-b
;name clearance .4
;author Charles
;strategy Bombs core every 8 addreses then enters core clear.
;assert CORESIZE==8000

step equ 2376     ; 2376=8*297, will eventually bomb every 8th address

org dwarf

ptr1    dat dwarf, c+100
a3      dat #0, c+2+2
a2      spl #1, c+2+3    ;spl #X, <-Y acts like a split 0.
dwarf   spl #2, <2667    ;slow enemy processes down
ptr     mov dwarf, hit+step
        add #step, ptr
hit     djn -2, <dwarf+2667 ;hit to start core-clear
        mov *ptr1, >ptr1        ; and use the decrement in the b-field
        mov *ptr1, >ptr1        ; as part of an imp gate.
        mov *ptr1, >ptr1        ; > (post-increment) keeps adding 1 to
c       djn.f -3, <4000         ; the b-field of ptr1 to move the bomb
                                ; through core.
        end
