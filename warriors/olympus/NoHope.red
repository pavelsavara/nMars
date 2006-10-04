;redcode
;name No Hope
;author M R Bremer
;strategy be small, bomb core
;nsfcwt round 9
;contact <bremermr@ecn.purdue.edu>
;written in '88 redcode

STEP EQU 3044
b       spl 0, -STEP 
stone   mov STEP-1, @STEP*2-1
        mov b, @-1
        add inc, stone
inc     jmp -3, STEP*2

        dat #0, #0
        dat #0, #0
        dat #0, #0
c       jmp 0, 0
        mov -2, inc
        sub #2731, -1
        jmp -2, 0
l       spl b
        jmp c
end l
