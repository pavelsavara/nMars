;General Notes: These two warriors are pretty weak by themselves, and
;aren't very effective together. What can I say? This week was a bitch...
;**************
;* Warrior #1 *
;**************

;redcode-94
;name S/P Warrior #1
;strategy 8-Process Paper
;author G. Eadon
;NSFCWT Round 3
;contact gmeadon@mit.edu
	spl   	1, <2665
	spl	1, <5330
	spl	1, <2663

silk1   spl     2920, #0      	;split to new copy
        mov.i   >-1, }-1     	;copy self to new location
	mov	<silk1, {copy2
copy2	spl	3100, #0
	mov.i	bomb1, {3000
	mov.i	bomb1, <2000
	jmp	-2
bomb1 	dat.f   >2667,  >5334   ;anti-imp bomb


