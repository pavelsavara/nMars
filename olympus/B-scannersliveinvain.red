;redcode quiet
;name B-scanners live in vain
;author Matt Hastings
        add #1226,3
start   jmz -1,@2
        mov grave,@1
        mov prog,<-2+1226
        jmn -4,-4
prog    spl 0,0
        mov @10,<-1
grave   jmp -1,0
