;redcode-x verbose
;name Comets Are The Chances In Our Future v2.0
;author Joshua Houk
;strategy  Replicator (sigh) that replicates a lot. Based on Mice, but
;strategy  includes more SPL instructions and tighter addressing.
;strategy  v2.0 - Sends off imps every so often, too.

bomb	dat #0 , #0
start   mov #12 , bomb
loop    mov @bomb , <branch
        djn loop , bomb
        spl @branch , 0
	spl @start , 0
	spl @imp , 0
        add #525 , branch
        jmz start , bomb
branch  dat #0 , #615
imp     mov 0,1
	dat #0,#0
        end start
