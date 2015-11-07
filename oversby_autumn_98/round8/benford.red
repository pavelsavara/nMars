;redcode-94
;name 8001: A Corewar Odyssey
;author Ben Ford
;assert CORESIZE==8001 && MAXPROCESSES==64
;strategy qscan -> paper
;strategy
;strategy Mostly taken from John Metcalf's Innocuous.
;strategy I couldn't find anything to beat it (in the
;strategy little time I took) so I hope he does not
;strategy mind me using it.
;strategy Added dual bomber to qscan based on the one
;strategy in Fixed.

        org     qstart

qf      equ     (qbomb+200)     ; qscan constants
qd      equ     (+101)
qs      equ     (+201)
gap     equ     (6)     ; qbomber constants
rep1    equ     (13)
rep2    equ     (17)
flag    equ     (qbomb-100)
datz    equ     (qf+qs*20)

p1      equ     6028    ; paper constants
p2      equ     4380
p3      equ     3924

; ***** QUICK DECODE *****

qbomb   dat     }gap,   }-gap
        nop     {q_B,   {q_E
tab     add     q_D,    q_B     ; decoder
slow    add     @tab,   @which
fast    add     *tab,   @which
which   sne     >datz,  @fnd1
        add     qDis,   @which
        spl     bmber1, }qf+qs*13

; ***** REDUNDANT BOMBER *****

bmber2  add.b     fnd1,  fnd2   ; redundant bomber
loop2   mov.i    qbomb, @fnd2   ; .5c, forward only
fnd2    mov.i    qbomb, >fnd1-(gap*rep1)/2+1
        add     #2*gap,  fnd2
        djn      loop2, #rep2
        jmn.b    qbomb,  flag   ; check flag

; ***** PAPER 1 *****

paper2  spl     1,      {1234
        spl     1,      {2345

pa21    spl     @   0,  {  p1
        mov     }pa21,  >pa21
        mov     }pa21,  >pa21
pa22    spl     @   0,  {  p2
        mov     }pa22,  >pa22
        mov     {pa22,  {pa23
pa23    jmz.a   *p3+1,  >p3-3
        dat     >   1,  }   1

; ***** QUICK SCAN *****

qDis    dat     qd,     qd

q_A     dat     10*qs,  10*qs   ; Can get 23 values from this
q_B     dat     13*qs,  13*qs   ; table and can also use the
q_C     dat     6*qs,   6*qs    ; initial value of qKil.
q_D     dat     1*qs,   1*qs    ; (Traditional Q^2 comment!)
q_E     dat     4*qs,   4*qs

; [0 cycles]
qstart  seq     qf,             qd+qf        ; 0
        jmp     which,          {qd+qf-2

; [1 cycles]
        seq     qf+qs*4,        qd+qf+qs*4      ; E
        jmp     fast,           }tab
        seq     qf+qs,          qd+qf+qs        ; D
        jmp     fast,           {qd+qf+qs-2
        seq     qf+qs*6,        qd+qf+qs*6      ; C
        jmp     fast,           {tab
        seq     qf+qs*13,       qd+qf+qs*13     ; B
        jmp     fast,           {fast
        seq     qf+qs*10,       qd+qf+qs*10     ; A
        djn.a   fast,           {fast

; [2 cycles]
        seq     qf+qs*14,       qd+qf+qs*14     ; DB
        jmp     slow,           {qd+qf+qs*4-2
        seq     qf+qs*19,       qd+qf+qs*19     ; CB
        jmp     slow,           {tab
        seq     qf+qs*17,       qd+qf+qs*17     ; EB
        jmp     slow,           }tab
        seq     qf+qs*11,       qd+qf+qs*11     ; DA
        jmp     slow,           <tab
        seq     qf+qs*7,        qd+qf+qs*7      ; DC
        jmp     slow,           >tab
        seq     qf+qs*26,       qd+qf+qs*26     ; BB
        jmp     slow,           {fast
        seq     qf+qs*5,        qd+qf+qs*5      ; DE
        jmp     slow,           {slow
        seq     qf+qs*16,       qd+qf+qs*16     ; CA
        djn.f   slow,           tab
        seq     qf+qs*23,       qd+qf+qs*23     ; BA
        djn.a   slow,           {fast
        seq     qf+qs*2,        qd+qf+qs*2      ; DD
        djn.b   slow,           {slow

; [3 cycles]
        seq     qf+qs*15,       qd+qf+qs*15     ; DDB
        jmp     tab,            {qd+qf+qs*4-2
        seq     qf+qs*12,       qd+qf+qs*12     ; DDA
        jmp     tab,            <tab
        seq     qf+qs*8,        qd+qf+qs*8      ; DDC
        jmp     tab,            >tab
        seq     qf+qs*25,       qd+qf+qs*25     ; CCB
        jmp     tab,            {tab
        seq     qf+qs*21,       qd+qf+qs*21     ; EEB
        jmp     tab,            }tab
        seq     qf+qs*28,       qd+qf+qs*28     ; DDBB
        jmp     tab,            {fast
        seq     qf+qs*24,       qd+qf+qs*24     ; DAB
        djn.a   tab,            {fast
        seq     qf+qs*22,       qd+qf+qs*22     ; CCA
        djn.f   tab,            tab

; ***** PAPER  1 *****

paper1  spl     1,      {1234
        spl     1,      {2345

pa11    spl     @   0,  {  p1
        mov     }pa11,  >pa11
        mov     }pa11,  >pa11
pa12    spl     @   0,  {  p2
        mov     }pa12,  >pa12
        mov     {pa12,  {pa13
pa13    jmz.a   *p3+1,  >p3-3
        dat     >   1,  }   1

; ***** PRIMARY BOMBER *****

qincr   dat     }-gap,  >2*gap

bmber1
loop1   mov.i   qincr,  *fnd1     ; primary bomber
        mov.i   qincr,  @fnd1     ; .66c, bi-directional
fnd1    mov.i   qf-2*gap,       }qf
        add     qincr,  fnd1
        djn     loop1,  #rep1
        jmp     paper1, >flag    ; set flag

; ***** FILLER *****

a       for     MAXLENGTH+qbomb
        dat     0,      0
        rof

        end
