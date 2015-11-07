;redcode
;name I like white
;assert 1
;author Paul-V Khuong
;strategy mod 16 66% one-shot ---> anti-imp stargate
        org     start
inc	dat.f	3024,	-3024
pp	dat.f	4,	0
start	add.f	inc,	@2
	jmn.f	3,	@pp
	jmz.f	-2,	*pp
	mov.x	@0,	pp
sb	spl	#-1,	9
	mov.i	*3,	>pp
	djn.f	-1,	<inc-9
db	dat.f	sb-1,	9
bp	dat.f	sb,	0
end
