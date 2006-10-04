;
; Scrambler
;
; by Mark A. Durham
;
; January 22, 1990
;
START      MOV     < HERE,      < THERE
           MOV     < THERE,     < HERE
           JMN       START,       THERE
WAIT       SPL       WAIT
HERE       JMP       WAIT,      # START
THERE      DAT                  # 4092
           END       START

