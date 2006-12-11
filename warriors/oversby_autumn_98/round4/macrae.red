;redcode-94
;name Assugg 
;author Robert Macrae
;strategy Build a core clear
;assert 1

; It would be nice to build a couple of hand-tuned bombers, add an
; imp-killer and space them so that they only lost to the papers...
; but I have simply not got time. Anyway, I liked that clear Joonas
; used last time...

org     bootc

bptr    equ    (clear+3)

gate    mov    3500,     3495
 ;ai      dat    <2667,    <2667*2        ; borrow imp-kill from Sad
  ai      dat 0,0
s2      spl    #bptr-gate, ai-bptr       
s1      spl    #bptr-gate, s2-bptr      ; 2 passes of SPL until bptr dec.
clear   mov.i  @bptr,    }gate
        mov.i  @bptr,    }gate
 ;        djn.f  clear,    <gate          ; borrow from Carbon
          dat 0,0

bootc   mov    gate,     >ptr
        mov    cs-1,     >ptr
       for 4
        mov    }ptr,     >ptr
       rof
        mov    cad+1,    @ptr
        mov.ab #-6,      >ptr
        spl    s1-2000 
        mov.ab #-4,      >ptr

        dat    0, 0

ptr     mov    #s2,       #gate-2000

     for 5
        spl    1,  1
        spl   #1,  1
        spl    1, #1
        spl   @1,  1
        spl    1, @1
        spl   #1, #1
        spl   #1, @1
        spl   @1, #1
        spl   @1, @1
     rof
; ------------------------------------------------------------------
; Code Bank

carbon	spl	#0,	#0
		spl	#0,	<-1151+3
cptr		mov	197,	cad-(197*3500)
cad		add.ab	{0,	}0
		djn.f	-2,	<-1151
init		mov.i	cbmb,	*cptr
		jmp.b	carbon,	>-4000
cbmb		dat	>-1,	>1

len     EQU 9
fcp     EQU 3039
scp     EQU 2365
tcp     EQU 777

boot	  spl	1,	>-3000    ; 7 processes replace 9 in CCPaper
	  spl	1,	<-3200    ; for cost of extra Mov in launcher.
	  mov	-1,	#0

frog    spl	@0,	<fcp-len
        mov	}-1,	>-1
        mov	}-2,	>-2
        spl	@0,	<scp
        mov	}-1,	>-1
        spl	@0,	<tcp
        mov	}-1,	>-1
        mov	2,	<-fcp+len+1   ; Wipe uncle.
        jmp	-1,	<-10
        dat	<2667,	<2667*2

cs	spl.b	#0,		<-700
	spl.b	imp+5334,	<1
	spl.b	imp+2667,	<-1000
imp	mov.i	#2667,		*0

        end


