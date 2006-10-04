;redcode verbose
;name Signal 1.1
;author James Jesensky

start    djn  start, <where  ;modify 1 memory location per instruction
         jmn  start, signal  ;check if we reached our own code
         mov  #1, signal     ;\
         mov  #7990, where   ; Yes, so reset data and continue.
         jmp  start          ;/
where    dat  #7990
signal   dat  #1
         end
