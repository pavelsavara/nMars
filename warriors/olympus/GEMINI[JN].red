; GEMINI copies itself forward about 100 cells
; and then jumps to the copy.
; GEMINI has required considerable modification
;  to run under Core War '89.  Jon Newman
offset  equ 100
source  dat 0,0
dest    dat 0,source+offset
loop			 add #1,source
   				 add #1,dest
start   mov @source,@dest
   				 cmp #last-source,source
    				jmp loop,0
done    mov #0,source+offset
   				 mov #source-dest+offset,dest+offset
last				jmp start+offset,0
end 				start