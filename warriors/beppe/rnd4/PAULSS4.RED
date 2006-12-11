;redcode-94
;name Reclaiming
;author Magnus Paulsson
;assert 1
; I'm convinced that Beppe changed my warrior before the Round 3
; fight, I couldn't have made such a bad one, or?
; Another boring imp warrior.
; theMystery with constants from NightTrain :-)
; That means I took out the bombing lines in NightTrain.
; And but in a Impfinity launcher in it, just in case
; I don't have enough imps :-)
; I thought about trying to catch the Tornado+Torch processes
; by some fast qscan and then using them to kill of everything
; in a 3c coreclear. But then again on the multiwarior hill
; you just have to stay alive longer than the next guy to win.

D0      EQU     745
D1      EQU     5185
OFFSET  EQU     500
INUM    EQU     2667
istep   EQU     INUM

        ORG     first

first   spl     second
        spl     1,      <-2000
        mov     -1,     0
        mov     -1,     0
m1      mov     {ptr1,  <ptr1
m2      mov     {ptr2,  <ptr2
s1      spl     go3,    <-4000  
s2      spl     go2,    <-5000
go1     jmp     @ptr1
go2     jmp     @ptr2   
go3     mov     {ptr3,  <ptr3
        jmp     @ptr3

ptr1    dat     last1+1,last1+1+OFFSET+INUM*0
ptr2    dat     last1+1,last1+1+OFFSET+INUM*1
ptr3    dat     last2+1,last1+1+OFFSET+INUM*2

is11    spl     D0,     0
im11    mov     >is11,  }is11
im12    mov     <is11,  <is12
is12    spl     @0,     }-D1
last1
imp1    mov.i   #istep,*0

is21    spl     D0,     0
im21    mov     >is21,  }is21
im22    mov     <is21,  <is22
is22    spl     @0,     }-D1            
last2
imp2    mov.i   #istep, *0

for 20
        dat.f   0,0
rof


point   equ     (instr)

second  djn.a   #6,#0
pump    spl     #1, >prime
ptr     spl     instr-istep-1, {335+i
        add.f   #istep+1, ptr
prime   mov.i   point, point-2
        dat.f   0,0
pend
        
instr   mov.i   #-2, istep
end

