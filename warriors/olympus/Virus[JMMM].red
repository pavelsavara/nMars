;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;; Name:		Virus
;;; Original Author:	John McLean
;;; Modified:		Michael Mauldin
;;;
;;; 1.	Changed code to work for Mauldin/Milazzo system.
;;; 2.	Changed increment from 4 to 9 so that virus has a
;;;	chance to beat dwarf.  With an increment of 4, 
;;;	dwarf wins 100 percent of the time.
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

;;; Real code for the virus program

first	jmp	subvert		; First site for bomb
vsite	bss	1		; Address of first location to bomb
vbomb	bss	1		; Value of viral bomb
vincr	bss	1		; Increment for vbomb, jmp9-jmp0
jmp9	jmp	9		; Data for 'jmp 9'
jmp0	jmp	0		; Data for 'jmp 0'

start	mov	#7999,	vsite	; Initialize vsite
	mov	jmp9,	vincr	; Make 'vincr' be the difference between
	sub	jmp0,	vincr	;	'jmp n' and 'jmp n+9'
	mov	first,	vbomb	; Set viral bomb value
loop	mov	vbomb,	@vsite	; Fire viral bomb at vsite
	sub	#9,	vsite	; Decrement vsite by 9
	add	vincr,	vbomb	; Make vbomb be 'jmp n+9'
	cmp	vsite,	#79	; About to subvert bogus code
	jmp	loop		; And repeat
	jmp	start		; Start over

;;; Branch to one of several bogus programs

next	dat	1		; Next bogus code fragment
subvert	cmp	next,	#1	; Next == 1?
	jmp	st2or3
	jmp	start1
st2or3	cmp	next,	#3	; Next == 3?
	jmp	start2		; No, branch to program 2
	jmp	start3		; Branch to program 3

;;; Bogus code for subverted program number 1

site1	dat	36		; Site to drop 0 bomb
start1	mov	#2,	next	; Make program 2 the next one
loop1	mov	#-4,	@site1	; Bombs away!
	add	#6,	site1	; Increment bomb site
	cmp	site1,	#7974	; About to bomb original virus?
	jmp	loop1		; No: repeat
abort1	mov	#24,	site1	; Re-initialize for next victim
	mov	#0,	die1	; Zero next instruction
die1	bss	1		; Die

;;; Bogus code for subverted program number 2

site2	dat	24		; Site to drop 0 bomb
start2	mov	#3,	next	; Make program 3 the next one
loop2	mov	#-4,	@site2	; Bombs away!
	add	#4,	site2	; Increment bomb site
	cmp	site2,	#7972	; About to bomb original virus?
	jmp	loop2		; No: repeat
abort2	mov	#16,	site2	; Re-initialize for next victim
	mov	#0,	die2	; Zero next instruction
die2	bss	1		; Die

;;; Bogus code for subverted program number 3

site3	dat	16		; Site to drop 0 bomb
start3	mov	#1,	next	; Make program 1 the next one
loop3	mov	#-4,	@site3	; Bombs away!
	add	#2,	site3	; Increment bomb site
	cmp	site3,	#7970	; About to bomb original virus?
	jmp	loop3		; No: repeat
abort3	mov	#8,	site3	; Re-initialize for next victim
	mov	#0,	die3	; Zero next instruction
die3	bss	1		; Die

	end	start
