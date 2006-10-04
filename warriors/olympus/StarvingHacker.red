;redcode-94
;name Starving Hacker
;author David Moore
;strategy Score 1 point :-)  Optimized for single-elimination combat.
;assert 1

PLAYER EQU 0

dest equ 2670

;----------------------------------
; bootstrap
;----------------------------------

boot   mov  scan1+0, >away
       mov  scan2+0, >away
       mov  scan2+1, >away
       mov  scan3+0, >away
       mov  scan3+1, >away
       mov  scan3+2, >away
       mov  scan4+0, >away
       mov  scan4+1, >away
       mov  scan4+2, >away
away   jmp boot+dest+3, boot+dest

;----------------------------------
; scanner adapted from Fire and Ice
;----------------------------------

; pre-bootstrap version

scan1  MOV.B  $     2, #  2667

       jmp #0, @0  ; scanned

scan2  MOV.I  $     4, >    -1
       ADD.AB #  -723, # -2170

       jmp #0, 0   ; scanned

scan3  JMZ.F  $    -2, @    -1
       JMN.B  $    -4, *    -4
       SPL.B  #     0, {     0

       jmp #0, #0  ; scanned

scan4  MOV.I  $     2, >    -6

for PLAYER!=1
       JMP.B  $    -1, }     1
rof
for PLAYER==1
       JMP.B  $    -1, {     1
rof
       SPL.B  #     0, $    12

;----------------------------------
; decoy
;----------------------------------

       spl #0, #0  ; scanned
       spl #1, {1
       spl #1, @1
       spl #0, *0  ; scanned
       spl  1, *1
       spl  1, {1
       spl #1,  1
       spl #0, @0  ; scanned
       spl #1, #1
       spl #1, {1
       spl #1, @1
       spl #0, *0  ; scanned
       spl  1, *1
       spl  1, {1
       spl #0,  0  ; scanned
       spl #0, @0
       spl #1, #1
       spl #1, {1
       spl #0, @0  ; scanned
       spl #0, *0
       spl  1, *1
       spl #0,  0  ; scanned
       spl #1, #1
       spl #1, {1
       spl #1, @1
       spl #0, *0  ; scanned
       spl  1, *1
       spl  1, {1
       spl #1,  1
       spl #0, @0  ; scanned
       spl #1, #1
       spl #1,  1
       spl #0, @0  ; scanned
       spl #1, *1
       spl  1, *1
       spl #1, *1
       spl #0, *0  ; scanned
       spl  1, {1
       spl #1,  1
       spl #0, @0  ; scanned
       spl #1, #1
       spl #1, {1
       spl #1, @1
       spl #0, *0  ; scanned
       spl  1, *1
       spl #1, *1
       spl #1, #1
       spl #0, {0  ; scanned
       spl #1, @1
       spl #1, *1
       spl  0, *0  ; scanned
       spl  1, {1
       spl #1,  1
       spl #1, @1
       spl #0, #0  ; scanned
       spl #1, {1
       spl #1, @1
       spl #1, *1
       spl #0, #0  ; scanned
       spl #1, {1
       spl #1, @1
       spl #0, *0  ; scanned
       spl  1, *1
       spl  1, {1
       spl #1,  1
       spl #0, @0  ; scanned
       spl #1, #1
       spl #1, #1
       spl #0, {0  ; scanned
       spl #1, @1
       spl #1, *1
       spl  1, *1
       spl #0, {0  ; scanned
       spl #1,  1
       spl #1, @1
       spl #1,  1
       spl #0, @0  ; scanned
       spl #1, #1

end boot
