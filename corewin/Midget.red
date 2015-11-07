;redcode
;name Midget
;author Chip Wendell
;strategy stone (bomber)
;history Third place at the 1986 ICWS tournament
Bomb	dat	#0,	#-980
Spacer	equ	28
Start	mov	Bomb,	@Bomb
	sub	#Spacer,Bomb
	jmp	Start,	#0
	end	Start
