;redcode
;name garlic
;kill garlic
;author Stefan Strack
;strategy vampires are afraid of it
;strategy Submitted: @date@

scan    jmz scan,<ptr
        sub @ptr,<ptr
        add #10,@ptr
ptr     mov 2,<-100
        jmp ptr
