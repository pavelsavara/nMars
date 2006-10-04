;redcode
;assert 8000
;name Loh_tst_1.3
;author Calvin Loh
;strategy p-space switcher between imp spiral, scanner, paper and bomber

;some constants
RSLT    equ     0
STRTG   equ     1
IS      equ     #0
B       equ     #1
P       equ     #2
SC      equ     #3

;loading p-space values into core
res     ldp.ab  RSLT,   #0
str     ldp.ab  STRTG,  #0

;deciding which strategy to use
eval    sne.ab  #0,     res
        jmp     lost
switch  sne.ab  IS,     str
        jmp     imp
        sne.ab  B,      str
        jmp     bomber
        sne.ab  P,      str
        jmp     paper
        jmp     scan_b

lost    add.ab  #1,     str
        mod.ab  #4,     str
        stp.ba  str,    STRTG
        jmp     switch

;imp spiral
STEP    equ     3077
TSTEP   equ     2667
CSTEP   equ     1143
NSTEP   equ     5091
RANGE   equ     2353
imp     mov     imp,    imp + STEP
        spl     1
        mov     -1,     0
        mov     -1,     0
        spl     1
        spl     1
        mov     -1,     0
launch  spl     2
        jmp     @0,     imp
        add.ab  #STEP,  -1
tim2    spl     @tim2, }TSTEP
tim2a   mov.i   }tim2,  >tim2
cel2    spl     @cel2,  }CSTEP  ;these four lines are the main body
cel2a   mov.i   }cel2,  >cel2
        mov.x   <-RANGE,>RANGE  ;here you can insert some bombing line
ncl2a   mov.i   {cel2,  <ncl2
ncl2    jmp     @ncl2,  >NSTEP

;bomber
bomber  mov     bomb,   4000
        mov     toss,   4000
        mov     toss+1, 4000
        mov     toss+2, 4000
        mov     toss+3, 4000
        jmp     @-1
bomb    dat     #100,   #1
toss    spl     0,      0
        mov     bomb,   {bomb
        mul.a   #3,     bomb
        jmp     toss

;paper
STEP1   equ     2667
STEP2   equ     1143
STEP3   equ     5091

paper   spl     1
        mov     -1,     0
        spl     1
        mov     -1,     0
;generate 12 parallel processes

silk    spl     @silk,  }STEP1
        mov.i   }silk,  >silk
slk1    spl     @slk1,  }STEP2  ;these four lines are the main body
        mov.i   }slk1,  >slk1
        mov     boom,   }boom   ;here you can insert some bombing line
        mov.i   {slk1,  <slk2
slk2    spl     @0,     >STEP3
banzai  spl     2,      100
        mov     boom,   <banzai
        mul.ab  #3,     banzai
boom    dat     #100,   #1

;scanner
;boot routine
plus    dat     #1,     #1
scan_b  mov.i   step,   4000
        add.f   plus,   scan_b
        djn     scan_b, #17
        jmp     4001

step    dat     20,     20

;stun bomb
fire    spl     0,      0
stun    jmp     -10

;start of scanner
begin   add.f   step,   scan
scan    cmp.i   100,    110
        jmp     s_bomb
        djn     begin,  #385

;core clear routine
clear   mov.i   soap,   }soap
        djn     clear,  #7995
gate    spl     0,      <-10    ;warrior degenerates into an impgate
soap    dat     #1,     #1

;bombing routine
s_bomb  mov.i   fire,   }scan
        seq.ab  scan,   scan
        jmp     s_bomb
        mov.i   stun,   *scan
        sub.a   #10,    scan
        jmp     begin

        end     res
