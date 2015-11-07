;
; MAD Ferret
;
; by Mark A. Durham
;
; January 22, 1990
;
; based on FERRET by Rober R. Reed, III.
;
START       CMP     < HERE,    < THERE
            MOV       TRAP,    @ THERE
            CMP     < HERE,    < THERE
HERE        MOV       TRAP,      START
            JMN       START,     THERE
LOOP        MOV       KILL,    < KILL
            DJN       LOOP,    < KILL
TRAP        SPL       TRAP
KILL        DAT                  LOOP
THERE       DAT                  4096
            END       START
