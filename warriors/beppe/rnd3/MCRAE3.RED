;redcode
;name dead end
;author nandor sieben
;strategy  different living deads and start system
;assert 1

; My strategy for this round assumed I'm most likely to face
; a scanner or an imp/stone with a paper and "other" less likely.
; This suggested a Vampire (actually, '88 always suggests vampires
; to me; no Silks :) but huge quantities of TLC have not produced
; a vamp capable of beating Sphinx and Iron Gate... yet.

; Testing did, however, show that living deads were up to the job
; and I've no time left for tuning, so this appears in original form.

dist    equ    8000/9
start   MOV     dead , dead+dist     ; copy a living dead
        MOV   living , <start
        MOV   return , <start
s2      MOV     dead , dead+2*dist
        MOV   living , <s2
        MOV   return , <s2
s3      MOV     dead , dead+3*dist
        MOV   living , <s3
        MOV   return , <s3
s4      MOV     dead , dead+4*dist
        MOV   living , <s4
        MOV   return , <s4
s5      MOV     dead , dead+5*dist
        MOV   living , <s5
        MOV   return , <s5
s6      MOV     dead , dead+6*dist
        MOV   living , <s6
        MOV   return , <s6
s7      MOV     dead , dead+7*dist
        MOV   living , <s7
        MOV   return , <s7
s8      MOV     dead , dead+8*dist
        MOV   living , <s8
        MOV   return , <s8
j0      spl     j2
j1      spl     j4
j3      spl     j8
j7      jmp     @start          ; start them
j2      spl     j6
j5      spl     j12
j11     jmp     @s2
j4      spl     j10
j9      jmp     @s3
j6      spl     j14
j13     jmp     @s4
j8      jmp     @s5
ptr     dat     #0
        dat     #0 
j10     jmp     @s6
j12     jmp     @s7
j14     spl     @s8

return  SPL     0    , <ptr
living  MOV     ptr  , <ptr
dead    djn     return , <ptr
        END     start

-- 
Regards,

Robert Macrae

