Howdy Philip,

I have attached a bomber dodger that works better then the one shot I
sent in.  I realize it is after the deadline.  Please rule on the
admissibility as required but if I can not have this warrior as my entry
please run it just to see how it does and publish it when the tourney is
over.  Thanks

;redcode-94
;name Skittish
;author Robert Hale
;strategy   Look for a non zero spot copy the dclr to it, 
;strategy	kill the bomber
;assert CORESIZE == 8000


start   equ     125

Aptr    dat     0, 200

scan    jmz.b   scan, >Aptr
        mov.i   {gate, <Aptr
        mov.i   {gate, <Aptr
        mov.i   {gate, <Aptr
        mov.i   {gate, <Aptr
        jmp.a   @Aptr, 0

for 80
         dat    0,0
rof        

gate    dat     wipe+1, 0

for MAXLENGTH-CURLINE-4
        dat     0, 0
rof        

dclr    spl     #0
        mov     wipe, >gate
        djn.f   -1, >gate
wipe    dat     >5335, 2-gate

        end     scan


Robert G. Hale
Lockheed Martin Mission Systems
(719)594-1734
robert.hale@lmco.com
