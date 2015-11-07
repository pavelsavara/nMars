;redcode-94nop
;name optima finder #1
;author M Joonas Pihlaja
;strategy show off subroutines in redcode
;assert CORESIZE>=50 && MAXCYCLES>=CORESIZE*100

load0 z for 0
        rof

sp rsp  dat     -1,0                    ; sp: data stack pointer
                                        ; rsp: return stack pointer

ip      jmp     >0,     go+1            ; instruction pointer

; macro to execute next instruction in a threaded subroutine.
NEXT    equ     jmp     >ip

; macro to exit from a subroutine.
EXIT    equ     mov.b   >rsp, ip
        equ     NEXT

; runtime code for saving ip to stack and for tail recursive calls.
; used like:  jmp  enter, SUBR-ip
; and:        jmp  tail, SUBR-ip
enter:  mov.b   ip,     <rsp
tail:   mov.b   <ip,    ip
        NEXT

;--------------------------------------------------------------------------
udivmodcore:                            ; N -- CORESIZE%N CORESIZE/N
r       mov.ba  #0,     #-1
        mod.a   *sp,    r
q       mov.ba  #0,     #-1
        div.a   *sp,    q

        add.a   #1,     r
        mod.a   }sp,    r
        jmn.a   2,      r
        add.a   #1,     q

        mov.a   r,      {sp
        mov.a   q,      {sp
        NEXT                            ; CORESIZE/N CORESIZE%N


;--------------------------------------------------------------------------
udivmod:                                ; a b -- a%b a/b
b       mov.ab  }sp,    #0
a       mov.ab  *sp,    #0
        mod.ba  b,      *sp
        mov.ba  a,      {sp
        div.ba  b,      *sp
        NEXT

;--------------------------------------------------------------------------
optimality:                             ; N -- O(N,CORESIZE) gcd(CORESIZE,N)
        mov.ab  #loop-ip, ip
        mov.a   *sp,    nm
sum     mov.ba  #0,     #0
        jmp     udivmodcore

loop    add.a   }sp,    sum
        mov.ab  }sp,    nm
nm      mov.x   #0,     #0
        jmz.a   done,   nm
        mov.ba  nm,     {sp
        mov.a   nm,     {sp
        jmp     udivmod, <ip

done    mov.a   sum,    {sp
        mov.ba  nm,     {sp
        EXIT

;--------------------------------------------------------------------------
M       equ     1                       ; desired mod

start:
step    mov.a   #2,     *sp
go      jmp     enter,  optimality-ip

        sne.ab  }sp,    #M
        slt.ab  *sp,    best
        jmp     cont

        mov.ab  *sp,    best
        mov.a   step,   best
cont    nop     <ip,    }step
        djn     start,  #-3

best    dat     #0,     #-1             ; a-field contains the smallest
                                        ; mod-M optima number on exit.

end     start


