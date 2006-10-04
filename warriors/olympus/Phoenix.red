;redcode-94 verbose
;name Phoenix
;author J. Pohjalainen
;assert CORESIZE==8000
;kill Phoenix

PSTEP equ 2720
NSTEP equ 1072
ESTEP equ 455

warrior

        spl     1,              <-100
        spl     1,              <-300
        mov.i   -2,             0

phoenix spl     @phoenix,       >PSTEP
        mov.i   }phoenix,       >phoenix
nest    spl     @nest,          >NSTEP
        mov.i   }nest,          >nest
egg     spl     @egg,           >ESTEP
        mov.i   }egg,           >egg
        dat.f   <2667,          <2*2667

end warrior
