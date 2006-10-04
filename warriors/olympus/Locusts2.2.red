;redcode
;name Locusts 2.2
;author Stefan Strack
;strategy Spawn off bombers near enemy code
;strategy Version 2.0: smaller, changed constants
;strategy         2.1: one less non-zero B-field, changed constants
;strategy              rearranged code to evade mod-4 scanners
;strategy         2.2: copies bombers farther ahead of enemy
;strategy Submitted: @date@

DIST    EQU     79  ; scan increment (mod 5/11 scan)
OFFSET  EQU     110 ; bomber starts that far ahead of enemy
BOMB    EQU     20  ; hopefully DAT #0
bombptr EQU     (b1-2)

spawn   ADD     #OFFSET,scanptr     ; copy bomber OFFSET addresses ahead
scanptr MOV     b2,     scanptr     ; of non-zero B-field address
        MOV     b1,     <scanptr
        SPL     @scanptr            ; and start it up
scan    ADD     #DIST,  scanptr     ; start here: scan for non-zero B-field
        JMZ     scan,   <scanptr
        JMP     spawn               ; found
        DAT     #0                  ; spacing to fool mod-4 scanners

; ----- The Bomber
b1      MOV     BOMB,   <bombptr
b2      JMP     b1,     <bombptr

        END     scan
