;redcode-94xm
;name Anthill 4
;author Planar
;strategy quick, stone, paper
;assert CORESIZE==55440
;kill Anthill

; try to catch a few opponents early (quick stone), then survive (paper)

nstone	equ	30
spacing	equ	((CORESIZE-MAXLENGTH)/(nstone*4+1))
src	equ	(zero+(j*2+i-1)*spacing+MAXLENGTH)
dst	equ	(zero-(j*2+i-1)*spacing)

bigst01	equ	8765
bigst02	equ	43210
smlst01	equ	1234
smlst02	equ	4567

zero	spl	twin

i FOR 2

j FOR nstone
	mov.i	<src, {dst
ROF; j

	spl	1
	spl	1
	spl	1
	spl	bigst&i, 0
	mov.i	>-1, }-1
	mov.i	3, {2
	mov.i	<-3, {1
	jmp	smlst&i
	dat	<34117, <34117*2
	mov	#1, {1
	mov	#1, <1

j FOR i == 1
decoy
k FOR (MAXLENGTH-1 - (CURLINE-1)*2)
	spl	-1, k
ROF; k
twin
ROF; j

ROF; i
