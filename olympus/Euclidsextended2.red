;redcode
;name Euclid's extended 2
;author Planar
;assert MAXLENGTH >= 11

n       equ     3

        org     start

yx      dat     -n, n          ; y = CORESIZE - n
ab      dat     1, 0
q	dat	0, CORESIZE/n

loop    mov.ab  yx, q         ; (y)
        div.b   yx, q         ; q' = y' / x'
start   mul.ab  ab, q         ; (a*q)
        mov.x   ab, ab        ; (b);   b' = a
        sub.ba  q, ab         ; a' = b - a*q
        mov.x   yx, yx        ; (y);   y' = x
        mod.ab  yx, yx        ; x' = y % x
        jmn.b   loop, yx      ; We're done if x = 0

        end
