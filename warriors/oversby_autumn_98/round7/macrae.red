;redcode-94
;name Last Laugh 2
;author Robert Macrae
;strategy  Quickvamp + Tiny Vamp with Thorough Trap
;strategy   -- Hope that, once I win, I win for good! 
;assert CORESIZE == 8000

; Hmmm... with only 20 minutes to the deadline, I don't have much
; room to get clever. I have moved some code a little in case 
; anyone picks a tuned counter. Shame really -- this strategy can
; be improved enormously. My favourite would be a really heavy 
; defensive Silk-Imp to cover the losses, and something like a 
; washing HSA to follow up the wins... Ho hum.

; If I'm losing, I launch a small vampire. 
; If I'm winning, I try a small quickvamp first.
; Hope I haven't missed a killer strategy...

STEP    equ 1364        ; Sensible mod-4 step? Also 868, 652, 204, 212.
MSTEP   equ 3240        ; Approximately 2/5 way round core, and 2/7
_RESULT equ #0          ;   through bombing pattern...
_BOOT   equ #419
base    equ start+4000

start    
     
i    for 57              ; just in case anyone is searching for the 
        dat     0,0      ; start...
     rof  

i    for 24              ; 168
        nop     start,1      ; 7 is unlikely scan separation...
        nop     start,>1     ;  (of course, who'd scan? Bow tie?)
        nop     start,}1     ; and I don't have a djn trail... 
        nop     start,{1
        nop     start,@1
        nop     start,#1
     rof

vamp    mov     bite, @bite              ; Minimal vampire
        add     split-boot+vamp+4, bite    
        jmp     -2, >-20             
bite    jmp     trap-boot+vamp+4, 0      ; Fang 

; Have to launch fang, sadly, to permute bombing...
        
; Separate by a multiple of 4... Total is 44.
        nop     1,>1
        nop     1,<1
     for 6                
        nop     start,1      
        nop     start,>1
        nop     start,<1
        nop     start,}1
        nop     start,{1
        nop     start,@1
        nop     start,*1
     rof

trap    mov     5, <boot-6    ; Core-clear 
split   spl     #STEP, <-STEP ; Step for vampire
        stp     >0, #1        ; Stores 0 through P-Space
        jmp     trap, 4       ; Will be over-written...
        
   for 4
        dat     <2667, 0 ; Coreclear
   rof         

; Separate by a multiple of 4... Total is 36.
        nop     1,>1
     for 5                
        nop     1,1          ; 7 is unlikely scan separation...
        nop     start,>1     ; Dec if QV gets lucky?
        nop     1,<1
        nop     start,>1
        nop     start,<1
        nop     start,}1
        nop     start,{1
     rof

boot    ldp     _BOOT, #0     ; Calculate boot offset
result  ldp     _RESULT, #0 
        jmn.b   quickv, result ; If I lost, drop quickvamp.

launch
        seq.b   result, #1     ; If I won, don't nudge vampire.
nudge    add.ab  #MSTEP, boot
        mov.ba  boot, store
store   stp     #0, _BOOT      ; complete book-keeping.
        sub.ba  boot,   vamp+1 ; Correct pointer to step
        sub.ba  boot,   bite   ; Correct fang

        mov     bite,   <boot  ; Copy vampire 
        mov     bite-1, <boot
        mov     bite-2, <boot
        mov     bite-3, <boot
        add.b   boot,   trap   ; Correct coreclear start
        jmp     @boot, {base+500 ; and Go! 
     
qf
        nop     @1, @1
        jmp     trap-base-72  , base+72    
        jmp     trap-base-33  , base+33
        jmp     trap-base-52  , base+52
        jmp     trap-base-94  , base+94
        jmp     trap-base-122 , base+122
        jmp     trap-base-258 , base+258
        jmp     trap-base-211 , base+211
        jmp     trap-base-284 , base+284
        jmp     trap-base-367 , base+367
        jmp     trap-base-308 , base+308
        jmp     trap-base-175 , base+175
        jmp     trap-base-425 , base+425
        jmp     trap-base-146 , base+146
        jmp     trap-base-492 , base+492
        jmp     trap-base-239 , base+239

quickv
count   for 15    
          mov.i   qf+count, @qf+count   
        rof                              
        jmp     launch, {base+3

     for 20
        nop     start,1      
        nop     start,>1
        nop     start,<1
        nop     start,}1
        nop     start,{1
        nop     start,@1
        nop     start,*1
     rof

        end     boot

