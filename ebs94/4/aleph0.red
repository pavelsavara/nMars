;redcode-94
;name Aleph 0
;author Jay Han
;macro

; Some quickscan, then a stone.
; This beats some larger programs, does dismally against vampires,
; and the stone/imp combo is pretty weak.
; Oh well...  Hopefully there isn't any huge bug.

		org	entry

j		equ	6
n		equ	22
s		equ	(((CORESIZE-(2*MINDISTANCE)-MAXLENGTH)*4)/((4*n)+1))
q		equ	(s/4)
h		equ	(q/2)
a		equ	(head-MINDISTANCE)
l		equ	((2*q)+MAXLENGTH)
k		equ	(l/j+1)
d		equ	1000

head
test		seq.i	@-1,		@0
		add.ab	#2*q,		@-1
		add.b	test,		bite
		add.b	@test,		bite
		mov.i	pit,		>bite
		mov.i	mega,		>bite
stun		mov.i	bite,		@bite
		add.f	vamp,		bite
		djn.b	stun,		#k

copy		mov.i	>ptr1,		<bite
		djn.b	copy,		#4
ptr1		jmp.b	@bite,		bomb

pit		spl.b	#s2,		s1
mega		mov.i	2,		>-1

adder		add.a	#step,		jumper
bomb		dat.f	<-j-2,		<-j-1
		jmp.b	-1,		<-j-2
		mov.i	2,		<-j+1
vamp		spl.b	#j,		<-j

bite		jmp.b	-2,		#test

p2		equ	-73+(972*s2)
s2		equ	-74
p1		equ	75+(972*s1)
s1		equ	74

cast		mov.i	<p1,		p2
stone		spl.b	cast,		<pit
		add.x	pit,		cast
		djn.f	stone,		<test

imp		mov.i	0,		step

entry
m for 22
		sne.i	a-(m*s),	a-(m*s)+(2*q)
		seq.i	a-(m*s)+q,	a-(m*s)+(3*q)
		sub.x	#test+2,	@test
rof

		jmn.b	test,		test
		spl.b	stone

; makeimp v3: Automatic imp-spiral generator by Jay Han, 5/6/1994.
; 6-process 3-point spiral (size 8000, '94)
step		equ	2667
launch
		spl	1
		spl	1
		mov.i	-1,		0
		spl	adder
jumper		jmp	imp

		end
