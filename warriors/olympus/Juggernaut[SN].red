;redcode-x
;author Scott Nelson
;name Juggernaut
;strategy Copy to the next area, then jump there.
;kill Juggernaut
 
s	dat		#0
d	dat		#0
count	dat		#25
start	mov	#0,	s
	mov	#106,	d
	mov	#25,	count	;25*4 copies==100 locations copied
jn	mov	>s,	>d
	mov	>s,	>d
	mov	>s,	>d
	mov	>s,	>d
	djn	jn,	count
 
	jmp	start+107
 
pit	spl	1
	spl	-1
	spl	-2
	jmp	-2
for 76
	jmp	pit
rof
	end	start
