;redcode
;name viralOS
;author Brian Haskin
;strategy Not many will shoot at the real thing. I hope.
;strategy cmp scanner + OS

org virus

version equ 2,0

STEP equ 218
DIST equ 96
FIRST equ 100

virus   spl start
	spl code
	mov 2,>1
	jmp -1,#-3      ;leave as little code behind as possible

for 10
	dat 0,0
rof

code    add inc,1               ;make a scanner that will kill
scan    cmp.f FIRST,FIRST+DIST  ;everything but the real os, hopefully.
	slt #toe+DIST+1,scan
	jmp code
	seq @scan,wait
	mov bomb,@scan
	sne *scan,wait
	jmp dbl
	mov bomb,*scan
	jmp code
for 7
	dat 0,0
rof

dbl     mov.a scan,chk  		;must be 17 instructions between scan
chk     seq 10,wait+17  		;and chk for number to end up right
	mov bomb,*scan	;this saved one add instruction
	jmp code
bomb    dat 0,0
for 10
	dat 0,0
rof

inc     dat STEP,STEP

for 13
	dat 0,0
rof

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
	mov     clean,inpu
	jmp     wait                    ; goto wait

cold    stp     #0,#1                   ; clean error count
	mov     clean,input
	jmp     wait

run     spl     *input
	mov     clean,input
	jmp     wait

fix     dat     CORESIZE,CORESIZE-toe+head      ;CORESIZE, CORESIZE-OS
clean   dat     0,
toe     dat     1,1
	end
