;redcode-94
;name Not Expecting Too Much 2
;author Karl Lewin
;contact lewin@netcom.com
;assert 1
;strategy Paper launched Imps (ala theMystery) with improved (I hope!)
;strategy constants and a mild brainwash additive thorwn in for good measure.

D0	EQU	745
D1	EQU	5185
OFFSET	EQU	500
INUM	EQU	2667
	ORG	first
first	spl	1,	<-200
	spl	1,	<-300
	mov	-1,	0
m1	mov	{ptr1,	<ptr1
m2	mov	{ptr2,	<ptr2
s1	spl	go3,	<-600	
s2	spl	go2,	<-700
go1	jmp	@ptr1
go2	jmp	@ptr2
go3	mov	{ptr3,	<ptr3
	jmp	@ptr3
ptr1	dat	last+1,	last+1+OFFSET+INUM*0
ptr2	dat	last+1,	last+1+OFFSET+INUM*1
ptr3	dat	last+1,	last+1+OFFSET+INUM*2
is1	spl	D0,	0
im1	mov	>is1,	}is1
im2	mov	<is1,	<is2
is2	spl	@0,	}-D1
	mov.i	last,	}12
imp	mov.i	#0,	INUM
last	stp.b	<-10,	}-10






