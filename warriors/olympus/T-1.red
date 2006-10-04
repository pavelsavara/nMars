;redcode-94b
;name T-1
;author Ross
;strategy scanner -> coreclear
;assert CORESIZE==8000
;type scan, stun, clear

; 157.5333 wilkies :-)

ptr     DAT     #0,             #0            
start   ADD.AB  #3039,          ptr             ;step through locations
        JMZ.A   start,          @ptr            ;check for nonzero A-field
        SLT.ab  #cctail-ptr,    ptr             ;check for self-bombing
        JMP     start,          ptr
        MOV     ptr,            ccptr
        SUB     #ccptr-ptr+5,   ccptr
        JMP     cclear
FOR     50
        DAT     0,              0
ROF
ccptr   dat.f   0,              0        
        dat.f   0,              10       
cclear  spl     #0,             10      
        mov.i   @bptr,          >ccptr 
        mov.i   @bptr,          >ccptr 
cctail
bptr    djn.b   -2,             {cclear 

        END     start
