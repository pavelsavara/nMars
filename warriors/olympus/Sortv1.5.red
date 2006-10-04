;redcode-94
;name Sort v1.5
;author Zul Nadzri
;strategy  Round 1 Entry : Anton's Sorting Tournament 
;assert 1

org start

a       slt ITEMLIST-comp,ITEMLIST-comp
b       slt ITEMLIST-comp,ITEMLIST-comp+1 
second  mov.b ida,idb
	sub minus,b
	mov b,comp

	mov #0,second-4
start   mov *comp,second-3
comp    slt ITEMLIST,ITEMLIST+1
ida     jmp mark,ITEMS-1
adjust  sub #-1,comp

return  djn comp,idb
	sne #0,second-4
idb     jmp loop,ITEMS-1
	mov a,comp
	mov second-3,@comp

loop    djn second,ida
minus   dat #-1,#-1
mark    mov @comp,*comp  
	mov comp,a
	jmp adjust,<second-4
