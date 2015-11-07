;redcode-94m quiet
;name test
;kill test
;strategy gemini - jump ahead of scanning/bombing run
;
start    spl 1        ; 
         spl 1        ; make 8 processes
         spl 1        ; 
         spl g2
         
g1       spl @0,43    ; jump to next location
         mov }g1,>g1  ; move code there
         mov 2,>1     ; little bombing
         dat 1,28
     for 4
         dat 1,1
     rof
     for 50
         dat 1,1
     rof
g2       spl @0,43    ; jump to next location
         mov }g2,>g2  ; move code there
         mov 2,>1     ; little bombing
         dat 1,28
     for 4
         dat 1,1
     rof
         end start
