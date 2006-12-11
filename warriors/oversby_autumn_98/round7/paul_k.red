;redcode
;name sliver
;assert 1
;author Paul-V Khuong
;email: pkhuong@technologist.com
;strat 2 clear, 1 big and 1 little. The big one checks for incoming
clears  
org     boot
st      
decoy for 20
spl     #0,     <2
spl     -1,     >-1
stp.a   #0,     <-2
spl     -3,     >-2
spl     #0,     0
spl     -2,     <0-1
rof
boot    mov.i   lc,     st+3995

for     7
mov.i   }boot,  >boot
rof

spl     <boot

spl     8
jmp     4
dat     2,      e               
dat.f   -2,     0
spl     #6,     8
mov.i   *-3,    >-3
mov.i   *-4,    >-4
jmz.b   -1,     -4
dat     2,      8
mov.i   *-7,    >-7
mov.i   *-8,    >-8
jmz.b   -1,     -8
dat.f   0,      0
        
lc      dat     2,      6
        dat     2,      6
        spl     #1,     6
        mov.i   *-3,    >-3
        jmz.b   -1,     lc-1
        dat.f   0,      0
        jmp     -3
decoy2  for     150
        spl     #0,     0
        spl     -1,     0
        rof
e end

