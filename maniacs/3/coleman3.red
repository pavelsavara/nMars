;redcode-94
;name How-Far-Off-GMT-Am I?
;author Ryan Coleman
;assert 1
;strategy 80% f-scanner switches from SPL to DAT carpet
;strategy blatant ripoff of HSA
;strategy submitted in the wee hours of the morn in america.. 
;strategy questioning time zones

tPtr      dat    100 ,4100-4             
          dat    0,0
          dat    0,0
          dat    0,0
          dat    0,0
          dat    0,0
          
tWipe     mov    tSpl     ,<tPtr         
          mov    >tPtr    ,>tPtr
          jmn.f  tWipe    ,>tPtr
          
tScan     sub.x  #-12     ,tPtr          
          sne    *tPtr    ,@tPtr
          sub.x  *pScan   ,@tScan        
          jmn.f  tSelf    ,@tPtr
          jmz.f  tScan    ,*tPtr
pScan     mov.x  @tScan   ,@tScan        
tSelf     slt.b  @tScan   ,#tEnd+4-tPtr  
          djn    tWipe    ,@tScan     
          djn    *pScan   ,#10           
          jmp    *pScan   ,}tWipe       
          dat    0,0
tSpl      spl    #1,{1
          dat    0,0
          dat    0,0
tEnd      dat 0,0
      for 61
          dat 0,0
      rof
tDecoy    equ    (tWipe+1-1196)
         mov    <tDecoy+0,{tDecoy+2     ; make a quick-decoy
          mov    <tDecoy+3,{tDecoy+5     ; to foil one-shots
          mov    <tDecoy+6,{tDecoy+8     ; and the occasional q-scan
tStart djn.f  tScan+1  ,<tDecoy+10
          
          end    tStart

