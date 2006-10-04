;redcode-x verbose
;name Locusts 2.1
;author Stefan Strack
;strategy Spawn off bombers near enemy code
;strategy Version 2.0: smaller, changed constants
;strategy         2.1: one less non-zero B-field, changed constants
;strategy              rearranged code to evade mod-4 scanners
;strategy Submitted: @date@

DIST    EQU     79  ; (mod 5/11 scan)
OFFSET  EQU     22
BOMB    EQU     20 ; hopefully DAT #0
bombptr EQU     (b1-2)

spawn   ADD     #OFFSET, scanptr
scanptr MOV     b2,   scanptr
        MOV     b1,   <scanptr
        SPL     @scanptr
scan    ADD     #DIST+1,scanptr
        JMZ     scan,   <scanptr
        JMP     spawn
        DAT     #0

b1      MOV     BOMB,   <bombptr
b2      JMP     b1,     <bombptr

        end     scan
