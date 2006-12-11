;redcode
;name 8001:  A Pathetic Odyssey
;author WFB
;strategy Yet another lame imp-stone.
;strategy For Ian's Round 8.
;strategy This is barely tested.  All I did was change a few numbers...
;strategy Not to mention the fact that I know almost nothing about imps.
;strategy I'm not sure how well the imp will work with the changes I made...
;strategy Oh well.  I just wanna keep 4th.  I got about 100 points ahead and
;strategy Behind me, so it shouldn't be too hard.  Knowing me, however...
;strategy As I said, this is a lousy imp-stone I made for Weasel.
;strategy Just changed the constants.  Kept the spl 0.  Otherwise it suicides
;strategy A whole lot faster...=)
;strategy I should make a p-spacer or include something to kill paper but
;srategey it is I...WFB!  Record holder for longest time playing and still
;strategy Getting nowhere on the -b hill.  Whatever.  Ciao...
;assert CORESIZE==8001
step    equ 2829
sdist   equ     4644
start   mov.i   {loc, <sptr
for 4
        mov.i   {loc, <sptr
rof
        mov.ab  #-7,    *sptr
        spl.b   impboot,        <-707
        spl.b   @sptr,  <-700
sptr    div.f   #sdist, #sdist-1
        dat.f   }300,   >200
dstart  spl #0 , #0
diamond spl #-step,<step
stone   mov >-step,step+1
        add diamond,stone
        djn.f  stone,<diamond-1051
loc     dat #0,#0
imp_sz  equ     6401
impboot spl     1      ,<-450
        spl     1      ,<-458
        spl     1      ,<-466
        spl     <0     ,#vector+1
        djn.a   @vector,#0

imp     mov.i   #imp_sz, *0

        jmp     imp+imp_sz*10,imp+imp_sz*9   
        jmp     imp+imp_sz*8,imp+imp_sz*7   
        jmp     imp+imp_sz*6,imp+imp_sz*5   
        jmp     imp+imp_sz*4,imp+imp_sz*3
        jmp     imp+imp_sz*2,imp+imp_sz*1
vector  jmp     imp+imp_sz  ,imp

end    start
