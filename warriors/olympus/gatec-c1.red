;name   gate c-c1

gate1   equ     (gate-5)
	org     start
for 10
	dat 0,0
rof
	dat     -5,   100
gate    dat     -5,   jump-gate1+5
	spl     #-5,  jump-gate1+5 
for 10
	dat     0,0             ;the warrior goes here
rof
start   spl     #-10,#10
	mov     @jump,>gate1
jump    djn     start+1,{gate+1
