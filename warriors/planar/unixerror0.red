;redcode-94
;name test ue0c
;author Planar
;assert CORESIZE == 8000
;kill test

;xname Error 0
;xstrategy I'll tell you in Core Warrior 24 (maybe).
;xstrategy quick scan pspace boot clear stun stone

; quick-scan to find decoy
; guess opponent's boot distance
; start a core-clear right next to him
; use p-space to change our guess until it works well


; p-space addresses

Lastrnd	equ	0
Param	equ	047
Parmnew	equ	113


step	equ	3039
bstep	equ	2892
istep	equ	(-2909)      ; 2667; 1143; -2909; 3077; 2353
clroff	equ	2500
djnoff	equ	950
impoff	equ	300
ssd	equ	1            ; flag: 0 -> SPL/DAT;       1 -> SPL/SPL/DAT


; Quick-scan:  Quickly find the enemy.

early1	equ	6
early2	equ	12
QSlen	equ	20
spc	equ	((CORESIZE-100)/4/QSlen)

first	equ	(here+spc)
here
i FOR early1
	sne.i	first+i*4*spc-4*spc, first+i*4*spc-3*spc
	seq.i	first+i*4*spc-2*spc, first+i*4*spc-1*spc
	mov.ab	#first+i*4*spc-1*spc-found, found
ROF; i
	jmn.b	rescan, found
i FOR (early2-early1)
	sne.i	first+(i+early1)*4*spc-4*spc, first+(i+early1)*4*spc-3*spc
	seq.i	first+(i+early1)*4*spc-2*spc, first+(i+early1)*4*spc-1*spc
	mov.ab	#first+(i+early1)*4*spc-1*spc, found
ROF; i
	jmn.b	rescan, found
i FOR (QSlen-early2)
	sne.i	first+(i+early2)*4*spc-4*spc, first+(i+early2)*4*spc-3*spc
	seq.i	first+(i+early2)*4*spc-2*spc, first+(i+early2)*4*spc-1*spc
	mov.ab	#first+(i+early2)*4*spc-1*spc, found
ROF; i
	jmn.b	rescan, found

; The enemy was not found.  Launch back-up strategy: imp spiral

	mov.i	alt, src
	mov.ab	#5, boot+1
	jmp	boot, <-1900


; The enemy is in one of these locations:
;    @found, (@found)-spc, (@found)-2*spc, or (@found)-3*spc
; Find out which one exactly.

found	sub.ab	#spc, #0
rescan	sne.i	here-1, @found
	djn.b	-2, #4

think
	ldp.ab	#Lastrnd, #1000          ; load last round's result
	jmn.b	wontied, -1

param	equ	dest

lost
	ldp.a	#Parmnew, param          ; load parameter
	stp.ab	param, #Param
newparm	add.ab	param, #step
	stp.b	newparm, #Parmnew
	jmp	attack, <-2300

wontied	ldp.a	#Param, param
	stp.ab	param, #Parmnew

attack	add.ba	found, param


boot	mov.i	{src, {dest
	djn.b	boot, #6+ssd
	add.ba	offs, dest
dest	spl	-505, <-1800
	sub.f	-1, -1          ; erase boot pointer

src
offs	dat	cclast+1, 2+ssd


; The spiral launcher

	spl	#1, >prime
ptr	spl	imp+impoff-2*(istep+1), {700
	add.f	#istep+1, ptr
prime	mov.i	imp, imp+impoff-3
imp	mov.i	#-3, istep

alt	nop	imp+1-src, 0          ; DAT for one spiral, NOP for two

; The core-clear

p	dat	2, clroff
	dat	1, 20
FOR ssd
	spl	#3, 20
ROF
cc	spl	#1, 20
	mov.i	*p, >p
change	mov.i	*p, >p
cclast	djn.b	-2, <p-djnoff

; The stone and core-clear, only 4 instructions and a space.

;step1	equ	2197
;step2	equ	(-226)
;xx	equ	(3+step1)
;yy	equ	(2-2766*step2)
;
;	spl	#step1, <step2
;	mov.i	}xx, yy
;	add.f	-2, -1
;	dat	0, 0
;stlast	mov.i	1, <-2

	end


Revision history:

test ue0a:
  simplified pspace logic, reverse rescan, backup stone,
  with ssd, no quick-scan increment

test ue0b:
  unified bootstrap with loop

test ue0c:
  longer QS
  backup changed to a pair of spirals instead of stone+spiral
