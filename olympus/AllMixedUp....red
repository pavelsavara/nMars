;name All Mixed Up...
;author George Eadon
;strategy The Extended94 / Multi-Warrior part is the paper I used in rounds
;strategy 1 & 4.
;strategy The limited process part is the bomber I wrote for the lp round.
;strategy And the 88-part is a slight improvement on the bomber I wrote for
;strategy for the 88 round.
;assert 1

FOR MAXPROCESSES == 8 
;; Limited Process warrior -- 12 instructions
STEP 	EQU	5*641

inc	dat	<-STEP, <STEP
	dat 	pos+1 - bomb, 0
	spl	#0, #0
loop	add     inc, pos
start	mov	bomb, @pos
	mov	bomb, *pos
pos	mov	-STEP, @STEP
	djn	loop, #800
        spl	#0, #0
	mov	inc+1, {bomb
	jmp	-2, 0
bomb	dat	pos+1, <-2
ROF

FOR MAXCYCLES == 80001
;; 88-warrior -- 14 instructions

STEP    EQU     5*103

        spl     0, <2668
start   SPL     0, <ptr + 1
loop    ADD     #STEP, ptr
        MOV     start-1, @1
ptr     MOV     start-1, <1
        JMP     loop, <4000
        mov     bomb, <bomb-1
	jmp	-1, 0
	dat	#0, #0
	dat	#0, #0
	dat	#0, #0
	dat	#0, #0
	dat     #0, #ptr
bomb	dat	#0, #ptr+1
ROF

FOR MAXCYCLES == 79999 || MAXCYCLES == 80000
;; Extended 94 / Multi Hill warrior -- 10 instructions

	spl	1, <300
loop	spl	1, <500
	mov	-1, 0		; 7 parallel processes
	
pos	spl	987, 0 		; split to first copy
	mov	>pos, }pos	; Make 1st copy
	mov	bomb, >1806
	mov	bomb, }6034
	mov	<pos, {pos2 	; Make 2nd copy
pos2	spl	333, <1401	; split to second copy
bomb	dat	<2667, <(2667*2)
ROF

end	loop-1






