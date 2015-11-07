;redcode-94
;name Pink
;kill Pink
;author P.Kline
;strategy switching DieHard & core-sweep  (tie or win)

PIN      ; almost forgot to hide this one :-)
rndlmt   equ    ; number of trial rounds - some small number < 20
tscore   equ    ; acceptable trial score - aggressive
pzero    equ    ; somewhere in pspace
prndcnt  equ    (pzero-2)
pscore   equ    (pzero-8)
pstragy  equ    (pzero-14)
presult  equ    0
        
         dat    #gate-10,clr-gate+7    ; just in case clr is decremented
gate     dat    #4000   ,3000
wipe4    dat    #4000   ,clr-gate+7
wipe3    dat    #4000   ,clr-gate+7
wipe2    spl    #6000   ,clr-gate+7    ; redundant wipers
wipe1    spl    #3050   ,clr-gate+7
     for 6
         dat 0,0
     rof
clr      spl    #0,>-20
         mov    @2,>gate
         mov    @1,>gate
         djn.b  -2,{wipe1
     for 40
         dat 0,0
     rof
start    ldp.a  presult,wresult    ; get result of last battle
         sne.a  #-1,wresult        ; check for very first battle
         jmp    goforit
         ldp.a  #prndcnt,wrndcnt   ; get trial round counter
         ldp.a  #pscore ,wscore    ; get trial score
         ldp.a  #pstragy,wstragy   ; get trial strategy
wresult  jmp    @0,tlose
         dat    0 ,twin            ; couldn't we make this scoring system
         dat    0 ,ttie            ; just a little more difficult to manage??
twin     add.a  #3,wscore          ;
ttie     add.a  #1,wscore
tlose    djn.a  goforit,wrndcnt
wscore   slt    #0,#tscore         ; trial score acceptable?
         jmp    reset,}reset+1     ;    yes (grant edge for winning)
         add.a  #1,wstragy         ;    better try something else
                                   ; start a new trial period
reset    mov.a  #0,wscore          ;   set trial score to zero
         mov.a  #rndlmt,wrndcnt    ;   set trial round count to rndlmt
goforit  mod.a  #str1-wstragy,wstragy
wrndcnt  stp.ab #rndlmt+1,#prndcnt ; remember these three
         stp.ab wscore   ,#pscore  ;   "
         stp.ab wstragy  ,#pstragy ;   "
;break
wstragy  jmp    @0,clr
         dat     0,dh
str1     dat     0,0

space    equ (4-40*127)
boot     equ (30*127+50)
dv       equ (c0+58)

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

         dat    1,1                ; prevent Agony's djn overrunning
         dat    1,1                ; before we get started
         end    start
