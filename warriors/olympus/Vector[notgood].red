;redcode-94
;name   Vector (3 point, 8 process spiral, this not really a good spiral)
;author T.Hsu
;assert CORESIZE == 8000

imp_size        equ             2667                            ; 3 point, 8 process imp spiral
imp_prc         equ             8

                        dat             imp+imp_size*3 ,imp+imp_size*7
                        dat             imp+imp_size*2 ,imp+imp_size*6
                        dat             imp+imp_size   ,imp+imp_size*5
                        dat             imp            ,imp+imp_size*4
imp_vector      spl             1              ,#0
                        spl             1              ,#0
                        spl             *(imp_vector-1),{0
                        djn.a   @(imp_vector-1),#0

imp                     mov.i   #0,imp_size

                        end             imp_vector
