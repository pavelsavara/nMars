;redcode-94x
;name Virus
;author Jay Han
;strategy Vampire
;macro

start		equ	20
step		equ	23
n		equ	16873

		org	bite

gate		equ	head-step

loop		add.x	head		,fang
bite		mov.i	fang		,@fang
ptr		djn.b	loop		,#n-1
head		spl.b	#step		,<-step
kill		mov.i	bomb		,<ptr
bomb		dat.f	<gate+1		,<gate
fang		jmp.b	trap-start	,start

for 16
		dat.f	0,		0
rof

pit		spl.b	#0		,<gate
trap		jmp.b	pit		,<gate

for 15
		dat.f	0,		0
rof

fool		equ	55440/319
m for 160
		dat.f	fool*m,		-fool*m
rof

		end	bite
