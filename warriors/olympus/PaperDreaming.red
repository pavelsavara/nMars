;redcode-94 quiet
;name Paper Dreaming
;kill Paper Dreaming
;author P.Kline
;strategy paper experiments
;macro

len     equ 16
incr    equ 4320                ; high-mod separation
dec1    equ 5334
dec2    equ 2667
step    equ 13
     for 10
        dat   #1,1              ; decoy to tie Agony up during startup
        dat   1,#1
     rof
     for 45
        dat   0,0
     rof
start   spl 1,>100
        spl 1,>200
        spl 1,>300
        spl 1,>400              ; create 16 processes
        mov   <1,{1
        spl   s1+3040-320+len,s1+len
        
s1      spl   incr,0
sd      mov   >s1,}s1
        spl   s1,<s1
        mov   sc,   >s1-(2*incr)-(15*step)-14       ; here is where we bomb
        add   #step, s1-(2*incr)-(15*step)-14+incr  ; increment son's bombing
        mov   sb,>s1-(2*incr)-dec2                  ; more bombing
        dat   >s1-(2*incr)-dec2+incr,>s1-(2*incr)-dec2+incr ; triple-incr above
sb      dat   <dec1,<dec2
        dat   0,0
        dat   0,0               ; 3-spacer helps against Taking Names
        dat   0,0
sc      dat   1,1               ; all these dat 1,1's throw Torch's timing off
        dat   1,1
        dat   1,1
        dat   1,1
        dat   1,1
        end start
