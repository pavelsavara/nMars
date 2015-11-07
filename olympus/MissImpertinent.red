;redcode
;name Miss Impertinent
;kill Miss Impertinent
;NSFCWT Round 9

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Written in '88 code.
;strategy Submitted to NSFCWT Round 9: 15th December 1995
;strategy Imp bomber with jumping copy ...
;strategy Unfortunately ran out of time before
;strategy completion so it's just cannon fodder this time ...

;assert CORESIZE > 1000
;assert VERSION >= 80

impGap  equ ((CORESIZE+1)/3)


start   spl launch

fire1   mov bomb1, @fire2
fire2   mov one, @impGap+90
        add bomb2, fire2
        cmp fire1-200, imp
bomb1   jmp @bomb1, #fire1
boot    spl 1
        add one, copy
        mov boot, 0
        mov boot, 0
        spl 1
        mov boot, 0
        spl copy
        sub one, copy
here    mov bomb2, here
        jmp @copy
bomb2   dat #0, #impGap+5
one     dat #1, #1
copy    mov copy, copy+impGap-200
        mov 0, copy
        
        for 30
        dat #0, #0
        rof

launch  mov imp, imp-impGap
        spl imp-impGap
        spl imp+impGap
imp     mov imp, imp+impGap

        end start
