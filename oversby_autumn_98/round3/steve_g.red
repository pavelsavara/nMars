;redcode
;name In Valen's Name
;author Steve Gunnell
;strategy Submission for round 3 of Ian Oversby's tournament.
;strategy  It is a hacked over HSA with a spiral clear grafted
;strategy  onto the end and the constants optimised with a GA.
;strategy  I've tried several times to add a Qscan but every
;strategy  time the score drops right away. *sigh*
;strategy  HSA bomb changed to not trigger its own scan.
;strategy  Spiral clear bombs with spl for a while to reinforce
;strategy  stunning. (paper heavy warriors were breaking out).
;strategy  Scan to head at kill-1 causes much better stunning.
;strategy  Lucky it doesn't have to face serious djn streams 8-).
;assert 1

STEP  equ    6519
COUNT equ    14
PSTEP equ    2000

ptr   equ    (bomb-5)

bomb  spl    #0      ,#0
      jmn.f  #0      ,<ptr
kill  mov    bomb    ,<ptr
mptr  mov    >ptr    ,>ptr
      jmn.f  kill    ,>ptr
a     add    #STEP+1 ,@mptr
scan  jmz.f  a       ,<ptr
      slt    @mptr   ,@mptr
      djn    a       ,#COUNT
      spl    #btm    ,PSTEP
      add.ab #2667   ,-1
      mov.i  *-2     ,@-2
      jmp    -2      ,<-20
      dat    #4      ,#5
btm   spl    #4      ,#6
      end    kill



