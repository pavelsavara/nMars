;redcode
;name Sieve of Aristostenes (sp?)
;author Stefan Strack
;strategy calculate prime numbers until LIMIT; non-prime numbers in array
;strategy are set to -1. Not efficient since upper bound (label 'bound')
;strategy is not recalculated.

LIMIT  equ 100

fill   mov addptr,@addptr ; fill array with potential primes
       sub #1,addptr
       djn fill,#LIMIT
loop   add priptr,addptr  ; weed out all multiples of priptr
       jmz next,@addptr
       mov #-1,@addptr    ; indicate a non-prime
       jmp loop
next   add #1,priptr      ; increment priptr and check if done
       mov priptr,addptr
bound  slt #LIMIT,priptr  ; this is inefficient, since bound := bound / priptr
       jmp loop

priptr dat #2
addptr dat #LIMIT

       end fill
