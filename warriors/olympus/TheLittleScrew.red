;redcode
;name           The Little Screw
;author         kdmiller@athena.mit.edu
;strategy       Probably the smallest possible scanning slaver program

ptr     jmp      zot,    0
inc     dat     #3044,  #-3044

s       add      inc,    ptr
        jmz      s,     @ptr
        slt      ptr,   #10	;keeps it from zapping itself
        mov      ptr,   @ptr
        jmp      s

zot     spl      0,      ptr-1
k       mov      ptr-1, <zot
        jmp      zot

        end     s
