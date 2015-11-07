;redcode-94
;name The Optimist
;author David Moore
;assert 1
;strategy pswitcher chooses between 3 pspace strategies
;strategy 1. TimeScape only
;strategy 2. Switch on Win
;strategy 3. Switch on Loss/Tie

;------------------------------------------
; Main pswitcher
;
; remember score; switch if losing
;

nStr   equ   4  ;number of strategies (w00, w01, w02, ... )

sLoss  equ  -9
sWin   equ   9
sTie   equ  -3

sMax   equ  40  ;score cannot exceed sMax
sMin   equ -20  ;switch when score drops below sMin (score resets to 0).

pScore equ 100
pStrat equ 102


main   ldp.a   #0, vt
       ldp.a  ploc, score
       add.ba *vt, score
       ldp.ba    ploc, sgy
       slt.ab   score, #sMax-sMin
       jmp     change, <1
score  stp.a   #-sMin, ploc
ploc   sub.f  #pScore, #pStrat

sgy    jmp @0, w00

  i for (nStr-1)
       dat  0, w&i
  rof

change slt.ab  score, #(sMax-sMin)+(sWin*2)
       jmp    switch, }sgy
       stp.a  #(sMax-sMin), ploc
       jmp      ploc, -sMin

vt     dat 0, sLoss
       dat 0, sWin
       dat 0, sTie

switch mod.a   #nStr, sgy
       stp.ab    sgy, ploc
       stp.a  #-sMin, ploc
       jmp      ploc, 0


       dat 0,0


;--------------------
; Switch on Loss/Tie 
;--------------------

pSL equ 201   ; must be 4n+1

w02    ldp.a  #pSL, gosl
       ldp.ab   #0, -1
       add.a  @ -2, gosl  ; +1 after loss, +2 after tie
       mod.a    #4, gosl
       stp.ab gosl, #pSL

gosl   jmp       @0, carbo
tsw    dat ltsw-gosw,   hsa
       dat wtsw-gosw,   hsa
       dat ttsw-gosw,  time


       dat 0,0


;---------------
; Switch on Win
;---------------

pSW equ 300

w03
w01    ldp.ab    #0, tsw
       ldp.a   #pSW, gosw
       mod.a     #3, gosw
       add.a   @tsw, gosw
       stp.ab *gosw, #pSW
ttsw
gosw   jmp @0, carbo
       dat  2, hsa
ltsw   dat  2, hsa
       dat  0, carbo
wtsw   dat  1, time
       dat  0, carbo
       dat  1, time


  for 2
       dat 0,0
  rof


;---------
;TIMESCAPE
;---------

TSTEP equ 1800
CSTEP equ 3740
NSTEP equ -1922
FSTEP equ 1870

w00
time    spl     1,              <-200
        spl     1,              <-300
        mov.i   -1,             0

tim1    spl     @tim1,          }TSTEP
        mov.i   }tim1,          >tim1
cel1    spl     @cel1,          }CSTEP
        mov.i   }cel1,          >cel1
        mov.i   {-FSTEP,        <FSTEP
        mov.i   {cel1,          <ncl1
ncl1    jmp     @ncl1,          >NSTEP


  for 3
       dat 0,0
  rof


;---------
;CARBONITE
;---------

dbomb	dat	>-1, >1
carbo	spl	#0, <-100
	mov	dbomb, tar-197*3500
tar	add	#197, -1		; gets bombed to start coreclear
	djn.f	-2, <-1151


  for 14
       dat 0,0
  rof


;--------
;MINI HSA
;--------

      dat 0, 250

 for 4
      dat 0,0
 rof

step EQU 9
ptr EQU (bomb-5)

bomb: spl    #1,{1
hsa:
kill: mov    bomb,<ptr
mptr: mov    >ptr,>ptr
      jmn.f  kill,>ptr
a:    add    #step+1,@mptr
scan: jmz.f  a,<ptr
      slt    @mptr,#btm-ptr+3
      djn    kill,@mptr
      djn    a,#16
btm:  jmp    a,{kill


end main
