;redcode
;name fireworks
;author Brian Haskin
;strat draw fireworks
;strat runs with a -v of 714
;strat the width of the display should be 158 instructions
;assert CORESIZE==8000

	org star
first   equ 2880
fcirc   equ 1800
row     equ 158

sinc    dat 1041,1041 ;567,567
sptr    dat star,star
cinc    dat 521,521
cptr    dat circ,circ

star    mov first,first+row+1
	mov star+first+row-1,star+first-row-1
	mov star+first-row+1,star+first+(row*2)+2
	mov star+first-(row*2)-2,star+first-(row*2)+2
	mov star+first-(row*3)+3,star+first+(row*2)-2
	mov star+first+(row*3)+2,star+first-(row*3)+4
	mov star+first+(row*3)-2,star+first-(row*3)-3
	mov star+first+(row*4)-3,star+first+(row*4)+3
	mov star+first-(row*3)-4,star+first+(row*6)-3
	mov star+first+(row*6)+3,star+first-(row*2)-5
	mov star+first-(row*2)+5,star+first

	add.f sinc,>sptr
	djn -1,#11
	mov #11,-1
	mov.ab sptr,sptr
	djn 0,#2000
	mov #2000,-1

circ    sne fcirc-row,fcirc+row
	sne circ+fcirc-1,circ+fcirc+1
	sne circ+fcirc+(row*2)+2,circ+fcirc+(row*2)-2
	sne circ+fcirc-(row*2)+2,circ+fcirc-(row*2)-2
	sne circ+fcirc+3,circ+fcirc-3
	sne circ+fcirc+(row*3),circ+fcirc-(row*3)
	sne circ+fcirc+5,circ+fcirc-5
	sne circ+fcirc+(row*5),circ+fcirc-(row*5)
	sne circ+fcirc+(row*4)+4,circ+fcirc-(row*4)-4
	sne circ+fcirc+(row*4)-4,circ+fcirc-(row*4)+4

	add.f cinc,>cptr
	djn -1,#10
	mov #10,-1
	mov.ab cptr,cptr

	djn 0,#2000
	mov #2000,-1

	djn star,#20

	end
