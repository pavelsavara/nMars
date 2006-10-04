;redcode-94
;name Quick Thinking
;author Ben Ford
;assert 1
;strategy qscan -> HSAish scanner
;strategy
;strategy instead of bombing, qscan sets starting values for scanner
;strategy scanner based on HSA, added part to set my score properly
;strategy also never switches to dat-bombing (stun everything but me!)
;strategy
;strategy beats test warrior (and simple improvements) 80%+
;strategy better than nothing, I suppose someone could try to take
;strategy advantage of 'flaws' in the hsa engine

PLAYER EQU 2                ; change this number to either 1 or 2, depending
                            ; on which position it should be looking for.

; ----- HSA-ish scanner -----

; use +/- 10 for constants to prevent increments/decrements from hurting score
; hopefully won't lose out to someone using +/- 1
c1	equ	(20*PLAYER-30)
c2	equ	(30-20*PLAYER)

slen	equ	(qend-sptr+4)

sptr	dat	$  qs,	$  qs	; widely-spaced pointers

	dat	$   0,	$   0
	dat	$   0,	$   0
	dat	$   0,	$   0
	dat	$   0,	$   0

pos2	spl	#  c2,	$  c2
pos1	spl	#  c1,	$  c1

	mov	 sbmb,	>sptr
kill	jmn.f	   -1,	@sptr
scan	sub.x	# -12,	 sptr	; increment and look
	sne	*sptr,	@sptr
	sub.f	 scan,	 sptr	; increment and look
qhsa	jmn.f	 self,	@sptr
	jmz.f	 scan,	*sptr
swap	mov.x	 sptr,	 sptr	; swap pointers for attack
self	slt.ab	#slen,	 sptr	; self-check
	jmp	 scan,	$   0
	jmn.f	$   0,	<sptr	; find top of code
	mov	 sbmb,	>sptr
	mov	 pos1,	>sptr
	mov	 pos2,	>sptr
	jmp	 kill,	$   0	; go to attack

sbmb	spl	#   0,	$   0

for	17
	dat	$   0,	$   0
rof

; ----- decoy -----
; put a copy of the top of RedOS to fool other warriors

	DAT.F	$   0,	$ -45	; <-- this is a pointer to the end of code.
	DAT.F	$   3,	$   5	; <-- this represents the version number.
	DAT.F	$   0,	$   0	; <-- this is the input register for commands.
	DAT.F	$   1,	$   1	; <-- this is the register for warrior 1
	DAT.F	$   1,	$   1	; <-- this is the register for warrior 2.
	LDP.AB	#   0,	#  -1	; <-- this is the start of code for RedOS.

; ----- q-scan -----

qf	equ	sptr
qs	equ	100
qd	equ	3996
qo	equ	(qi*qr-10)
qi	equ	7

	spl	#  14,	<  10	; A,D
qtab	spl	#   7,	<   4	; B,E
qbmb	dat	#  19,	{   1	; C

qscan	seq	qd+qf+14*qs,	qf+14*qs   ; A
	jmp	qfas,	{qfas
	seq	qd+qf+35*qs,	qf+35*qs   ; B*(E+1)
	jmp	qslo,	>qtab
	seq	qd+qf+52*qs,	qf+52*qs   ; (A-1)*E
	djn.a	qslo,	{qfas
	seq	qd+qf+70*qs,	qf+70*qs   ; B*D
	jmp	qslo,	{qslo
	seq	qd+qf+9*qs,	qf+9*qs    ; D-1
	djn.b	>qfas,	{qslo
	seq	qd+qf+24*qs,	qf+24*qs   ; (B-1)*E
	jmp	qslo,	{qtab
	seq	qd+qf+7*qs,	qf+7*qs    ; B
	jmp	qfas,	{qd+qf+7*qs+qi
	seq	qd+qf+21*qs,	qf+21*qs   ; B*(E-1)
	jmp	qslo,	<qtab
	seq	qd+qf+5*qs,	qf+5*qs    ; E+1
	jmp	>qfas,	>qtab
	seq	qd+qf+18*qs,	qf+18*qs   ; (B-1)*(E-1)
	djn.f	qslo,	qtab
	seq	qd+qf+3*qs,	qf+3*qs    ; E-1
	jmp	>qfas,	<qtab
	seq	qd+qf+56*qs,	qf+56*qs   ; A*E
	jmp	qslo,	{qfas
	seq	qd+qf+76*qs,	qf+76*qs   ; C*E
	jmp	qslo,	}qfas
	seq	qd+qf+13*qs,	qf+13*qs   ; A-1
	djn.a	qfas,	{qfas
	seq	qd+qf+32*qs,	qf+32*qs   ; (B+1)*E
	jmp	qslo,	}qtab
	seq	qd+qf+10*qs,	qf+10*qs   ; D
	jmp	>qfas,	{qslo
	seq	qd+qf+8*qs,	qf+8*qs    ; B+1
	jmp	qfas,	}qtab
	seq	qd+qf+63*qs,	qf+63*qs   ; B*(D-1)
	djn.b	qslo,	{qslo
	seq	qd+qf+6*qs,	qf+6*qs    ; B-1
	jmp	qfas,	{qtab
	seq	qd+qf+19*qs,	qf+19*qs   ; C
	jmp	qfas,	}qfas
	seq	qd+qf+4*qs,	qf+4*qs    ; E
	jmp	>qfas,	{qd+qf+4*qs+qi
	seq	qd+qf+57*qs,	qf+57*qs   ; C*(E-1)
	djn.b	qslo,	}qfas
	seq	qd+qf+1*qs,	qf+qs      ; 1
	jmp	qfnd,	{qd+qf+qs+qi

qslo	mul.b	 qtab,	 sptr	; decode
qfas	mul.ab	 qtab,	@qslo
qfnd	mov.ba	 sptr,	 sptr
	add	#  qd,	 sptr
qend	jmp	 qhsa,	<1234

end	qscan
