;redcode
;author Pavel Savara
;name Train

slow   EQU       5
len    EQU       25
par    EQU       32


pre    EQU       (par*4*4)
post   EQU       10

tweak1 EQU       13
tweak2 EQU       CORESIZE-(pre+post)-(CORESIZE/2)
tweak3 EQU       post

start1     
       ADD.A     #(CORESIZE/2), boiler
       SPL       sl1
       SPL       start3
       SPL       start2
       SPL       1
       JMP       loco                    ; 2 jpm to loco

sl1    
       SPL       1
       SPL       1                       ; 2 tasks
       JMP       loco                    ; 4 jpm to loco


start2
       SPL       1
       SPL       1
       JMP       engine+2,}0             ;4 tasks to blade, engine , boiler 
      

;passangers
start3
       SPL       1                       ;2  tasks 
       SPL       1                       ;4  tasks 
       SPL       1                       ;8  tasks 
       SPL       1                       ;16 tasks 
       SPL       1                       ;32 tasks 

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
door   MUL.A     #tweak1,coal-1          ; tweak wagon tasks
boiler MOD.A     #tweak2,coal-1          ; tweak wagon tasks
blade  ADD.A     #tweak3,coal-1          ; tweak wagon tasks
       DAT       0,0                     ;fender
       DAT       0,0                     ;fender
tail   MOV.I     500 ,}1                 ; tail
       MOV.I     2500,}1                 ; second class
       MOV.I     4500,}1                 ; dining-car
       MOV.I     6500,}1                 ; first class
coal   MOV.I     8500,}1                 ; coal car

    

