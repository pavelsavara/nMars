;name Imp Spiral
;author Walter Hofmann <walterh@gmx.de>
; taken from the FAQ

; grid 79x79 (igcdex)
; 5461 for 8 imps
; 4681 for 4 imps

IMPSIZE	EQU 5461
example	spl 1			; extend by adding more spl 1's
	spl 1
	spl 1
	spl 2
	jmp @0, imp
	add #IMPSIZE, -1	; bump address by impsize after each jmp
	dat #0, #0		; excess processes must die!
imp	mov 0, IMPSIZE		; in '94 use -> mov.i #0,IMPSIZE
