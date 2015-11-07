;redcode-x verbose
;name Absolute 250
;author James Jesensky

;The second oldest program on the X-hill (age 61) is an imp-based
;program, Absolute 250.  It hit #1 twice, but usually hangs out
;between 4th and 9th.  For an imp-based program, it scores a lot
;of wins (25%).  Here it is:

start    spl  imp, <-199
         jmp  -1, <-200
imp      mov  0, >1
