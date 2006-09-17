       ORG      START
START  ADD.B  #     4, $3        ; execution begins here
       MOV.I  $     2, @2
       JMP.B  $    -2, #0
       DAT.F  #     0, #0