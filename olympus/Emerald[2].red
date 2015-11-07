;redcode
;name Emerald
;author P.Kline
inc      dat #-2045,#2045
emerald  spl 0,100
stone1   mov <a,<c
         add inc,stone1
stone2   mov <c,<d
         add inc,stone2
cnt      djn stone1,<-3799
         end emerald
