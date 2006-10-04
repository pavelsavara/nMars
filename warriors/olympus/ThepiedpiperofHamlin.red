;   The pied piper of Hamlin
;   by Adam King

cliff	dat			$  0
jump	mov	    bomb,	    cliff	;  cause pests
	mov	    bomb,	    cliff	;  to jump
	mov	    bomb,	    cliff	;  off the
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff
	mov	    bomb,	    cliff	;  to jump
	mov	    bomb,	    cliff	;  to jump
	mov	    bomb,	    cliff	;  off the
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff
	mov	    bomb,	    cliff	;  cliff
	mov	    bomb,	    cliff
bomb	dat			$  0
baddr   dat			$ -110
faddr   spl			$  40
bmbcnt  dat                     $  700
loop    mov         bomb,	@   baddr
	sub	 #  10,		    baddr
	mov	    bomb,	@   faddr
	add	 #  10,		    faddr
	djn         endlop,         bmbcnt
	mov	 #  40,		    faddr
	mov	 # -110,	    baddr
	mov      #  700,	    bmbcnt
endlop	jmz	    loop,	    cliff-100	;  watch for incoming
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    jump
	spl			    imp
	mov	    bomb,	    cliff-100	; clear fence
	jmp	    loop
start	spl			    imp
	mov	    bomb,	    cliff-100	; clear fence
	jmp	    loop
impcnt	dat			$  8100
imp	mov	    imp,	    imp+1
	end	    start
