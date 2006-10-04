;redcode-94
;name pScout
;author David Moore
;assert 1
;strategy use a vampire to find opponent's pspace location

Pstore equ 123
step   equ 1445   ; multiple of 5

fang   jmp t1-(5+step), 5+step

vamp   mov       @0, @fang
       add       t1,  fang
       jmz.a   vamp,    t2     ; know when opponent is trapped

       jmz.b     #0,    t2     ; search for last nonzero pspace
       stp.ab    t2, #Pstore   ; capture the prize!

t1     spl   #-step, #step
t2     ldp.ab    #0,    #0
t3     dat       {0,     0

end vamp
