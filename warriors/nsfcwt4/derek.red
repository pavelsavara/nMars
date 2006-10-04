;redcode-94
;name Mister Understudy
;NSFCWT Round 4

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Program to Selection (!) Sort the opposition.
;strategy takes a long time on large input.
;strategy Written in '94 code.
;strategy Submitted to NSFCWT Round 4: 3rd November 1995

;assert CORESIZE > 7000

data    equ (begin+4000)
flag    equ data
first   equ (data+1)
elem    equ (fini+1)
temp    equ (fini+2)

begin
start   mov.a #first-elem, elem
        jmz.b stripon, flag
        mov patch1, check1
        mov patch2, check2
stripon jmz.a sort, flag
        mov patch3, check3
getlast seq @check3, fini
        jmp getlast, >check3
        jmp sort
patch1  slt.a @elem-check1, *elem-check1
patch2  slt.b @elem-check2, *elem-check2
patch3  jmp repS2a-check3, #first-check3
        
repS1   mov.ab elem, elem
        mov.a elem, temp
        jmp testS2, }elem
repS2a  seq.i *elem, @elem
        jmp repS2b
        mov.i <check3, *elem
        mov.i fini, @check3
        jmp testS2
test    sne.b *elem, @elem
check1  slt.a *elem, @elem
        jmp nextS2
        jmp mark   
repS2b   
check2  slt.b *elem, @elem
        jmp test
mark    mov.ab elem, elem
nextS2  add.a #1, elem
testS2  seq.i *elem, fini
check3  jmp repS2b
        mov.a temp, elem
        sne.ab elem, elem
        jmp nextS1
        mov.i *elem, temp
        mov.i @elem, *elem
        mov.i temp, @elem
nextS1  add.a #1, elem
sort
testS1  seq.i *elem, fini
        jmp repS1

fini    end start
