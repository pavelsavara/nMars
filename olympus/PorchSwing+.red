;redcode-94x
;name Porch Swing +
;kill Porch Swing
;Author Randy Graham
;assert 1
;strategy Original Porch Swing (80% bomb/scan w/multi-pass clear)
;strategy with some tweaking, optimizations and slightly changed clear
;strategy + use decoy, longer run (almost 2000 bomb/scans) before clear

MOVETO  equ    (decoy+1795)

decoy   dat.f  0,         0
move1   mov.i  }first,    >first
        mov.i  }first,    >first
        mov.i  }first,    >first
        mov.i  }first,    >first
first   mov.i  gate,      MOVETO
filler  mov.i  decoy,     first
move2   mov.i  }second,   >second
for 8
        mov.i  }second,   >second
rof
second  mov.i  adder,     MOVETO+(adder-gate)
start   jmp.a  second+MOVETO+(adder-gate)+1,  0

STEP    equ    12
EXTRA   equ    4
DJNOFF  equ    (-430+EXTRA)

gate    dat.f  #site,     sneer-STEP+1
dat2    dat.f  #2,        step-gate+5+EXTRA
dat1    dat.f  #1,        step-gate+5+EXTRA
site2   spl.a  #2,        step-gate+5+EXTRA
site    spl.a  #3,        step-gate+5+EXTRA
        dat.f  0,         0
        dat.f  0,         0
        dat.f  0,         0
        dat.f  0,         0
adder   sub.f  sweeper,   sneer
hithigh mov.i  step,      *sneer
hitlow  mov.i  step,      @sneer
sneer   sne.i  @gate+STEP*6-1+EXTRA, *gate+STEP*3+EXTRA  ;so we bomb step
looper  djn.b  adder,     <DJNOFF
setup   add.b  sneer,     gate
sweeper spl.a  #-STEP*4+1,<-STEP*4+1
mover   mov.i  *gate,     >gate
swinger djn.f  mover,     {gate-10
step    dat.f  <STEP,     <-STEP     ;36 - last line of real program
garbage dat.f  *1,        @1         ;decoy optimzed to not set me off
        dat.f  #1,        <1         ;til third time through
        dat.f  >1,        }1
        dat.f  #1,        *1   ;40
        dat.f  *1,        >1
        dat.f  @1,        #1
        dat.f  $1,        *1
        dat.f  >1,        {1
        dat.f  *1,        }1
        dat.f  #1,        {1
        dat.f  {1,        *1
        dat.f  {1,        <1
        dat.f  @1,        }1
        dat.f  }1,        >1   ;50
        dat.f  }1,        @1
        dat.f  *1,        >1
        dat.f  {1,        >1
        dat.f  #1,        <1
        dat.f  *1,        $1
        dat.f  $1,        }1
        dat.f  @1,        {1
        dat.f  *1,        >1
        dat.f  {1,        <1
        dat.f  {1,        @1   ;60
        dat.f  $1,        *1
        dat.f  }1,        @1
        dat.f  @1,        <1
        dat.f  <1,        #1
        dat.f  >1,        {1
        dat.f  @1,        $1
        dat.f  }1,        >1
        dat.f  *1,        #1
        dat.f  #1,        @1
        dat.f  }1,        {1   ;70
        dat.f  >1,        }1
        dat.f  #1,        *1
        dat.f  *1,        >1
        dat.f  @1,        #1
        dat.f  $1,        *1
        dat.f  <1,        >1
        dat.f  >1,        {1
        dat.f  *1,        }1
        dat.f  {1,        *1
        dat.f  {1,        <1   ;80
        dat.f  @1,        }1
        dat.f  }1,        >1
        dat.f  #1,        #1
        dat.f  }1,        }1
        dat.f  <1,        {1
        dat.f  {1,        >1
        dat.f  *1,        $1
        dat.f  $1,        }1
        dat.f  @1,        {1
        dat.f  {1,        <1   ;90
        dat.f  {1,        @1
        dat.f  $1,        *1
        dat.f  }1,        @1
        dat.f  @1,        <1
        dat.f  <1,        #1
        dat.f  >1,        {1
        dat.f  @1,        $1
        dat.f  0,         0
        dat.f  $1,        }1

;end     hithigh
end move1
