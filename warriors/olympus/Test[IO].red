;redcode-94
;name Test
;author Ian Oversby
;strategy Spiral Clear
;strategy I wish I could understand how other peoples
;strategy coreclears worked :-(
 
cptr    SPL.B   #4,     #6-381
        ADD.AB  #381,   cptr
        MOV.I   *cptr,  @cptr
        JMP.B   -2
b1      SPL.B   #5,     #6-381
b2      DAT.F   #5,     #6-381
 
end
