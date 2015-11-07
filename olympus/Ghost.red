;redcode-x
;name Ghost
;kill Ghost
;author Pierre Baillargeon

len	equ 8
dist	equ 125
field	equ 250+bomber-target

lab	dat #0,#0
what	mov #0,#0
	dat #0,#0

mod	add #618,#-2		; change location
	mov @mod,lab
	sub lab,lab
	cmp what,lab
	jmp mod,0
	spl @mod,0
	djn mod,#3

waiter	spl target,0		; start core clear
sleep	djn sleep,#0		; wait...
	jmp waiter,0		; redo clear

target	mov #250-len,target	; init bomb distance
bomber	mov bomb,<target	; bomb
	jmn bomber,target	; rebomb if not reached us
copy	mov <target,<dist	; now copy (bomb contains right value)
	jmn copy,dist-1		; finished copying ?
	jmp @dist-2,0		; next field
bomb	dat #0,#len		; bomb contains program length
target	dat #0,#0		; ze target pointer

	end mod
