;redcode-94
;name Mind Reader
;author David Moore
;assert 1
;strategy Launch an imp-paper;
;strategy if paper loses then assume opponent used "He Scans Alone"
;strategy but there is a trick!
;strategy First use a vampire to find his pspace location;
;strategy then switch to an anti-HSA warrior.
;strategy Anti-HSA can brainwash with different numbers until it finds the right one.
;strategy If that number forces my opponent to use HSA
;strategy then continuous brainwash with 100% wins :) Works great against Electric Head!

;;;;;;;;;;;;;;;;;
;               ;
;     paper     ;
;               ;
;;;;;;;;;;;;;;;;;

d1 equ 3359
d2 equ 2365

paper  spl   1, <ploc
       mov.i 1, #0
       spl   1, <kloc

       spl   @0,  d1
       mov  }-1, >-1
       spl   #0,   0
       spl imp+(2*((CORESIZE+1)/3)), 0
       spl imp+((CORESIZE+1)/3), 0
imp    mov.i #(CORESIZE+1)/3, *0

       dat 0,0
       dat 0,0

     for 20
       dat 1,1
     rof

       dat 0,0
       dat 0,0

;;;;;;;;;;;;;;;;;
;               ;
;    vampire    ;
;               ;
;;;;;;;;;;;;;;;;;

Pstore equ 123
step   equ  15   ; multiple of 5

vamp   mov       @0, @fang
       add     incr,  fang
       jmz.a   vamp,  read           ; know when opponent is trapped

       jmz.b     #0,  read           ; search for last nonzero pspace
ploc   stp.ab  read, #Pstore         ; capture the prize!
incr   jmp   #-step, #step           ; wait for the next fight

fang   jmp trap+5-step, step-5

trap   spl     #0,  #0
       spl     #0,  #0
read   ldp.ab  #0,  #0
       dat     {0,   0

     for 10
       dat 0,0
     rof

;;;;;;;;;;;;;;;;;
;;             ;;
;;   P-logic   ;;
;;             ;;
;;;;;;;;;;;;;;;;;

Key    equ 127
Strat  equ 131
 
binc   equ 3359

       dat 0, 0
table  dat 0, CORESIZE/2
       dat 0, 0
       dat 0, 0

main   ldp.a       #0,  table
       ldp.ba   store,  store
       add.ba  *table,  store
store  stp.ab      #0, #Strat
       slt.a #(CORESIZE/2)-1, store
       jmp      paper, <store
       ldp.ab #Pstore,  bwash
       mod.ab #PSPACESIZE, bwash    ; vampire may capture 0th location
       mod.ab #PSPACESIZE-1, bwash  ; vampire may suffer a djn.f attack
       jmz.b     vamp,  bwash       ; enemy pspace unknown; go to vampire
       ldp.a     #Key,  bwash
       djn.a   adjust,  table
       jmp       anti, <store
adjust add.a    #binc,  bwash       ; anti-HSA did not win; change the brainwash
kloc   stp.ab   bwash, #Key
       jmp       anti, <store

       dat 0,0
       dat 0,0
       dat 0,0

;;;;;;;;;;;;;;;;;
;               ;
;   Anti-HSA    ;
;               ;
;;;;;;;;;;;;;;;;;

bwash  stp.ab #1, #1
anti   mov bwash, >bptr
       mov bwash, >bptr
bptr   jmp  anti,  1


end main
