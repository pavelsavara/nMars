;redcode-94
;name Slayer
;kill Slayer
;author Randy Graham
;contact graham@mathcs.rhodes.edu
;NSFCWT round 7
;assert 1
;strategy use a number of different components and p-space to switch them

STRATS    equ    3   ;how many strategies I have other than scatter
	  
FIRST     equ    (dummy1+4000)

_RSLT     equ    #0
_STRAT    equ    #17
_MEMORY1  equ    #64
_MEMORY2  equ    #73
_LAST     equ    #155 ;last non-scatter we played

mstore1   equ    3    ;what to store in memory 1
mstore2   equ    7    ;what to store in memory 2
mresult   equ    (mstore1*mstore2)  ;result to check memory for brainwash

org        start
	   
dummy1     dat.f  #-10,     #10
stopper    jmp.a  0,        <-4

wash       stp.ab #0,        0
pit        spl.a  -1,        <-1
	   spl.a  -1,        <-14
	   jmp.a  -1,        }wash

for 38
    dat.f  <-15, needed1
    spl.a  15,   <-25
    jmp.a  5,    4
    mov.i  #pit, 14
rof

needed1    dat.f  0,         0     ;starts scatter on round1
needed2    dat.f  1,         0     ;forces switching on a loss

start      ldp.ab _RSLT,     #0    ;repeats same strategy 
	   ldp.a  _STRAT,    where_to   ;forces switching on a loss
	   jmz.a  where_to,  <start

check_mem  ldp.ab _MEMORY1,  #0
	   ldp.ab _MEMORY2,  checker
	   mul.b  check_mem, checker
checker    sne.ab #mresult,  #0
	   jmp.a  mem_ok,    0
bad_mem    stp.ab #mstore1,  _MEMORY1 ;brainwashed, return to default
	   stp.ab #mstore2,  _MEMORY2
	   stp.ab #3,        _LAST    ;because paper is my weakest
strat_ptr  jmp.a  scatter,   mem_ok   ;points to our next strategy

mem_ok     jmn.b  tied,      <start

lost       jmz.a  not_scat,  where_to
	   stp.ab #0,        _STRAT
	   jmp.a  scatter,   0

not_scat   ldp.a  _LAST,     where_to
	   mod.a  #STRATS,   where_to
	   add.a  #1,        where_to
	   stp.ab where_to,  _LAST
	   stp.ab where_to,  _STRAT
	   jmp.a  where_to,  0

tied       add.a  #1,        where_to
	   mod.a  #4,        where_to
	   stp.ab where_to,  _STRAT
	   jmz.a  scatter,   where_to
	   stp.ab where_to,  _LAST

where_to   jmp.a  @0,        scatter
	   dat.f  0,         moveston
	   dat.f  0,         moveduel
	   dat.f  0,         movpapr

for 27
   dat.f   <2667,   <5334
   dat.f   <1143,   <2286
   dat.f   <381,    <742
rof

scatter    mov.i  stopper,   FIRST+255    ;move stuns out, every 10th
	   
	   mov.i  stopper,   FIRST+125
	   mov.i  stopper,   FIRST+385
	   
	   mov.i  stopper,   FIRST+65
	   mov.i  stopper,   FIRST+185
	   mov.i  stopper,   FIRST+445
	   mov.i  stopper,   FIRST+325
	   
	   mov.i  stopper,   FIRST+35
	   mov.i  stopper,   FIRST+95
	   mov.i  stopper,   FIRST+415
	   mov.i  stopper,   FIRST+475
	   mov.i  stopper,   FIRST+155
	   mov.i  stopper,   FIRST+215
	   mov.i  stopper,   FIRST+295
	   mov.i  stopper,   FIRST+355

	   mov.i  stopper,   FIRST+15
	   mov.i  stopper,   FIRST+55
	   mov.i  stopper,   FIRST+395
	   mov.i  stopper,   FIRST+435
	   mov.i  stopper,   FIRST+135
	   mov.i  stopper,   FIRST+175
	   mov.i  stopper,   FIRST+275
	   mov.i  stopper,   FIRST+315
	   mov.i  stopper,   FIRST+75
	   mov.i  stopper,   FIRST+115
	   mov.i  stopper,   FIRST+455
	   mov.i  stopper,   FIRST+495
	   mov.i  stopper,   FIRST+195
	   mov.i  stopper,   FIRST+235
	   mov.i  stopper,   FIRST+335
	   mov.i  stopper,   FIRST+375
	   
	   mov.i  stopper,   FIRST+5
	   mov.i  stopper,   FIRST+25
	   mov.i  stopper,   FIRST+425
	   mov.i  stopper,   FIRST+365
	   mov.i  stopper,   FIRST+265
	   mov.i  stopper,   FIRST+285
	   mov.i  stopper,   FIRST+485
	   mov.i  stopper,   FIRST+465
	   mov.i  stopper,   FIRST+45
	   mov.i  stopper,   FIRST+85
	   mov.i  stopper,   FIRST+165
	   mov.i  stopper,   FIRST+205
	   mov.i  stopper,   FIRST+105
	   mov.i  stopper,   FIRST+145
	   mov.i  stopper,   FIRST+225
	   mov.i  stopper,   FIRST+245
	   mov.i  stopper,   FIRST+345
	   mov.i  stopper,   FIRST+405
	   mov.i  stopper,   FIRST+305

vamp_em    mov.a  #FIRST-pit+2,FIRST+5
	   add.f  dummy1,    vamp_em
	   djn.b  vamp_em,   #49

SWEEP_TO   equ    FIRST-104
mov_swp    mov.i  ptr,       SWEEP_TO
	   mov.i  swp3,      SWEEP_TO+1
	   mov.i  swp2,      SWEEP_TO+2
	   mov.i  swp1,      SWEEP_TO+3
	   spl.a  SWEEP_TO+(well-ptr), #well
	   mov.i  >-1,       }-1
	   mov.i  >-2,       }-2
	   mov.i  >-3,       }-3
	   

ptr        dat.f  #20,       #swp1
swp3       dat.f  <2667,     <-15
swp2       mov.i  #20,       <1
swp1       spl.a  #20,       2
	   dat.f  0,         0
	   dat.f  0,         0
	   dat.f  0,         0
well       spl.a  #0,        <-15
	   mov.i  @ptr,      }ptr
	   djn.b  -1,        <well-14

DUELTO     equ    (dummy1+1720)
STONETO    equ    (dummy1+1840)
IMPTO      equ    (STONETO+128)
PAPERTO    equ    (STONETO+191)
PAPEROFF   equ    1800

for 11
    spl.a  #0,   <-15
    jmp.a  -1,   <-16
rof

moveduel mov.i  }final,   >final
for 12
	 mov.i  }final,   >final
rof
final    mov.i  adder,    DUELTO
	 jmp.a  DUELTO,   #0

moveston mov.i  }last,    >done
	 mov.i  }last,    >done
	 mov.i  }last,    >done
last     mov.i  stone,    >done
	 spl.a  STONETO+1,>done
done     mov.i  smover,   STONETO
paperimp jmp.a  moveimp,  0

movpapr  spl    1,        paper1
	 spl    1
	 spl    1
	 mov.i  -1,       #0
starter  spl.a  @0,       PAPERTO
	 mov.i  >movpapr, >starter
stopit   dat.f  <2667,    <2667*2

moveimp  mov.i  imp,      IMPTO
	 spl    i
	 spl    i31
i12      spl    imp2
imp1     jmp    >0,       IMPTO
i31      spl    imp1
imp3     jmp    >0,       IMPTO+5334
i        spl    i12
	 spl    imp3
imp2     jmp    >0,       IMPTO+2667

imp    mov.i  #1143,  2667

OPT equ 98     ;mod 2
LEN equ (14)
DIFF equ 12
BOMBS equ (DIFF+2)      ;how many bombs to lay
OFF equ -402    ;djn stream offset for long run     ;for OPT 7934
BEST equ -402   ;best I've found so far in length of run
ENDAT equ 78164 ;how long BEST runs

adder  add.f  spltrp,   cmper   ;adjust our compare sites
cmper  sne.i  adder-(OPT*1), adder-(OPT*2) ;see if they differ
       add.f  spltrp,   cmper
       seq.i  *cmper,   @cmper
       slt.b  cmper,    #(-OPT*1)  ;different, only bomb if not us
       djn.b  adder,    #OFF      ;lay djn stream, jump to add line
       mov.i  build,    *cmper
       mov.i  spltrp,   {cmper
       sub.i  datadd,   cmper     ;reset compare pointer
       jmz.i  adder,    adder-1   ;if we haven't bombed ourself, scan more
spltrp spl.a  #-(OPT*2), <-(OPT*2)    ;trap, and stay alive line
sweep  mov.i  datadd,   <build         ;lay dats down
build  jmp.a  -1,       <-3
datadd dat.f  <0-OPT-1, <0-OPT  ;sets up poor gate

SSTEP  equ    168

stone  mov.i  <6,     1
       spl.a  -1,     <-24
       add.f  3,      stone
       djn.f  -2,     <-26
smover mov.i  SSTEP,  <-SSTEP

paper1   spl.a  @0,       PAPEROFF
breeder  mov.i  }paper1,  >paper1
getimps  mov.i  nonimp,   >-550
novamp   mov.i  static,   }399
again    spl.a  paper1,   {paper1
nonimp   dat.f  <2667,    <5334
static   dat.f  <1,       <1

;not used, but just to fil in space

STEP     equ   73
T_OFF    equ   0

gate     dat   0,0
     for 3
	 dat   0,0
     rof
w2       dat   -7,cp-gate+3
	 dat   0,0
wipe     dat   -7,cp-gate+3
sp       spl   #-1-STEP,-STEP    ; spl half of the incendiary
in       sub   #STEP+STEP,@msp
msm      mov   sm,*tgt+(T_OFF)
msp      mov   sp,@msm           ; bomb alternately with spl & mov
tgt      jmz   in,#0             ; bombed with spl to start clear
clr      mov   @cp,>gate
cp       djn.b clr,{wipe+1
     for 2
	 dat   0,0
     rof
sm       mov   STEP+1,>STEP+1    ; mov half of the incendiary

for 8
       add.f  spltrp,   cmper
       seq.i  *cmper,   @cmper
       slt.b  cmper,    #(-OPT*1)  ;different, only bomb if not us
       djn.b  adder,    #OFF      ;lay djn stream, jump to add line
       mov.i  build,    *cmper
       mov.i  spltrp,   {cmper
rof
end
