;redcode-94
;name White warrior
;author Nandor & Stefan
;assert CORESIZE==8000
;strategy White warrior for round 2 of Nandor and Stefan's fall 1995 tournament
;strategy Out of senseless cruelty, we'll show the load file format only :-)

       ORG      START
       DAT.F  $   600, $   600     
START  MOV.I  $    14, @     1     
       MOV.I  <   100, @   300     
       MOV.I  $    12, *    -1     
       ADD.F  $    -4, $    -2     
       DJN.B  $    -4, #    11     
       SPL.B  $     1, $     0     
       SPL.B  $     1, $     0     
       SPL.B  $     1, $     0     
       SPL.B  @     0, }  1800     
       MOV.I  }    -1, >    -1     
       SPL.B  @     0, }  3740     
       MOV.I  }    -1, >    -1     
       MOV.I  {    -2, <     1     
       JMP.B  @     0, > -1874     
       DAT.F  > -2467, >   200     
       MOV.I  $    -1, $     1     
       END
