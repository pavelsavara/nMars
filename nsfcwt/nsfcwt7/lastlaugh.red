Return-Path: <ff95@dial.pipex.com>
Received: from vent.pipex.net ([158.43.128.5]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA08575; Sat, 2 Dec 95 07:18:30 CST
Received:  from unknown by vent.pipex.net (8.6.12/PIPEX simple 1.20)
	id NAA06850; Sat, 2 Dec 1995 13:26:33 GMT
Message-Id: <199512021326.NAA06850@vent.pipex.net>
Resent-Message-Id: <MAPI.Id.0016.00663935202020203532444330303030@MAPI.to.RFC822>
Priority: Normal
To: Stefan Strack <stst@idnsun.gpct.Vanderbilt.Edu>, Me! <ff95@dial.pipex.com>
Resent-To: Stefan Strack <stst@idnsun.gpct.Vanderbilt.Edu>,
        Me! <ff95@dial.pipex.com>
Mime-Version: 1.0
From: Robert Macrae <ff95@dial.pipex.com>
Resent-From: Robert Macrae <ff95@dial.pipex.com>
Subject: Round 7, late as usual
Date: Sat, 02 Dec 95 13:24:32 GMT
Resent-Date: Sat, 02 Dec 95 13:25:23 GMT
Content-Type: text/plain; charset=US-ASCII; X-MAPIextension=".TXT"
Content-Transfer-Encoding: 7bit
Status: R

;redcode-94
;name Last Laugh
;author Robert Macrae
;strategy  Quickvamp + Tiny Vamp with Thorough Trap
;strategy   -- Hope that, once I win, I win for good! 
;assert CORESIZE == 8000

; Very tricky round, because the situation is so knife-edged and 
; unfamiliar. There should be a huge disparity in scores... :-|

; If I'm losing, I launch a small vampire. 
; If I'm winning, I try a small quickvamp first.
; Hope I haven't missed a killer strategy...

STEP    equ 1364        ; Sensible mod-4 step? Also 868, 652, 204, 212.
MSTEP   equ 3240        ; Approximately 2/5 way round core, and 2/7
_RESULT equ #0          ;   through bombing pattern...
_BOOT   equ #419
base    equ start+4000

start    
i    for 24              ; 168
	nop     1,1      ; 7 is unlikely scan separation...
	nop     1,>1     ;  (of course, who'd scan? Bow tie?)
	nop     1,<1
	nop     1,}1     ; and I don't have a djn trail... 
	nop     1,{1
	nop     1,@1
	nop     1,*1
     rof

vamp    mov     bite, @bite              ; Minimal vampire
	add     split-boot+vamp+4, bite    
	jmp     -2, >-20             
bite    jmp     trap-boot+vamp+4, 0      ; Fang 

; Have to launch fang, sadly, to permute bombing...
	
; Separate by a multiple of 4... Total is 44.
	nop     1,>1
	nop     1,<1
     for 6                
	nop     1,1      
	nop     1,>1
	nop     1,<1
	nop     1,}1
	nop     1,{1
	nop     1,@1
	nop     1,*1
     rof

trap    mov     5, <boot-6    ; Core-clear 
split   spl     #STEP, <-STEP ; Step for vampire
	stp     >0, #1        ; Stores 0 through P-Space
	jmp     trap, 4       ; Will be over-written...
	
   for 4
	dat     <2667, 0 ; Coreclear
   rof         

; Separate by a multiple of 4... Total is 36.
	nop     1,>1
     for 5                
	nop     1,1      ; 7 is unlikely scan separation...
	nop     1,>1     ; Dec if QV gets lucky?
	nop     1,<1
	nop     1,}1
	nop     1,{1
	nop     1,@1
	nop     1,*1
     rof

boot    ldp     _BOOT, #0     ; Calculate boot offset
result  ldp     _RESULT, #0 
	jmn.b   quickv, result ; If I lost, drop quickvamp.

launch
	seq.b   result, #1     ; If I won, don't nudge vampire.
nudge    add.ab  #MSTEP, boot
	mov.ba  boot, store
store   stp     #0, _BOOT      ; complete book-keeping.
	sub.ba  boot,   vamp+1 ; Correct pointer to step
	sub.ba  boot,   bite   ; Correct fang

	mov     bite,   <boot  ; Copy vampire 
	mov     bite-1, <boot
	mov     bite-2, <boot
	mov     bite-3, <boot
	add.b   boot,   trap   ; Correct coreclear start
	jmp     @boot, {base+500 ; and Go! 
     
qf
	nop     @1, @1
	jmp     trap-base-193 , base+193    
	jmp     trap-base-308 , base+308
	jmp     trap-base-262 , base+262
	jmp     trap-base-384 , base+384
	jmp     trap-base-217 , base+217
	jmp     trap-base-336 , base+336
	jmp     trap-base-242 , base+242
	jmp     trap-base-284 , base+284
	jmp     trap-base-367 , base+367
	jmp     trap-base-404 , base+404
	jmp     trap-base-119 , base+119
	jmp     trap-base-425 , base+425
	jmp     trap-base-146 , base+146
	jmp     trap-base-92  , base+92
	jmp     trap-base-169 , base+169

quickv
count   for 15    
	  mov.i   qf+count, @qf+count   ; Hitting two small targets 
	rof                             ; harder than one big one.
	jmp     launch, {base+3

     for 26
	nop     1,1       
	nop     1,>1
	nop     1,<1
	nop     1,}1
	nop     1,{1
	nop     1,@1
	nop     1,*1
     rof

	end     boot





Regards,  Robert Macrae


