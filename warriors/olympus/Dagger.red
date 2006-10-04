;--------------------------------------------------------------
; Dagger - stabbing version of Invader
; 3-28-91 Stefan Strack
;
; Probes the core randomly for an executable address, copies
; itself some distance before the enemy program and kills it
; with a stab in the back.
; [uses non-standard opcodes RND, EXC; and pre-increment]
;--------------------------------------------------------------

        equ     exclude                 20
        equ     back                    50
        equ     bombstart               30
        equ     bombnumber              20

bcounter:dat 0
source: dat 0

rem ----------- extend dagger ---------------------------------
first:
        mov     #bombnumber             bcounter
        mov     #bombstart              baddr
bomb:   mov     bcounter                >baddr
        djn     bomb                    bcounter

rem ----------- search for victim -----------------------------
probe:
        rnd     #ADDRESS_SPACE-exclude  destin  ; generate random address
        exc     found                   @destin ; if executable leave loop
        jmp     probe                           ; else continue random
found:
        mov     #last-first+1           source  ; copy program
        sub     #back                   destin
copy:   mov     @source                 <destin
        djn     copy                    source
        spl     @destin                         ; and spawn subprocess
last:   jmp     first                           ; go extend dagger again

destin: dat     0
baddr:  dat     0
        end     probe
