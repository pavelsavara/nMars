;redcode-94
;name RedOS
;author jkl


org start

version equ 2,0

head    dat     CORESIZE,CORESIZE-toe   ;CORESIZE, CORESIZE-OS
        dat version
input   dat 0,0

start   ldp     #0,#0                   ; last state request
        sne.b   start,#-1               ; check for start up
        jmp     cold                    ; goto cold_boot
        sne.b   start,#0                ; check for error after hard crash
        jmp     error                   ; goto error
        stp     #1,#1

wait    jmz     0,input                 ; wait for input
        sne     input,#1                ; check for run
        jmp     run                     ;
        sne     input,#2                ; check for user clear
        jmp     clear
        sne     input,#3                ; user cold boot
        jmp     cold
        mov     clean,input
        jmp     error
        jmp     wait                    ; future function go here

error   ldp     #1,#0                   ; load previous error count
        add     #1,error
        stp.b   -2,#1                   ; store error codes
        slt.b   #10,error
        jmp     wait

clear   mov.b   head,2
        mov     clean,>toe              ; clear memory
        djn     -1,#0
        mov.ab  #1,toe
        mov     fix,head                ; bug fix
        mov     clean,input
        jmp     wait                    ; goto wait

cold    stp     #0,#1                   ; clean error count
        mov     clean,input
        jmp     wait

run     spl     *input
        mov     clean,input
        jmp     wait

fix     dat     CORESIZE,CORESIZE-toe+head      ;CORESIZE, CORESIZE-OS
clean   dat     0,0
toe     dat     1,1


;----------end os----------
