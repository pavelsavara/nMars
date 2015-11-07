;redcode-94
;name handshake
;author Anders Ivner
;assert (CORESIZE == 8000)
;strategy give up every second round

RES	equ	0
HS	equ	55
F	equ	17

	org	res

res	ldp	#RES,	#res
hs	ldp	#HS,	#hs

	seq	#-1,	res	; - first?
	sne	#F,	hs	; not first - handshake?
	sne	#0,	res	; handshake or first - lost?
	jmp	nohs		; lost or (not hs and not f) -

;(won and handshake) or first
	stp	#F,	#HS
	dat	0,0

;lost or (not handshake and not first)
nohs	stp	#0,	#HS

;strategy if opponent doesn't cooperate goes here

	end
