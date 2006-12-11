;redcode-b
;name Hammermill 4.0
;kill Hammermill
;author Matt Lewinski
;strategy BDECWT Round 4 Multiwarrior
;strategy q^2 => Replicator
;strategy not sure how much the q^2 helps in multi, but left it on
;strategy anyway.
;assert CORESIZE==8000

org     start

boota   spl.b   $1          , <1000
        spl.b   $1          , <1500
        mov.i   $-1         , $0
pbomba  equ     1180
rangea  equ     4260
milla   spl.b   $rangea     , $0
        mov.i   >-1         , }-1
        mov.i   $hammera    , >pbomba
        mov.i   $hammera    , }pbomba
        add.a   #50         , milla
        jmp.b   $milla      , <milla
hammera dat.f   <2667       , <5334

qb      equ (start+400)
qs      equ 200
qd      equ 100
count   equ 6
gap     equ 15
rep     equ 6

        dat.f   $10*qs      , $2*qs
table   dat.f   $4*qs       , $1*qs
        dat.f   $23*qs      , $3*qs
qbomb   dat.f   $-200       , $gap  ;jmp.f $-200, $gap
qinc    dat.f   $gap        , $-gap
tab     add.a   $table      , $table
slow    add.ab  @tab        , $fnd
fast    add.b   *tab        , @slow
which   sne.i   $datz       , @fnd
        add.ab  #qd         , $fnd
        mov.i   $qbomb      , @fnd
fnd     mov.i   $-gap/2     , @qb
        add.ba  $fnd        , $fnd
        mov.i   $qbomb      , *fnd
        add.f   $qinc       , $fnd
        mov.i   $qbomb      , @fnd
        djn.b   $-3         , #rep
        jmp.b   $paper      , }-300
start   seq.i   $qb+qs*0    , $qb+qs*0+qd
        jmp.b   $which      , }qs*13
        seq.i   $qb+qs*1    , $qb+qs*1+qd
        jmp.b   $fast       , }qb+qs*1+qd/2
        seq.i   $qb+qs*2    , $qb+qs*2+qd
        jmp.b   $fast       , {tab
        seq.i   $qb+qs*3    , $qb+qs*3+qd
        jmp.b   $fast       , }tab
        seq.i   $qb+qs*13   , $qb+qs*13+qd
        jmp.b   $fast       , {fast
        seq.i   $qb+qs*4    , $qb+qs*4+qd
        jmp.b   >fast       , }qb+qs*4+qd/2
        seq.i   $qb+qs*5    , $qb+qs*5+qd
        jmp.b   $slow       , }qb+qs*5+qd/2
        seq.i   $qb+qs*6    , $qb+qs*6+qd
        jmp.b   $slow       , {tab
        seq.i   $qb+qs*7    , $qb+qs*7+qd
        jmp.b   $slow       , }tab
        seq.i   $qb+qs*10   , $qb+qs*10+qd
        jmp.b   >fast       , <tab
        seq.i   $qb+qs*11   , $qb+qs*11+qd
        jmp.b   $slow       , <tab
        seq.i   $qb+qs*12   , $qb+qs*12+qd
        djn.f   $slow       , $tab
        seq.i   $qb+qs*23   , $qb+qs*23+qd
        jmp.b   >fast       , >tab
        seq.i   $qb+qs*24   , $qb+qs*24+qd
        jmp.b   $slow       , >tab
        seq.i   $qb+qs*17   , $qb+qs*17+qd
        jmp.b   $slow       , {fast
        seq.i   $qb+qs*8    , $qb+qs*8+qd
        jmp.b   <fast       , }qb+qs*8+qd/2
        seq.i   $qb+qs*9    , $qb+qs*9+qd
        jmp.b   $tab        , }qb+qs*9+qd/2
        seq.i   $qb+qs*15   , $qb+qs*15+qd
        jmp.b   $tab        , <tab
        seq.i   $qb+qs*16   , $qb+qs*16+qd
        jmp.b   $tab        , {tab
        seq.i   $qb+qs*20   , $qb+qs*20+qd
        djn.f   <fast       , $tab
        seq.i   $qb+qs*21   , $qb+qs*21+qd
        jmp.b   $tab        , {fast
        seq.i   $qb+qs*22   , $qb+qs*22+qd
        djn.f   $tab        , $tab
        seq.i   $qb+qs*27   , $qb+qs*27+qd
        jmp.b   <fast       , >tab
        seq.i   $qb+qs*28   , $qb+qs*28+qd
        jmp.b   $tab        , >tab
        seq.i   $qb+qs*30   , $qb+qs*30+qd
        jmp.b   $tab        , }tab

paper   spl.b   $boota      , <500

pbomb   equ     780
range   equ     2860
boot    spl.b   $1          , <1000
        spl.b   $1          , <1500
        mov.i   $-1         , $0
mill    spl.b   $range      , $0
        mov.i   >-1         , }-1
        mov.i   $hammer     , >pbomb
        mov.i   $hammer     , }pbomb
        add.a   #50         , $mill
        jmp.b   $mill       , <mill
hammer  dat.f   <2667       , <5334

datz    dat     $0          , $0 
                end
-- 
--------------------------------------------------------------------
Matt Lewinski                            98mlewinski@kamsc.k12.mi.us
Kalamazoo Area                       mlewinsk@newton.kamsc.k12.mi.us
Math & Science Center       http://www.kamsc.k12.mi.us/sp98/mlewinsk
