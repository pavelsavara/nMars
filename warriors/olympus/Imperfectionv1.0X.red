;redcode-94x
;name Imperfection v1.0 X
;author Michael Constant

step    equ     35873

toadd   dat     #-12001,#12001

boot    mov     <from,  <to
        djn     -1,     #4

start   spl     stone+21012
        spl     ig2
from    spl     1,      stone+4
        mov     -1,     0
        mov     -1,     0
        mov     -1,     0
to      spl     1,      stone+4+21012
        spl     2
        jmp     imp
        add.a   #step,  -1
        
        dat     0,      0

ig2     mov     imp,    imp+1602
        spl     1
        mov     -1,     0
        mov     -1,     0
        mov     -1,     0
        spl     1
        spl     2
        jmp     imp+1602
        add.a   #step,  -1
        
        dat     0,      0

stone   mov     <-5,    <1-12001
        spl     -1,     <-23617
        add.f   toadd-21012, -2
        djn.f   -2,     <-23619
        

i	for (MAXLENGTH-CURLINE-1)
	dat	i, 1
	rof


imp     mov.i   #0,     step
         
        end boot
