;redcode-94
;name HSA (no decoy)
;author David Moore
;assert 1

; Just like the original "He Scans Alone" by Paul Kline.
;
; I did experiment briefly with dual scanners, but the pair never scored as
; well as one lone scanner did. When the SPL/MOV portion of the replicator
; landed on one scanner, it would cause stray processes to wander into the
; SPL carpet that had been laid. This was a difficult problem which I could
; not solve.
;
; I think that the strategy of multiple cooperating warriors makes it very
; hard to get wins so I don't expect to see it in the top ranks.
; However, I would like to be proven wrong.

tPtr      dat    100 ,4100-4             ; widely-spaced pointers
          dat    0,0
          dat    0,0
          dat    0,0
          dat    0,0
          dat    0,0
          
tWipe     mov    tSpl     ,<tPtr         ; positive wipe of opponent
          mov    >tPtr    ,>tPtr
          jmn.f  tWipe    ,>tPtr
          
tScan     sub.x  #-12     ,tPtr          ; increment and look
tStart    sne    *tPtr    ,@tPtr
          sub.x  *pScan   ,@tScan        ; increment and look
          jmn.f  tSelf    ,@tPtr
          jmz.f  tScan    ,*tPtr
pScan     mov.x  @tScan   ,@tScan        ; swap pointers for attack
tSelf     slt.b  @tScan   ,#tEnd+4-tPtr  ; self-check
          djn    tWipe    ,@tScan        ;   go to attack
          djn    *pScan   ,#13           ; after 13 self-scans
          jmp    *pScan   ,}tWipe        ;   switch to dat-wiping
          dat    0,0
tSpl      spl    #1,{1
          dat    0,0
          dat    0,0
tEnd      dat 0,0
          
          end    tStart

