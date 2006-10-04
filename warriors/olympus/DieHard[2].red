;redcode-94m quiet
;name Die Hard
;kill Die Hard
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 1
;assert CORESIZE == 8000
;strategy minimal kill+, maximal survival
;
; Quick-scan a small portion of core
;    vamp anything found into the pit
;    the pit does a brainwash as well as core-clear
; Die Hard - replicate continuous ring-launchers (ala Keystone)
; The brainwash forces pspacers to their default - usually
; some stand-still program which Die Hard can kill
;
space    equ (4-40*127)
boot     equ (30*127+50)
dv       equ (c0+58)
dvins    mov   101,{1               ; pretty good bomb

qstep    dat    -8,8
qfang    jmp    qpit-qcomp+8,qcomp-8
start    seq    qcomp+(100*01),qcomp+(100*02) ; quick-scan small part of core
         mov.ab #(100*01),*qcptr
         seq    qcomp+(100*03),qcomp+(100*04)
         mov.ab #(100*03),*qcptr
         seq    qcomp+(100*05),qcomp+(100*06)
         mov.ab #(100*05),*qcptr
         seq    qcomp+(100*07),qcomp+(100*08)
         mov.ab #(100*07),*qcptr
qcptr    jmn.b  qcomp,qcomp
         seq    qcomp+(100*09),qcomp+(100*10)
         mov.ab #(100*09),*qcptr
         seq    qcomp+(100*11),qcomp+(100*12)
         mov.ab #(100*11),*qcptr
         seq    qcomp+(100*13),qcomp+(100*14)
         mov.ab #(100*13),*qcptr
         seq    qcomp+(100*15),qcomp+(100*16)
         mov.ab #(100*15),*qcptr

         jmz.b  dh,qcomp
qcomp    sne    -200,0           ; which of two pointers was it?
         add    #100,qcomp
         add.b  qcomp,qfang      ; adjust fang
         sub.ba qcomp,qfang
         mov    qfang,@qfang     ; drop 6 fangs
         add    qstep,qfang
         mov    qfang,@qfang
         add    qstep,qfang
         djn    -4,#3            ; can't take too much time!

dh       mov dvins,dv+boot       ; position dv-bomb as needed
         mov dvins,dv
         spl 1,>-2002            ; make 8 processes
         spl 1,>-2001
         spl 1,>-2000
         mov <s2,{s2             ; boot one copy of Die Hard
s2       spl c0+boot+8,c0+8

c0       spl   @0,space          ; here is Die Hard
         mov   }c0,>c0
cs       spl   #0        ,}dv    ; following lines execute in reverse order
         mov   dv        ,}dv+space
cb       add.a #119      , dv+space
         spl   imp+5334  ,}dv+space
         spl   imp+2667  ,}dv+space
imp      mov.i #2667 ,*0
     for 36
         dat   0,0
     rof
qclr     dat   1,1
qpit     spl   0,0               ; the pit
         spl   -1,>1             ; washing with zero causes opponent
         stp.ab #0,#0            ;    to choose default strategy
         mov    qclr,>1          ; self-destructive core-clear
         jmp    -1,5
     for 5
         dat   0,0
     rof
         dat   start+1000,start+2000 ; small decoy for backward-scanners
         dat   start+1000,start+2000
         dat   start+1000,start+2000
         dat   start+1000,start+2000
         dat   start+1000,start+2000
         dat   1,1                   ; delay djn-stream overruns
         dat   1,1
         end start
