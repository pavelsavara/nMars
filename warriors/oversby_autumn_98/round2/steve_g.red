;redcode
;name backslider
;author Steve Gunnell
;strategy 1.33C linear scanner not triggered by djn streams.
;strategy Limited resistance to increment/decrement streams.
;strategy Tried scanning fowards as well. This was better.
;strategy Tried various decoy generators etc. Bleagh...
;strategy Should beat core clears and get eaten by cmp/add scanners.
;assert 1

ptr   nop    30,    -30
      nop    30,    -30
bomb  nop    30,    -30
      nop    30,    -30
loop  sne.f  <ptr,  <ptr
      seq.f  <ptr,  <ptr
      slt.ab bomb,  ptr
      jmp    loop,  >bomb
      mov.f  bomb,  >ptr
      mov.f  bomb,  @ptr
      jmp    loop,  >bomb

      end    loop



