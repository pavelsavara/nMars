;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;
;;;			V O T E R
;;;
;;; A simple self-repairing program which keeps three copies of 
;;; itself and constantly checks to see that all three are
;;; kept identical.
;;;
;;; Author: Michael L. Mauldin
;;; Idea:   Dr. Kee Dewdney in May 1984 Scientific American.
;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;		Copy number 1 of voter program
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

;	Data area
s11	dat	1
s21	dat	1
s31	dat	1
stop1	dat	1

;	Initialize data area with starting locations of each copy
start	mov	#0008,	s11
	mov	#0107,	s21
	mov	#0206,	s31
	mov	#0025,	stop1

;	Start of main loop, check for end of program
loop1	cmp	s11,	stop1	; Indexes run off of program?
	jmp	next1		; Yes, jump to the next program
	cmp	@s11,	@s21	; No, compare programs 1 and 2
	jmp	oneok1		; If words are equal, check 2 and 3
	cmp	@s11,	@s31	; 1 and 2 not equal, check 1 and 3
	jmp	twobad1		; Program number two is bad
	mov	@s21,	@s11	; Program 1 is bad, fix it
	jmp	allok1		; Go around again
twobad1	mov	@s11,	@s21	; Fix program 2 instruction
	jmp	allok1		; Go around again
oneok1	cmp	@s21,	@s31	; Check programs 2 and 3
	jmp	allok1		; Everything matches
	mov	@s21,	@s31	; Program 3 is bad, fix it
allok1	add	#1,	s11	; Increment program 1 counter
	add	#1,	s21	; Increment program 2 counter
	add	#1,	s31	; Increment program 3 counter
	jmp	loop1		; Loop
next1	jmp	start2		; Now branch to the next instruction

space1	FOR	74
	dat	0
ROF

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;		Copy number 2 of voter program
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

;	Data area
s12	dat	1
s22	dat	1
s32	dat	1
stop2	dat	1

;	Initialize data area with starting locations of each copy
start2	mov	#7908,	s12
	mov	#0007,	s22
	mov	#0106,	s32
	mov	#7925,	stop2

;	Start of main loop, check for end of program
loop2	cmp	s12,	stop2	; Indexes run off of program?
	jmp	next2		; Yes, jump to the next program
	cmp	@s12,	@s22	; No, compare programs 1 and 2
	jmp	oneok2		; If words are equal, check 2 and 3
	cmp	@s12,	@s32	; 1 and 2 not equal, check 1 and 3
	jmp	twobad2		; Program number two is bad
	mov	@s22,	@s12	; Program 1 is bad, fix it
	jmp	allok2		; Go around again
twobad2	mov	@s12,	@s22	; Fix program 2 instruction
	jmp	allok2		; Go around again
oneok2	cmp	@s22,	@s32	; Check programs 2 and 3
	jmp	allok2		; Everything matches
	mov	@s22,	@s32	; Program 3 is bad, fix it
allok2	add	#1,	s12	; Increment program 1 counter
	add	#1,	s22	; Increment program 2 counter
	add	#1,	s32	; Increment program 3 counter
	jmp	loop2		; Loop
next2	jmp	start3		; Now branch to the next instruction

space2	FOR	74
	dat	0
ROF

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;		Copy number 3 of voter program
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

;	Data area
s13	dat	1
s23	dat	1
s33	dat	1
stop3	dat	1

;	Initialize data area with starting locations of each copy
start3	mov	#7808,	s13
	mov	#7907,	s23
	mov	#0006,	s33
	mov	#7825,	stop3

;	Start of main loop, check for end of program
loop3	cmp	s13,	stop3	; Indexes run off of program?
	jmp	next3		; Yes, jump to the next program
	cmp	@s13,	@s23	; No, compare programs 1 and 2
	jmp	oneok3		; If words are equal, check 2 and 3
	cmp	@s13,	@s33	; 1 and 2 not equal, check 1 and 3
	jmp	twobad3		; Program number two is bad
	mov	@s23,	@s13	; Program 1 is bad, fix it
	jmp	allok3		; Go around again
twobad3	mov	@s13,	@s23	; Fix program 2 instruction
	jmp	allok3		; Go around again
oneok3	cmp	@s23,	@s33	; Check programs 2 and 3
	jmp	allok3		; Everything matches
	mov	@s23,	@s33	; Program 3 is bad, fix it
allok3	add	#1,	s13	; Increment program 1 counter
	add	#1,	s23	; Increment program 2 counter
	add	#1,	s33	; Increment program 3 counter
	jmp	loop3		; Loop
next3	jmp	start		; Start on copy 2

	end	start1
