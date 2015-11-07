;redcode
;name Mice
;author Chip Wendell
;strategy paper (replicator)
;history Winner of the 1986 ICWS tournament
Top	dat	#0,	#0
Start	mov	#12,	Top
Loop	mov	@Top,	<Target
	djn	Loop,	Top
	spl	@Target,0
Spacer	equ	653
	add	#Spacer,Target
	jmz	Start,	Top
Target	dat	#0,	#833
	end	Start
