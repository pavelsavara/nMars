;redcode
;name FI V1
;author PVK, but don't tell anyone
;assert 1

	org	scan-1
x	equ	scan-15

inc	dat.f	31,	30

clear	spl	#0,0
	mov.i	2,	>-2
	djn.f	-1,	>-3
	dat.f	>5335,	6
sb	spl	#1,	0
	spl	#0,0
for 22
	spl	#0,0
rof
	add.x	inc,	1
scan	mov.i	<-2,	{13
	jmz.f	-2,	<-1
chkself	slt.ab	scan,	#-8
	djn.f	scan-1,	scan
	jmp	attack,	-100;i think that this line is hit, if not, i'll just o the b-field
db2	dat.f	-5,	-5;inc's b-field point to this line
for 9
	dat.f	-100,	-100 ; might not be needed, except for the 1st one, but i'm not sure
rof
attack	mov.b	scan,	x
	mov.i	sb,	<x
	mov.i	>x,	>x
	jmn.f	-2,	>x
check	jmn.b	scan-1,	-1
	jmp clear
