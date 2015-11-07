;redcode-94
;name ivscan
;author J.Layland
;strategy Kill imps and vamps.  Otherwise die.

	org	start

;macro

; Try very hard to kill imps and vamps.  Die horribly when faced with
; anything else.  Probably choke if I see a quick-cmp like Jazz.

; I had wanted to submit an anti-imp paper warrior in this round, and
; save this for the big coresize, but I couldn't tune my paper to
; reliably kill both imps&vamps at the same time, especially while trying
; to keep a slim startup to avoid a quick-cmp.  I need another week...
; Steve Morrell's imps seem to be relatively immune to my anti-imp paper
; attempts.  I'm not sure why.

; This scans for non-zero core, throws away small b-fields (+-1) and
; assumes it found either an imp or a fang.  Wrong guesses will probably
; lead to stupid behavior. 

; This could be slimmer, but I'm so big it probably wouldn't make
; much difference without radical recoding.  And time.

; I've had major version-control problems developing this.  Hopefully this
; is actually a version that works...

  
test equ step+2000
  
step	dat 	-7, -7

start	add	step, loc
scan	jmz.f	-1, @loc
	mov	@loc, test
	add 	#1, test
	slt	#2, test
	jmp	start
	
loc	seq	@-33, -33
	jmp	avamp


impsize mov 	@loc, 0
 	mov	split, @loc
	add	impsize, loc
	djn	-2, #100

split	spl 	#0, <-15
	mov 	gate, <-12
	jmp 	-1, <-17

gate	dat	<-17, <-16
	
avamp	sub	@loc, loc
	jmz.f	@loc, start

	mov	gate, @loc
	spl 	start

	spl 1
	mov -1, 0
	spl 1

l001	mov	#6,	6		;set source
p001	mov	<l001,	<t001		;make copy
t001	spl	@0,	5301		;split to copy
 	mov 	2, <t001
 	jmz	l001,	l001		;loop
	dat 	<2667, <2*2667
	spl 	start
