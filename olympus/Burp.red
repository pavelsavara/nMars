;redcode
;name Burp
;author Jack Twilley
;strategy Simple looper
start   mov  empty,  <bottom
bottom  djn  start,  #start
imp     mov  imp,     empty
empty   dat #empty,  #empty
        end start
