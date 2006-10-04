;redcode-94x
;name test ue1a
;author Planar
;assert CORESIZE == 55440
;kill test

;xname Not owner
;xstrategy 
;xstrategy scan pspace boot clear stun

; "quick"-scan to find decoy
; guess opponent's boot distance
; start a core-clear right next to him
; use p-space to change our guess until it works well


; p-space addresses

Lastrnd	equ	0
Param	equ	243

; Parameters.  There's a lot of design space, here.

scstep	equ	200
pstep	equ	3039
clroff	equ	3500

djnoff	equ	950
ssd	equ	1            ; flag: 0 -> SPL/DAT;    1 -> SPL/SPL/DAT

first

; fast scan:  Quickly find the enemy.

incr	dat	2*scstep, 2*scstep

start	add.f	incr, start
target	sne.i	first+200-2*scstep, first+400-2*scstep
found	djn.b	start, #138

	jmz.b	nfound, found

; Change or keep parameter.

think
param	ldp.ab	#Param, #1000            ; load parameter

; Change parameter if last round was lost.
	ldp.ab	#Lastrnd, #0
	jmn.b	attack, -1

lost	add.ab	#pstep, param

attack	add.b	param, target            ; give parameter to attack module

boot	mov.i	last, *target
	mov.i	{boot, {target
	mov.i	{boot, {target
	mov.i	{boot, {target
	spl	*target, <-1000
FOR ssd
	mov.i	{boot, {target
ROF; ssd
	mov.i	{boot, {target
	mov.i	{boot, {target
	sub.f	target, target           ; erase boot pointer

p	dat	2, clroff
	dat	1, 20
FOR ssd
	spl	#3, 20
ROF; ssd
cc	spl	#1, 20
	mov.i	*p, >p
	mov.i	*p, >p
last	djn.b	-2, <p-djnoff


; Enemy was not found.  Launch a paper.

	spl	1, <-2000
	spl	1, <-3000
	spl	1, <-4000
	spl	1, <-5000

	spl	@0, >st1
	mov	}-1, >-1
	spl	@0, >st2
	mov	}-1, >-1
	spl	@0, >st3
	mov	}-1, >-1
	mov	{-6, <1
	jmp	st4, <-1000

	end	start
