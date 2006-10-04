;redcode-94
;name  test
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSFCWT Round 3
;assert CORESIZE == 8000
;assert VERSION >= 63

;strategy Use this submission twice!
;strategy Paper-imp combo with reflection 12

org first

step equ 12
step1 equ 3740
step2 equ -1874

first spl 1
      spl 1
      spl 1
      spl step+1
      spl 1144,0
      mov >-1,}-1
      spl step1,0
      mov >-1,}-1
      mov <-2,{2
      jmz.f *1,-5
      mov.i #step2,1143
      dat <2667,<5334
      spl 1
      spl 1
      spl 1
      spl step+1
      spl 1144,0
      mov >-1,}-1
      spl step1,0
      mov >-1,}-1
      mov <-2,{2
      jmz.f *1,-5
      mov.i #step2,1143
      dat <2667,<5334
      
end
