; Warrior KISS

l   MOV b1, <p
    MOV b2, <p
    JMN l, p
    MOV #-16, p
z   MOV k, <p
    JMN z, p
    MOV #-16, p
    JMP l
b1  JMP -1
b2  SPL 0
k   DAT #0
p   DAT #-16
