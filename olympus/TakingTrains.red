;redcode-94
;name Taking Trains
;author Maurizio Vittuari
;contact pan0178@iperbole.bologna.it
;NSFCWT Round 2 
;assert CORESIZE == 8000

for 0
Ahem...
This should be the parody of the famous Taking Names...
In fact this is Taking Names slightly modified!
(my other warriors aren't able to do better :(   )
With the -f option TT against White Warrior scores 623 280 97 (total 1966)
But I know that someone reaches 220 points on 100 rounds!
so...
CIUF! CIUF! ;-)
rof

step    equ    98

spl3	spl	-3
clrptr  dat    last+2
jmp3	jmp	-4
reset   dat    #step-4,	#step
spl2	spl	-2
spl1	spl	-1
    
attack	mov	jmp3,	*comp
compptr	mov	spl3,	{comp
	mov	spl2,	{comp
	mov	spl1,	{comp
	mov	spl0,	{comp
	sub	reset,	@compptr
        
scan	add	spl0,	@compptr
comp	sne	2*step,	3*step
	add	spl0,	@compptr
	seq	*comp,	@comp
	slt	#100+step,@compptr
ctr	djn	scan,	#2500
	jmn	attack,	-1

spl0	spl.i	#(2*step),#(2*step)
clear	mov	reset,	>clrptr
last	jmp	-1
end	comp
