;redcode-94
;name safeclear
;author Anders Ivner
;strategy quickscan the 80 worst starting positions of the paper
;strategy use two halves to survive a hit from the bomber
;strategy qscan assures safety from paper for 80*16 cycles
;strategy -> multipass coreclear (most efficient thing I found)
;strategy unfortunately it doesn't work as well as I hoped,
;strategy but I don't have time to improve it. :-(

a	equ	(pt-2+10)
empty	equ	(last+1)

start	spl	q2
	sne	a-1809,a-3609
	seq	a-3751,a-5409
	sub.f	#find,	find
	sne	a-7491,a-5551
	seq	a-7209,a-7351
	sub.f	#find,	find
	sne	a-1009,a-3231
	seq	a-1291,a-6971
	sub.f	#find,	find
	sne	a-5031,a-3091
	seq	a-1151,a-2809
	sub.f	#find,	find
	sne	a-6132,a-1888
	seq	a-1872,a-2711
	sub.f	#find,	find
	sne	a-0209,a-4249
	seq	a-6831,a-4891
	sub.f	#find,	find
	sne	a-2951,a-4609
	seq	a-5644,a-5628
	sub.f	#find,	find
	sne	a-5612,a-6451
	seq	a-3688,a-3672
	sub.f	#find,	find
	sne	a-4511,a-1732
	seq	a-2571,a-0631
	sub.f	#find,	find
	sne	a-6691,a-4751
	nop	a-6409,a-1400

find	sne	*-2,	@-2
	nop	}-1,	>-1
	add	@find,	fpt
	add	find,	fpt
	sne	empty,	@fpt
	mov.ab	fpt,	fpt

	add	#12,	fpt
	mov	s1,	<fpt
	mov	s1,	<fpt
	djn	-2,	#10

tcboo	djn	s1,	#2	; There can be only One
fpt	dat	find,	find

q2	sne	a-1384,a-1368
	seq	a-1352,a-2191
	sub.f	#find2,	find2
	sne	a-7444,a-7428
	seq	a-7412,a-0251
	sub.f	#find2,	find2
	sne	a-5488,a-5472
	seq	a-6311,a-3532
	sub.f	#find2,	find2
	sne	a-4371,a-2431
	seq	a-0491,a-6551
	sub.f	#find2,	find2
	sne	a-7932,a-0771
	seq	a-5156,a-5140
	sub.f	#find2,	find2
	sne	a-5124,a-5108
	seq	a-5092,a-5931
	sub.f	#find2,	find2
	sne	a-3200,a-3184
	seq	a-3168,a-3152
	sub.f	#find2,	find2
	sne	a-3991,a-1244
	seq	a-1228,a-1212
	sub.f	#find2,	find2
	sne	a-1251,a-7288
	seq	a-7272,a-0111
	sub.f	#find2,	find2
	sne	a-5332,a-6171
	nop	a-4231,a-2291

find2	sne	*-2,	@-2
	nop	}-1,	>-1
	add	@find2,	fpt2
	add	find2,	fpt2
	sne	empty,	@fpt2
	mov.ab	fpt2,	fpt2

	add	#12,	fpt2
	mov	s1,	<fpt2
	mov	s1,	<fpt2
	djn	-2,	#10

	djn	s1,	tcboo
fpt2	dat	find2,	find2

pt	dat	#0,	#last+2
d1	dat	#-20,	#last+2-pt
s1	spl	#-20,	#last+2-pt
	mov	@last,	>pt
	mov	@last,	>pt
last	djn.b	-2,	{s1



	end	start
