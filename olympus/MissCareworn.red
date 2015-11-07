;redcode
;name Miss Careworn
;NSFCWT Round 5

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy B-scan once through core.
;strategy Stun anything found then SPL/DAT coreclear ...
;strategy Written in '88 code.
;strategy ... because I *like* '88 code.
;strategy Submitted to NSFCWT Round 5: 10th November 1995

;assert 1

gap     equ 27
gap1st  equ 100
first   equ (begin-gap1st)

begin   dat #0, #begin-carpet
core    spl 0, #begin-carpet
clear   spl 0, #begin-carpet     
loop    mov @bomb, <carpet
        djn loop, <clear
bomb    dat loop, #core

scan    sub #gap-1, carpet
start
check   jmz scan, <carpet
carpet  mov stun, first
        jmn check, signal
stun    spl clear, #0

        for 40
        dat #0, #0
        rof

signal  dat #1, #1
q       for gap
        dat #q+1, #q+100
        rof

        end start
