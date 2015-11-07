;redcode-94
;name Life
;author Philip Kendall
;assert CORESIZE==8000
;planar other

width   equ     13
height  equ     13
first   equ     (2092-CURLINE)
line    equ     158
die     equ     (first-2)

main    mov.ab  #(first-param1),param1
	mov.ab  #height,count32
loop32  mov.ab  #width,count31
loop31  jmz.a   count31,>param1
	sub.ab  #(line+2),param1
	mov.ab  #3,count12
loop1   mov.ab  #3,count11
param1  nop.f   >0,>0
count11 djn.b   param1,#0
	add.ab  #(line-3),param1
count12 djn.b   loop1,#0
	sub.ab  #(2*line-2),param1
count31 djn.b   loop31,#0
	add.ab  #(line-width),param1
count32 djn.b   loop32,#0

	mov.ab  #(first-param2),param2
	mov.ab  #height,count42
loop42  mov.ab  #width,count41
loop41  mov.ab  #0,storage
param2  jmz.a   2,0
	seq.ab  #4,@param2
	sne.ab  #3,@param2
storage mov.ab  #1,#0
	jmn.b   alive1,storage
	mov.i   dead,@param2
	jmp.a   3
alive1  mov.i   alive,@param2
	sub.ba  param2,@param2
	spl.a   >param2
count41 djn.b   loop41,#0
	add.ab  #(line-width),param2
count42 djn.b   loop42,#0

	jmp.a   main

dead    dat.f   0,0
alive   jmp.a   (die-param2),0

start   mov.i   alive,(first+0*line+1)
	mov.i   alive,(first+1*line+2)
	mov.i   alive,(first+2*line+0)
	mov.i   alive,(first+2*line+1)
	mov.i   alive,(first+2*line+2)
	jmp.a   main

	end     start
