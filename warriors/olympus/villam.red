;redcode
;Name villam
;Author nandor sieben

start  add #7 ,2
       mov bomb , @1
       mov bomb , @94
       djn start , #12000/7-15
       spl 0
       mov 0,1
bomb   dat #0,#3997
       end start
