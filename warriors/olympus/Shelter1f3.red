;redcode-94
;name Shelter 1f3
;author Ilmari Karonen
;strategy Anton Marsden's tournament round 2 entry:
;strategy  hide from HSA behind a decoy, and catch
;strategy  it with a brainwashing 1c forward clear
;date Jul 31, 1997
;planar clear, pspace
;assert CORESIZE == 8000

PSTATE  equ     250     ; from EH
STATES  equ     10      ; from EH
BWASH   equ     2

hsastep equ     9       ; from EH's mini HSA
proglen equ     7

cend    equ     (cptr+BWASH+2*STATES)

        org     start

decoy   z for   (MAXLENGTH-19)
        spl     #-z, 4000+z
        rof

dgap    dat.f   0, 0    ; next scan will land at dgap+hsastep+1
        dat.f   0, 0    ; or at dgap+hsastep+2
        dat.f   0, 0
cptr    dat.f   0, 0
        dat.f   0, 0
        dat.f   0, 0
        dat.f   0, 0
        dat.f   0, 0
cbmb    dat.f   {1234, {BWASH+2*STATES
cwsh    stp.ba  #250, #BWASH+2*STATES
        dat.f   0, 0    ; this will be scanned
        dat.f   0, 0    ; or this

start   spl     #0, 0
loop    mov.i   cbmb, >cptr
        mov.i   cwsh, >cptr
        mov.i   cwsh, >cptr
        mov.i   cwsh, >cptr
        djn.f   loop, >cptr

        end
