;redcode
;name I-Deserve-Your-Ridicule
;author John Metcalf
;strategy a scanner which doesn't stand a chance. Just
;strategy had to write a scanner for the round which
;strategy is extremely hostile to them ;-)
;assert 1
 
; arrrghhh - no time to finish it off. Not even tested
; it :-( I did want to also scan for identical core at
; a distance of 2667 to catch imps, but...
 
; I'll write a serious entry for the next round :-P
 
     step equ 3039
 
slkM:dat   -1,       -1
 
pos: dat   <-2667,   slkM-1
 
     dat   <-2667,   <-5334
     dat   <-2667,   <-5334
 
loop:add   #step+2,  pos   ; search for -1,-1
     seq.f slkM,     <pos
     jmn.f loop,     <pos  ; search for  0, 0
     djn.f 1,        <pos
 
 
     spl   #0,       <pos-2667
     mov   @bp,      >pos
     mov   @bp,      >pos
     mov   @bp,      >pos
bp:  djn   -2,       {sb1
 
     dat   <loop,    <8-pos
     dat   <2667,    <5334+2
     spl   #loop,    <6-pos
sb1: spl   #loop,    <5-pos
     end   loop
