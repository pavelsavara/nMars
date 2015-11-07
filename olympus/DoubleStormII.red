;
;    Warrior: DoubleStormII
;  File name: Dblstrm2.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Matthew J. Chung
;     Branch: Lisgar Collegiate Institute
;
start     SPL                    start2    ; split to dwarf gun
start1    MOV   instr2,        < move1
          MOV   instr1,        < move1
          SPL                  @ move1     ; spawn a new "double smash"
          SUB # 801,             move1
move1     JMP   start1,         -100
start2    MOV   instr8,        < move2
          MOV   instr7,        < move2
          MOV   instr6,        < move2
          SPL                  @ move2     ; spawn a new "dwarf"
move3     SUB # 796,             move2
move2     JMP   start2,          100
instr1    MOV   move3,         < move3     ; ** double smash **
instr2    DJN   instr1,          move3
instr6    ADD # 60,              instr8
instr7    MOV   instr2,        @ instr8    ; ** dwarf **
instr8    JMP   instr6,          instr2
          END   start
