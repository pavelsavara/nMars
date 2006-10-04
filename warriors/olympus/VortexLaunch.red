;redcode-94
;author Ilmari Karonen
;name Vortex Launch
;strategy Build 8 infinite interleaved imp spirals

	org split

split	spl	1
	spl	1
	spl	1		; delete this line for 3-point
vortex	spl	#0
	add.a	#1143, launch	; use #2667 for 3-point
launch	jmp	imp-1144	; use imp-2668 for 3-point

imp	mov.i	#1143, *0	; use #2667 for 3-point

	end
