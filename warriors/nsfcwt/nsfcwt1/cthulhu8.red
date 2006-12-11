;contact jwilkinson@mail.utexas.edu
;NSFCWT Round 1
;redcode-94
;name Cthulhu v8
;kill Cthulhu v6c
;author John K. Wilkinson
;strategy I don't think I'm sending this in time...
;strategy Ah well, if it's too late, then I'll cry later... :)
;assert CORESIZE == 8000

PIN 9999     ;altered

i       equ imp+100
NUM_STR equ #2
BOB     equ -250  ;altered
CTHUCODE equ #3345
_RESULT equ #0
_BROTHER equ #999    ;altered
_LOSS   equ #222
_STR    equ #333
BOUND   equ #800
CDIST   equ 12
IVAL    equ 42
FIRST   equ scan+OFFSET+IVAL
OFFSET  equ (2*IVAL)
DJNOFF  equ -431
BOMBLEN equ CDIST+2
GATE    equ tie-4000
stinc   equ 190
T       equ res+5500
step    equ 52
count   equ 665

S        equ -500
d        equ 1143

org start

            nop stone, S         
cannonboot: mov }-1, >-1
            jmp S

stone    mov   <stspl+5+(stinc*800),stspl
stspl    spl   -1,<2
stadd    add   3,stone
         djn   -2,<5141+1
         dat   0, 0
inc      mov   stinc,<-stinc

start:   stp    CTHUCODE, _BROTHER
         ldp    _BROTHER, #0
         cmp.ab -2, -1
         dat 0,  0

res:  ldp _RESULT,  #0      ;load last result into B-field
loss: ldp   _LOSS,  #0
      jmz goloss,   res          ;a zero indicates a loss in the last round

      djn tie,res

win:     add    #-1,    loss
         stp.b  loss,   _LOSS
go:      ldp    _STR,   #0

         slt    BOUND-80, loss  ;check for illegal _LOSS record
         stp    BOUND,    _LOSS

         mod.ab NUM_STR,   go    ; in case _STR ever gets screwed up
         mov.ba go,      case
gojmp:   jmp    case             ;after this gojmp, we jump again from case

tie:     add    #-1,    loss
goloss:  add    #1,     loss
         slt    loss,   BOUND+11  ;if we've lost too much
         jmp    switch

         slt    BOUND-80, loss  ;check for illegal _LOSS record
         jmp    switch

         stp.b  loss,   _LOSS
         jmp    go

switch:  ldp    _STR,   #0
         add    #1,     -1
         slt    -2,     NUM_STR
         mov    #0,     switch
         stp    BOUND,  _LOSS
         stp.b  switch, _STR
         add.ba switch, case

case:    jmp    @0,     sandboot  ;3
         jmp    @0,     cdie      ;3
         
sptr:     nop   sand,   S
sandboot: mov   }sptr,  >sptr
          mov   }sptr,  >sptr
          mov   }sptr,  >sptr
          mov   }sptr,  >sptr
          mov   }sptr,  >sptr
          djn   sandboot, #4
          jmp   S-7

cdie: 
spl 1
spl 1
mov -1, 0
spl cannonboot
spl 1
spl 1

cotton: spl   d+09, 0
        mov.i >-1,  }-1
        spl   2
        jmp   3
        add.a #d,   -1
        jmp   -3
        mov.i #20,  d

for 10
mov.i #20,   d
rof

;*** SandBlast!
sand    mov     bombd,  *sstone
        mov     bombd,  @sstone
sstone  mov     *(1*step)+1, *(2*step)+1
        add     incr,   sstone
jump    djn.b   sand,   #count           ;count equ 665
        jmp     clr
        dat 0, 0
        dat 0, 0

clr:    spl #0, #0
        mov     @ptr,     }sstone ;art-1
        djn.b   -1,    <BOB

dat 0, 0
dat <20, 0
dat <20, 0
ptr: spl #20, {0
dat 0, 0
dat 0, 0
dat 0, 0

incr    dat     3*step, 3*step
bombd   dat     #step,  {8         ;hit dat
