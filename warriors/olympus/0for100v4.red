;redcode-94
;name 0 for 100 v4
;author John K W
;strategy Lose points.  Break records. :-)
;strategy v4- commit suicide more efficiently. :P
p: ldp.b #0, #0
   seq.b p, #-1 ;die first round
   jmz.b }0,   p
