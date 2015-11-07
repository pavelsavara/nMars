;redcode-94
;name kill -9
;author David Moore
;strategy a very simple bomb dodger
;assert 1

scan  jmz.f   #0, }sp
      mov    <sp, {sp
      djn     -1, #(db-p2)+1
sp    jmp   db+1, db+1
      
p2    spl    #p2, db+1
      mov     db, >p2
      djn.f   -1, {p2
db    dat <(CORESIZE+1)/3, <((CORESIZE+1)/3)*2

end
