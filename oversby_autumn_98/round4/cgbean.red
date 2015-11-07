;recode
;name Darkish Grey Warrior Thingy
;author WFB
;strategy For Oversby's Tournament Round 4.
;strategy Hmmm...this'll probably be bad....
;strategy Please don't laugh...
;assert 1
start
spl init
spl cs
djn.f init,<-10
;Benj's Revenge
;Robert Macrae
;Paper
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

;Carbonite++
;Attributed to Ian Sutton
;Additions from Anton Marsden
;and Christian Schmidt
carbon  spl     #0,     #0
	spl	#0,	<-1151+3
ptr	mov	197,	cad-(197*3500)
cad	add.ab	{0,	}0
	djn.f	-2,	<-1151

for 20
        dat.f   $0,     $0
rof

init	mov.i	cbmb,	*ptr
        jmp.b   carbon, >-4000

cbmb	dat	>-1,	>1


;Die Hard Imps
;Attributed to Paul Kline
;Continuous imp rings

cs	spl.b	#0,		<-700
	spl.b	imp+5334,	<1
	spl.b	imp+2667,	<-1000
imp	mov.i	#2667,		*0

end start

