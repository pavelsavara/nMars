;redcode
;name P-Space test #1
;assert 1
load0 z	for 0
	rof

dat0	equ	(load0-10)

;- Assert that p-space remembers things.
;
p0:	ldp.ab	#0, #0
	sne	#-1, p0
	jmp	init

;- assert that P[i]=i for i=1..PSPACESIZE-1
loop:	ldp	#PSPACESIZE-1, #0
	sne.ab	loop, loop
	djn.a	loop, loop
	jmz.a	stall, loop
	dat	1,1

; initialise P[i]=i for i=1..PSPACESIZE-1
init:	stp.b	#0, #PSPACESIZE-1
	djn.b	-1, -1
stall:	jmp	0,0
	


	end
