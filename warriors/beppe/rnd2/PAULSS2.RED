Thanx for the reminder Beppe. Hope this works.

Had a look at Phill's published warriors: he'll make a scanner.
(Or he finds myVamp and makes a stone)
(or he doesn't think and makes a paper :-)

Eight processes is ideal for airBag tecnology!
Tornado stone, d-clear with only two-four 
instructions sensitive to bombing!
I will probably loose since I underestimate my
opponent and haven't tested the warrior wery much.

;redcode
;name ABC-80
;author Paulsson
;assert 1

org start
gate	equ		bmb-3
st		equ		85
kill	add.f	step,ptr
		mov.i	bmb,@ptr
hit
ptr		mov.i	hit+st*3,@hit+st*4
		mov.i	>check,*ptr
		jmz.f	kill,<check
		jmp		step+1
for 33
		dat.f	0,0
rof
start	spl	1
		mov.i	-1,0
		spl	2
		jmp	@2,}0
		jmp *1,}0
		dat.f	kill+2,kill+1
		dat.f	kill+4,kill+3
		dat.f	kill+1,kill
for 35
		dat.f	0,0
rof


		dat.f	0,st
		dat.f	0,st
bmb		jmp		@0,st
check	dat.f	0,0
step	spl		#3*st,3*st
		mov.i	bmb-1,>gate
		djn.f	-1,>gate
		jmp		step
