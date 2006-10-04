;redcode-94 quiet
;name Taking Names
;kill Taking Names
;author P.Kline
;strategy sne.x/seq.x scanner using spl-spl-jmp bomb
;strategy and continuous forward-clear

step    equ    98
clrptr  dat    jump+2
        dat    0,0
reset   dat    #step-2,#step
    for 19
        dat    0,0
    rof
    
attack  mov    jump,*comp           ; drop wide bomb on a-pointer
compptr mov    split,{comp
        mov    split,{comp          ; after bombing, reset to
        sub    reset,@compptr       ; make b-pointer the next a-pointer
        
scan    add    split,@compptr
comp    sne    2*step,3*step        ; take a look
        add    split,@compptr
        seq    *comp,@comp          ; take another look
        slt    #100+step,@compptr   ; don't attack self
ctr     djn    scan,#1000           ; countdown to finish
        jmn    attack,-1

split   spl.i  #(2*step),#(2*step)
clear   mov    reset,>clrptr        ; continuous forward clear
jump    jmp    -1
    for 30
        dat    0,0
    rof
    for 12
        dat    #1,1                 ; simple decoy
        mov.i  #attack+1000,2667
    rof
        end    comp
