;redcode verbose
;name Crimp
;author Andy Pierce
;strategy  small cmp scanner
;strategy  scan constant optimized
;strategy  smaller

ret	add offset,start
start	cmp -284,-1
	slt #15,start
count	djn ret,<6223
	mov bomb1,@start
	mov bomb2,<start
	add next,start
	jmn start,ret
bomb2	spl 0,0
	mov next,<bomb2
next	dat #-283,#-282
offset	dat #-566,#-566
bomb1	jmp -1,0
