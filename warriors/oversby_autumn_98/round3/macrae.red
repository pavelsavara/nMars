;redcode-94 test
;author Robert Macrae
;name Hexagram
;assert CORESIZE==8000
;strategy Two-shot with SSSD clear

; Hexagram combines two 0.8c oneshots in a rather pretty 6-point
; scan to minimise triggering by the imp. When one strikes, it starts
; a single-process clear and the other continues scanning. Eventually
; I spawn multiple process to get draws if over-run.
; Strength -- fast stun of paper, assuming decoy is no problem.
; Weakness -- single clear so vulnerable to bomber.
;          -- only 5% better than Seven11; disappointing.

STEP    equ     10
BSTEP   equ     2667+(STEP-1)/3

gate    dat    0,        100  
        dat    #gate-1500, repeat-gate+3
sweep1  spl    #gate-10, repeat-gate+3
clear   mov.i  @repeat,  >gate
        mov.i  @repeat,  >gate
        mov.i  @repeat,  >gate
repeat  djn.b  clear,    {sweep1
        jmp    sweep1,   <gate

      for 3
        dat    0,        0          
      rof

ptr2    dat    100+(2667/2), 100+(STEP/2)+(2667/2)  
ptr     dat    100,      100+(STEP/2)       ; scans 5 apart
step    dat    #BSTEP,   #BSTEP    ; three trails, vs imps.
loop    add.f  step,     ptr        
        sne.i  *ptr,     @ptr
        add.f  step,     ptr        
        sne.i  *ptr,     @ptr
check   djn.b  loop,     #175
        mov.b  ptr,      gate
        jmp    clear 

step2   dat    #BSTEP,   #BSTEP    ; three more.
loop2   add.f  step2,    ptr2        
        sne.i  *ptr2,    @ptr2
        add.f  step2,    ptr2        
        sne.i  *ptr2,    @ptr2
check2  djn.b  loop2,    #175
        mov.b  ptr2,     gate
        jmp    clear 

play    spl    loop
        jmp    loop2

        end    play
