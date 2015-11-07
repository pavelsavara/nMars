;redcode-94
;name Origami 3
;author Planar
;strategy paper
;assert CORESIZE==8000

step0	equ	175
step1	equ	3700
step2	equ	60
step3	equ	(-113)
step4	equ	1043
step5	equ	3039

N	equ	10			; number of processes to launch

i for 31 + ((n=1073741824) && 0)	; generate N processes
for N-1 >= n && (N-1) / n % 2 == 1	; no need to do this by hand !
	spl	1			;
rof					;
for N-1 >= n && (N-1) / n % 2 == ((n=n/2) && 0)
	mov.i	-1, 0			;
rof					;
rof					; N processes generated

last	equ	(paper+N)

paper	spl	@0, >step0
	mov.i	}-1, >-1
	spl	@0, >step1
	mov.i	}-1, >-1
	mov.i	bomb, #0            ; keep only one process
zz	spl	#step5, <step3
	add.f	-1, 1
	mov.i	}0, <0
	djn.f	-3, <step4          ; -2 ou -3
bomb	dat	<1143, <2286
	end

FOR 0

ROF; 0
