Ok, here it is (finally).  No time to really test it -- I hope it works! :-)

		- Michael Constant


;redcode-94
;name Theme
;author Michael Constant
;strategy silk paper and dynamically launched imp-spiral
;strategy based on a wonderful idea by Mike Nonemacher
;assert CORESIZE % 30030
;nsfcwt round 5

MAGIC	equ 42

magicp	ldp.ab #1, #0
	seq.b magicp, #MAGIC	; is the magic number there?
	jmp calc		; ... nope, we have to recalculate
	ldp.ab #2, imp		; ... yup, we can start immediately

launch	spl setup
	spl 1
	spl 1
	spl 1
	spl 1
	spl 1
	spl 2
	jmp imp			; a fast imp-launcher would have been a
	add.ba imp, -1		; real pain to do dynamically

magic1	dat 0, 13
magic2	dat 0, 11
which	dat endp+1, 7
sign	dat 1, 5
	dat 0, 3
endp	dat 0, 2

setup	spl 1
	spl 1
	spl 1
	spl paper2
	spl paper3

paper1	spl -11751, 0
	mov.i >-1, }-1
	mov.i <-2, {1
	jmp -12015

paper2	spl -11560, 0
	mov.i >-1, }-1
	mov.i <-2, {1
	jmp -12351

paper3	spl -11301, 0
	mov.i >-1, }-1
	mov.i <-2, {1
	jmp -12511

calc	mod.b {which, #-1	; take CORESIZE-1 % p, where p is prime
	add.ab #1, calc		; ... but we really wanted CORESIZE % p
	seq.b calc, *which	; is p relatively prime with CORESIZE?
	jmp euclid		; ... yes, we have a winner!
	mov.ab #-1, calc	; ... no, restore calc and try again
	jmp calc
	
euclid	div.b *which, #-1	; this works out to CORESIZE / p
	mov.ba imp, magic2	; store imp for later reuse
	mul.b euclid, imp	; apply the inverse Euclidean algorithm
	add.ab magic1, imp	; ... storing partial results in imp
	mov.a magic2, magic1	; magic1 is now the old value of imp
	mov.b *which, euclid
	mov.b calc, *which
	mov.b euclid, calc
	mod.b *which, calc	; apply the standard Euclidean algorithm
	mul.a #-1, sign		; sign is the parity of the total pass count
	jmn.b euclid, calc	; is the remainder zero yet?

	mul.ab sign, imp	; ... yes, we're done -- prepare the imp
	stp.b imp, #2		; we've found the imp-number, let's store it
	stp.ab #MAGIC, #1	; ... and store MAGIC so we know it's real
	jmp launch

imp	mov.i #-5, 1		; the -5 is to help against anti-vamps
