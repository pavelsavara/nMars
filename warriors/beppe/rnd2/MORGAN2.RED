I've had this done for a little while, I just forgot to send it... 
oops. One of my very first warriors, touched up a bit. Okay, a whole 
lot.

;redcode
;name 1,000lb weight v2
;author Ross Morgan-Linial
;assert CORESIZE==8000

;strategy Two copies of a simple bomber, working together (sort of)
for 0
; Two copies of a simple bomber, booted to locations symetrical
; in core. After they finish their bombing run, they cooperate
; to clear the core. If one is killed, the other clears core by
itself.

; Only two processes are used until the coreclear, where all 8 are
needed. ; Thus, being hit by a SPL bomb will probably kill this, but
it won't ; feel it until the coreclear tries to start.

; I figure there won't be much paper this round... ;-)
rof

bootptr DAT     bomb2+1,2009        
bootadd DAT     9,      4009


start
n      
        FOR     9
         MOV     {bootptr, <bootptr     
        ROF
        ADD.f   bootadd, bootptr
        FOR     9
         MOV     {bootptr, <bootptr     
        ROF
        MOV     bootadd, bootptr        
        SPL     2               ;binary launch the warriors
        JMP     bootptr+2000
        JMP     bootptr+6000

lbstart
loop1   mov     bomb1,  @addr
        mov     bomb1,  *addr
        add.f   inc,    addr
        djn     loop1,  <-6     ;hit by SPL to start coreclear
        mov.i   cbomb,  <-6
        mov.i   cbomb,  <-7
cbomb   dat     <-31,   <-2
addr
bomb1   spl     #10,    <6      ;this is changed to 3994 and dropped
above inc bomb2   dat     #10,    #10

        end     start
--------
Ross Morgan-Linial  *  rmorganl@fhcrc.org

Don't confuse me with the facts. I've got a closed mind.
      - Earl Landgrebe

