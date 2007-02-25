;redcode
;author Pavel Savara
;name Train

slow   EQU       3
tweak1 EQU       0
tweak2 EQU       0

start1     
       SPL       sl1
       SPL       start3
       SPL       start2
       NOP
       JMP       loco                    ; 1 jpm to loco

sl1    
       SPL       1
       SPL       1                       ; 2 tasks
       JMP       loco                    ; 4 jpm to loco


start2
       SPL       sl2
       SPL       1
       JMP       engine+2,}0             ;3 tasks to blade, engine , boiler 
sl2    JMP       -1 
      

;passangers
start3
       NOP       1                       ;2  tasks 
       NOP       1                       ;4  tasks 
       NOP       1                       ;8  tasks 

       SPL       b
a      SPL       a2
a1     JMP       tail+0+slow
a2     JMP       tail+1+slow
b      SPL       b2
b1     JMP       tail+2+slow
b2     JMP       tail+3+slow

;---------------- Train ----------------
wheel  DAT       blade+1,blade+2         ; counter for loco
       DAT       blade+2,blade+3         ; reset counter
loco   MOV.I     {wheel,<wheel           ; 4 tasks running here
engine MOV.I     tail-1,coal-1           ; roll wagon tasks
boiler DIV.A     #20,coal-1              ; tweak wagon tasks
blade  MUL.A     #20,coal-1              ; tweak wagon tasks
       DAT       0,0                     ;fender
       DAT       0,0                     ;fender
tail   MOV.I     500 ,}1                 ; tail
       MOV.I     2500,}1                 ; second class
       MOV.I     4500,}1                 ; dining-car
       MOV.I     6500,}1                 ; first class
coal   MOV.I     8500,}1                 ; coal car

    

