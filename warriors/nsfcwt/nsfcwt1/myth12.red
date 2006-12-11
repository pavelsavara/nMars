;redcode-b
;name Mythicon v1.2
;kill Mythicon
;author G. Eadon
;contact gmeadon@mit.edu
;NSFCWT Round 1
;strategy This guy hangs around the top 5 on the beginer's hill... Which
;strategy means it will get its ass kicked in the big-leagues, but I
;strategy haven't had any time recently to improve it or work on any new
;strategy warriors... (Mythicon might be competive if it had a better
;strategy coreclear)
;assert CORESIZE == 8000

next	add.f	inc, offset
	mov.i	bomb1, >offset
	mov.i	c3, @offset
	mov.i	bomb1, }offset
	mov.i	c3, *offset
	djn	next, #8000/50
	jmp	c1

db	dat	<c1-bomb1-1, #0
offset	dat	#1 + 2974, #1 - 2976
inc	dat	#2974, #-2976
ptr1	dat	#c1
c1	spl	0, <-bomb1
c2	mov	@ptr1, <bomb1
c3	jmp	-1, <db-7

bomb1	spl	0, <db-5

	end	next+1
