;redcode-94
;name test c0a
;author Planar
;assert CORESIZE == 8000
;kill test


; *** parameter set A
step	equ	406       ; 867
stream	equ	-1736

; *** parameter set B
;step	equ	454       ; 1163
;stream	equ	-2328

; *** parameter set C
;step	equ	238       ; 1479
;stream	equ	-2960

; *** parameter set D
;step	equ	326       ; 1226
;stream	equ	-2456

; *** parameter set E
;step	equ	82        ; 1561
;stream	equ	-3124

	sub.x	#step, 2
start	spl	-1, <-3
	mov.i	{stream, -1-step
	
	end	start
