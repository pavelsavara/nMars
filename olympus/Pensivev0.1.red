;redcode-b quiet
;name Pensive v0.1
;author Ian Oversby
;strategy v0.1  Anti-scanner
;assert 1
 
stun    SPL.B   #-3044, #3044
loop    ADD.F   stun,   1
        MOV.I   <101,   2
        MOV.I   stun,   >-3000
        DJN.F   loop,   <-100
        MOV.I   1,      {loop
