;name Particle Sorter
;author Mole IX
;strategy Bubble sorter
;strategy 12 instructions
;assert 1

tmp     equ                     loop_a-1

loop_a  mov.b   d2,             d1
	nop.f   >loop
	mov.b   loop,           l
loop    slt.b   >l,             ITEMLIST-1
l       jmp     d1
	mov.f   @loop,          tmp
	mov.f   <l,             @loop
	mov.f   tmp,            >l
d1      djn     loop,           #0
start   jmz.b   finish,         #ITEMS
d2      djn     loop_a,         #ITEMS
finish  dat     0

end     start
