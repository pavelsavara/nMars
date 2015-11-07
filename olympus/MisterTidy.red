;redcode   

;name Mister Tidy
;NSFCWT Round 3

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Start an SPL/SPL/DAT coreclear ...
;strategy ... If Mr Neat finds me ...
;strategy ... he will start an impgate.
;strategy Written in '94 code.
;strategy Submitted to NSFCWT Round 3: 27 October 1995

;assert 1

gap1    equ 14
signal  equ -117
        

        for gap1-1
        dat 1, 1
        rof

gate    dat -1, -1
        
        for gap1
        dat 0, 0
        rof

entry   mov.i #signal, #ally
next    jmp @entry
begin   dat 0, gate
kill    dat 0, next-check
part2   spl #0, gate-check
stun    spl #0, gate-check
loop    mov.i @bomb, <check
        djn.b loop, <begin
bomb    dat 0, stun
        
ally    spl #0, <gate
        mov.i brick, gate
brick   dat <gate, <gate-2667
check   dat 0, gate-check

        end stun
