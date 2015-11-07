;redcode-94
;name He Scans Alone
;kill He Scans Alone
;author used by Paul-V Khuong(P.Kline)
;assert CORESIZE == 8000
;strategy 80% f-scanner switches from SPL to DAT carpet
;strategy I couldn't do what i wanted to do:a q^2 optimized against the white warrior
;strategy followed by a clear, bc i had no time, and couldn't find why it didn't work 8(
;strategy So, i submitted HSA(btw, the verion on planar's page has two "-" signs missing)
;strategy The rules didn'T specify that i couldn't do it, and jurisprudence was in me
;strategy favor, so i decided to submit "something"...
;strategy I'm sorry, bc i know it'S not as good as an original warrior

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
          sne    *tPtr    ,@tPtr
          sub.x  *pScan   ,@tScan        ; increment and look
          jmn.f  tSelf    ,@tPtr
          jmz.f  tScan    ,*tPtr
pScan     mov.x  @tScan   ,@tScan        ; swap pointers for attack
tSelf     slt.b  @tScan   ,#tEnd-tPtr  ; self-check
          djn    tWipe    ,@tScan        ;   go to attack
          djn    *pScan   ,#13           ; after 13 self-scans
          jmp    *pScan   ,}tWipe        ;   switch to dat-wiping
          dat    0,0
tSpl      spl    #1,{1143*2+1
          dat    0,0
          dat    0,0
tEnd      dat 0,0
      for 61
          dat.f 0,0
      rof
tDecoy    equ    (tWipe-1196)
tStart    mov    <tDecoy,{tDecoy     ; make a quick-decoy
          mov    <tDecoy,{tDecoy     ; to foil one-shots
          mov    <tDecoy,{tDecoy     ; and the occasional q-scan
          djn.f  tScan  ,<tDecoy
          for 11
   dat.f 0,0
   rof
          end    tStart
