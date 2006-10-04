* fang.cw    ----    from the mind of Brian A. Cole
*            ----        (almost) never wins, but is great fun.
*
@-3
t1    	spl 0
t2    	jmp -70
adr 	dat -136
b    	mov t1 @adr
    	pct @adr
    	add #1 adr
    	mov t2 @adr
    	add #10 adr
    	jmp b
