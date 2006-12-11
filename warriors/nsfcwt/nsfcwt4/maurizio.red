;redcode-94
;name SnailSort
;author Maurizio Vittuari
;contact pan0178.iperbole.bologna.it
;NSFCWT round 4
;strategy Sorting enemy according to location 4000
;assert 1
for 0
Simple bubble sort ---> quite short (or quite sort ;-)
but also very slow with big arrays :(
(hoping no bugs....)
rof

void	equ	ref-1			;dat.f 0,0
buf	equ	ref-2			;swap buffer
moves	equ	ref-3			;used in sort
numaux	equ	ref-4			;used in compress
ref

ptr	dat	4001,	4002
ptr1	dat	4001,	4002		;back-up pointer

sortd	slt.b	@ptr-sort,	*ptr-sort
lookad	slt.a	*ptr-looka,	@ptr-looka



loop	add.f	inc15,	num		;find the length of the vector to sort
start	seq.i	void,	@num
	jmp	loop
loop2	sne.i	void,	<num
	jmp	loop2,	{num
	mov.ab	num,	num
	jmz.b	sort,	ref+4000	;set up or down sorting
	mov.i	sortd,	sort
	mov.i	lookad,	looka
	jmp	sort
reset	mov	ptr1,	ptr
	mov.ab	num,	num
	mov	#0,	moves
sort	slt.b	*ptr,	@ptr		;skip if x.b < x+1.b
	jmp	lookeqb
next	add.f	incr,	ptr
	djn.b	sort,	num
	jmn.b	reset,	moves
	jmz.a	ref-1,	ref+4000
;brea

;	***  MARK ROUTINE  ***


;	put a "void" on the istructions to be deleted according
;	to the following pseudo-C routine:
; 
; for (j=4001; j<num ; i++,j++)
;   {
;    if (v[i]!=void)
;      {
;      while ((v[i].f == v[j].f) && (j < num))
;        {
;	 if (v[i].i == v[j].i) v[j]=void;
;	 j++;
;	 }
;      j=i+1;
;      }
;   }


mark	mov.ab	num,	num
	mov	ptr1,	ptr		;i=ptr.a  j=ptr.b
loop3	seq.i	void,	*ptr		;return to loop3 if v[i]=void
	jmp	setaux			;jmp to while cycle
incl3	add.f	incr,	ptr
	djn.b	loop3,	num

;brea
;	***    COMPRESS ROUTINE    ***

	mov	ptr1,	ptr
loop4	add.f	incr,	ptr
	sne.i	void,	*ptr		;find the first void --> v[i]=void
	jmp	coll
	djn.a	loop4,	num
incr	dat	1,	1		;end

coll	seq.i	void,	>ptr		;find the first istr --> v[j]=istr
	jmp	go
	djn.a	coll,	num
inc15	dat	15,	15		;end

go	mov.i	<ptr,	}ptr		;the < 'cos we have the > in coll line
	mov.i	void,	>ptr
	djn.a	coll,	num
num	dat	9,	ref+1+4010	;end


endw	mov.ab	ptr,	ptr		;j=i+1
	jmp	incl3,	>ptr		;return to loop3	
setaux	mov.i	num,	numaux
while	seq.f	*ptr,	@ptr		;while cycle (mark routine)
	jmp	endw
	sne.i	*ptr,	@ptr
	mov.i	void,	@ptr		;v[j]=void
	jmp	1,	>ptr		;j++
	djn	while,	numaux
	jmp	endw


lookeqb	seq.b	*ptr,	@ptr
	jmp	swap
looka	slt.a	@ptr,	*ptr		;skip if x.a >= x+1.a
	jmp	next
swap    mov	*ptr,	buf
	mov     @ptr,	*ptr
	mov	buf,	@ptr
	jmp	next,	>moves
end	start
