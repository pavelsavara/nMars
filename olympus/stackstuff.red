;redcode
;name stack stuff
;author mjp
;assert 1
load0 z for 0
	rof

	org	main

; implements common stack machine primitives and mixed
; red/stack code example.

; One stack for data and the other for return addresses.  Makes
; things simpler when you don't have to manage the return address
; around data.  The stack cell .b fields are the ones that hold
; actual data, with .a fields being ignored.

sp	equ	(load0-1000)		; data stack pointer
rsp	equ	(load0+4000)		; return stack pointer
ip	equ	CURLINE			; instruction pointer

; use 'ADR lab' for the absolute address of label 'lab'
ADR	equ	-load0 +



;;-- data stack operations
;;

;
; implemented as macros (some of which take arguments) 
;
						; stack effect
DUP	equ	mov.b	@sp	,	<sp	; (n -- n n)
DROP	equ	nop	>sp			; (n --()
DROP2	equ	add	#2	,	sp	; (n2 n1 -- )

DROPN	equ	mov	>sp	,	#0	; ( nk ... n1 k  -- )
	equ	add.b	-1	,	sp

SWAP	equ	mov.b	>sp	,	#0	; (n2 n1 -- n1 n2)
	equ	mov.b	>sp	,	#0
	equ	mov.b	-2	,	<sp
	equ	mov.b	-2	,	<sp

DUP2	equ	mov.b	sp	,	sp+2	; (n2 n1 -- n2 n1 n2 n1)
	equ	mov.b	<sp+2	,	<sp
	equ	mov.b	<sp+2	,	<sp

ROT	equ	mov.b	sp	,	sp+2	; (n3 n2 n1 -- n2 n1 n3)
	equ	mov.ba	@sp+2	,	<sp+2
	equ	mov.b	>sp+2	,	@sp+2
	equ	mov.b	@sp	,	<sp+2
	equ	mov.ab	@sp+2	,	@sp

OVER	equ	mov.b	sp	,	sp+1	; (n2 n1 -- n2 n1 n2)
	equ	mov.b	@sp+1	,	<sp

PICK	equ	mov.ba	3	,	sp	; dups the nth cell down from 
	equ	add.ba	sp	,	sp	; top of stack. eg.
	equ	mov	#sp-1	,	1	; PICK 0 is the same as DUP
	equ	mov.b	*sp	,	<	; PICK 1 is the same as OVER

PLUS	equ	add.b	>sp	,	@sp	; (n2 n1 -- n2 <op> n1)
MINUS	equ	sub.b	>sp	,	@sp
TIMES	equ	mul.b	>sp	,	@sp
REM	equ	mod.b	>sp	,	@sp
DIVIDE	equ	div.b	>sp	,	@sp

NEG	equ	mul	#-1	,	@sp	; (n -- -n)

tos	equ	@sp


;;-- return stacks
;;

; I wanted to use this:
;
;CALL	equ	mov	#ip+2	,	<rsp	; save return adr.
;	equ	jmp				; and jump
;

; but pmars assembles backward references wrong when expanding equs
; that alias opcodes.  It would have been nice to write 'CALL sub', or
; 'CALL @func_table_ptr'. Instead now we have to use two lines with
; SAVERET/jmp sub
;


SAVERET	equ	mov	#ip+2	,	<rsp	; save return adr.

RET	equ	mov.ba	>rsp	,	2	; load ret.adr.
	equ	sub.a	#ip+1	,	1	; make relative
	equ	jmp	0			; and jump

HALT	equ	stp.b	1	,	#1
	equ	dat	0	,	

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;; Main program
;;
;
; generates a random table and quicksorts it
;

;; :fib ( n -- fib(n) )
;;
fib:	slt	tos	,	#2	; ( if n < 2 )
	jmp	fib_else

fib_then:
	mov	#1	,	tos	; 1
	jmp	fib_out			; ( return )

fib_else:
	DUP				; ( calc. fib(n-1) )
	sub	#1	,	tos	; dup 1- fib
	SAVERET
	jmp	fib

	SWAP				; ( calc. fib(n-2) )
	sub	#2	,	tos	; swap 2 - fib
	SAVERET
	jmp	fib

	PLUS				; +~
fib_out: RET				; ( return )



;; :rand ( -- n )
;;
rand:	mul	#6121	,	_seed
	add	#111	,	_seed
	mov.b	_seed	,	<sp
	RET
_seed	dat	#1234			; seed for rand()



;; :gen_tab ( table len -- )
;;
gen_tab:
gt_len	mov.b	>sp	,	#0	; these are static variables, but
gt_tab	mov.b	>sp	,	#0	; that's ok as we don't recurse.
	jmz	gt_out	,	gt_len	; if (len == 0) return

	sub	#ADR gt_tab,	gt_tab	; make the address of table
					; relative
gt_loop:
	SAVERET
	jmp	rand			; get a rand()
	mov.b	>sp	,	>gt_tab	; store it into the table
	djn	gt_loop	,	gt_len

gt_out	RET



;; :qpartition ( table len -- low_partition_len )
;;
; partition subroutine for quick sort
;
qpartition:
qp_len	mov.b	>sp	,	#0	; pop argument len
qp_tab	mov.b	>sp	,	#0	; pop arg. table ptr.
	mov.ba	qp_tab	,	qp_ptr	; lo := tab

	mov.ab	qp_ptr	,	qp_ptr	; hi := lo+len
	add.b	qp_len	,	qp_ptr

	sub	# ADR qp_ptr,	qp_ptr	; make pointers lo and hi
	sub.a	# ADR qp_ptr,	qp_ptr	; relative

qp_x	mov.b	*qp_ptr	,	#0	; choose a pivot element x
					; (first in table)
qp_loop:
	slt.b	qp_x	,	<qp_ptr	; find an element <=
	jmp	2			; than the pivot
	jmp	-2

	slt.b	*qp_ptr	,	qp_x	; find an element >= than
	jmp	2			; the pivot
	jmp	-2	,	}qp_ptr

	slt.ab	qp_ptr	,	qp_ptr	; if lo >= hi
	jmp	qp_out	,	>qp_ptr	; then we exit

qp_swap:				; else we swap *lo and *hi
	mov.b	*qp_ptr	,	#0
	mov.b	@qp_ptr	,	*qp_ptr
	mov.b	-2	,	@qp_ptr
	jmp	qp_loop

qp_out:	add	#ADR qp_ptr,	qp_ptr	; make absolute
	sub.b	qp_tab	,	qp_ptr	; return index of hi
	mov.b	qp_ptr	,	<sp
	RET

qp_ptr	dat	0	,	0	; low and high pointers
					; of table


;; :qsort ( table len -- )
;;
; recursively sort an array
;
qsort:
q_len	mov.b	>sp	,	#0	; save parameters table and len
q_tab	mov.b	>sp	,	#0

	slt	#1	,	q_len	; if len <= 1 exit early
	jmp	qs_out

	sub	#2	,	sp
	SAVERET
	jmp	qpartition

q_lolen	mov.b	>sp	,	#0	; save lo partition length

	mov.b	q_tab	,	<sp	; push arguments
	mov.b	q_lolen	,	<sp	; ( table ix )
					; for first recursion

	add.b	q_lolen	,	q_tab	; push arguments
	mov.b	q_tab	,	<sp	; ( table+ix len-ix )
	sub.b	q_lolen	,	q_len	; for second recursion
	mov.b	q_len	,	<sp

	SAVERET
	jmp	qsort			; recurse left segment

	SAVERET
	jmp	qsort			; recurse right segment

qs_out	RET


;; :main (--)
;;

; declare a table
table	equ	(load0+1000)
len	equ	400

main:
	mov	# ADR table,	<sp	; push arguments
	mov	#len	,	<sp
	SAVERET
	jmp	gen_tab			; generate a random array

	mov	# ADR table,	<sp	; 
	mov	#len	,	<sp
	SAVERET
	jmp	qsort			; sort it

	HALT	#0
	end
