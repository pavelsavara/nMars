;redcode
;name Give it a Proper Name
;author M Joonas Pihlaja
;strategy p-space: scanner, paper
;assert (CORESIZE==8001) && (PROCESSLIMIT==64)
load0
z for 0
  rof


        org     think

; switch on loss, fixed state on tie

state   equ     (load0+220)                     ; grab some dat 0,0's in core


think   ldp     }state  ,       state
        ldp.ab  state   ,       @state
        stp.a   @state  ,       <state+1
        jmn.b   zboot   ,       @state+1



; the killer bees paper with new constants to back up the scanner.
d1      equ     4839
d2      equ     1157
d3      equ     6538


paper  spl   1, >5917
       mov.i 1, #1
       spl   1, {4575

       mov <1, {1
       spl d1+6, 7

       spl @0, <d2
       mov }-1, >-1
       mov   3, >-2
       mov {-3, {1
       jmz.a d3, *0
       dat 1, 1
       dat 1, 1



z for   20
        dat     0,0
  rof




z for 18
        dat     0,0
  rof


; Irongate for CORESIZE==8001 and a minor -94 improvements.
DIST    equ     71
zgate   equ     (scan-4)

        add     bspl    ,       scan
scan    cmp     DIST-1  ,       -1
        slt     #12     ,       scan
        djn     -3      ,       <-3500
        mov     bjmp    ,       @scan
        mov     bspl    ,       <scan       
        add     res     ,       scan
        jmz.f   scan    ,       scan-2
bspl    spl     #2*DIST ,       <2*DIST
        mov     2       ,       >zgate
bjmp    jmp     -1      ,       }zgate
res     dat     <DIST   ,       <DIST+1



z for 20
        dat     0,0
  rof

; boot the scanner
zboot   mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
        mov     {zsrc   ,       {zdst
zdst    spl     load0+2000+12,  1
zsrc xxx div.f  #scan+11,       -1
end