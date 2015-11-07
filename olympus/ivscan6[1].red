;redcode-94x
;name ivscan6
;author J.Layland

;kill ivscan6
;strategy EBS Tournament round 3 entry
;strategy Leprechaun-style bomb/scan
;strategy Scanner tries to identify imps/vamps and run special-purpose
;strategy    anti-imp/vamp modules.
 
;macro

 	org	loop  

step	equ	13 

scan	equ	27725	; If I bomb myself, I'm probably dead anyway
			

impsize	mov.i	<loc, #0
stun	mov	split, @loc
	add	impsize, loc
	djn	stun,	#1000 
 
split	spl	#0,	<-59	 
	mov	gate, <-50
	jmp	-1, <-61


for 30
	dat 0,0
rof

gate	dat 	<-60, <-61
imp	mov.i 	#0, 0

for 30
	dat 0,0
rof	
 
; ### Removed by Planar: copy-paste error ?
;gate	dat 	<-60, <-61
;imp	mov.i 	#0, 0
;
;for 30
;	dat 0,0
;rof	
; ###
 
;bombing routine

;kill	mov	b1, @loc
loop	add	#step, target
 	mov	b1, @target
target 	jmz.f	loop, @224

; scan routine
		; if target contains "x" we want to look at target+x+scan
loc 	equ 	target+scan

	mov	target, loc
		; target+scan points at target+scan+x
;xx break
	sub	@loc,	@loc
	sne	@loc, core	; ignore incs/decs
	jmp	loop	; kill	
	sne	@loc,	imp
	jmp	impsize
	jmp	launch		; assume it's a fang

	dat 0,0
	dat 0,0
core	dat 0,0

for 40
	dat 0,0
rof

launch	mov	b1, @loc
	spl	1		; anti-vamp paper
	spl	1
	spl	1
	
paper	mov 	#8, 0			 
copy	mov 	<-1, <ptr	; make copy		 
ptr	spl 	@0, 6301	;start new copy  
	sub 	@avamp,<avamp	; subtract pointers going backwards
avamp	mov 	b1,>100	; now bomb forward to kill jump	
	mov 	b1,>avamp	
        jmz 	paper, paper
b1	dat	<34117, <scan	; might take out an imp if I'm (very) lucky
