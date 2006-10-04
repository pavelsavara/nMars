;redcode
;name Dwarven warrior
;author Net Mantis
          org dwarf
          dat     #0, 0
          dat     #0, 0
dwarf mov     -2,   5  ;lunch bomb ahead
          mov     -2,  -5  ;lunch bomb behind
          add    # 5,  -4  ;incriment ahead coordinates
          sub    #5,  -4  ;decriment behind coordinates
          jmp    dwarf
          end
