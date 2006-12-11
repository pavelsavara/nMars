;redcode-94
;name endpoint .
;kill endpoint .
;author M R Bremer
;contact <bremermr@ecn.purdue.edu>
;NSFCWT Round 1
;strategy Very basic p-test. Remember, this is only a test.

step1    equ 11
step2    equ 12
step     equ (step1+step2)

         dat    #gate-10,clr-gate+5    ; just in case clr is decremented
gate     dat    #gate-10,scan-(3*step2)-5
wipe4    dat    #gate-10,<2667
wipe3    dat    #gate-10,clr-gate+5
wipe2    spl    #4000   ,clr-gate+5    ; redundant wipers
wipe1    spl    #5000   ,clr-gate+5
     for 4
         dat    0,0
     rof
bomb     dat    -step,-step
         dat    0,0
next     add    inc,@2            ; scanner bombs two and scans two locations
         mov    bomb,@scan        ; in a five-instruction loop
         mov    bomb,*scan
scan     sne.x  *150-step1-step2,*150-step1
         djn    next,#7900/(2*step)
         add.f  scan,gate         ; position for wiping
inc      spl    #2*step,#2*step
clr      mov    @1,>gate
         djn.b  clr,{wipe1        ; self-decrementing pointer

for 25
        dat 0, 0
rof
start   ldp #0, #0
        ldp #1, #0
        cmp.b -2, -1
        jmp bomber, {4000
        stp #1, #1
        jmp start2, {4000
bomber  stp #0, #1
        jmp next+1, {3000
for 14
        dat 0, 0
rof

ptr     EQU -1333

gate2   dat <-445, <-446
s       spl #445, <-445
        spl #0, <-446
        mov {445-1, -445+2
        add -3, -1
        djn.f -2, <-2667-500
        mov 33, <-20
go      dat #0, #ptr
start2  mov {-1, <-1
        mov {-2, <-2
        mov {-3, <-3
        mov {-4, <-4
        mov {-5, <-5
        mov {-6, <-6
        mov gate2, ptr+24 
        mov gate2, ptr+24
        spl @go, <-4000
        jmp boot, <-4013
for 5
        dat #0, #0
rof

imp_sz  equ     2667

boot    spl     1      ,#0
        spl     1      ,#0
        spl     <0     ,#vector+1
        djn.a   @vector,#0

imp     mov.i   #0,imp_sz

        jmp     imp+imp_sz*7,imp+imp_sz*6   
        jmp     imp+imp_sz*5,imp+imp_sz*4   
        jmp     imp+imp_sz*3,imp+imp_sz*2   
vector  jmp     imp+imp_sz  ,imp

end start
