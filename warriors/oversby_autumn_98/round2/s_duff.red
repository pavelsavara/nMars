;name Cryton
;author Simon Duff
;strategy Simple Bomber except ADD to A and B fields rather than
;strategy drop DAT or SPL bombs
;assert 1
for 0
        The constant of 753 is nice, but is not very spread out,
        and misses a few gaps here and there. Thank God I've finished
        the exams now - I can get better constants for the next rounds.
rof

Cryton  ADD     bomb1,  ptr1    ; incremnet location to bomb
        ADD     bomb1,  @ptr1   ; 'bomb' it
        JMP     Cryton          ; repeat
bomb1   DAT     753,    753     ; 'bomb' to drop 
ptr1    DAT     1,      1       ; where am I pointing to?
        END     Cryton
