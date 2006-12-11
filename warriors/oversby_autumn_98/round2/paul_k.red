;redcode
;name 2 Fast 
;assert 1
;author Paul-Virak Khuong
;x..x....x..x....x..x....x..x....x..x....x..x....x..x..
;This is the pattern--^
;I've been thinking of a 67% scanner/bomber. 
;It wouldn't have been that bad.
;A bit like leprechaun. But, why use a scanner part?
;After all, there's no paper.......
;Wish i haven't just made an error. . . . . . .
FOR CORESIZE==8000
 step    equ     2376
 rof
 for CORESIZE==800
 step    equ     312
 rof
         org     start
 
 inc     nop     step,   -(step-1)
         mov.x   {-1,    <2
 start   add.f   inc,    -1
         jmz.f   -2,     <-2
 clear   spl     0,  0
         add.f  wipe,   >-3
         add.f  wipe,   >-4
         djn.f  -1,  >-5   ;clear for aprox 15670(19 time)
wipe  dat     671,    7
         for     MAXLENGTH-CURLINE
         spl.f     0,      0
         rof
 end
 

_________________________________________________________
DO YOU YAHOO!?
Get your free @yahoo.com address at http://mail.yahoo.com

