;redcode
;name The Ankh
;author M Joonas Pihlaja
;strategy p-space: clp -> (clear, imp/stone)
;strategy
;strategy I wonder if some of this booting is necessary?
;strategy Perhaps I'm only being paranoid but... in case /someone/
;strategy comes up with a sick way of (Q-)scanning/bombing or some such.
;TOA98CT round 6
;assert CORESIZE==8000
load0
z for 0
  rof

; w0 - acc
; w1 - imp/stone
; w2 - clear
; w3 - rbbomber

        org     think

;-------------------
; imp/stone (newt)
;

w1      mov     <src1   ,       <dst1
        mov     <src1   ,       <dst1
        mov     <src1   ,       <dst1
        mov     <src1   ,       <dst1
        djn     w1      ,       #2
src1    spl     }cgate  ,       last+2
        spl     @dst1   ,       <dst1
        mov     safedat ,       <dst1
        mov     safedat ,       <dst1
dst1    div.f   #0      ,       #2448


gate1   equ     (init-dist-5)
pat     equ     3315
dist    equ     3

init    spl.b   #0      ,       <1-pat
        spl.b   #pat    ,       <-pat
        mov     {0+pat  ,       2-pat
        add     -2      ,       -1
hit     djn.f   -2      ,       <-3-pat
        mov     2       ,       >gate1
last    djn.f   -1      ,       >gate1
        dat.f   <2668   ,       #2-gate1

impy    equ     (load0-1450)    
        mov     imp     ,       impy
spin    spl     #2668   ,       >prime
prime   mov     impy    ,       impy
        add     -2      ,       1
        jmp     impy-2668,      <-535
imp     mov.i   #6432   ,       2667


;--------
; clear
;
; if it's an imp/stone or paper it's not going to do any clever scanning,
; I hope.

cgate   dat.f   #spin-1 ,       #ccptr+200
t5      dat.f   #6542   ,       #7
        dat.f   #1354   ,       #-1
        dat.f   #7653   ,       #7
w2
cclear  spl     #2542   ,       cgate
        mov     *ccptr  ,       >cgate
        mov     *ccptr  ,       >cgate
        djn.f   -1      ,       {cgate
        dat     <2667*2 ,       <2667
        dat     <2667*2 ,       <2667
        dat     <-4     ,       ccptr-cgate
        spl.b   #-3     ,       ccptr-cgate
        spl.b   #-2     ,       ccptr-cgate
ccptr   dat.f   #-1     ,       #6373

;-------------
; Anti-clp clp
;
safedat dat.f   #DIST+load0-200,        #12             ; initial pointer for clp
DIST    equ     5093
pb      equ     (clp-1)
cp      equ     (px+1)

w0
clp     sub.a   #DIST   ,       {px
        mov     {px     ,       *fptr
        mov.f   px      ,       cp
        mov     }px     ,       @fptr
loop    mov     }px     ,       {pb
        add     #2340   ,       #clp-5-2340
        mov     pb      ,       @-1
fptr    sne     clp-(10+13*2),  cp+35
        jmp     -4      ,       {px
        mov     }cp     ,       >cp
        jmn.a   -1      ,       cp
px      jmp     *clp    ,       >clp+DIST-2


z       for     0
;-redcode
;-name RBbomber
;-author David Moore
;-assert 1


w3      mov     <src3   ,       <dst3
        mov     <src3   ,       <dst3
        mov     <src3   ,       <dst3
        djn     -3      ,       #3
src3    spl     @dst3   ,       bomb+9
dst3    div.f    #0     ,       #5054

;;;;;;;;;;;;;;;;;;;;
;                  ;
;   incendiary     ;
;                  ;
;;;;;;;;;;;;;;;;;;;;

bstep equ 2394 ; 7629 ; 7036
bhop  equ 7953 ; 7965 ; 7969
btime equ 1378 ; 1427 ; 1323
bgate equ    3 ;    4 ;    3

bomb    spl    #1,bhop      ; spl half of the incendiary
        add   #bstep, 1
        mov     bmov, >2-bstep*btime
        mov     bomb, @-1
        jmz       -3, #0    ; bombed with spl to start clear

        mov  bdat,>bomb-bgate
        djn.f  -1,>bomb-bgate

bdat    dat <2667, 2+bgate-bomb

bmov    mov -bhop,>-bhop    ; mov half of the incendiary

        rof

;----------
; p-logic
;

PSTATE  equ     378
STATES  equ     (statesend-state)

think   ldp.a   #0      ,       in
load    ldp.a   #PSTATE ,       state
        add.ba  *state  ,       in
in      add.ba  0       ,       state
        mod.a   #STATES ,       state
store   stp.a   state   ,       load
state   jmp     }0      ,       #t1-in  ; 1  0  0
        spl.f   #w2     ,       #t2-in  ; 1 -1  1
        nop.f   #w2     ,       #t2-in  ; 1 -1  1
        nop.f   #w2     ,       #t3-in  ; 4 -1  4
        nop.f   #w1     ,       #t4-in  ; 1  0  1
        nop.f   #w1     ,       #t2-in  ; 1 -1  1
        nop.f   #w1     ,       #t2-in  ; 1 -1  1
        nop.f   #w1     ,       #t5-in  ; 7 -1  7
;       nop.f   #w3     ,       #t4-in  ; 1  0  1
;       nop.f   #w3     ,       #t2-in  ; 1 -1  1
;       nop.f   #w3     ,       #t5-in  ; 6 -1  6
init0   nop.f   #w0     ,       #t1-in  ; 1  0  0
        nop.f   #w0     ,       #t2-in  ; 1 -1  1
;       nop.f   #w0     ,       #t2-in  ; 1 -1  1
        nop.f   #w0     ,       #t3-in  ; 4 -1  4
statesend

        spl.f   #0      ,       init0-state
t1      nop.f   #0      ,       #1
        nop.f   #4346   ,       #0
        nop.f   #4456   ,       #0

t2      nop.f   #9346   ,       #1
        nop.f   #4355   ,       #-1
t4      nop.f   #4366   ,       #1
        nop.f   #5431   ,       #0
        nop.f   #4356   ,       #1

t3      nop.f   #4387   ,       #4
        spl.f   #2597   ,       #-1
        nop.f   #4635   ,       #4

        end



