;redcode-94
;name Evil Jedimps
;author John K W
;strategy Jedimp for KOFACOTO Round 4
;assert 1

org start

d2    equ 1143;2667
TSTEP equ 3120;1751
bstep equ 2365;1819 ;2283 ;1997
boot  equ 1700-(80+15)*4-1

start	spl     1
        spl     1
        spl	e4
        spl     1
        mov     <b,	{b
b:	jmp     boot,   imp2+1
evol:   spl     @evol,  }TSTEP
        mov.i   }evol,  >evol
evoli:	spl	#d2,	bstep-1
        mov     bomb,	>2
        add.f   evoli,  j
j:      jmp.f   imp2-(d2+1), {-4+bstep
bomb	dat	{1,	{2
imp2    mov.i   #d2,	*0

for 75
dat 0,0
rof

d    equ 2667

e4:	spl	#d,	bstep-1
        add.f   e4,	1
	jmp.f   imp-(d+1), {-4+bstep
imp	mov.i   #d,	*0
end
