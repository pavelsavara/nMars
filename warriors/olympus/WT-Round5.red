;redcode-94
;name WT-Round5
;kill WT-Round5
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 5
;strategy once-thru 80% bomb/scan with multi-pass core-clear

step1    equ 12
step2    equ 16
step     equ (step1+step2)

gate     dat    #-10,scan-(8*step2)
         dat    #-10,clr-gate+7
wipe     spl    #-1 ,clr-gate+7
     for 2
         dat    0,0
     rof
bomb     dat    -step,1
next     sub    inc,@2            ; scanner bombs two and scans two locations
         mov    bomb,@scan        ; in a five-instruction loop
         mov    bomb,*scan
scan     sne    *150-step1-step2,*150-step1
cnt      djn    next,#-1
         add.b  scan,gate         ; position for wiping
inc      spl    #-2*step,#-2*step
clr      mov    @2,>gate
         mov    @1,>gate
         djn.b  clr,{wipe         ; self-decrementing pointer
  for 1
       dat 0,0                    ; a reflection at 12 :-)
    DAT.F  $   -28, $     1
    SUB.F  $     6, @     2
    MOV.I  $    -2, @     2
    MOV.I  $    -3, *     1
       dat 0,0
       dat 0,0
    ADD.B  $    -2, $   -11
    SPL.B  #   -56, #   -56
    MOV.I  @     2, >   -13
    MOV.I  @     1, >   -14
    DJN.B  $    -2, {   -13
  rof
  for 40
      dat 0,0
  rof

start    div    #5*step1,cnt
         div.a  #2,wipe
         jmp    next+1
         
         end    start
