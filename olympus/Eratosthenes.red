;redcode
;author Simon Arthur (neur0mancer@oak.circa.ufl.edu)
;name Eratosthenes
;strategy Bombs at large intervals.
 
begin    mov loc,@loc
         sub #391,loc
         jmp begin
loc      dat #-7
