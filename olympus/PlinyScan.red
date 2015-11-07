;redcode-b
;author G. Eadon
;name PlinyScan
;contact gmeadon@mit.edu
;NSFCWT Round 2
;strategy CMP Scanner for NSFCWT Round 2 White Warrior Challenge

step	equ	5
init0	equ	95
init1	equ	100
inc	dat	#(2*step), #(2*step)

scan	add.f	inc, pos
pos	seq.x	init0, init1
	jmp	attack
loop	djn	scan, #((7900-init1)/(2*step))

sp	mov.i	wipe0, @wipe2
	djn	sp, wipe2
	mov	#(sp-wipe2-1), wipe2
	djn	sp, #2
	mov	#7999, -1
	jmp	sp, {sp

wipe2   dat     <-1874, sp-1 
wipe0   spl     0, <3740

attack	mov	wipe0, >pos
	mov	wipe0, }pos
	djn	attack, #(step+1)
	mov.ab	#(step+1), -1
	djn	loop, loop
last	jmp	sp	

	end	scan
