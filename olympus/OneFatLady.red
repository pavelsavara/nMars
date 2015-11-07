;redcode-94
;name One Fat Lady
;author Robert Macrae
;strategy QS + 54 process Vamp + 10 process 5 pt Imp.
;assert CORESIZE == 8192

; Warrior based on half of the '88 instructions. It seems very
; hard to kill imps, so I expect a lot of draws. I'll need them...

; QS bombs with DATs because I can't guarantee that the trap will
; suicide. This will work best against other QSs.
; Vampire is launched without a SPL, to make a smaller target.
; Imp is compact (Nimbus?) style.
; Pit is not likely to achieve much, but does occasionally manage
; a coreclear.

; -------------------------------------------------------------

; QS based on my favourite "special tournament version of Sauron"

core    equ     (look+102)

look                    
qscan   for     6  
	  cmp  look+((qscan+2)*100)+3, look+4096+((qscan+2)*100)+3
	  mov     #look+((qscan+2)*100)-point+3, @point
	rof
	
	cmp     #0, point
	 jmp    found

qscan   for     7  
	 cmp  look+((qscan+10)*100)+3,look+4096+((qscan+10)*100)+3
	  mov     #look+((qscan+10)*100)-point+3, @point
	rof
	
	cmp     #0, point
	 jmp    found

qscan   for     8  
	  cmp  look+((qscan+18)*100)+3, look+4096+((qscan+18)*100)+3
	  mov     #look+((qscan+18)*100)-point+3, @point
	rof
	
	cmp     #0, point
	 jmp     found         
	jmp     boot             ; Or move boot code here? 

spb     DAT     #0, #-7
	
found   cmp     core, @point
	 add     #4096, point
	add     #4096, point    ; point now points to hit
	mov     spb, @point
	add     #45, point
	cmp     core, @point    ; Scan at +45, and start
	 add     #52, point     ; bombing at +45
	add     #-52, point     ; or -7
	
loop    mov     spb, @point     ; 40% bomber, backwards through
point   mov     spb, @0         ; his code
	add     #-14, point
	cmp     core, @point    ; Loop over whole target 
	jmp     point           

	add     #98, point
	mov     spb, @point     ; and one for luck!

; ---------------------------------------------------------------

STEP    equ     1396
OFFS    equ     -100
FANGOFF equ     -41
STEPOFF equ     -42     

boot    spl     bootimp
boot1   mov     vamp-boot1, OFFS
boot2   mov     vamp-boot1, OFFS  
boot3   mov     vamp-boot1, OFFS  
	mov     fang, boot1+OFFS+FANGOFF
	mov     step, boot1+OFFS+STEPOFF
	spl     1
	mov     -1, 0
	mov     -1, 0
	mov     -1, 0           ; Get 18 processes
	spl     1
	spl     j1              ; spread evenly around 
	spl     j3              ; the vamp
j2      jmp     @boot3    
j3      jmp     @boot1 
j1      jmp     @boot1          ; and jump to it. 

fang    jmp     pit-boot1-OFFS-FANGOFF, 0
vamp    mov     FANGOFF, @FANGOFF
	add     vamp+STEPOFF, vamp+FANGOFF
	jmp     vamp
step    dat     #-STEP, #STEP

pit     SPL     2, boot1+OFFS+STEPOFF-5                 
	MOV     bomb, @pit      
	ADD     #-2731, pit
	JMP     pit             ; Overwritten.
bomb    DAT     #0, #0

; -------------------------------------------

; Nimbus launch for 5 point, 10 process imp. Size is a
; better protection than speed here. Currently has tail
; on the end of my code; not elegant.

imp     MOV 0, 3277       ; 2731 or 3277 (3 or 5 point)

bootimp SPL 1             ;   2
	MOV -1, 0         ;   3
	MOV -1, 0         ;   5
	SPL 1             ;   10
	SPL 2              
	JMP @0, imp            
	ADD #3277, -1         
	END
