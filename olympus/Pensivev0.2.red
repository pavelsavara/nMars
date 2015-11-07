;redcode-b
;name Pensive v0.2
;author Ian Oversby
;strategy v0.1  Anti-scanner
;strategy v0.2  Fixed bugs
;assert 1
 
        org loop
stun    SPL.B   #-95, #95
loop    ADD.F   stun,   1
        MOV.I    }-1,   2
        MOV.I   stun,   >-3000
        DJN.F   loop,   <-100
        MOV.I   1,      {loop
        end
