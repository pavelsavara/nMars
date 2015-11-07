;redcode
;name Prime, bonus and big bucks
;author Pierre Baillargeon

;strategy	Load this program at address 500 to make the result fall in
;strategy	the range 7999-7900.


;strategy	The base idea is to use negative numbers.  We can thus take
;strategy	advantage of all the decrease side-effects of MARS-88.  The
;strategy	second idea is the technique to store base-prime in the
;strategy	B-field of the code.  We can therefore calculate the prime-
;strategy	factor at the beginning with very few instructions.
;strategy
;strategy	We use a small substract loop to calculate the division.
;strategy	If the result of the substract loop is zero, we have found a
;strategy	factor, so keep it and re-use it again.
;strategy
;strategy	If the result is non-zero, scan the marked memory, beginning
;strategy	at the current prime-factor to find the new prime-factor.
;strategy
;strategy       Now that I've seen some others, I understand that my downfall
;strategy       is the LOOOONG time it takes to compute division of small
;strategy       primes (2 takes 4000 loops !).
;strategy

bottom	equ next		; last instruction
top	equ base
pprime	equ top-1		; used to erathostene-out prime numbers
result	equ top-500		; where we save factors
number	equ bottom+1		; where the number will be stored as a negative
test	equ bottom+2		; number is temporary stored during calculation

base	mov #5,0		; init the loop count
primes	mov @base,pprime	; (-2) mark the location as non-prime
prime	add @base,pprime	; (-3) move back by the amount of base-prime
	mov #-1,@pprime		; (-4) tag number as non-prime
	cmp #-420,pprime	; (-5) stop at 420 (3 x 4 x 5 x 7)
	jmp prime,-7		; (-7) redo mark loop
	djn primes,base		; do all the base-prime
	mov #-2,pprime		; begin dividing with first factor: 2
	sub #0381,number	; *** place the nymber in the A-field ***

calc	mov number,test		; get number ready for test
CPU	jmz found,test		; if zero, found factor
	sub pprime,test		; substract current divisor
	slt pprime,test		; test < pprime -> new divisor
	djn CPU,@quot		; increase quotient

new_div	jmn new_div,<pprime	; search new divisor
	djn next,#24		; make sure we only use the 24 prime divisors
	sub number,<result	; number itself is prime, save it
quot	jmp number,500		; stop

found	mov @quot,number	; use quotient as new number
	sub pprime,<result	; save factor
	cmp #-1,number		; if number is 1, stop.
next	jmp calc,<quot		; next calculation, same factor

	end top
