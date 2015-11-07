;name Promotion
;author Pierre Baillargeon

;strategy
;strategy We start with the number, and substract the current prime-divisor
;strategy until the result is lower than the current prime divisor.  While
;strategy doing it, mark the memory with #1 so we can generate the new prime-
;strategy divisors at the same time.  This as the advantage of not having to
;strategy keep a table of divisors in the code (would use 24 locations) nor
;strategy having to compute them before-hand for nothing.  But if number is
;strategy too large, we modify ourselves (oups !).
;strategy
;strategy The calculation loop is four instructions long, which i believe
;strategy would be hard to beat (but not impossible, would make program
;strategy longer though).
;strategy
;strategy If the result of the substract loop is zero, we have found a
;strategy divisor, so keep it and re-use it again.
;strategy
;strategy If the result is non-zero, scan the marked memory, beginning
;strategy at the current prime-divisor to find the new prime-divisor.
;strategy

keep    equ bottom+20      ; where we keep the factors, if any
test    equ top-1          ; pointer for numbers and prime markers
number  equ bottom+2       ; we keep the number there

top
found   sub div,<keep      ; keep track of this good division
new_num mov div_res,number ; use division result as new number
n_found mov #-1,div_res    ; initialize, result of division to one
        mov #0,test        ; init marker
mark    sub test,@test     ; mark mem location as a non-base-prime
        add div,test       ; substract prime-divisor from marker pointer
        slt number,test    ; verify test >= number
div_res jmp verify,#-6479  ; yes -> verify if exact multiple
        djn mark,div_res   ; no -> increase quotient and loop
verify  sub number,test    ; verify equality
        jmz found,test     ; yes -> found a factor !
        mov div,test       ; no, find new prime-divisor
search  jmn search,<test   ; @--pointer, non-zero -> keep searching
        mov test,div       ; keep new prime-divisor
        djn n_found,#24    ; if more than 24 divisors, number is prime
        sub number,<keep   ; keep number as divisor and die
div     dat #0,#-2         ; initial prime divisor
bottom

        end new_num
