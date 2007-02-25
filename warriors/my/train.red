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
boiler DIV.AB    #20,coal-1              ; tweak wagon tasks
blade  MUL.AB    #20,coal-1              ; tweak wagon tasks
       DAT       0,0                     ;fender
tail   NOP.I     >1, 500                 ; tail
       NOP.I     >1,2500                 ; second class
       NOP.I     >1,4500                 ; dining-car
       NOP.I     >1,6500                 ; first class
coal   NOP.I     >1,8500                 ; coal car

    

