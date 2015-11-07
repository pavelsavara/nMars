LENGTH	equ 4
WHERE	equ 100

start	mov #LENGTH,		$0
	mov <-1,		<(WHERE+LENGTH-1)
	jmn $-1,		$-2
	jmp @(WHERE+LENGTH-3)
	end start
