;redcode
;author Pavel Savara
;name Train

       ORG start

; this is just boostrap
start  SPL       s2
       SPL       s1
s1     SPL       j1                      ; 2 tasks
j1     JMP       loco                    ; 4 jpm to loco

s2     SPL       s3
j2     SPL       loco                    ; 2 tasks to loco
       JMP       loco

s3     
slow   EQU       2
       SPL       s4
s4     SPL       s5
s5     SPL       wagon3+slow             ; 2 tasks to wagon3
       SPL       wagon3+slow             ; 2 tasks to wagon2
       JMP       wagon3+slow             ; 2 tasks to wagon2

 
; this is train
cnt    DAT       blade+1,blade+2           ; counter for loco
       DAT       blade+2,blade+3         ; reset counter
loco   MOV.I     {cnt,<cnt               ; 4 tasks running here
wagon1 MOV.I     1000,}wagon2            ;
wagon2 MOV.I     4000,}wagon3            ;
wagon3 MOV.I     6000,}wagon1            ;
blade  MOV.I     0,1                     ; small safety imp, when train is broken