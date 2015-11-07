;redcode-94
;name DwarfBomb
;author Ben Snitkoff
;stategy Dwarf throwing dwarf
;assert 1

    org main

dwarf:    ADD #12, 2
        SUB #12, 2
        MOV bomb, 6
        MOV bomb, 6
        JMP -4
bomb:    DAT #33, #33


main:    ADD #800, @1
        DAT #0, 8
        MOV dwarf, @-1
        MOV dwarf+1, @-2
        MOV dwarf+2, @-3
        MOV dwarf+3, @-4
        MOV dwarf+4, @-5
        MOV dwarf+5, @-6
        SPL <-6
        JMP main

        end
