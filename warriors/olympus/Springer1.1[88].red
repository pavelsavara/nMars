;redcode-x verbose
;name Springer 1.1
;author Alex MacAulay
;strategy A ring "replicator".
;strategy 1.1 - smaller
 
step      equ 247
offset    equ -126
 
start     spl 0
          add #1,spread
helpimp   mov imp,imp+offset+3
          add #1,helpimp
          spl 1
          spl 1
          spl 1
          spl 1
          spl inc
spread    jmp @spread,#imp+offset
inc       add #step,spread
          dat 0,0
imp       mov 0,step
 
          end start
