;redcode
;name Dwarf
;author A. K. Dewdney
;strategy Throw DAT bombs around memory, hitting every 4th memory cell.
;strategy This program was presented in the first Corewar article.
bomb  DAT   #0
dwarf ADD   #4,    bomb
      MOV   bomb, @bomb
      JMP   dwarf
      END   dwarf          ; Programs start at the first line unless
                           ; an "END start" pseudo-op appears to indicate
                           ; the first logical instruction.  Also, nothing
                           ; after the END instruction will be assembled.
