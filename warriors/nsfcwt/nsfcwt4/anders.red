;redcode-94
;name     SnafSort v0.5
;author   anders scholl
;contact  anders@kamsc.seds.org
;NSFCWT Round 4
;strategy A pritty generic bubble sort (i devised the basic algorithm _before_
;strategy I knew what a bubble sort was....)
;strategy My caffinated stupor is the reason for the icky labels in the delete
;strategy common insctructions function

org       the_start
                                       ;-7997 mirror of hit_flag
                                       ;-7998 "safety" ; copy of l-1
                                       ;-7999 length comparison; hit_flag 
fixer     nop       #1, #-1            ;0 fix for sort_b
echo      slt.b     $3991, 3992        ;1 echo of sort_b (wanna get rid of it)
the_start seq.i     $-3, $4009         ;2 find length of instructions to sort
          jmp       $-1, >-1           ;3 .......
          sub       #4000, $-2         ;4 make 0.b length-1
          mov.b     $-3, $sort_djn     ;5 put length-1 into sort_djn

test_asc  sne       #0, $3994          ;6 if ascending,
          jmp       sort_b             ;7 don't jump to sort_b; do
          add.f     fixer, sort_b      ;8 fix sort_b
          add.f     fixer, echo        ;9 fix echo of sort_b

sort_b    slt.b     $3991, $3992       ;10  if point1.b is l/g than point2.b,
          jmp       test_b             ;11  dont jmp to test_b; do
          mov.i     *-2, $-14          ;12  mov point1 to safety  (x)
          mov.i     @-3, *-3           ;13 mov point2 to point1  (c)
          mov.i     $-16, @-4          ;14 mov safety to point2  (g)
          jmp       snaf_end, >-16     ;15 jmp to switch end; set hit_flag

test_b    seq.b     *sort_b, @sort_b   ;16 if point1.b is equal to point2.b,
          jmp       snaf_end           ;17 don't jmp to snaf_end; do
sort_a    slt.a     *sort_b, @sort_b   ;18 test if point1.a is </> point2.a,
          jmp       snaf_end           ;19 don't jmp to snaf_end; do
          mov       *-10, $-22         ;20 mov point1 to safety  (x)
          mov       @-11, *-11         ;21 mov point2 to point1  (c)
          mov       $-24, @-12         ;22 mov safety to point2  (g)
          jmp       $1, >-24           ;23 flip up hit_flag
snaf_end  nop.f     }sort_b, >sort_b   ;24 incriment points to compare
sort_djn  djn       sort_b, #0         ;25 length has been moved to .b her

go_passp  sne       $-27, $-29         ;26 if hit_flag is hit,
          jmp       del_chck           ;27 don't go to del_checking; do
          mov       $-29, $-31         ;28 fix hit_flag
          mov       echo, sort_b       ;29 fix sort_b
          mov.b     the_start,sort_djn ;30 fix sort_djn
          jmp sort_b                   ;31 make another pass


del_chck  jmz.a     $400, $3968        ;32 if 4000.a is 0, kill proggy, else

          jmz.b     2, $3967           ;33 if ascending,
          mov.x     echo, echo         ;34 fix echo back to descending
          mov.i     echo, sort_b       ;35 fix sort_b
          mov.b     the_start, t_1     ;36 fix up t_1

go        mov.b     t_1, t_2           ;37 part1 of delete like instructions
go_on     sne.i     *sort_b, @sort_b   ;38
          mov.i     $5000, @sort_b     ;39
          nop       >sort_b            ;40
t_2       djn       go_on, #0          ;41
          sub.b     t_1, sort_b        ;42
          nop       }sort_b, >sort_b   ;43
t_1       djn       go, #0             ;44

          add.a     #1, echo           ;45
          mov.i     echo, sort_b       ;46
          mov.b     the_start, splat

lala      sne.i     $435, @sort_b
          sub.a     #1, sort_b
          add       3, sort_b
          mov.i     @sort_b, *sort_b
splat     djn       lala, #0
          dat       1, 1
