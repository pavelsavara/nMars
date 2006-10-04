;redcode
;name Achilles
;Author Jonathan Wolf
 
target  dat #0,#0
        dat #0,#0
bomb    dat #0,#0
        dat #0,#0
        dat #0,#0
start   spl 0,0
        mov @bomb, <target ;at bomb -> if bomb hit still
                           ;bombs with a dat not a spl
        mov @bomb, <target
        mov @bomb, <target
        jmp -3
        mov 1,-1  ;if the above is stunned repair it
        jmp -3
        end start
