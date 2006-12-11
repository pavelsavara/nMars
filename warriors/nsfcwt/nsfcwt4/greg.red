;redcode-94
;NSFCWT Round 4
;contact gmeadon@mit.edu
;name Bubble-Sort
;author G. Eadon
;strategy 1) Remove Duplicates, if appropriate.
;strategy 2) Buble-Sort Remaining data (VERY SLOW).
;strategy 3) Copy Data back to 4000, reversing order if appropriate.
;I waited too long to deciede wether or not to go for size or speed...
;I guess you could have to say this is optimized for size, but really
;it's big and slow. I'd have to guess that at < 60 instructions, this'll
;be smaller than a lot of the very fast sorts (and hey -- it seems to work). 
buf_abs	equ	500
abs0	equ	buf
temp2	equ	abs0 - 1
count 	equ	abs0 - 2
swaps 	equ	abs0 - 3
stack 	equ	abs0 - 4
empty	equ	abs0 - 5

buf	dat	a=(buf_abs+abs0), a
temp	dat	b=(4000+abs0), b+1
count2	dat	1,1

;***************************************************************************
;Step 1 - Determine if duplicate instructions are removed. If they are,
;         copy buffer to be sorted to 500, removing all duplicates and
;         counting the number of instructions that remain to be sorted.
;         If dups are not to be removed, copy the buffer to 500, and
;         count the number of instructions to be sorted.
;***************************************************************************

start	jmn.a	copy2, *temp

normcpy	mov.i	>temp, >buf
	sne.i	@temp, empty
	jmp	sort	
	jmp	normcpy, >count

copy2	mov.i	>temp, >buf
x0	mov.b	buf, >temp2
;	sub.ab	#2, temp2
	mov.ba	temp2, temp2
copy	sne.i	@temp, <temp2
	jmp	skip, <count
	djn	copy, count2	

	mov.i	@temp, >buf
	nop	}temp2, }count2
skip	nop	>temp, >count
	mov.ab	count2, count2
	mov.ab	temp2, temp2
	seq.i	@temp, empty
	jmp	copy

;***************************************************************************
;Step 2 - Sort the data 
;***************************************************************************
sort	mov.f	count, stack
	mov.ba	count, count
nextpss	jmz	order, count
	mov	#0, swaps
	mov.ab	#(a+1), buf
	mov.a	#(a), buf
compare	sne.b	*buf, @buf
	jmp	Afld
	slt.b	}buf, >buf
	jmp	switch
return	djn.b	compare, count
	nop	{count
	mov.ab	count, count
	jmn	nextpss, swaps
	jmp	order
	
;***************************************************************************
;Step 2b - Sort on A field
;***************************************************************************

Afld	slt.a	}buf, >buf
	jmp	switch
	jmp	return

switch  mov.i   {buf, temp
        mov.i   <buf, }buf
        mov.i   temp, >buf
ret     jmp     return, >swaps
;***************************************************************************
;Step 3 - If the order is descending, reverse the list and write it to 4000.
;***************************************************************************
order2  mov     {(temp-order1), >(temp-order1)

order	mov.f	stack, count
	mov	#(b+1), temp
	mov.a	#a-1, temp
	nop	>count
	jmz	order1, (4000 + abs0)
	mov.i	order2, order1
	add.ba	count, temp

order1	mov	}temp, >temp
	djn	order1, count
	mov	1, >temp

	end	start







