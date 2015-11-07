;name confeti
;author marshall

     SPL 1
     SPL 1 ;make 8 processes
     SPL 1

p1   SPL @0, >100 ; step size and weak increment attack
     MOV }p1, >p1 ;replication
     MOV pb, >p1
     MOV pb, >p1 ;carpet bombing
     MOV pb, >p1
     MOV {p1, <p2 ;replication
p2   JMP @0, <2020 ; launch a second copy
pb   DAT <2667, <5334 ; bomb deadly to 3-point imps
