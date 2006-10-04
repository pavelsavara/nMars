;        ACHILLE Soft
;          presents
;
;            KILI
;
;        developed by
;      Botta Francesco
;   & Gramenzi Pieramato
;
start      mov     w1,          @-2304
           mov     w1,          @-2817
           mov     w1,          @-3330
           mov     w1,          @-3843
           mov     w1,          @-4356
           mov     w1,          @-4869
           mov     w1,          @-5382
           mov   #-2,             j
a          jmn   < 0,           @ uno
b          jmn   < 0,           @ due
c          jmn   < 0,           @ tre
d          jmn   < 0,           @ quattro
           djn     a,             cont
           jmp     escape
cont       dat                    25
c1         mov   @ a,             tar
           add     a,             tar
           jmp     copia
c2         mov   @ b,             tar
           add     b,             tar
           jmp     copia
c3         mov   @ c,             tar
           add     c,             tar
           jmp     copia
c4         mov   @ d,             tar
           add     d,             tar
copia      add   # 50,            tar
           mov     20,          < tar
           mov     18,          < tar
           mov     16,          < tar
           mov     14,          < tar
           mov     12,          < tar
           mov     10,          < tar
           mov     8,           < tar
           mov     6,           < tar
           mov     4,           < tar
           mov     2,           < tar
           jmp   @ tar
fire       mov   @ w1,          < pun
           mov   @ w2,          < pun
           djn     fire,          pun
           dat                   -9
pun        dat                   -9
w2         dat                    2
           dat                   -2
me         spl                    me
w1         dat                    1
j          jmp    -1
tar        dat                    4096
escape     mov   #-27,            j1
           mov   # 20,            j2
           mov   # 741,           conta
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           mov     21,            4096
           jmp     4086
           jmp     v
v          djn     piu,           quanti
           mov     quanti,        piu
quanti     dat                    64
piu        spl                    v
           mov     targ,        < targ
conta      jmp     piu
j2         jmp   @ 0
j1         jmp   @ 0
scan       mov     j1,          @ j2
           mov     j2,          < j1
           add   # 11,            j2
           sub   # 10,            j1
           djn     scan,          conta
k          mov     w3,          < dove
           djn     k,             dove
w3         dat                   -5
dove       dat                   -17
targ       dat                    768
           jmn     c1,            2460
           jmn     c1,            2496
           jmn     c1,            2532
           jmn     c1,            2568
           jmn     c1,            2604
           jmn     c1,            2640
           jmn     c1,            2676
           jmn     c1,            2712
           jmn     c1,            2748
           jmn     c1,            2784
           jmn     c1,            2820
           jmn     c1,            2856
           jmn     c1,            2892
           jmn     c1,            2928
           jmn     c1,            2964
           jmn     c1,            3000
           jmn     c1,            3036
           jmn     c1,            3072
           jmn     c1,            3108
           jmn     c1,            3144
           jmn     c1,            3180
           jmn     c1,            3216
           jmn     c1,            3252
           jmn     c1,            3288
           jmn     c1,            3324
uno        jmn     c2,            3360
           jmn     c2,            3396
           jmn     c2,            3432
           jmn     c2,            3468
           jmn     c2,            3504
           jmn     c2,            3540
           jmn     c2,            3576
           jmn     c2,            3612
           jmn     c2,            3648
           jmn     c2,            3684
           jmn     c2,            3720
           jmn     c2,            3756
           jmn     c2,            3792
           jmn     c2,            3828
           jmn     c2,            3864
           jmn     c2,            3900
           jmn     c2,            3936
           jmn     c2,            3972
           jmn     c2,            4008
           jmn     c2,            4044
           jmn     c2,            4080
           jmn     c2,            4116
           jmn     c2,            4152
           jmn     c2,            4188
           jmn     c2,            4224
due        jmn     c3,            4260
           jmn     c3,            4296
           jmn     c3,            4332
           jmn     c3,            4368
           jmn     c3,            4404
           jmn     c3,            4440
           jmn     c3,            4476
           jmn     c3,            4512
           jmn     c3,            4548
           jmn     c3,            4584
           jmn     c3,            4620
           jmn     c3,            4656
           jmn     c3,            4692
           jmn     c3,            4728
           jmn     c3,            4764
           jmn     c3,            4800
           jmn     c3,            4836
           jmn     c3,            4872
           jmn     c3,            4908
           jmn     c3,            4944
           jmn     c3,            4980
           jmn     c3,            5016
           jmn     c3,            5052
           jmn     c3,            5088
           jmn     c3,            5124
tre        jmn     c4,            5160
           jmn     c4,            5196
           jmn     c4,            5232
           jmn     c4,            5268
           jmn     c4,            5304
           jmn     c4,            5340
           jmn     c4,            5376
           jmn     c4,            5412
           jmn     c4,            5448
           jmn     c4,            5484
           jmn     c4,            5520
           jmn     c4,            5556
           jmn     c4,            5592
           jmn     c4,            5628
           jmn     c4,            5664
           jmn     c4,            5700
           jmn     c4,            5736
           jmn     c4,            5772
           jmn     c4,            5808
           jmn     c4,            5844
           jmn     c4,            5880
           jmn     c4,            5916
           jmn     c4,            5952
           jmn     c4,            5988
           jmn     c4,            6024
quattro    dat                    6060
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    2
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           dat                    0
           end     start


