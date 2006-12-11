;name myKindOfSort
;author Paulsson
;strategy Bubble sort, short -> fast (hopefully)
;startegy v3, works (hopefully)
;contact mpn@ifm.liu.se
;NSFCWT Round 4

org start
temp    equ             count-2         ;temporary store
eot             equ             count-1         ;used to get end of data

count   dat             4002,4001       ;counters in bubble sort.

compb1  slt.b   @count-comp1,*count-comp1       
compb2  slt.a   @count-comp2,*count-comp2               

start   jmz.a   start2,count+4000               ;take away equals?
                seq.i   eot,>last
last    jmp             -1,count+4001
                nop             <last
start2  jmz.b   comp,count+4000 ;check if ascending,decending
                mov.i   compb1,comp1
                mov.i   compb2,comp2
comp
comp1   slt.b   *count,@count           ; compare b-field
                jmp             compb
                jmp             change
compb   seq.b   *count,@count           ;compare a-field
                jmp             next,}count
comp2   slt.a   *count,@count           
                jmp             samei

change  mov.i   @count,temp                     ; change place
                mov.i   *count,@count
                mov.i   temp,}count

next    seq.i   eot,*count                      ;increase pointers
                jmp             comp
                mov.ba  count,count
                nop             }count,}count
                seq.i   eot,*count
                jmp             comp,>count
                dat             0
samei   jmz.a   2,count+4000            ; check for equal
                seq.i   @count,*count
                jmp             next,}count
                mov.i   <last,*count
                mov.i   eot,@last
                jmp             next


