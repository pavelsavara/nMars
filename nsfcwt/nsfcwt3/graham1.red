Stefan, here are my entries.  Hope this is in the right format.   My
mailer from the office is tempermental, so I am using my old school
address still.  This will change.

Randy
-----------------------------------------------------------------
;redcode-94
;name Aces
;kill Aces
;Author Randy Graham
;contact hp715!rgraham@peridot.spawar.navy.mil
;NSFCWT Round 3
;assert 1
;strategy spl/spl/perpetual dat core clear.  First lays out flags
;strategy to tell Eights where to find it, then moves.  Eventually
;strategy spl-bombs Eights then dat-bombs some but not all so Eights
;strategy stays alive.

FLAGS     equ      75
MULT      equ      102
FLAG      equ      signal+(num*MULT)
PTR       equ      100
ADJ       equ      711    ;amont partner needs to add to get site
MOVETO    equ      (signal+ADJ-10)

signal
num for FLAGS   ;send out signals that also are bombs
	  mov.i  #signal-(num*MULT)+num,  FLAG
rof

moveme  mov.i  gate2,     MOVETO     ;now go where we really want to be
	mov.i  gate,      MOVETO+1
	mov.i  dat2,      MOVETO+3
	mov.i  dat1,      MOVETO+4
	mov.i  site2,     MOVETO+5
	mov.i  site,      MOVETO+6
	spl.a  MOVETO+8, <-100       ;enough setup, lets start working
	mov.i  sweeper,   MOVETO+8
	mov.i  mover,     MOVETO+9
	mov.i  swinger,   MOVETO+10


gate2   dat.f  #-210,     225        ;redundant gate
gate    dat.f  #-210,     225

dat2    dat.f  <-15,      <20
dat1    dat.f  <-15,      <20
site2   spl.a  #-15,      <16
site    spl.a  #-15,      <14

sweeper spl.a  #0,        <-24       ;P.Kline's core-clear routine
mover   mov.i  @swinger,  >-8
swinger djn.b  mover,     {-4

fini end signal
