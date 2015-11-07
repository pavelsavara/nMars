I hope this gets to you in time for inclusion in round four. I'm
not confident enough with my other strategy to enter it, so here
is a simple variation on a random p-switcher. I figured I can't
go too far wrong if I only have to write the switcher and boot
code. Struma and Maritza are the principle rivers of Bulgaria...
Cheers.

-------------------------------------------------------------
;REDCODE
;NAME Struma & Maritza
;AUTHOR John Metcalf
;STRATEGY .OOO. Entry for round four of Redcode Maniacs .OOO.
;STRATEGY A simple weighted-random p-switcher, since I'm only
;STRATEGY a beginner. The only switcher I've seen before is a
;STRATEGY switch-on-loss so I've had little to inspire me :-(
;ASSERT CORESIZE==8000
 LDP.A #41,PUNG
TUNG ADD.A #1,PUNG
 STP.AB PUNG,#41
 MOD.A #53,PUNG
PUNG JMP.A @0,PAPER
SPL 0,STONE
SPL -1,PAPER
SPL -2,STONE
SPL -3,SCISSORS
SPL -4,PAPER
SPL -5,STONE
SPL -6,PAPER
SPL -7,SCISSORS
SPL -8,PAPER
SPL -9,SCISSORS
SPL -10,PAPER
SPL -11,SCISSORS
SPL -12,PAPER
SPL -13,SCISSORS
SPL -14,PAPER
SPL -15,STONE
SPL -16,PAPER
SPL -17,SCISSORS
SPL -18,PAPER
SPL -19,STONE
SPL -20,PAPER
SPL -21,SCISSORS
SPL -22,PAPER
SPL -23,STONE
SPL -24,SCISSORS
SPL -25,STONE
SPL -26,SCISSORS
SPL -27,STONE
SPL -28,SCISSORS
SPL -29,PAPER
SPL -30,STONE
SPL -31,PAPER
SPL -32,SCISSORS
SPL -33,PAPER
SPL -34,SCISSORS
SPL -35,PAPER
SPL -36,SCISSORS
SPL -37,PAPER
SPL -38,STONE
SPL -39,SCISSORS
SPL -40,PAPER
SPL -41,STONE
SPL -42,SCISSORS
SPL -43,PAPER
SPL -44,STONE
SPL -45,SCISSORS
SPL -46,PAPER
SPL -47,STONE
SPL -48,SCISSORS
SPL -49,STONE
SPL -50,SCISSORS
JMP -51,STONE
; .OOO. BOOT ROUTINES .OOO.
STONE MOV >GLUG,}GLUG
 MOV >GLUG,}GLUG
 MOV >GLUG,}GLUG
 MOV >GLUG,}GLUG
 MOV >GLUG,}GLUG
 JMP -1521
SCISSORS MOV >FRED,}FRED
 MOV >FRED,}FRED
 MOV >FRED,}FRED
 MOV >FRED,}FRED
 MOV >FRED,}FRED
FRED SPL -1308,BOMB
 MOV >FRED,}FRED
 MOV >FRED,}FRED
 MOV >FRED,}FRED
 MOV >FRED,}FRED
 MOV >FRED,}FRED
GLUG DAT -1534,DBOMB
; .OOO. COMPONENTS .OOO.
;[TIMESCAPE]
TSTEP EQU 1800
CSTEP EQU 3740
NSTEP EQU -1922
FSTEP EQU 1870
PAPER SPL 1,<-200
 SPL 1,<-300
 MOV.I -1,0
TIM1 SPL @TIM1,}TSTEP
 MOV.I }TIM1,>TIM1
CEL1 SPL @CEL1,}CSTEP
 MOV.I }CEL1,>CEL1
 MOV.I {-FSTEP,<FSTEP
 MOV.I {CEL1,<NCL1
NCL1 JMP @NCL1,>NSTEP
;[CARBONITE]
DBOMB DAT >-1,>1
START1 SPL #0,<-100
 MOV DBOMB,TAR-197*3500
TAR ADD #197,-1
 DJN.F -2,<-1151
;[MINI-HSA]
STEP EQU 9
PTR EQU (BOMB-5)
BOMB SPL #1,{1
KILL MOV BOMB,<PTR
MPTR MOV >PTR,>PTR
 JMN.F KILL,>PTR
A ADD #STEP+1,@MPTR
SCAN JMZ.F A,<PTR
 SLT @MPTR,#BTM-PTR+3
 DJN KILL,@MPTR
 DJN A,#16
BTM JMP A,{KILL
END
-------------------------------------------------------------

--
  Fidonet:  John Metcalf 2:254/269
  Internet: john.metcalf@bsm-bbs.demon.co.uk

  Standard disclaimer : The views of this user are strictly their own.
  Don't delay, call today - Boiled Sweets Music BBS +44 (0)171 686 0135/6


