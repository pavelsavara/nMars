;redcode
;assert CORESIZE == 8000

;author Kurt Franke
;name Kurt's Qsort

;strategy
;strategy Sorts enemy program -- prepare to die!
;strategy
;strategy Weaknesses : stones, imps, vampires, scanners, papers, hybrids,
;strategy              things that wait for it to sort and kill itself,
;strategy              and anything that happens to already be sorted.
;strategy              (but other than that, it kicks butt)
;strategy
;strategy Seriously, I used a quicksort with a few modifications to optimize
;strategy for duplicate entries.  The reverse ordering is handled by
;strategy inverting all the data, sorting normally, and then inverting again.
;strategy The option to allow duplicates is handled by modifying a few
;strategy instructions before sorting.  The code is pretty long, but I think
;strategy it works.
;strategy

a	equ	4000			;; array header location

heap	equ	-8			;; for debugging
eqct	equ	-7			;; counts calls to equal
ct	equ	-6			;; counter
cc	equ	-5			;; empty core
s	equ	-4			;; swap space
b	equ	-3			;; original bounds
d	equ	-2			;; clear (dat)
c	equ	-1			;; command

z	mov	$z+a, $z+c		;; store command (z marks address 0)

	mov	@stack, $z+a		;; find array length
size	seq	@z+a, $z+d
	add.ab	$z+a, $z+a
	div.a	two, $z+a
	sub.ab	$z+a, $z+a
	jmn.a	size, $z+a

dones	mov.a	$one, $z+a
	sne	@z+a, $z+d
	sub.b	$one, $z+a

	mov	$z+a, $z+b		;; save initial bounds
	mov	$z+b, @stack

	jmn.a	descend, $z+c		;; if dups allowed, need to modify

	mov	$mid, $eq1
	mov	$mid, $eq2		;; turn == jmps into nops
	mov	$mid, $eq3

descend	jmz.b	qsort, $z+c		;; check ordering
neg1	mov.f	$neg, $z+s
	sub.f	@z+a, $z+s
	mov.f	$z+s, @z+a		;; if descending, invert data
	djn	neg1, $z+a
	mov	$neg, $z+d		;; use inverted dat as clear

	jmp	qsort

;; wrap everything up

finish	jmz.b	cmprs, $z+c		;; check if data were inverted
	mov	$z+b, $z+a
neg2	mov.f	$neg, $z+s		;; restore original numbers
	sub.f	@z+a, $z+s
	mov.f	$z+s, @z+a
	djn	neg2, $z+a

cmprs	jmz.a	done, $z+c		;; check if duplicates were allowed
	mov	$z+b, $z+a
	mov	$z+b, $mid
	add.f	$moffs, $mid
cmprs2	mov	}mid, *z+a		;; copy, skipping empty places
	seq	$z+cc, *z+a
	nop	}z+a
	djn.b	cmprs2, $z+a
	mov	$z+cc, *z+a		;; mark end of data

done	mov	$z+c, $z+a		;; restore original command
	dat	0			;; hasta la vista

;; pop stack and sort with those values

pop	sub.b	$one, $stack		;; pop stack and check underflow
	sne.ab	$stack, $stack
	jmp	finish

qsort	mov	@stack, $z+a		;; get a,b indices

;;	mov	$z+a, <z+heap		;; keep a record of qsort calls

	slt.ab	$z+a, $z+a		;; continue if a < b
	jmp	pop

	sne	@z+a, *z+a		;; extra check for equal
eq3	jmp	equalf

	mov	$z+a, $z+s		;; check if only 2 elements
	sub.ab	$z+s, $z+s
	sne.b	$one, $z+s
	jmp	sort2

l1	mov.x	$z+a, $mid		;; compute pivot
	sub.ba	$mid, $mid
	mov.b	$seed, $mid
	mod.ab	$mid, $mid
	add.ab	$z+a, $mid
	add.b	$moffs, $mid		;;    (add offset)

	add.ab	$seed, $seed		;; create new number

	mov	@z+a, $z+s		;; swap pivot with b
	mov	@mid, @z+a
	mov	$z+s, @mid
	mov.b	$z+a, $mid		;; make mid point to the right thing
	add.b	$moffs, $mid		;;    (add offset)

	mov	$z+cc, $z+ct		;; reset counter (counts duplicates)
	sub.b	$one, $z+a		;; preserve pivot

;; partition

part	add.b	$one, $z+a
f1	sub.b	$one, $z+a		;; find something lower

	slt.ba	$z+a, $z+a		;; stop when b < a
	jmp	t14
	jmp	setp

t14	sne	@z+a, @mid
eq1	jmp	equal
	sne.f	@z+a, @mid
x1	jmp	f1, }z+ct		;; count the duplicates

	slt.b	@mid, @z+a		;; test p.b < i.b
	jmp	t2			;;  n p.b >= i.b
	jmp	f1			;;  y p.b < i.b
t2	slt.b	@z+a, @mid		;; test i.b < p.b
	jmp	t3			;;  n p.b == i.b
	jmp	part2			;;  y p.b > i.b
t3	slt.a	@z+a, @mid		;; test p.a > i.a
	jmp	f1			;;  n p.a < i.a


part2	sub.a	$one, $z+a		;; find something higher
f2	add.a	$one, $z+a

	slt.ba	$z+a, $z+a		;; stop when b < a
	jmp	t15
	jmp	setp

t15	sne	*z+a, @mid
eq2	jmp	equal
	sne.f	*z+a, @mid
x3	jmp	part3, }z+ct

	slt.b	*z+a, @mid		;; test p.b > i.b ok
	jmp	t4			;;  n p.b <= i.b  ok
	jmp	f2			;;  y p.b > i.b   ok
t4	slt.b	@mid, *z+a		;; test p.b < i.b ok
	jmp	t5			;;  n p.b == i.b  ok
	jmp	part3			;;  y p.b < i.b   ok
t5	slt.a	@mid, *z+a		;; test p.a < i.a ok
	jmp	f2			;;  n p.a >= i.a  ok


part3	slt.ab	$z+a, $z+a		;; check if done with partition
	jmp	setp

	mov	@z+a, $z+s		;; swap elements
	mov	*z+a, @z+a
	mov	$z+s, *z+a

	nop	}z+a, <z+a		;; move pointers closer

	jmp	part			;; keep going..

;;	set partition element back into array and recur

setp	sne.a	$z+ct, $mid		;; check if all were duplicates
	jmp	pop			;; all items equal -- done.

	mul.a	$two, $z+ct
	slt.a	$mid, $z+ct		;; if more than half were duplicates
	jmp	t10

exch	mov	$x1, $z+s		;; change partition from < | >=
	mov	$x2, $x1		;;                   to <= | >
	mov	$z+s, $x2
	mov	$x3, $z+s		;; (this should catch a single
	mov	$x4, $x3		;;  different value stuck in
	mov	$z+s, $x4		;;  with a lot of equal values)

;;	mov	$exch, <z+heap		;; record exchange took place

t10	mov	*z+a, $z+s
	mov	@mid, *z+a
	mov	$z+s, @mid

	mov	>stack, @stack		;; make a,b to sort 2nd half
	mov.a	$z+a, @stack
	add.a	$one, @stack

	mov.ab	$z+a, <stack		;; make a,b to sort 1st half
	sub.b	$one, @stack
	add.b	$one, $stack

	jmp	qsort

;;	sorts two elements	(they are not duplicates)

sort2	slt.b	*z+a, @z+a		;; test 1.b < 2.b
	jmp	t6			;;  n 1.b >= 2.b
	jmp	pop			;;  y 1.b < 2.b
t6	slt.b	@z+a,*z+a		;; test 1.b > 2.b
	jmp	t7			;;  n 1.b == 2.b
	jmp	t8			;;  y 1.b > 2.b (need to swap)
t7	slt.a	@z+a,*z+a		;; test 1.a > 2.a
	jmp	pop			;;  n 1.a <= 2.a

t8	mov	@z+a, $z+s		;; out of order -> swap
	mov	*z+a, @z+a
	mov	$z+s, *z+a
	jmp	pop

;;	equal case

equal	mov	$z+d, @mid		;; delete duplicate
equala	sub.b	$one, @stack
	jmp	qsort, >z+eqct		;; start over

equalf	mov	$z+d, @z+a
	sub.b	$one, @stack
	jmp	qsort, }z+eqct

;;	data section

x2	jmp	part2-x1, }z+ct-x1	;; swapped with x1
x4	jmp	f2-x3, }z+ct-x3		;; swapped with x3

seed	dat	$2467,$3247		;; random numbers
mid	nop	$0,$0			;; pivot location (+code modifier)
moffs	dat	$z+a-mid, $z+a-mid	;; pivot offset

neg	dat	7999,7999		;; used to negate
one	dat	1,1			;; constant one
two	dat	2,2			;; constant two

;; 	stack

stack	dat	0,1			;; the 0 is used to check underflow

	dat	512,512			;; initial value to find array size

end	z
