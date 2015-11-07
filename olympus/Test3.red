;redcode-b
;name Test 3
;author Steve Bailey
;assert 1
OFFSET  equ     872
ZAP	equ     -50
start	spl     exec,	<1111
	spl     exec,	<2222
	spl     exec,	<3333
	djn.f	#0,	<ZAP
const   dat     #const, #const+OFFSET
exec    mov.i   }const, >const
	djn.f   exec+OFFSET, <ZAP
	end     start
