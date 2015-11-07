;redcode
;name RotLD TNG 2 
;author nandor sieben
;Return of the Living Dead the Next Generation
;macro
moves  equ mov next, <-1
       equ jmp @-2

sp     spl sp1
sp0    spl sp01 
sp00   spl sp001
sp000  mov gen, gen+1000
       moves
sp001  mov gen, gen+2000
       moves
sp01   spl sp011
sp010  mov gen, gen+3000
       moves
sp011  mov gen, gen+4000
       moves 
sp1    spl sp11
sp10   spl sp101
sp100  mov gen, gen+5000
       moves
sp101  mov gen, gen+6000
       moves
sp11   spl sp111
sp110  mov gen, gen+7000
       moves 
sp111  jmp next
var    for 20
       dat 0,0     
       rof 

next   spl #0 ,>-10
gen    djn.I #0,<-10
