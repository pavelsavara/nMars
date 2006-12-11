From: 	 MARGIE   YEAGER
Sent: 	17 December 1998 00:00
To: 	ian@i-next.co.uk
Subject: 	Round #4 entry

Here it is:

;redcode
;name I hope this works...
;author Josh Yeager
;strategy Split one Benj's,one Carbonite , one imp, and make a cc.
;strategy Wonder if the cc'll be worth it?
;assert 1
len     EQU 9
fcp     EQU 3039
scp     EQU 2365
tcp     EQU 777
;Initialize
spl	boot,<2000
spl	cs, <3000
spl	init, <4000
;Make the cc
mcc	mov ccj,ccptr
;Imp
cs	spl.b	#0,		<-700
	spl.b	imp+5334,	<1
	spl.b	imp+2667,	<-1000
imp	mov.i	#2667,		*0
;Benj's
boot	spl	1,	>-3000    ; 7 processes replace 9 in CCPaper
	spl	1,	<-3200    ; for cost of extra Mov in launcher.
	mov	-1,	#0

frog    spl	@0,	<fcp-len
        mov	}-1,	>-1
        mov	}-2,	>-2
        spl	@0,	<scp
        mov	}-1,	>-1
        spl	@0,	<tcp
        mov	}-1,	>-1
        mov	2,	<-fcp+len+1   ; Wipe uncle.
ccj     jmp	-1,	<-10
        dat	<2667,	<2667*2

;Carbonite
carbon spl	#0,	#0
	 spl	#0,	<-1151+3
ptr	 mov	197,	cad-(197*3500)
cad	 add.ab	{0,	}0
	 djn.f	-2,	<-1151

for 20
	 dat.f	$0,	$0
rof

init	 mov.i	cbmb,	*ptr
	 jmp.b	carbon, >-4000
for 20
	dat $0,$0
rof

ccs	 mov cbmb,>50
ccptr  dat	$0,$0
cbmb	 dat	>-1,	>1
;End of program


