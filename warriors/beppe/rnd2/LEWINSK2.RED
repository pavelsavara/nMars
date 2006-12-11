Here is my warrior for part 2, make sure that it looks right the seq.i
line is kinda long.

;redcode-lp
;name Touch
;kill Touch
;author Matt Lewinski
;strategy BDECWT Round 3 limited processes
;strategy 192 point quick scan => Corescan/Clear
;assert 1

start   equ 2*MINDISTANCE
number  equ 96
step    equ (CORESIZE-(start+MAXLENGTH))/((number-3)*2)

org     scan

scan
a for number
          seq.i  $((start)+(2*(a-1)*step))-CURLINE+1 ,$((start+step)+(2*(a-1)*step))-CURLINE+1
          mov.ab $((start)+(2*(a-1)*step))-CURLINE+1 , $kill
rof
          jmp.b  $search    , $0
ptr       dat.f  $100       , $100+11
wipe      mov.i  $kill      , <ptr
          mov.i  >ptr       , >ptr
search    sne.x  >ptr       , >ptr
          jmz.f  $search    , >ptr
          jmp.b  $wipe      , <ptr
kill      dat.f  $2-ptr     , $2-ptr
end
-- 
--------------------------------------------------------------------
Matt Lewinski                            98mlewinski@kamsc.k12.mi.us
Kalamazoo Area                       mlewinsk@newton.kamsc.k12.mi.us
Math & Science Center       http://www.kamsc.k12.mi.us/sp98/mlewinsk
