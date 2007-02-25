;redcode
;author Pavel Savara
;name Train

slow   EQU       5
tweak  EQU       0
       SPL       start2

start1     
       SPL       1
       SPL       1                       ; 2 tasks
       JMP       loco                    ; 4 jpm to loco

start2
       SPL       start3
       SPL       1
       JMP       engine+1,}0             ;2 tasks to engine & blade

;passangers
start3
       SPL       1                       ;2  tasks 
       SPL       1                       ;4  tasks 
       SPL       1                       ;8  tasks 

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
engine MOV.I     tail,coal               ; roll wagon tasks
blade  ADD.AB    #tweak,coal             ; tweak wagon tasks

tail   MOV.I     >1,1000                ; tail
       MOV.I     >1,3000                ; second class
       MOV.I     >1,5000                ; dining-car
       MOV.I     >1,7000                ; first class
coal   MOV.I     >1,1000                ; coal car

    

