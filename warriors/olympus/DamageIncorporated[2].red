FOR 0
  Imp/stones are Morrell's strength, He probably knows I know that and my 
  strength is (q)scanners. I will assume he has some idea of this. Mind you,
  I have two bombers on the hill at the moment... and if Macrae stops sending
  dozens of tests to the hill without ;killing them they should last a while
  longer. :-)

  My warrior of choice at this stage would be an imp/stone ... probably
  something like Rosebud. However, I don't really want to cut and paste and
  don't have the time to create anything new... so I'm submitting Damage
  Incorporated (MODIFIED). This is a T18 derivative with extra imp 
  protection (and qscan).

  I don't feel confident about winning this round ... but in these one-on-one
  battles it's anyone's game.

ROF

;redcode-94
;name Damage Incorporated
;author Anton Marsden
;strategy QScan -> Bomber
;assert CORESIZE==8000

step     equ   54
count    equ   2000
gate EQU (sp-7)

sp       spl   #-1-step,#-step   ; spl half of the incendiary
in       sub   #step+step,1
msm      mov   sm,*tgt+(step*count)-17228
msp      mov   sp,@msm           ; bomb alternately with spl & mov
tgt      jmz.b in,#0             ; bombed with spl to start clear
clr      mov   wipe,>gate
cp       djn.f clr,>gate
wipe     dat   0,wipe-gate+2
      dat   0,0
sm       mov   step+1,>step+1    ; mov half of the incendiary

FOR 24
    dat 0,0
ROF


QB EQU (start+300) ; not really this
QS EQU (QD*2)
QD EQU 100

GAP EQU 12
REP EQU 9

datz EQU (table-4)

bombm:   dat    <1,{1
      dat    10*QS, 2*QS ; can get 21 values from this table
table:   dat     4*QS, 1*QS ; and can also use the initial value
      dat    23*QS, 3*QS ; of fnd

qinc:    spl    #GAP,>-GAP
tab:     add.a  table,table
slow:    add.a  @tab,fnd
fast:    add.ba *tab,@slow
which:   sne.i  datz,*fnd
      add.a  #QD,fnd
      mov.i  bombm,*fnd
      add.ab fnd,fnd

fnd:     mov.i  QB,GAP/2
      add.f  qinc,fnd
      mov.i  bombm,*fnd
      djn.b  fnd,#REP
      jmp    sp,<0 ; don't bother booting

start:
      ; WHICH
      seq.i  QB+QS*0,QB+QS*0+QD
      jmp    which,}QB+QS*0+QD/2
      
      ; FAST
      seq.i  QB+QS*1,QB+QS*1+QD
      jmp    fast,}QB+QS*1+QD/2
      
      seq.i  QB+QS*13,QB+QS*13+QD
      jmp    fast,{fast
      seq.i  QB+QS*2,QB+QS*2+QD
      jmp    fast,{tab
      seq.i  QB+QS*3,QB+QS*3+QD
      jmp    fast,}tab
      
      ; SLOW
      seq.i  QB+QS*4,QB+QS*4+QD
      jmp    >fast,}QB+QS*4+QD/2
      seq.i  QB+QS*5,QB+QS*5+QD
      jmp    slow,}QB+QS*5+QD/2
      
      seq.i  QB+QS*6,QB+QS*6+QD
      jmp    slow,{tab
      seq.i  QB+QS*7,QB+QS*7+QD
      jmp    slow,}tab
      seq.i  QB+QS*10,QB+QS*10+QD
      jmp    >fast,<tab
      seq.i  QB+QS*11,QB+QS*11+QD
      jmp    slow,<tab
      seq.i  QB+QS*12,QB+QS*12+QD
      djn.f  slow,tab
      seq.i  QB+QS*23,QB+QS*23+QD
      jmp    >fast,>tab
      seq.i  QB+QS*24,QB+QS*24+QD
      jmp    slow,>tab
      seq.i  QB+QS*17,QB+QS*17+QD
      jmp    slow,{fast
      
      ; TAB
      
      seq.i  QB+QS*8,QB+QS*8+QD
      jmp    <fast,}QB+QS*8+QD/2
      seq.i  QB+QS*9,QB+QS*9+QD
      jmp    tab,}QB+QS*9+QD/2

      seq.i  QB+QS*15,QB+QS*15+QD
      jmp    tab,<tab
      
      seq.i  QB+QS*16,QB+QS*16+QD
      jmp    tab,{tab
      seq.i  QB+QS*20,QB+QS*20+QD
      djn.f  <fast,tab
FOR 0
      seq.i  QB+QS*21,QB+QS*21+QD
      jmp    tab,{fast
      seq.i  QB+QS*22,QB+QS*22+QD
      djn.f  tab,tab
      seq.i  QB+QS*27,QB+QS*27+QD
      jmp    <fast,>tab
      seq.i  QB+QS*28,QB+QS*28+QD
      jmp    tab,>tab
      seq.i  QB+QS*30,QB+QS*30+QD
      jmp    tab,}tab
ROF

away     equ   (QB+QS*18+100) ; not really this

boot:     spl   1,1                  ; using 2 processes
FOR 5               
    mov   {src,{dest
ROF               
dest:     djn.b sm+1+away,#1         ; ignite torch
src:      mov.i #sm+1,-1
    dat {300,{400
      
end start
