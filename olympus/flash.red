;redcode
;name flash
;author Nandor Sieben
;contact aznxs@asuacad.bitnet
;
;strategy fast short bomb, core clear, imp gate
;strategy I hope I get a scanner opponent
;
start  add #15 ,2
       mov bomb , @1
       mov bomb , @90
       djn start , #(8000-100)/15-20
       mov @bomb+2, <-6
       jmn -1 , bomb
       jmp 0 ,< -20
       mov 0 ,1
bomb   dat <-2667+8,<7
       end start
