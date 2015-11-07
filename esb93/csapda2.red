;redcode
;Name csapda2
;Author Nandor Sieben
;round2

start    add eltolas,point
         jmz -1,@point
         mov point,point+10
         mov #12,0
         mov bomb,<point+10
         djn -1,-2
         mov point,@point
         jmp start,#0
         dat #0,#0
         dat #0,#0
         dat #0,#0

         dat #0,#0
         dat #0,#0
         dat #0,#0
         dat #0,#0

         dat #0,#0
bomb     djn -1 ,#2
         dat #0,#0
         dat #0,#0

         dat #0,#0
point    jmp -start+200+2,start-1-200
         mov point-1,<1
         spl -1,start-2
         jmp -2,#0
eltolas  dat #3428,#-3428
         end start
