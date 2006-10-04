	STEP	equ 7308

	warf	spl 0, <-1+STEP
		add #STEP, warf
		mov 1, @warf
