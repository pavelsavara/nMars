;redcode
;name Iron Gate
;author Wayne Sheppard
;strategy CMPscanner
;
;Who knows?  I've been way too busy to fully develop a decent warrior.
;But I am hoping that Mintardjo has developed a replicator that can take
;Snake out.  Plus I can't beat Sphinx or Chimera with Snake.  

dist equ 98
scan equ dist*2     

a add d,@x
c cmp a+dist,a
  slt #20,@x
  djn a,<7000
  mov j,@c
x mov s,<c
  sub n,@x
  jmn c,a
s spl 0,<1-dist
  mov 2,<-3
j jmp -1
n dat <0-dist,<0-dist-1
d dat <scan,<scan
