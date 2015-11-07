;redcode
;name Euclid's extended 3
;author Planar
;assert MAXLENGTH >= 21

n       equ     3             ; n is assumed relatively prime with CORESIZE

        org     begin

yx      dat     0, n
ab      dat     1, 0          ; The result will be in the A-field.
q       dat     0

begin   mov.a   #-1, yx       ; (-1)
        mul.ba  yx, yx        ; y = -n = CORESIZE-n
        mov.ab  #-1, q        ; (CORESIZE-1)
A       div.b   yx, q         ; (CORESIZE-1)/n == CORESIZE/n
        jmp     start

loop    mov.ab  yx, q         ; (y)
B       div.b   yx, q         ; q' = y' / x'
start   mul.ab  ab, q         ; (a*q)
        sub.b   q, ab         ; a' = b - a*q
        mod.ba  yx, yx        ; x' = y % x
        jmz.a   done, yx      ; We're done if x = 0
        mov.b   yx, q         ; (y)
        div.ab  yx, q         ; q' = y' / x'
        mul.b   ab, q         ; (a*q)
        sub.ba  q, ab         ; a' = b - a*q
        mod.ab  yx, yx        ; x' = y % x
        jmn.b   loop, yx      ; We're done if x = 0
C       mov.ba  ab, ab        ; Put the result into the A field.

done    end
