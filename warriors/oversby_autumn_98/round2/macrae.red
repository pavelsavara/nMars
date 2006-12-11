;redcode-94
;name Nibble 
;author Robert Macrae
;assert CORESIZE==800
;strategy Blur-like scanner
; Steps forward at 2.5c linear with spacing of 5.
; Based on NiBl, but with DClear carpet. Vuln to 1,1 bombs.

hit             spl.f {1,       }1
		spl.f }0,       {0
		spl.f {0,       }0

ptr   spl.f  }0,        -200  
scan  seq.f  hit+35,    hit+30
chg    mov.b scan,      @pp
      add.f  clr,       scan
      mov.f  clr,       >ptr    
pp    djn.f  scan,      >ptr   ; falls through at hit.
      spl.f  }0,        {0 
      mov.f  clr,       >ptr
btm   djn.f  -1,        >ptr
clr   jmp.f  {10,       10

		spl.f {0,       }0
		spl.f }0,       {0
		spl.f {0,       }0
		spl.f }0,       {0
		spl.f {0,       }0
		spl.f }0,       {0

      end    scan
