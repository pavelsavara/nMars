;redcode
;name Trinity Zwo
;author Stefan Strack (stst@vuse.vanderbilt.edu)
;strategy     1) Decrements B-operands at large intervals
;strategy     2) Cleans up debris with imp
;strategy     3) Finishes off with mod-2 bomber/imp-stomper
;strategy (Version 2.0: smaller, should tie less)
;strategy Submitted: @date@

DIST    EQU     212
impstop EQU     trinity-12
bomb    EQU     trinity-8

trinity SPL     bomber
        SPL     imp
mutagen ADD     #DIST,  decrem
decrem  DJN     mutagen,<decrem
bomber  MOV     bomb,   <impstop
        JMP     bomber, <impstop
imp     MOV     imp,    imp+1

        END     trinity
