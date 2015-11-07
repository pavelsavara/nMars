;redcode 88
;name Redcoder Title
;author Alex MacAulay

;Draws the word 'Redcoder' in "9-point Monaco" and has two imps running above
;and below the word. The width of the core array should be the same as the
;equate variable, width, for the display to look sensible.

width	equ 127 ; set width of the core array to this value
charWidth	equ 6
top	equ (imp-8*width)
bottom	equ (imp-2*width)
nn1	equ (top+width+4)
nn2	equ (top+2*width+4)
nn3	equ (top+3*width+3*charWidth+4)
nn4	equ (top+3*width+7*charWidth+4)
nn5	equ (bottom+charWidth+4)
nn6	equ (bottom+3*charWidth+4)
nn7	equ (bottom+6*charWidth+4)

imp	mov 0,1

b	dat 1,1
c	dat charWidth,charWidth+1
x	jmp imp-y

	; left side of R
start	mov <nn1,top
	add #width,-1
	djn -2,#7
	
	; right side of 1st & 2nd d
	mov #18,@1
	mov <nn2,@top+2*charWidth+4
	add #width,-1
	djn -3,#7
	
	; top & mid of r
	mov <top+3,top+2
	mov <nn3,<-1
	mov <top+width*3+3,top+width*3+2
	mov <nn4,<-1
	
	; top 3-piece of 'edcode'
	mov <top+2*width+charWidth+3,top+2*width+charWidth+2
	mov <nn5,<-1
	add c,-2
	djn -3,#6
	
	;bottom 3-piece of 'edcode'
	mov <bottom+charWidth+3,bottom+charWidth+2
	mov <nn6,<-1
	add c,-2
	djn -3,#6
	
	mov <c,nn7
	
	; side 3-piece of 'edcoder'
	mov #width,@1
	mov <top+3*width+charWidth,@top+4*width+charWidth
	add c,-1
	djn -3,#7
	
	; middle of e's
	mov <top+4*width+charWidth+4,top+4*width+charWidth*6+4
	sub b,-1
	djn -2,#4
	
	mov <top+4*width+4,top+5*width+4
	mov <top+3*width+charWidth+4,top+3*width+6*charWidth+4
	mov <bottom+4,top+3*width+4*charWidth+4
	mov <top+4*width+4*charWidth+4,top+5*width+4*charWidth+4
	mov <bottom+7*charWidth,top+2*width+7*charWidth
	mov <top+2*width+7*charWidth+2,top+2*width+7*charWidth+3
	
	mov imp,imp-width*10
	mov stomp,stomp-width*10
	mov x,y-width*10
	spl stomp-width*10,<top+3*width+7*charWidth+1
	spl y
	spl 2
	jmp imp
	jmp imp-width*10
y	mov x,0
stomp	jmp 0,<-2
	
	end start
