;redcode end
;name Cannon Jr
;author Zul Nadzri
;kill Cannon Jr
;assert CORESIZE==8000
;strategy  reduced cannonade component,...with reduced strength (a lot!) 
;
;This round is in 88 code and my opponent is David Moore. Good timing eh? 
;I'll prepare for vampire and scanner. I hope it's not PacMan this time. 
;Warrior Summary:
;This is actually cannonade engine without the spirals. I add another 
;code for an extra core clear. Difficult to attack small&fast dclear type 
;warriors.

Cannon  spl     s2,     <1700
bomb    mov     dcl-1,  desti
        mov     dcl,    desti
        mov     dcl+1,  desti
        mov     dcl+2,  desti
        mov     dcl+3,  desti+1
        jmp     bomb+desti+1,<6000
        mov     <6,1
dcl     spl     -1,<2
        add     3,-2
        djn     -2,<-2858
        mov     190,<-190
for     MAXLENGTH-CURLINE-11
        dat     #dcl,     #sec
rof
sec     jmz     0,-21
        spl     1,<0
        mov     -3,<-400
        djn     -1,<4000
        mov     0,1
s2      mov     sec,destj
        mov     sec+1,destj
        mov     sec+2,destj
        mov     sec+3,destj
        mov     sec+4,destj
        jmp     destj+s2
destj   equ     2667+200-404
desti   equ     2667+200-28
        end     Cannon
