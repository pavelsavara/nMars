;redcode
;name Carbonite
;author Um.. I forgot who. :-)
;assert CORESIZE==8000
org strat2
dbomb   dat     >-1, >1
strat2  spl     #0, <-100
        mov     dbomb, tar-197*3500
tar     add     #197, -1        ; gets bombed to start coreclear
        djn.f   -2, <-1151
