;redcode
;name Diamod 88
;kill Diamod
;author Matt Lewinski
;strategy Stone-Imp
;assert CORESIZE==8000

;Unfortunately, this warrior scores many ties, not the best thing in
;this case. I hope to work on it more, but obviously not before
;round three. 88 sucks, too restrictive
step     equ 95
boot     equ impsize+5
impsize  equ 889


split    spl     0               , 0
move     mov     <(step-2)+step  , step-2
addr     add     data            , move
jump     djn     move            , <split
data     dat     #-step          , #step
         
start    mov     data            , <where
         mov     jump            , <where
         mov     addr            , <where 
         mov     move            , <where 
         mov     split           , <where
where    spl     @where          , boot

spiral   spl     1               , <-700
         spl     1               , <-700
         spl     1               , <-700
         spl     1               , <-700
         spl     1               , <-700
         spl     2               , <-700
         jmp     @0              , imp
         add     #impsize        , -1
         dat     #0              , #0
imp      mov     0               , impsize

end      start
