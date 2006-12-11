;redcode-94
;name Points is Points
;author Karl Lewin
;assert 1
;strategy  A simple selection sort.  Not real efficient 
;strategy  but kinda small so maybe it won't end up losing
;strategy  me too many points this round :)
;strategy  
;strategy  (That is if it really does work)
;strategy
;strategy  I'm pretty sure that as the size of the data block
;strategy  being sorted goes up, my program gets rapidly slower
;strategy  so be patient if many of the samples are towards the
;strategy  large end of the range :)

	ORG	startup
empty	EQU	last+1
INPUT	EQU	4000-44
reset	dat	#last+INPUT+1-comploc,#last+INPUT+2-comploc
comploc	dat	#last+INPUT+1,	#last+INPUT+2
;----------- Selection Sort (Kind of) ----------------
loop1b	slt.b	comploc,#last+INPUT+2-loop1b
insptr	jmp	fndmax,	#last+INPUT+1
        ;---this next section is the compare routine inlined
start	mov.ab	#0,	compare
	sne.i	@comploc,empty
a_or_d	jmp	compare,>compare
	sne.b	*comploc,@comploc
	jmp	gt_a
	slt.b	*comploc,@comploc
	jmp	compare,>compare
	jmp	compare
gt_a	sne.a	*comploc,@comploc	
	jmp.a	compare
	slt.a	*comploc,@comploc
	jmp	compare,>compare
	;---end compare routine
compare	sne.ab	#0,	#0
	mov.ba	comploc,comploc
	jmp	loop1b,	>comploc
fndmax	sne.ab	reset,loop1b
sorted	jmp	setupcp,#last+INPUT+1+2000
	mov.i	*comploc,>sorted
	mov.i	@insptr,*comploc
	mov.i	empty,	@insptr
	nop	}reset,	>reset
	mov.i	reset,	comploc
	jmp	loop1b,	>insptr
;---------- Startup Section -------------------------
startup	seq	@loop1b,empty
	jmp	startup,>loop1b
	add.ab	#loop1b-comploc,loop1b
	sne	#0,	last+INPUT
	mov.a	#1,	compare
	jmp	start
;---------- Copy & Remove Duplicates ----------------
curp	dat	#last+INPUT+1+2000,#last+INPUT+1
keepdup	seq	#0,	#0
setupcp sne.a	#0,	last+INPUT
	mov.i	keepdup,cpybck
cpybck	sne.i	*curp,	@curp	
	jmp	next,	}curp
	seq.i	@curp,	empty
	jmp	cpybck,	>curp
	mov	}curp,	@curp
next	mov.ab	#last+INPUT+1-curp,curp
	seq.i	*curp,empty
last	jmp	cpybck	

	






