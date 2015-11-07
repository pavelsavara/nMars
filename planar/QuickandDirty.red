;redcode
;name Quick and Dirty
;author Planar
;strategy Q^2 scan, stone, continuous-launching imp
;strategy ... in Redcode-88
;assert CORESIZE == 8000 

;; Entry for round 5 of the Redcode Maniacs Tournament

;; I don't have much time for fine-tuning, but I hope nobody expects a
;; Q^2 scan in redcode-88.

;;      org     start

Z       equ     start+1000
qstep   equ     150

bstep   equ     3
bcount  equ     11

ploc    equ     start+1299
point   equ     pump+500
istep   equ     1143

sloc    equ     start+3500
sstep   equ     2214
smagic  equ     644

trash1  equ     start-100
trash2  equ     start-200
trash3  equ     start-300
trash4  equ     start-400


;; quick-scanner attack (backward)

qsto2:  mov     qbomb, @targ2
targ2:  mov     qbomb, @Z         ; overwritten
        add     #-2*bstep, targ2
        djn     qsto2, #bcount
        jmp     boot, <trash4


;; Q^2 scan

start:  cmp     Z+0*qstep, Z+1*qstep
        jmp     fast
        cmp     Z+2*qstep, Z+3*qstep
        jmp     found
        cmp     Z+4*qstep, Z+5*qstep
        jmp     found, <idx
        cmp     Z+6*qstep, Z+7*qstep
        djn     found, <idx

        add     #8*qstep, target

        cmp     Z+8*qstep, Z+9*qstep
        jmp     fast
        cmp     Z+10*qstep, Z+11*qstep
        jmp     found
        cmp     Z+12*qstep, Z+13*qstep
        jmp     found, <idx
        cmp     Z+14*qstep, Z+15*qstep
        djn     found, <idx

        add     #8*qstep, target

        cmp     Z+16*qstep, Z+17*qstep
        jmp     fast
        cmp     Z+18*qstep, Z+19*qstep
        jmp     found
        cmp     Z+20*qstep, Z+21*qstep
        jmp     found, <idx
        cmp     Z+22*qstep, Z+23*qstep
        djn     found, <idx

        add     #8*qstep, target

        cmp     Z+24*qstep, Z+25*qstep
        jmp     fast
        cmp     Z+26*qstep, Z+27*qstep
        jmp     found
        cmp     Z+28*qstep, Z+29*qstep
        jmp     found, <idx
        cmp     Z+30*qstep, Z+31*qstep
        djn     found, <idx

        add     #8*qstep, target

        cmp     Z+32*qstep, Z+33*qstep
        jmp     fast
        cmp     Z+34*qstep, Z+35*qstep
        jmp     found
        cmp     Z+36*qstep, Z+37*qstep
        jmp     found, <idx
        cmp     Z+38*qstep, Z+39*qstep
        djn     found, <idx

;; nothing found...

boot:   spl     sboot

pboot:  mov     pump+4, <pptr
        mov     pump+3, <pptr
        mov     pump+2, <pptr
        mov     pump+1, <pptr
        mov     pump+0, <pptr
pptr:   mov     iinstr, @ploc
        jmp     @pptr, <trash2

sboot:  mov     stone+4, sloc
        mov     stone+3, <sboot
        mov     stone+2, <sboot
        mov     stone+1, <sboot
        mov     stone+0, <sboot
        jmp     @sboot, <trash1


;; quick-scanner attack (forward)

found:  add     @idx, 1
        add     #0, target
fast:   jmn     qstone, @target
        add     #qstep, target

qstone: mov     qbomb, @target
target: mov     qbomb, @Z
        add     #2*bstep, target
        djn     qstone, #bcount

        mov     target, targ2
        jmp     qsto2, <trash3


;; imp launcher (adapted from Impfinity)

iinstr: mov     0, 1143

pump:   spl     0, point
        add     isteps, j
        mov     point, @j
j:      jmp     point-(2*istep)-2, point-2
isteps  dat     #istep+1, #1


;; stone (adapted from Impfinity)

stone:  spl     0, <-20
        mov     sbomb, @ptr
        add     #sstep, ptr
ptr:    djn     stone, <smagic
sbomb:  dat     <2667, <5335


;; quick-scanner table

        dat     #6*qstep, #0
idx:    dat     #4*qstep, #1
        dat     #2*qstep, #0

qbomb:  dat     #0, #bstep


;; decoy
        spl     0, <1
        spl     0, <2
        spl     0, <3
        spl     0, <4
        spl     0, <5
        spl     0, <6
        spl     0, <7
        spl     0, <8
        spl     0, <9
        spl     0, <10
        spl     0, <11
        spl     0, <12

	end     start
