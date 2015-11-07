;redcode-94
;name Dodger
;author M R Bremer
;start 100% of c forward linear scan with imp advance detection
;strat followed by a d-clear dodger.  i'm going to let it play
;strat in all areans.
;assert 1

first   sne.i }ptr, -12           ; -12 is the imp detector
        jmz.f first, }ptr
        add.a #2, ptr
        mov.i {gate, {ptr
        djn.b -1, #4
ptr     spl 2234, {ptr 
        mov.i gate, {ptr
        dat {ptr, {ptr
gate    dat bomb+1, 20
        spl #0, >-2
        mov.i bomb, >-3
        djn.f -1, >-4
bomb    dat <2667, 9
