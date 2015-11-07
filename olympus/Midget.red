;redcode
;name Midget
;author Chip Wendell
;strategy 3rd place in ICWST'86
;assert 1
START   ADD     #-28   ,3
        MOV     #0     ,@2
        JMP     -2
        DAT     #-980
        END     START
