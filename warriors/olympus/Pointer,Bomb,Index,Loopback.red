loopback	mov.i bomb,@pointer
		add.b index,pointer
		jmp loopback
bomb		dat 0,0
pointer		dat 0,0
index		dat 10,10
