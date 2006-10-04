;redcode-94
;author Franz
;name Neverending Brutality 7
;rating 105.54 wilkies
;strategy Quickscan/Brainwasher/Pittrapper/Coreclear/IMPgate:
;strategy ----------------------------------------------------------------
;strategy 1) Quickscan (new in v7)
;strategy 2) boots up to 5 different locations in core, 2 data 1 coreclear
;strategy    1 trapper, 1 pit
;strategy 3) starts trapper (modulo 5, nonsplitting)
;strategy 4) when done calls coreclear routine to kill the enemy
;strategy 5) converts to 150% c IMP gate
;strategy ----------------------------------------------------------------
;strategy the pit is a SPL only pit that tries to cripple the enemy asap
;strategy in spare time the pit brainwashes pspace type enemies
;url http://www.azstarnet.com/~franz
;assert CORESIZE==8000

opt EQU 2365
pit EQU trapper

INSTALLT EQU 2000
INSTALLC EQU -3000
INSTALLP EQU -2700
INSTALLB EQU 1500

QB EQU (start+400)
QS EQU 200
QD EQU 100
COUNT EQU 6

GAP EQU 15
REP EQU 6

		ORG start

		DAT 10*QS,2*QS ; can get 21 values from this table
table		DAT 4*QS,1*QS  ; and can also use the initial value
		DAT 23*QS,3*QS ; of fnd

qbomb		JMP -200,GAP
qinc		DAT GAP,-GAP

tab 		ADD.A table,table
slow		ADD.AB @tab,fnd
fast		ADD.B *tab,@slow
which		SNE.I datz,@fnd
		ADD.AB #QD,fnd

		MOV.I qbomb,@fnd
fnd		MOV.I -GAP/2,@QB
		ADD.BA fnd,fnd
		MOV.I qbomb,*fnd
		ADD.F qinc,fnd
		MOV.I qbomb,@fnd
		DJN.B -3,#REP
		JMP boot,}-300

start
         seq.i  QB+QS*0,QB+QS*0+QD
         jmp    which,}QS*13 ; qinc+GAP

         seq.i  QB+QS*1,QB+QS*1+QD
         jmp    fast,}QB+QS*1+QD/2
         seq.i  QB+QS*2,QB+QS*2+QD
         jmp    fast,{tab
         seq.i  QB+QS*3,QB+QS*3+QD
         jmp    fast,}tab

         seq.i  QB+QS*13,QB+QS*13+QD
         jmp    fast,{fast

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

boot		MOV coreclr,pit+INSTALLP
		MOV p2,pit+1+INSTALLP
		MOV p3,pit+2+INSTALLP
		MOV p4,pit+3+INSTALLP
		MOV trapper,trapper+INSTALLT
		MOV tr2,tr2+INSTALLT
		MOV tr3,tr3+INSTALLT
		MOV tr4,tr4+INSTALLT
		MOV coreclr,coreclr+INSTALLC
		MOV cc2,cc2+INSTALLC
		MOV cc3,cc2+1+INSTALLC
		MOV bombstart,cc2+2+INSTALLC
		MOV bomb,bomb+INSTALLB
		JMP trapper+INSTALLT
bomb		DJN.F bombstart-INSTALLT+pit-opt+INSTALLP,<bombstart-INSTALLB+INSTALLT+opt
bombstart	DAT <-1-80,<-(opt+1)

trapper		MOV bomb-INSTALLT+INSTALLB,@bomb-INSTALLT+INSTALLB
tr2		SUB coreclr-INSTALLT+INSTALLC,bomb-INSTALLT+INSTALLB
tr3		JMZ trapper,bombstart
tr4		DJN coreclr-INSTALLT+INSTALLC,<trapper-81

p4		JMP -3,>-1

coreclr		SPL #opt,<-opt
cc2		MOV 2,<coreclr-5
p2		SPL -1,{1
p3		STP.AB #-66,#0

cc3		DJN.F -1,<-83

datz		DAT 0,0
bottom		END

