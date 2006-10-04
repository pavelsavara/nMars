;redcode-94
;name Vtest
;author Planar
;strategy scan, vamp, stun, clear, gate, stone
;assert CORESIZE==8000


step	equ	78
bstep1	equ	1235    ; mod 5
bstep2	equ	88      ; mod 8
runlen	equ	20

xx	equ	3

gate	dat	clear, pit
fang	jmp	pit-xx, xx
steps	dat	-step, step

i FOR 20
	dat	0, 0
ROF

stone1	spl	#bstep1, <bstep1
	add.f	stone1, 1
	mov.i	<-3+bstep1, 4000-3+bstep1
	djn.f	-3, <gate-1

i FOR 20
	dat	0, 0
ROF

loop	add.f	steps, @ptr+1
ptr	jmz.f	loop, @fang
	mov.i	fang, @fang
	djn.b	loop, pit+2
	jmn.b	clear, pit+3
	spl	stone1+2

stone2	dat 0, 0            ;spl	#bstep2, <bstep2
	add.f	stone2, 1
	mov.i	<-6, 4000-6
	djn.f	-3, <gate-1

i FOR 20
	dat	 0, 0
ROF

; Core Clear stolen from CW 13

clear	spl	#kill-gate, pit-gate
	mov.i	*gate, >gate
	mov.i	*gate, >gate
	djn.b	-2, {gate-20
kill	dat	kill-gate, pit-gate

i FOR MAXLENGTH-CURLINE-3
	dat	0, 0
ROF

pit	mov.i	1, >1
	spl	-1, 1
	dat	0, runlen

	end loop
