;redcode-94
;name Let's Run Benj's Revenge
;author Robert Hale
;assert 1
;strategy early testing indicate benj's revenge does best
;strategy so due to the holidays I run benj's revenge
;strategy the rest is dead weight


;r edcode-94
;n ame Benj's Revenge
;a uthor Robert Macrae
;s trategy Paper
;a ssert 1

len     EQU 9
fcp     EQU 3039
scp     EQU 2365
tcp     EQU 777

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
        jmp	-1,	<-10
        dat	<2667,	<2667*2



for 75
	dat.f	$0,	$0
rof

;r edcode-94
;n ame Die Hard Imps
;a uthor Attributed to Paul Kline
;s trategy Continuous imp rings
;a ssert 1

cs	spl.b	#0,		<-700
	spl.b	imp+5334,	<1
	spl.b	imp+2667,	<-1000
imp	mov.i	#2667,		*0

init	mov.i	cbmb,	*ptr
	jmp.b	carbon,	>-4000

cbmb	dat	>-1,	>1
;r edcode-94
;n ame Carbonite++
;a uthor Attributed to Ian Sutton
;s trategy Additions from Anton Marsden
;s trategy and Christian Schmidt
;a ssert 1

carbon	spl	#0,	#0
	spl	#0,	<-1151+3
ptr	mov	197,	cad-(197*3500)
cad	add.ab	{0,	}0
	djn.f	-2,	<-1151

	end	boot
==
Robert G. Hale
rghale@earthlink.net
rg_hale@yahoo.com

_________________________________________________________
DO YOU YAHOO!?
Get your free @yahoo.com address at http://mail.yahoo.com

