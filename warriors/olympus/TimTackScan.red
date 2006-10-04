;redcode-94 test
;name Tim Tack Scan
;author P.Kline
;assert CORESIZE == 8000
;strategy 50% spl-carpeting f-scanner

tGate     equ    (tSpl-19)
tStep     equ    9

tPtr      dat    100 ,4102
          dat    0,0
          dat    0,0
          dat    0,0
          dat    0,0
tAttack   mov    tSpl     ,>tPtr       ; spl-carpet
          jmn.f  -1       ,@tPtr
tScan     add.x  #tStep   ,@-2         ; increment and scan
          jmz.f  tScan    ,@tPtr
tSelf     slt.b  tPtr     ,#tEnd-tPtr  ; check for self
          jmp    tAttack  ,<tPtr
          djn    tScan    ,#6          ; count self-scans
tSpl      spl    0,0
          mov    tDat     ,>tGate      ; dat-wipe core
          djn.f  -1       ,>tGate
tDat      dat    >5335    ,tEnd-tGate
          dat 0,0
tEnd      dat 0,0

          end    tScan
