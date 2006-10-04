;redcode-94
;name Process Finder
;author David Moore
;assert CORESIZE==8000

first equ 4104 ; 3585 ; 2587
fstep equ  911 ; 6727 ; 7699

PFIND equ 250

;bomb that writes back to fstore
fbomb  mov.a #first,  fstore-first

find   spl    #fstep , -fstep
fstore stp.ab #0     ,#PFIND
       add     find  , fbomb
       mov     fbomb ,*fbomb
       jmp     -2    , 0

end find
