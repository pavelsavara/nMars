;redcode-94
;name Q^2
;author Anders Ivner
;strategy Qscan with shorter reaction time.
;assert (CORESIZE == 8000)

QBASE equ   (tab+100)
QS1   equ   (100)
QS2   equ   (3*QS1)
QS3   equ   (6*QS2)

QP01  equ   (0*QS2)
QP02  equ   (1*QS2)
QP03  equ   (2*QS2)
QP04  equ   (3*QS2)
QP05  equ   (4*QS2)
QP06  equ   (5*QS2)

HOP01 equ   jmp
SIG01 equ   a01
HOP02 equ   jmp
SIG02 equ   {a01
HOP03 equ   jmp
SIG03 equ   }a01
HOP04 equ   jmp
SIG04 equ   >a01
HOP05 equ   jmp
SIG05 equ   <a01
HOP06 equ   djn.f
SIG06 equ   a01

  org   qq

qq
j  for   3
i  for   6
  sne   QBASE+QP&i+0*QS3+(j-1)*QS1,   QBASE+QP&i+1*QS3+(j-1)*QS1
  seq   QBASE+QP&i+2*QS3+(j-1)*QS1,   QBASE+QP&i+3*QS3+(j-1)*QS1
  HOP&i a&j,  SIG&i
  rof
  rof
  jmp   boot     ;nothing found

  dat   1*QS2,   4*QS2+QBASE-found
tab   dat   0*QS2,   0*QS2+QBASE-found
  dat   2*QS2,   3*QS2+QBASE-found

a03   add   #QS1, @a01
a02   add   #QS1, @a01
a01   add.ab   tab,  tab
found mov.b @a01, #0
  add.ba   found,   test1
test1 sne   QS3+found,@found
  add   #QS3*2,  found
  sne   -100, @found
  add   #QS3, found

  end
