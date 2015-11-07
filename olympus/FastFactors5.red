;redcode
;name Fast Factors 5
;author Anders Ivner

np      equ     yes+4000
q	equ	yes+7500
x	equ	yes+1000

input   dat             #2

;dividable
found   mov     factor,         <results
        mov     @q,             input

foo     mov     factor,         <np
        mov     input,          x

yes     mov     @np,    <np             ; B-field = 4000
        add     @np,    @np             ;double it
        slt     yes,    @np             ;ok to double?
        jmp     yes,    <q              ;yes (set q to 0)

shift	add	@q,	@q
factor	jmp	lowp,	#2

subt    sub     @np,    x               ;subtract
        add     #1,	@q

lowp    slt     x,      @np             ;ok to subtract?
results jmp     subt,   #input          ;yes

prev    add     #1,     np              ;previous multiple
	jmn	shift,	np		;if pt=0 then we're done
	jmz	found,	x

;not dividable
next	add	#1,		factor
        djn     foo,            #88
        cmp     #1,             input
        mov     input,          <results

        end     foo

; 22 instructions
