;redcode-b verbose
;name Flamberge 101
;kill Flamberge
;author Matt Lewinski
;assert CORESIZE==8000

         org scan
gap      equ 5
optima   equ 90


;Executing Loop        
        dat.f   $0                  , $100
top     mov.i   $offset             , >-1
scan    seq.i   $2*optima-(top)     , $(2*optima)+gap-(top)
        mov.b   $scan               , @top
        add.f   $offset             , $scan
        djn.b   $top                , #796
offset  spl.a   #optima             , #optima
        mov.i   $clear              , >top
bottom  djn.f   $-1                 , >top
clear   dat.f   <1                  , #clear-top+2

;Spacer
for 100-CURLINE
        dat.f   $0                  , $0
rof
end

-- 
--------------------------------------------------------------------
Matt Lewinski                            98mlewinski@kamsc.k12.mi.us
Kalamazoo Area                       mlewinsk@newton.kamsc.k12.mi.us
Math & Science Center      http://www.kamsc.k12.mi.us/sp98/mlewinski
