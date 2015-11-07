From: 	Paul-V Khuong
Sent: 	18 December 1998 20:28
To: 	ian@i-next.com
Subject: 	tournament

here:

;redcode
;assert 1
;author PVK
;name My Grey Warrior
        org     start

len     EQU 9
fcp     EQU 3039
scp     EQU 2365
tcp     EQU 777



boot    spl     1,      >-3000    ; 7 processes replace 	spl	1,	<-3200
   ; for cost of extra 
	mov	-1,	0

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
               
                for     27
                dat.f   0,0
                rof

start           mov.i   <cbmb+1,  {bptr
                for     5
                mov.i   <cbmb+1,  {bptr
                rof
bptr            spl     cbmb+1+4000
                spl     boot
                spl     boot2
carbon          spl     #0,     #0
		spl	#0,	<-1151+3
		mov	197,	cad-(197*3500)
cad		add.ab	{0,	}0
		djn.f	-2,	<-1151
cbmb		dat	>-1,	>1

                for     27
                dat.f   0,0
                rof

dest1   equ     1400    ; For Pulp v0.2
dest2   equ     5460
dest3   equ     725
pos1    equ     930     
pos2    equ     3359
pos3    equ     1009    ; clear old copies

boot2   SPL.B   1,      <-300
        MOV.I   -1,     0
        MOV.I   -1,     0
        SPL.B   1,      {-300

silk    SPL.B   @0,     >dest1
        MOV.I   }-1,    >-1
        MOV.I   bomb,   >pos1
silk2   SPL.B   @0,     >dest2
        MOV.I   }-1,    >-1
        MOV.I   bomb,   >pos2   ; linear bombing
        MOV.I   bomb,   }pos3   ; anti-vamp
        MOV.I   {silk2, <silk3
silk3   SPL.B   @0,     >dest3
bomb    DAT.F   <2667,  <5334


cs	spl.b	#0,		<-700
	spl.b	imp+5334,	<1
	spl.b	imp+2667,	<-1000
imp	mov.i	#2667,	*0
end







==
Vive le Québec libre... dé souverainistes!!!

_________________________________________________________
DO YOU YAHOO!?
Get your free @yahoo.com address at http://mail.yahoo.com

