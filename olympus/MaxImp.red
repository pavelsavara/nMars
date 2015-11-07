;redcode-94
;name MaxImp
;author Planar
;strategy (CORESIZE-1)-point imp ring
;assert CORESIZE >= 2 && CORESIZE <= 2147483647  ; to launch N processes
;assert MAXPROCESSES >= CORESIZE-1               ; for the imp ring to work

N	equ	(CORESIZE-1)		; number of processes to launch

i for 31 + ((n=1073741824) && 0)	; generate N processes
for N-1 >= n && (N-1) / n % 2 == 1	; no need to do this by hand !
	spl	1			;
rof					;
for N-1 >= n && (N-1) / n % 2 == ((n=n/2) && 0)
	mov.i	-1, 0			;
rof					;
rof					; N processes generated

	jmp	imp, {0			; launch the ring
imp	mov	0, -1

	end
