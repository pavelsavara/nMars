;redcode
;name Sieve of Arisztotenesz
;author Na'ndor Sieben
;ICWS-88
;strategy calculate prime numbers between 2 and LIMIT ( actually
;strategy between -2 and -LIMIT )
;strategy non prime numbers are set to 0 .
;strategy A not so slight modification of Stefan's program
;strategy I know this is nasty but it's only 11 instructions
;strategy and a little bit faster ( it deletes the multiples of primes only )

LIMIT     equ 100                   ; range of integers modify here
fillptr   equ (fill-1)

fill      mov fillptr, <fillptr     ; fill array with integers
          djn -1, #LIMIT+2          ; from 0 to LIMIT+1, the last one
                                    ; is not checked it's a marker
next      jmz 0, <priptr            ; find the next prime
          mov priptr, addptr
          slt #-LIMIT,<addptr       ; are we done ?

stop      dat #0                    ; we have room even for a dummy line :-)

loop      add @priptr, addptr       ; the next integer that is not a prime
          slt #-LIMIT-(addptr-fillptr)-2, addptr ; are there any more to check
          jmp next                  ; no. do it again with the next prime
          mov #0, @addptr           ; it is not a prime, delete it
priptr    jmp loop, #fillptr-2      ; the prime we are working with
addptr    end fill
