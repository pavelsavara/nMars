* muncher.cw    ----    from the mind of Brian A. Cole
*               ----        you took 210, you figure it out.
*
@-19
b1  	dat #0
b2  	dat #0
b3  	dat #0
b4  	dat #0
d1a  	dat mov 0 1
d1b  	dat #40
l1  	mov d1a @d1b
 	add #3 d1b
    	jmp l1
d2a    	dat mov 0 1
d2b  	dat #40
l2  	mov d2a @d2b
 	add #3 d2b
    	jmp l2
d3a  	dat mov 0 1
d3b 	dat #40
l3  	mov d3a @d3b
 	add #3 d3b
    	jmp l3
    	pct b1
    	pct b2
    	pct b3
    	pct b4
    	pct d1a
    	pct d1b
    	pct d2a
    	pct d2b
    	pct d3a
    	pct d3b
    	spl l1
    	spl l2
    	spl l3
    	mov 0 1
