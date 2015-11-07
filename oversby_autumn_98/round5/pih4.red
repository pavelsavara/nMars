;redcode-94
;name ostest2 (r5)
;author M Joonas Pihlaja
;strategy oneshot
;strategy TOA98CT round5:
;strategy Three instances of ostest2(r5) and one copy of
;strategy Memories
;assert 1

        org     booot

gate    equ     (top-2)

top     add.a   #23     ,       gate
        jmz.f   -1      ,       {gate
        add.x   #-2333  ,       gate
clr     spl     #boot-1 ,       <gate
        mov     *clr    ,       }gate
        mov     *clr    ,       }gate
        mov     *clr    ,       }gate
        djn.f   clr+1   ,       <gate
        dat     <2667   ,       <5334
        spl     #clr+8-gate,    6
        spl     #clr+8-gate,    6
boot    dat     0       ,       0


        for     25
        dat     0       ,       0
        dat     0       ,       0
        dat     0       ,       0
        rof


booot   mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        mov     {boot   ,       <dst
        spl     @dst
dst     div.f   #0      ,       #1500

        end
