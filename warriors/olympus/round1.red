;redcode
;name round1
;author nandor sieben
 
begin     spl start02
i for 2
start&i   jmz 0 , 80
          jmn 3 , 81
          mov 0,-1
          dat #0
 
          mov 8 , start+80
          jmp 3
          dat #0
          dat #0
 
          mov 5 , start+81
          jmp start+80
          dat #0
          dat #0
 
          spl 0 ,<1
          mov -3 ,-10
 
          dat #0
          dat #0
          dat #0
          dat #0
rof
