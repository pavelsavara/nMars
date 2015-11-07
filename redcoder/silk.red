;name Silk
;author Walter Hofmann <walterh@gmx.de>
; taken from the FAQ

                 spl   1
                 mov   -1, 0
                 spl   1                ;generate 6 consecutive processes
         silk    spl   3620,   #0       ;split to new copy
                 mov   >-1, }-1      ;copy self to new location
                 mov   bomb,   >2000 ;linear bombing
                 mov   bomb,   }2042    ;A-indirect bombing for anti-vamp
                 jmp   silk,   {silk    ;reset source pointer, make new copy
         bomb    dat   >2667,  >5334  ;anti-imp bomb
