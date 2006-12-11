;redcode-94 quiet
;name blackTN
;kill blackTN
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 2
;assert CORESIZE == 8000
;strategy pair of sne/seq scanners using spl-spl-spl-jmp bombs

step    equ    98

reset1  dat    #step-3,#step
attack1 mov    jump1,*comp1          ; drop wide bomb on a-pointer
cmpptr1 mov    split1,{comp1         ;
        mov    split1,{comp1         ;
        mov    split1,{comp1         ; after bombing, reset to
        sub    reset1,@cmpptr1       ; make b-pointer the next a-pointer
scan1   add    split1,@cmpptr1
comp1   sne    2*step,3*step         ; take a look
        add    split1,@cmpptr1
        seq    *comp1,@comp1         ; take another look
        slt    #start-comp1+step+3,comp1
ctr1    djn    scan1,#2000           ; countdown to finish
        jmn    attack1,ctr1
split1  spl.i  #(2*step),#(2*step)
        mov    reset1,<ctr1          ; clear
jump1   jmp    -1,}1
    for 66
        dat    0,0
    rof
reset2  dat    #step-3,#step
attack2 mov    jump2,*comp2          ; drop wide bomb on a-pointer
cmpptr2 mov    split2,{comp2         ;
        mov    split2,{comp2         ;
        mov    split2,{comp2         ; after bombing, reset to
        sub    reset2,@cmpptr2       ; make b-pointer the next a-pointer
scan2   add    split2,@cmpptr2
comp2   sne    (comp1+4000+4)+2*step,(comp1+4000+4)+3*step     ; take a look
        add    split2,@cmpptr2
        seq    *comp2,@comp2         ; take another look
        slt    #start-comp2+step+3,comp2
ctr2    djn    scan2,#2000           ; countdown to finish
        jmn    attack2,ctr2
split2  spl.i  #(2*step),#(2*step)
        mov    reset2,<ctr2          ; clear
jump2   jmp    -1,}1

start   spl    comp1
        jmp    comp2
        end    start
