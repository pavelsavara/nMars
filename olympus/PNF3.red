;redcode
;name PNF 3
;author Mintardjo W.

s1      equ 16
s2      equ s1

copy    equ (input - 1)
out     equ (copy - 1)
posn    equ (out - s1 - 1)      ; this holds the current prime number
i       equ (input - 25)
j       equ (i + 4000)
prime   equ (i - 1)             ; this holds the first prime number
dst     equ (last + s1)
src     equ (dst + 1)
sdst    equ (src + s1)

input   dat #-3          ; please put input here

nprime  dat #prime

;start  jmz last, input
;trace
start   mov #2, prime    ; the first prime starts with 2
;trace off
        mov #1, posn     ; the next starts with 3 - 2. -2 for adjustment
;       mov #0, out

mark0   mov #s1, src
        mov @nprime, <src
        mov #s1, dst
fill    mov #0, <dst      ; fill with numbers: a, a^2, ... a^n until
        mov @nprime, copy ; (n = s1) or (a^n > input)
loop1   add @src, @dst
        slt @dst, @src
        djn loop1, copy

        slt @dst, @src   ; check for overflow
        djn fill, src    ; and src should be decremented as well

        mov #0, @dst     ; mark the max number at the end
        mov input, copy  ; do not alter the input value at input variable
        mov #s1+(sdst-dst), dst

loop2   mov #0, sdst
loop3   slt copy, <sdst
        jmn loop3, @sdst
        sub #-1, sdst
        jmz mark2, sdst  ; if it is, then the remaining is even smaller than
                         ; the base prime which indicates the indivisibility
        sub @sdst, copy  ; get the remainder
        mov sdst, <dst   ; record the exponent. leave it in negative number
        jmn loop2, copy  ; if the result > 0 then reiterate

loop4   sub @dst, 0      ; negate the negative exp number
        add @nprime, <out      ; get the divisor
        djn -1, loop4    ; as many as the positive exponent

; Gets the quotient

        mov #0, input    ; Reset the input
                         ; The order of src & dst, helps to add 1
                         ; which is the self-division of last term ...
        mov #s1+(sdst-src), src
mark1   sub @dst, <src   ; divide each term by subtracting
                         ; the exponent
div2    mov @src, sdst   ; get the index
        add @sdst, input ; to get the right term and add it to input
div3    jmn mark1, @src  ; reiterate until the last sequence of term
        jmz last, input  ; if what's left is only the last term,
                         ; then we are done
        sub dst, input   ; add the quotient from self-division
        add src, input   ; adjust the offset
        sub #(dst-src)-1, input

; This performs the sieve of Erasthosenes

mark2   mov #prime-i, i  ; i, j are parallel variables
        mov #prime-i, j
        mov #0, mark3
        add #2, posn

loop6   jmz mark3, <i    ; assume the rest of the core is 0 b-field
        cmp posn, <j
        jmp loop6

        add @i, @j
        add @i, @j
        jmp loop6, <mark3

mark3   jmn mark2, #0
        mov posn, <nprime ; record the base prime
        mov posn, <j
        add posn, @j
        add posn, @j      ; record the next multiple of base prime. Ignore 2x

        slt #89, posn     ; if greater than 89, whatever input is prime
                          ; because 89 is the upper bound for 8000
        jmp mark0
        mov input, <out

last    end start
