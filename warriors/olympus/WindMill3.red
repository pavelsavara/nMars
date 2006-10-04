;redcode-b
;assert 8000
;name WindMill3
;author	Calvin Loh
;strategy Scans for enemy code, then bombs them.
start	dat	#1,	#1
step1	dat	#6,	#4006
step2	dat	#2004,	#6004
bomb1   mov	step1,	*step1
	mov	step1,	@step1
	jmp	scan2
bomb2	mov	step2,	*step2
	mov	step2,	@step2
	jmp	launch
scan1	cmp 	}step1,	>step1
	jmp     bomb1
scan2   cmp	}step2,	}step2
	jmp     bomb2
launch  djn 	scan1,	#1988
clear	mov	start,	>start
	end	scan1
