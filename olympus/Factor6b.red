num  equ 4501
factor2 equ loop+4000

first	
x   	dat #num		; input number

tmp	sub #0, x-tmploc

next1	sub #1, factor
	add #next-next1, jptr
next	add #2, factor		; try next possible factor
start	mov factor, factor2
	add factor2, factor2    ; divide by 2F, then divide remainder by F
again   mov x, test
	slt test, factor2	; this line necessary for small prime factors
loop    sub factor2, test	; "division" by 2F loop
	slt test, factor2
loc	jmp loop, first		; keep subtracting	
	slt test, factor	; test is x % 2F
	sub factor, test 	; now test = x % F
	jmz found, test		; remainder ==0, found factor
	cmp #89, factor
jptr	jmp @0, next1
	mov x, <loc		; x is prime, save and die

factor	dat #1, #2		; current factor to try
	
found	mov factor, <loc	; save factor
	mov #0, x
	mov tmp, tmploc
	add test, tmploc
tmploc	sub #0, x
	cmp #1, x		; if x==1 we're done, so die
 	jmp again		; recheck same factor
	  	
test	end start
