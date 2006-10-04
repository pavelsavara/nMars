;redcode
;name Euclid's extended
;author Planar
;assert MAXLENGTH >= 15 && CORESIZE >= 16

; To compute the imp step for a given imp number,
; enter the imp number in the following line:

n       equ     3

; The program terminates with gcd (n,CORESIZE) in the a-value at
; address 0.  If this is 1, there is a spiral of size n, and the
; b-value at address 1 is the corresponding step.

; This program works in any core size, and it computes imp steps
; for that core size.

; Use the following cdb macro to display all the (N,S) imp pairs
; with N <= 100 in the current core size.
; imps=@ca z=0~!!~@ca z=z+1~@ed 0~dat z~@g~@0~if a==1~!!~@1~ca z,b~!1~@s~!100
; (and launch pMARS with -r 100)

        org     start

yx      dat     0, n          ; y = CORESIZE = 0
ab      dat     1, 0

done    equ     ab
start   sub.b   yx, q         ; (CORESIZE-n)
        div.b   yx, q         ; ((CORESIZE-n)/n)
        add.ab  #1, q         ; q = (CORESIZE-n)/n+1 = CORESIZE/n
loop    mul.ab  ab, q         ; (a*q)
        mov.x   ab, ab        ; (b);   b' = a
        sub.ba  q, ab         ; a' = b - a*q
        mov.x   yx, yx        ; (y);   y' = x
        sub.ab  yx, yx        ; (y - x)
        mod.ab  yx, yx        ; x' = (y-x) % x = y % x
        jmz.b   done, yx      ; We're done if x = 0
        mov.ab  yx, q         ; (y)
        div.b   yx, q         ; q' = y' / x'
        jmp     loop

q       end
