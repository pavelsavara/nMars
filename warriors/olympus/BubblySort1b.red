;redcode-94
;name Bubbly Sort 1b
;author Ilmari Karonen
;strategy Going for the size point with this one..
;strategy I hope I'm not too late, good reason:
;strategy  I've spent the last twelve days a few
;strategy  kilometers away from the nearest modem,
;strategy  and so couldn't participate earlier, or
;strategy  even know that the tournament had begun
;strategy Written and optimized in a few hours for
;strategy size only!
;strategy  length: 10 instructions
;strategy  speed: ITEMS*(ITEMS-1)/2 comparisons
;strategy         1 comparison = 2 cycles
;strategy         1 swap = 7 cycles (!)
;date Jul 14, 1997
;planar sort
;assert MAXLENGTH > 10

LAST    equ     (ITEMLIST+ITEMS-1)
temp    equ     (swap-1)

	org     loop

swap    mov.i   @ptr, temp
	mov.i   *ptr, >ptr
	mov.i   temp, }ptr
loop    slt.b   <ptr, {ptr
	djn.b   loop, count
	jmn.b   swap, count
count   mov.ab  #ITEMS-1, #ITEMS-1
	add.f   count, ptr
	djn.f   loop, count
ptr     dat.f   LAST, LAST+1

	end
