;redcode-94
;name Twins
;author Maurizio Vittuari
;assert CORESIZE==8000
;contact pan0178@iperbole.bologna.it
;NSFCWT Round 3 
;strategy  We're just two papers...

step1	equ	3743
step2	equ 	1567
step3	equ	1349

twin1	spl	twin2,	{400
	spl	1,	{300
	spl	1,	{500
	mov	-1,	0
s1	spl	step1,	#0
	mov.i	>-1,	}-1
s2	spl	step2,	#0
	mov.i	>-1,	}-1
	mov.i	<s2,	<s3
s3	spl 	@0,	}step3
	mov.i	#-13,	1

for 47
	dat.f	0,	0
rof

twin2	spl	1,	>-200
	mov	-1,	0
	spl	1,	>-300
	spl	1,	>-400
s1b	spl	step1,	#0
	mov.i	>-1,	}-1
	mov.i	bomb,	}1942
s2b	spl	step2,	#0
	mov.i	>-1,	}-1
	mov.i	bomb,	}1842
	mov.i	bombd,	}1900
	mov.i	bomb,	}2000	;anti-vamp fire
	mov.i	<s2b,	<s3b
s3b	jmp 	@0,	}step3
bomb	dat	<2667,	<5334	;anti-imp bomb
bombd	dat	>1,	}1	;anti-djn bomb

end twin1
