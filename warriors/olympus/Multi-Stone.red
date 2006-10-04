;NSFCWT Round #5
;contact gmeadon@mit.edu
;name Multi-Stone
;author G. Eadon
;strategy 3 stones (mod-5, mod-6 and mod-7) + coreclear in parrallel...
;strategy The coreclear degrades into an imp-gate... 
;strategy Its tough to pick constants when coresize varies.
start	spl	bomb1
	spl	bomb2
	spl	bomb3, 0
	spl	0, <-99
	mov	1, <-2	
db	dat	<-100, <-100
	dat	0, 0

bomb1	add	#441, 1		; Mod-7
	mov 	db, 3
	jmp	bomb1
	dat	0, 0
	dat	0, 0

bomb2	add	#1385, 1	; Mod-5
	mov	db, -2
	jmp	bomb2
	dat	0, 0
	dat	0, 0
	dat	0, 0

bomb3	add	#1362, 1	; Mod-6
	mov	db, -2
	jmp	bomb3
