;redcode-94
;name twoOFaKIND
;author Paulsson
;strategy Two scans working side by side to find safe place
;strategy for spl/spl/dat coreclear. 87-91% good enough?
;assert CORESIZE ==8000
;contact mpn@ifm.liu.se
;NSFCWT Round 2


;Scans for non zero fields, when found check if it's the
;white wariors body, place coreclear.

;Two copies of more or less the same program.
;If hit in scan part, that process will die of fast.
;If hit in coreclear before it is copied to the safe place
;a checksum check asures that the other part gets a fair shoot. 

org start
step1   equ             -17
comp1   DAT.F  $   600, $   600
st1             add.ab  #step1,p1       ;scan, step 17.
p1              jmz.f   st1,-101
                jmn.f   #0,<p1          ;Find begining of body. 
                nop             >p1
                seq.f   comp1,@p1       ;check if white warior
                jmp             st1
check1  add.f   >sump1,sum1                     ;calculate checksum
                djn.b   check1,#sumc1-check1
                seq.f   sumc1,sum1
                jmz.f   sum1,sum2       ;sum failed,
                                                        ;if other part running die!
                mov.i   sum1,p2
                add.ab  #5,p1
                mov.i   {p21,<p1        ;move out clear
                djn.b   -1,#6
sump1   jmp             @p1,check1

c21      spl.f   #b11, b21+2            ;core clear
b11      spl     #b21-c21, b21-c21+1
                mov.i   *c21, >c21
                jmp             -1
b31      dat.f   #b31-c21, b21-c21-2
b21      spl     #b31-c21, b21-c21-1
p21             dat             0,0
sumc1   dat     59,121
sum1    dat             0,0
i for 8
                dat 0,0
rof
step2   equ             17
comp2   DAT.F  $   600, $   600
st2             add.ab  #step2,p2               ;second part
p2              jmz.f   st2,p1+100
                jmn.f   #0,<p2
                nop             >p2
                seq.f   comp2,@p2
                jmp             st2
check2  add.f   >sump2,sum2
                djn.b   check2,#sumc2-check2
                seq.f   sumc2,sum2
                jmz.f   sum2,sum1
                mov.i   sum2,p1
                add.ab  #5,p2
                mov.i   {p22,<p2
                djn.b   -1,#6
sump2   jmp             @p2,check2

c22      spl.f   #b12, b22+2
b12      spl     #b22-c22, b22-c22+1
                mov.i   *c22, >c22
                jmp             -1
b32      dat.f   #b32-c22, b22-c22-2
b22      spl     #b32-c22, b22-c22-1
p22             dat             0,0
sumc2   dat     59,-11
sum2    dat             0,0


start   spl             st1+1
                jmp             st2+1
