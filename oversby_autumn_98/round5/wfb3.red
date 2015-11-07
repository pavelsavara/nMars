;redcode-94
;name d-clear
;author bjoern guenzel
;strategy clear (no scanning)
;assert CORESIZE==8000
;release 23.5.96
;kill d-clear

shift           equ -3000

ptr             dat >0,4000
                dat 0,0
start           spl #0,>ptr
                mov.i bomb,>ptr
                djn.f -1,>ptr
bomb            dat >2667,bomb-ptr+3
bsource         dat 0,0
end start
