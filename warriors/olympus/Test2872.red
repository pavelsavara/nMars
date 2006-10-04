;redcode-b
;name Test 2 872
;author Steve Bailey
;assert 1
OFFSET  equ     872
ZAP	equ	-50
start	spl     exec,   <1111
	spl     exec,   <2222
	jmp     exec,   <3333
const   dat     #const, #const+OFFSET
exec    mov.i   }const, >const
	djn.f   exec+OFFSET, <ZAP
	end     start
