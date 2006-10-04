;redcode-b
;name IMPy
;author WFB
;strategy lanches simple imps, then kills them (huh?)
;assert 1
net equ shoot-12          
shoot:       spl 2
catch:        jmp -1,<net
imp:          mov 0,1
end shoot
