;redcode-94
;name Simple Scissors
;author John K. Wilkinson
;strategy Just plain scissors, baby.
;strategy I don't see how you can top scissors for overall
;strategy ability to adjust to coresize chnages.

org clear

         dat    #cgate-10, clear-cgate+8    ; just in case clr is decremented
cgate    dat    #-4000,    3000
wipe4    dat    #-4000,    clear-cgate+8
wipe3    dat    #-4000,    clear-cgate+8
         dat    #-2000,    clear-cgate+8   ; redundant wipers
wipe2    spl    #-2000,    clear-cgate+8   ; redundant wipers
wipe1    spl    #-5950,    clear-cgate+8

dat 0, 0
dat 0, 0
dat 0, 0
dat 0, 0
dat 0, 0
dat 0, 0

clear    spl    #0, >-20
         mov    @2, >cgate
         mov    @1, >cgate
         djn.b  -2, {wipe1
