;name 4way
;author David Moore
;strategy hope Joshua plays lots of imp/stones
;assert 1

for MAXPROCESSES==8
               tboot mov    #-18,   tmod - 119
rof

for MAXCYCLES==80001 || (MAXCYCLES==80000 && MAXPROCESSES!=8)
start                mov       d, < hide
                     mov       c, < hide
                     mov       b, < hide
                     mov       a, < hide
               hide  jmp     @ 0,   -2670
                  a  mov      <c,   d + 5 + 70
                  b  add    # 70,   a
                  c  jmz       a,   d + 795
                  d  jmp    2676,   0
rof

for MAXCYCLES==80000 || MAXCYCLES==80001
                     spl       1,   0
rof

for MAXCYCLES==80001 || (MAXCYCLES==80000 && MAXPROCESSES!=8)
                     mov       1,   0
rof

for MAXPROCESSES==8
                     spl   tetra,   0
rof

for MAXCYCLES==80000 || MAXCYCLES==80001
                     spl       1,   0
rof

for MAXCYCLES==80001 || (MAXCYCLES==80000 && MAXPROCESSES!=8)
                     ; paper borrowed from B-Panama V
                     mov      #6,   0
                     mov     <-1,  <1
                     spl      @0,  -3365
                     mov       2,  <-1
                     jmz      -4,  -4
                     dat   <2667,  <5334
end start
rof

for MAXPROCESSES==8

                tmod mov    -119, < -119
                     jmp      -1, < -120

tetra  mov    # 10, # 0
       mov < tetra, < next
       mov < tetra, < next
       mov < tetra, < next
next   sub   #1075,   -2950
       mov < tetra, < next
       mov < tetra, < next
       spl  @ next, < -10
       jmz     @ 0,   tetra

       end tboot

rof

for MAXCYCLES==79999

spl 5, 0
spl 0, <-2700
mov 2, <-10
djn.f -2, <-2702
dat <2667, <5334
spl #0, 0
spl 2+2667, 0
spl 1+5334, 0
mov.i #0, 2667

rof
