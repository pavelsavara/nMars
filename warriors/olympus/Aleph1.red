;redcode-94x
;name Aleph 1
;author Jay Han
;macro

		org	entry

; Avoid quickscanners
for 15
		dat.f	0,		0
rof

; Modified constants: more thorough bombing (Mod-2)
p1		equ	8751
s1		equ	17498
p2		equ	46693
s2		equ	-17498

gate		equ	inc-28
offset		equ	inc-18

; This stone ends with a two-pass (SPL/DAT) core-clear and gate
inc		dat.f	s1,		s2
top		dat.f	0,		patch+1 ; pointer
loop		add.f	inc,		cast
stone		spl.b	loop,		<gate	; This gets replaced by patch
cast		mov.i	<p1,		p2
buckle		djn.f	stone,		<gate	; This gets replaced by stop
stunner		spl.b	#0,		#bomb-ammo
stop		dat.f	<gate-buckle,	#1
; The core-clear starts here
clear		spl.b	#0,		<gate
kill		mov.i	@ammo,		<patch+1 ; This gets decremented
bomb		dat.f	<gate,		#stop-ammo
patch		djn.f	clear-stone,	<gate-stone
ammo		dat.f	0,		stunner

; More void for quickscans
for 156
		dat.f	0,		0
rof

; This is my wimp, as usual
split		spl.b	#0,		<-199
wimp		djn.f	#0,		<-200
entry		spl.b	stone

; The wimp is copied slightly ahead of the stone
newimp		mov.i	wimp,		offset
		mov.i	split,		<newimp
		spl.b	@newimp

; Boot spiral-head away
step		equ	29179
imp		mov.i	0,		step
		spl	1		
		mov.i	-1,		#0
		mov.i	-1,		#0
		spl	1		
		mov.i	-1,		#0
		spl	1		
		spl	2		
		jmp	imp+step
		add.a	#step,		-1
; There should be a DAT right here

		end
