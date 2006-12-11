;redcode-94
;name test-qds
;author Planar
;strategy Just looking...
;kill test
;assert 1

early1	equ	6
early2	equ	12

first

i FOR early1
	sne.i	first-100+i*400, first+000+i*400
	seq.i	first+100+i*400, first+200+i*400
	mov.ab	#first-100+i*400-found, found
ROF; i
	jmn.b	rescan, found
i FOR (early2-early1)
	sne.i	first-100+(i+early1)*400, first+000+(i+early1)*400
	seq.i	first+100+(i+early1)*400, first+200+(i+early1)*400
	mov.ab	#first-100+(i+early1)*400-found, found
ROF; i
	jmn.b	rescan, found
i FOR (19-early2)
	sne.i	first-100+(i+early2)*400, first+000+(i+early2)*400
	seq.i	first+100+(i+early2)*400, first+200+(i+early2)*400
	mov.ab	#first-100+(i+early2)*400-found, found
ROF; i

rescan

found	jmn.b	first-1, #0
;found	jmz.b	first-1, #0
;found	nop	first-1, #0

dh       mov dvins,dv+boot       ; position dv-bomb as needed
         mov dvins,dv
         spl 1,>-2002            ; make 8 processes
         spl 1,>-2001
         spl 1,>-2000
         mov <s2,{s2             ; boot one copy of Die Hard
s2       spl c0+boot+8,c0+8

c0       spl   @0,space          ; here is Die Hard
         mov   }c0,>c0
cs       spl   #0        ,}dv    ; following lines execute in reverse order
         mov   dv        ,}dv+space
cb       add.a #119      , dv+space
         spl   imp+5334  ,}dv+space
         spl   imp+2667  ,}dv+space
imp      mov.i #2667 ,*0

FOR MAXLENGTH-CURLINE-1
	dat	0, 0
ROF

space    equ (4-40*127)
boot     equ (30*127+50)
dv       equ (c0+58)
dvins    mov   101,{1               ; pretty good bomb
