;name GCD
;finds the Greatest common divisor of a and b
tmp	dat #0
a	dat #17*151	 
b	dat #23*151

start   jmz quit, b	; while (b>0) {

loop	sub b, a	; for (; a>=b; a-=b);
	slt a, b
	jmp loop

	mov a, tmp	; swap(a,b);
	mov b, a
	mov tmp, b

	jmp start	; }
