;redcode-94
;name Kiss the Fish Babe!
;author P.Kline
;assert CORESIZE == 8000
;strategy pspacing three components for the Redcode Mainiacs Tournament
;strategy round 1

slStone   add    #Stone-Sweep ,btSweep
slSweep   mov    <btSweep   ,{btSweep
          djn    -1         ,#9
btSweep   jmp    5380       ,Sweep+9

Sweep     add    #2671   ,#2681           ;one-shot scan
          jmz.f  Sweep   ,@Sweep          ;with spl-dat wipe
          jmp    swWipe  ,<Sweep
          dat    #-100   ,{swWipe+7-Sweep
          dat    #-100   ,{swWipe+7-Sweep
swWipe    spl    #5900   ,{swWipe+7-Sweep
          mov    @2      ,>Sweep
          mov    @1      ,>Sweep
          djn.b  -2      ,{swWipe

PSTATE EQU 1458
STATES EQU (loss_table-win_table)
      dat    0  ,init_table-state
in    dat    0  ,loss_table-state
      dat    0  ,win_table-state
      dat    0  ,tie_table-state

think ldp.a  #0,in              ; get input value
load  ldp.a  #PSTATE,state      ; load old state
      mod.a  #STATES,state      ; brainwash protection
      add.ba *in,state          ; select correct state table
store stp.a  *state,load        ; store new state
state jmp    @0        ,w1

w0 EQU slStone
w1 EQU slSweep
w2 EQU slPaper
w3 EQU slSweep
w4 EQU slPaper

win_table
ww0   spl    #ww0-win_table,w0   ; Stone
      spl    #-1-win_table ,w0
init_table
      spl    #-1-win_table ,w0
ww1   spl    #ww1-win_table,w1   ; Sweep
ww2   spl    #ww2-win_table,w2   ; Paper
ww3   spl    #ww1-win_table,w1   ; Sweep
ww4   spl    #ww2-win_table,w2   ; Paper

tie_table
loss_table
wl0   spl    #1-loss_table ,w0   ; Stone
      spl    #1-loss_table ,w0
      spl    #1-loss_table ,w1
wl1   spl    #1-loss_table ,w2   ; Sweep
wl2   spl    #1-loss_table ,w3   ; Paper
wl3   spl    #1-loss_table ,w4   ; Sweep
wl4   spl    #-4-loss_table,w0   ; Paper

sStep     equ    3174
Stone     mov    {1545     ,1-sStep
          sub.x  #sStep   ,-1
          jmp    -2       ,}-2

STEP      equ    (2381)
slPaper   spl    1,<1
          jmn    -1,#7
paper     spl    @paper      ,<STEP
          mov.i  }paper      ,>paper
          mul    #5091       ,paper
          spl    paper       ,{paper
          mov.i  #-1+7*STEP    ,}-3*STEP
          mov.i  gate        ,>-6
          djn.f  -1          ,>-7-1333        
gate      dat.f  <5334       ,<2667

         end think


