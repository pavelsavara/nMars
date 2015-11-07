;Redcode
;Name launch
;Standard 88
;Strategy impring launch at jmp range limitation
;Strategy very inefficient, shows only the possibility
;Author Nandor Sieben

start    spl 1
         spl 1
s        mov #12 , 0
         mov #d-s-2667+4-12, d ; historical constant :-)
         jmp 1, < count
         jmz count, count      ; did we make a whole round (if yes start imp)
         mov <s , <d
         mov <s , <d
         mov <s , <d
count    spl wait , 4*3        ; start the waiting to become the imp
         jmn @d , count
         mov imp, wait         ; start the impring
d
wait     jmp 0 , #0	       ; this is gonna be the imp
imp      mov 0 , 2667
         end start
