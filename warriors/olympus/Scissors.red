;
;    Warrior: Scissors
;  File name: scissors.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Matthew Householder
;
start	mov	#-101,	     ptr-5084
look	add	# 5084,	     ptr
look2	jmz	  look,	   @ ptr
ptr	mov	  stun2,     ptr
	mov	  stun1,   < ptr
	add	# 5084+1,    ptr
	jmn	  look2,     ptr
	jmp	  1
halt	mov	  bomb,	   < bptr
	jmp	  halt
stun1	spl		     0
stun2	jmp	 -1
bomb	dat		     halt-bptr
bptr	dat		     look
        end       start
