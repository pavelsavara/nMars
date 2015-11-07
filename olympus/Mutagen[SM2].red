;redcode 94
;name Mutagen
;author Scott Manley
;strategy Scan -> SPL/JMP bomb -> split to Imp gate / 2 pass  forward 
; travelling core clear
;assert CORESIZE==8000

plength EQU     35
inc     EQU     6
carpet  EQU     (CORESIZE-MINDISTANCE)/inc

step equ 127

adds    DAT     #inc , #inc
begin   SPL     clear2
start   SEQ.I   *scan, @scan
        JMP     scan1        
cont    ADD.F   adds , scan
        DJN     start , count
        JMP     clear3  
scan1   MOV     sbomb , * scan 
scan2   MOV     sbomb2 , @ scan 
        JMP     cont
scan    DAT     MINDISTANCE-10 , MINDISTANCE-9
target1 DAT     26 , -23
target2 DAT     25 , -22
target3 DAT     -1 , -24
target4 DAT     -2 , -23
        DAT     0 , 0
        DAT     0 , 0
        DAT     0 , 0
        JMP     0 , } cont
clear2  MOV.I   sbomb , } target1
        DJN     clear2 ,# -23 
        JMP     clear4
clear3  MOV.I   target2 , } target2
        DJN     clear3 , #-22
clear1  MOV.I   target4 , { target4  
        DJN     clear1 , target4
        JMP     0 , > -10
clear4  MOV.I   sbomb , { target3
        DJN     clear4 , target3
        SPL     imp,-10
pos     SPL     0 , < -9 
        JMP     < 1, <-10
        DAT     < -11,-20
imp     MOV     0,1
sbomb   SPL     0 , 0
sbomb2  JMP     -1
count   DAT     #carpet-1,#carpet-1
        END     begin

