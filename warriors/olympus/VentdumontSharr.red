;redcode verbose
;name Vent du mont Sharr
;author Pierre Dak Baillargeon
;strategy   v1.0:   YASB.
;strategy   v2.0:   Mutagenize memory.
;kill Vent du mont Sharr

dist    equ -6883          ; mod 4

coma    spl coma,  <1      ; the poison, the pointer and the core mutagenizer
start   add #dist, coma+1  ; change location
kill    mov @kill, <coma   ; put ennemy in coma (indirection is the key)

        end coma
