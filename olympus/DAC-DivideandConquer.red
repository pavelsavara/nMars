;
;    Warrior: DAC - Divide and Conquer
;  File name: dac.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Mark A. Durham
;       Date: December 4, 1990
;
        JMP START
SOURCE  DAT #TARGET
START   MOV #TARGET-SOURCE,         SOURCE
        MOV #2342+SOURCE-TARGET,    TARGET
COPY    MOV @SOURCE,                <TARGET
        DJN COPY,                   SOURCE
        SPL @TARGET
        MOV #155,                   TARGET
ENSLAVE MOV TRAP,                   @TARGET
        DJN ENSLAVE,                TARGET
        MOV #155,                   TARGET
KILL    MOV FREE,                   @TARGET
        DJN KILL,                   TARGET
FREE    DAT #63
TRAP    SPL TRAP
TARGET  DAT #2432+SOURCE-TARGET
        END START
