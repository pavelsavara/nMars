;redcode-b
;name   Clear Sighted v1
;author JS Pulido
;strategy  Qscan -> MultiPass Cclear
;assert CORESIZE==8000
;kill TEST

stepA       EQU     ****    
stepB       EQU     ***
stepC       EQU     **
LA          EQU     *
LB          EQU     *
sep         EQU     5
exeins      EQU     (clr-ptr)+sep+1
fin         EQU     (last+1)

start
A   FOR     LA

    B   FOR     LB
        sne.i bp+(stepA*A)+(stepB*B)-(stepC*2),bp+(stepA*A)+(stepB*B)-(stepC)
        seq.i bp+(stepA*A)+(stepB*B)+(stepC*2),bp+(stepA*A)+(stepB*B)+(stepC)
        mov.ab  #bp+(stepA*A)+(stepB*B),    bp
        ROF

        jmn.b   boot,       bp

    ROF

bp
default     mov.ab  #*****, bp

boot        mov.i   {ptr,           <bp
            jmn.a   boot,           ptr

            sub.ab  #(sep+1),       bp
            mov.i   gate,           @bp
            add.ab  #exeins,        bp
            spl     @bp
            mov.i   1,              bp
gate        dat     #fin+sep,       #ptr+sep
ptr         dat     #last+1,        #bomb1
bomb2       dat     #fin-gate+sep,  #ptr-gate+1+sep
bomb1       spl     #fin-gate+sep,  #ptr-gate+1+sep
            mov.ab  #bomb1-ptr,     ptr
clr         mov.i   @ptr,           }gate-sep
            djn.b   clr,            <gate-sep
last        jmp     -3,             >gate-sep

    FOR     (MAXLENGTH-CURLINE)
            dat     #1,             #1
    ROF
    end start
