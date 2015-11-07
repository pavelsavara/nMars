;redcode-94
;name Digital DNA
;author Christian Schmidt
;strategy stone,clear
;assert 1
;After loading the gameclock, two 2c Quickbomber try to hit
;the enemy before booting. In the meanwhile two d-clears are
;booted away to a point which is set by the gameclock. The
;start of them are delayed until the qbombers are finished.

PCOUNT equ     123
bptr1  equ     (begin+3005-400)
xbptr1 equ     (begin-995-400)
delay  equ     12

       org     load

k  for 40
       dat      1-k,        4+k
   rof
begin  dat      0,          0
load   ldp.a    #PCOUNT,    store     ;load the gameclock
       nop      }store,     <-2000    ;adjust and
store  stp.ab   #store,     #PCOUNT   ;store the new gameclock
       spl      quickb1,    <-3000
       spl      quickb2,    <-3000
       spl      dboot,      <-2500
       jmp      xdboot,     <-3500
k  for 40
       dat      1-k,        4+k
   rof
dboot  mul.ab   store,      #20       ;set the bootpointer
       add.ab   #bptr1,     -1        ;with the gameclock
   for 7
       mov      {bptr,      <dboot
   rof
       spl      @dboot,     {0
       mov      {bptr,      <dboot
       mov      {bptr,      <dboot
ptr    dat      0,          #1500
       dat      0,          0
wait   djn.b    #0,         #delay    ;wait until the qbomber is
finished
       spl      #0,         >ptr
loop   mov.i    bomb,       >ptr
       djn.f    loop,       >ptr
       dat      0,          0
       dat      0,          0
bomb   dat      >1,         >bomb-ptr+2
bptr   dat      0,          0
k  for 40
       dat      1-k,        4+k
   rof
quickb1
i  for 25
       mov.i    }(begin+4000+(i*10)), }(begin+4245-(i*10))
   rof
       spl      @xdboot,    {0
       jmp      @xdboot,    {0
quickb2
i  for 25
       mov.i    }(begin+4250+(i*10)), }(begin+4495-(i*10))
   rof
       spl      @dboot,     {0
       jmp      @dboot,     {0
k  for 40
       dat      1-k,        4+k
   rof
xdboot mul.ab   store,      #100       ;set the bootpointer
       add.ab   #xbptr1,    -1         ;with the gameclock
   for 7
       mov      {xbptr,     <xdboot
   rof
       spl      @xdboot,    {0
       mov      {xbptr,     <xdboot
       mov      {xbptr,     <xdboot
xptr   dat      0,          #1500
       dat      0,          0
xwait  djn.b    #0,         #delay     ;wait until the qbomber is finished
       spl      #0,         >xptr
xloop  mov.i    xbomb,      >xptr
       djn.f    xloop,      >xptr
       dat      0,          0
       dat      0,          0
xbomb  dat      >1,         >xbomb-xptr+2
xbptr  dat      0,          0
k  for 40
       dat      1-k,        4+k
   rof

end
