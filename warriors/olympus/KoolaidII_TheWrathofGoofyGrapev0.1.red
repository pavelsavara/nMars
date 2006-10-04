;redcode-b
;name Koolaid II: The Wrath of Goofy Grape v0.1
;author David Boeren
;assert CORESIZE == 8000
;strategy stun bomber -> coreclear
;strategy     v0.1 New bombing engine with ideas from Tornado
;strategy          Wasn't able to make it work with the Exodus bomb though...
 
step    equ 404                     ; modulo 8 bombing
stepb   equ (2*step)
stepc   equ (3*step)
gate    equ loop-3
 
        org loop
loop    MOV.I     bomb2,    @targ
        MOV.I     bomb1,    <targ
        MOV.I      vamp,    *targ
targ    MOV.I   stepb+3,  @step+3
        ADD.F       inc,     targ
        DJN.B      loop,     #333   ; (8000/(modulo*3))-1 bombs
inc     SPL.B    #stepc, #stepc+1
clear   MOV.I      kill,    >gate   ; Coreclear modified from Phosphorus
        DJN.F     clear,    {gate
kill    DAT.F        #0,      #20
bomb1   SPL.B        #2, #stepb+2   ; heavy stun bomb
bomb2   MOV.I        -1,      }-1
vamp    JMP.B -(step+1),    {2667
        END
