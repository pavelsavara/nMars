;redcode-b
;name Silk
;author Lifted from Core Warrior # 1
;assert 1
OFFSET  equ     100
start	spl     1,      <1111
	mov	-1,	0
silk	spl.a	@0,	OFFSET
	mov.i   }silk,  >silk
	jmp.a	silk,	{silk
	end     start
