;redcode-94x
;name Anthill 5
;author Planar
;strategy quick, stun, paper
;assert CORESIZE==55440
;kill Anthill

; try to catch a few opponents early (quick stun), then survive (paper)

nstun	equ	11
spacing	equ	300
targ1	equ	(zero-3000-(j*4+i*2-2)*spacing)
targ2	equ	(zero-3000-(j*4+i*2-1)*spacing)

bigst01	equ	1500
bigst02	equ	2500
smlst01	equ	100
smlst02	equ	170

zero

start	spl	twin02

i FOR 2

twin&i

j FOR nstun
	jmn.f	3, @2
	mov.ab	#targ2, 1
	jmz.f	3, targ1
	mov.i	bomb1&i, >-1
	mov.i	bomb2&i, @-1
ROF; j

j FOR i==1
	spl	pap02
ROF
j FOR i==2
	spl	pap01
ROF
pap&i	mov.i	11, #0               ; only one process will get through
	spl	clear&i
	spl	1, 1
	mov.i	-1, #1
	mov.i	-1, #1
	mov.i	-1, #1
	spl	bigst&i, 0
	mov.i	>-1, }-1
	spl	smlst&i, 0
	mov.i	>-1, }-1
	seq.ab	#9, -2               ; check number of processes
	dat	<smlst&i*2-2, -3
	mov.i	-1, >-4
	mov.i	-2, >-5
	djn.f	-2, <-3

clear&i
j FOR nstun
	mov.i	bomb3&i, targ1
	mov.i	bomb3&i, targ2
ROF; j

	dat	1, 1
bomb1&i	mov.i	1, >1
bomb2&i	spl	-1, 1
bomb3&i	mov.i	-1, <-1

ROF; i
