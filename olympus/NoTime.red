;redcode-lp
;name No Time
;author Ilmari Karonen
;strategy Enough ideas this time, but barely an hour left.
;strategy Pleeeease don't put deadlines on Fridays..
;strategy especially not when it's my exam week. :-(
;assert CORESIZE == 8000
;planar boot, scan

; Round two entry. No time for comments.
; At least I'll get a few points, I hope.

        org     start

ptr     dat     0, 4000
        dat     >2667, >10      ; why not?

        z for   5
        dat     0, 0
        rof

clear   mov.i   ptr+1, >ptr
        jmp     {0, }0

        z for   MAXLENGTH-CURLINE-2
        dat     0, 0
        rof

start   spl     0, <1
        jmp     clear, <666

datz    end

