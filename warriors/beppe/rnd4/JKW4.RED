;redcode-94
;name EvolTmp - multi 4
;author John K W
;assert CORESIZE == 8000
;strategy Gotta love those stone/imps, right?
;strategy Well... here's Evoltmp... yet again!  YAY!! <applause>
;strategy I didn't submit it for the Battle Royale round,
;strategy but maybe I should have. ;-)
;strategy The only thing I changed was the bombing constant (and
;strategy bootdist so the new constant would work)... mod 8 seemed
;strategy to work better than mod 4 for this round.  I experimented
;strategy with other warriors, but nothing beat this. :/
;strategy I had some high hopes for a "core clear"-ish warrior...
;strategy but at best it would tie this.

org EvolCap

BOOT_DIST equ (2626+24*66)
S       equ 48

jclr:   dat     >2667,     S+10

evol
EvolCap mov.i   jclr,   evol+BOOT_DIST+S+4

for 6
        mov.i   {pptr,  <pptr
rof
        spl     @pptr

istep   equ     2667
impoff  equ     (Z+1138)
point equ     (pump-pmpof+impoff)
pmpof   equ     (impoff-100)

Z

j FOR 4
        mov.i   {psrc, <pdst
ROF
        mov.i   instr, impoff
        jmp     @pdst, >-500-15-1*2

for 72/4
spl #1, *1
spl #1, @1
spl #1, #1
spl #1, 1
rof

psrc
pdst  dat     pend, pmpof+pend-pump

pump  spl     #0, 0
      add.a   #istep+1, ptr
prime mov.i   point, point-1
ptr   jmp     pump-pmpof+istep+impoff-(istep+1)*3, >prime

;pump  spl     #1, >prime
;ptr   spl     pump-pmpof+impoff-istep-1, {335+1
;      add.f   #istep+1, ptr
;prime mov.i   point, point-2

pend
instr mov.i   #istep, *0

p       spl     #0,     {-S+1
        add.f   3,      1
        mov     }S-2,   -S+1
        djn.f   -2,     <-1160
        mov     S,      >-S
        djn.f   -1,     >-S-1

pptr:   nop     0,      evol+BOOT_DIST+6



