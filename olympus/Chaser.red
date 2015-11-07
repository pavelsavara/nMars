;redcode
;name Chaser
;assert CORESIZE==8000
        SPL addme
        JSI 1,#0
        MOV {data,<data
        DAT 0,0
adder   DAT 3095,3095
addme   JSI 1,#0
        ADD adder,data
        DAT 0,0
data    DAT 3095,1
