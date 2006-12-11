;contact <bremermr@ecn.purdue.edu>
;nsfcwt round 4
;redcode-94
;name   bubble gum
;author M R Bremer
;strategy       pray for ordered data.
;strategy       hopefully small, hopefully not TOO slow.
;strategy       my quicksort-->bubble speedup is in the shop.
;strategy       please, please, please, please don't break my sorter

org start

PTRSAVE EQU -1
ENDER EQU -2   
ADDER EQU -3
STORAGE EQU -4

ptr     dat 4001-1, 4002-1
start   jmz.b stock, ptr+4000           ;stock is ascending order
modify  mov.x ptr, ptr                  ;change to descending order
stock   seq.i >count, ENDER+ptr         ;parse:  how many elements to sort
        djn.f -1, ADDER+ptr 
        sub.f ADDER+ptr, ptr    ;points ptr to (quasi)bottom of list
        mov ptr, PTRSAVE+ptr  
        mul.a #-1, ADDER+ptr  
        add.ab ADDER+ptr, j3
        add.ab ADDER+ptr, j2
pass    add.ab ADDER+ptr, j
sortb   slt.b {ptr, <ptr
count   jmp maybe, ptr+4001     ;possible switch / bvalue used for parse
j       djn.b sortb, #-1
        sne.a #1, ADDER+ptr     ;are we done yet?
flag    jmp out, 0          ;b value is flag, set when switch is made
        jmz.b out, flag
        mov.ab #0, flag         ;reset early exit flag
        mov.i PTRSAVE+ptr, ptr      ;restore pointer to bottom of list
        jmp pass, {ADDER+ptr    ; { b-cuz don't need to go up as far
maybe   seq.b *ptr, @ptr        ;check for equal b fields
        jmp switch              ;doesn't matter switch anyways
sorta   slt.a @ptr, *ptr        ;b fields are equal, switch depends on a
        jmp j
switch  mov @ptr, STORAGE+ptr
        mov *ptr, @ptr
        mov STORAGE+ptr, *ptr
        jmp j, >flag            ;there were switches this pass

erase   sne.i @sortb, ENDER+ptr
        jmp j2
        sne.ab #3990, pass
        jmp dec
        sne.i @pass, @sortb
        mov.i ENDER+ptr, @pass  ;wipe the double out!
dec     nop <pass, 0    
        sne.f @pass, @sortb
        jmp erase
clean   mov.b sortb, pass
        jmp j2

out     jmz.a ENDER+ptr, 4000+ptr        ;kill self if no deletions
        mov.b count, pass       ;set up pointers--pass is runner
        mov.b count, sortb      ;set up pointers--sortb is anchor
check   sne.f <pass, <sortb     
        jmp erase       
j2      djn.b check, #-1            ;need to set up this value

        mov.ba pass, pass
degap   seq.i *pass, ENDER+ptr 
close   mov.i *pass, >pass
        nop }pass
j3      djn.b degap, #0
        mov.i ENDER+ptr, >pass
