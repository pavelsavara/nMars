;redcode-94
;name Mr Speculative
;NSFCWT Round 2

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Scan, Carpet Bomb, Faster Core Clear ...
;strategy Written in '94 code
;strategy Submitted to NSFCWT Round 2: 20 October 1995

;assert 1

gap1    equ 39
gap2    equ 36
gap1st  equ 200
multipl equ ((CORESIZE-gap1st)-((CORESIZE-gap1st)%gap1))
first   equ (check+multipl)
        


check   cmp <(first-(gap2*2/3)), <first
        jmp found
        add aim, check
start   mov bomb, @check
        djn check, <-100
found   mov.b check, aim
        jmp loop
bomb    jmp bomb, #-(gap2*1/3)
begin   dat #stun-begin, #begin-aim+1
kill    dat #begin-begin+1, #begin-aim+1
clear   spl #kill-begin+1, begin-aim+1
stun    spl #clear-begin+1, begin-aim+1
loop    mov }begin, <aim
        jmp loop, {begin
aim     dat #-gap1, #-gap1
        
        end start
