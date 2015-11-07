;redcode-94
;name Cheater 2.0
;author Nathan Green
;strategy Use knowledge of the -F number to my advantage
;assert CORESIZE==8000

; Use "pmars -F 1234"

RESULT	equ	#0
ROUND	equ	#1
NUM	equ	#2
DEFEND	equ	#3
OFFSET	equ	#4

ptr	dat.f	20,1234		; B-field is the -F number

round	ldp.ab	NUM,#0		; Load attack address from p-space
	add.b	round,ptr	; Offset by magic number (round 1 = 0+magic)

loop	mov.i	bomb,>ptr	; Hit 'em
	mov.i	bomb,>ptr
	djn.b	loop,#10

x	ldp.ab	ROUND,#0	; Increment round counter.
	add.ab	#1,x
	mov.b	x,bomb
	stp.b	x,ROUND

	sub.ba	ptr,ptr		; Check if opponent is at negative position
	seq.i	*ptr,ptr-1
	stp.ab	#1,DEFEND	; If so, plan on reversing attacks in future

	div.ab	#2,bomb		; Calculate array position for next number
	mod.ab	#2,x
	add.ab	#1,bomb

	seq.b	x,#0		; Retrieve address.
	mov.ba	@bomb,@bomb
	mov.ab	@bomb,ptr

y	ldp.ab	DEFEND,#0	; Reverse if we are defending
	jmz.b	z,y
	sub.ba	ptr,bomb
	mov.ab	bomb,ptr

z	ldp.ab	OFFSET,#0	; If we lost, increment offset
res	ldp.ab	RESULT,#1
	sne.ab	#0,res
	add.ab	#2,z

	add.b	z,ptr		; add the offset to the address
	stp.b	z,OFFSET
done	stp.b	ptr,NUM		; Store next attack address in p-space

clear	mov	bomb,@last	; Clean up anything that may have booted.
	djn.b	clear,last
clear2	mov	bomb2,*last
	djn.a	clear2,last

	jmp	#0,<ptr-5	; Clean up imps that may have booted.

bomb	spl	#5532,0		; 5532 for reversing and still having the
                                ; address offset by 1234. 5532+2*1234=8000.

bomb2	dat	 0,161		; As many starting positions as I can fit.
	dat	 3724,454	; Each is offset by 1234 so that the first
	dat	 3324,4591	; number is 0, which is what is in p-space
	dat	 -249,909	; the first round.
	dat	 4178,1683
	dat	 653,653
	dat	 4893,1088
	dat	 3891,6517
	dat	 5271,-842
	dat	 6491,1233
	dat	 -1029,3715
	dat	 6050,4703
	dat	 2266,2332
	dat	 1938,4912
	dat	 2309,5664
	dat	 1862,-1077
	dat	 5390,-427
	dat	 -289,4070
	dat	 -901,-501
	dat	 5926,2626
	dat	 4475,4368
	dat	 4990,4049
	dat	 3849,1070
	dat	 29,1602
	dat	 -672,5065
	dat	 6538,3103
	dat	 3879,958
	dat	 5837,5751
	dat	 1788,-262
	dat	 4552,1871
	dat	 -706,-876
	dat	 725,1754
	dat	 2671,5871
	dat	 571,1244
	dat	 3239,5443
	dat	 5760,3015
	dat	 3572,-421
	dat	 2271,2044
	dat	 2597,4941
	dat	 2543,2075
	dat	 3077,6355
	dat	 5950,-671
	dat	 554,4461
	dat	 1315,3075
	dat	 2462,3801
	dat	 1043,902
	dat	 2672,3711
	dat	 5682,-318
	dat	 3991,-212
	dat	 616,717
	dat	 -2,2647
	dat	 2148,5930
	dat	 4967,-1019
	dat	 1957,4573
	dat	 -825,4179
	dat	 1944,1411
	dat	 5342,1553
	dat	 5336,2465
	dat	 1260,5436
	dat	 3372,3869
	dat	 4368,1277
	dat	 1265,782
	dat	 -488,3080
;	dat	 5686,4812	; *pout*  I can't fit any more :(
;	dat	 -99,4008
;	dat	 5925,5982
;	dat	 819,540
;	dat	 5351,5445
;	dat	 -692,6354
;	dat	 4373,3931
;	dat	 1555,5862
;	dat	 1154,6186
;	dat	 4743,4892
;	dat	 4319,5978
;	dat	 -650,5884
;	dat	 1941,6613
;	dat	 1446,-845
;	dat	 159,-731
;	dat	 5284,3089
;	dat	 -1007,-187
;	dat	 3873,474
;	dat	 955,1721
;	dat	 2282,3204
;	dat	 3407,4644
;	dat	 3122,4953
;	dat	 3964,6034
;	dat	 3738,-275
;	dat	 3875,4464
;	dat	 2809,3712
;	dat	 -336,4870
;	dat	 4446,3238
;	dat	 6416,3749
;	dat	 3652,6383
;	dat	 3154,-726
;	dat	 -847,1999
;	dat	 4474,3991
;	dat	 -106,6570
;	dat	 6127,1496
;	dat	 2045,848
;	dat	 2129,829
last dat	ptr,ptr
	end	round
