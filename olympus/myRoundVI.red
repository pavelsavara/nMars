;redcode
;name myRoundVI
;author Paulsson
;assert 1
; This shouldn't win anything :-)
; myVamp but smaller and a lot worse.
; Cannonade stone + cclear
; Paper based imp launcher
; One byte to spare :-)

for MAXCYCLES == 80000
st		equ		912

fang		jmp	*(fang-8)+st,-st	;hit
check		dat.f	0,0
trap		jmp	pit-(fang-8),#0
ptr		dat.f	0,200
		dat.f	-20,0
bmb		dat.f	0,-ptr+cclear+2
		jmp	cclear
next		add.f	step,fang
start2		mov.i	@0,>fang		;scan
		jmz.a	next,*fang
		mov.i	<check,*fang
stop		jmn.b	next,>check
step		spl	#st,-st-1
cclear		mov.i	bmb,>ptr
		djn.f	cclear,>ptr
		jmp	cclear
start		mov.i	trap,fang-8		;hit
		jmp 	start2
pit		mov.i	bmb,>ptr
		spl	-1,-4000
		jmp	-1,>check
rof

for MAXCYCLES == 80001
; Cannonade stone with gate, credits to P.Kline
start	spl	stspl
	spl	0,<-20
	mov	1,<-22
	dat	<-22,<-21
stinc    equ 190
stone    mov <stspl+5+(stinc*800),stspl
stspl    spl -1,<2+5141+1
stadd    add 3,stone
         djn -2,<5141+1
       	 dat #0,#0
inc      mov stinc,<-stinc
rof

for MAXCYCLES == 79999 
; One of my Imp launchers!
start	spl	1,<2000
	mov.i	-1,#0
	spl	1,<-2000
	spl	@0,3488
	mov.i	}-1,>-1
	spl	@0,2668
	mov.i	}-1,>-1
	mov.i	#2667,*0
rof
end start
