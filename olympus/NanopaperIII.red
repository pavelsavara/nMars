;redcode
;name Nano paper III
;author Maurice Fernández

STEP    EQU    17

paper   spl.b  0, STEP 
        mov.i  }-1, >-1
        spl    paper+STEP+1, <-10
        jmp    paper+1, <-10
