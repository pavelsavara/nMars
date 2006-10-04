;redcode-94
;name No Ideas
;author Ilmari Karonen
;strategy  ** Entry for round 1 of the Redcode Maniacs Tournament **
;strategy It's a p-switcher, and a real simple one at that. I've got
;strategy two days left, and still no inspiration coming up. Besides,
;strategy I should be writing an essay, not redcode. Oh well..
;assert CORESIZE==8000
;assert PSPACESIZE > 1
;assert MAXLENGTH >= 50
;planar pspace, boot, clear, gate, scan, stun

; Ok, this is a variation of something I was writing for the tiny
; hill. (After trying to do a pspacer in 20 instructions, 50 feels
; like luxury.) It's a small and fast switch-on-loss pbrain I
; published on r.g.c about a year ago, switching between d-clear and 
; mini-HSA.

; Rationale: The one type of warriors that benefit from halved
; maxlength will be scanners and especially oneshots. D-clear beats
; them, and is small enough to often avoid bombers. But some will
; undoubtedly submit heavy papers, which benefit from the lack of
; qscanners. D-clear drops like a stone against silks, but mini-HSA
; can beat them.

; Actually, I haven't the faintest idea how this will score. At least
; it has no major weaknesses, so it shouldn't lose too much.. Except
; perhaps against very aggressive papers that can kill HSA.

        org     first

; *** switch-on-loss p-brain ***
; 5 cycles on win/tie, 6 on loss

pflag   equ     182
num     equ     2               ; fast

; pflag must not be the a-field of num-1 instructions after switch!

first   ldp.ab  #pflag, switch
        ldp.a   #0, switch
        mod.ab  #num, @first
switch  sne.a   >0, 0           ; published version had a bug here
        stp.ba  switch, first
        djn.b   strat2, @first  ; asymmetric if num>2

; *** mini-HSA ***
; almost straight out of Electric Head

hstep   equ     9
hptr    equ     (hbomb-5)
haway   equ     (hbomb-4000)

strat1  mov.i   hbtm, @hboot
        z for   8
        mov.i   hbtm-z, <hboot
        rof
        spl     @hboot, }999    ; 15-16 cycles
hboot   mov.ab  #250, @haway
        mov.i   hbomb, <hboot
        div.f   #0, hboot

hbomb   spl     #1, {1
hkill   mov.i   hbomb, <hptr
hmptr   mov.i   >hptr, >hptr
        jmn.f   hkill, >hptr
ha      add.ab  #hstep+1, @hmptr
hscan   jmz.f   ha, <hptr
        slt.b   @hmptr, #hbtm-hptr+3
        djn.b   hkill, @hmptr
        djn.b   ha, #16
hbtm    jmp     ha, {hkill

        z for   50-CURLINE-11           ; optimize placement
        spl     #100*z, >1
        rof

        dat     1234, 5678

; *** d-clear ***
; this should beat oneshots and HSA-derivatives well

daway   equ     (-(CORESIZE/4))         ; beats scanners
dptr    equ     (dclear-18)

dclear  spl     #0, 0
dloop   mov.i   dbomb, >dptr
        djn.f   dloop, >dptr
dbomb   dat     >5335, >(dclear+10)-dptr

strat2  mov.ab  #datz-(dptr+daway), dptr+daway
dboot   spl     dclear+daway, }666      ; 7-8 cycles
        mov.i   dclear, }dboot
        mov.i   dclear+1, }dboot
        mov.i   dclear+2, }dboot
        mov.i   dclear+3, }dboot

datz    end