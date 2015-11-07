;redcode-94
;name ldpgun
;author k.m
;assert 1
;strategy implike?

ptr dat start-10, start-10

ok  spl 0

start nop    }ptr+3,}ptr+2
      ldp.ab }ptr+1,{ptr+4  ; or } or < or >, makes different effects.
      ldp.a  >ptr+5,{ptr+7
      jmp start,<-10

end ok
