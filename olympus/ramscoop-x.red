;redcode-x
;name ramscoop-x
;author Stefan Strack
;strategy Blankets the core with imps
;strategy Submitted: @date@
impstop equ     start-6
i1      equ     imp+4000
i2      equ     imp+2000
i3      equ     imp+1000

start   spl     impgun
bloop   mov     <impstop,<impstop       ;runs at 50%
        jmp     bloop,  <impstop
        jmp     -1,     <0
        jmp     -1,     <0
        jmp     -1,     <0
        jmp     -1,     <0
impgun  mov     imp,    i1
        spl     i1                      ;runs at 25%
        mov     imp,    i2
        spl     i2                      ;runs at 12.5%
        mov     imp,    i3
        spl     i3                      ;runs at 6.25%
imp     mov     imp,    imp+1           ;runs at 3.125%

        end     start
