
Well, here we go again...

Phil

-- 
 Philip Kendall (pak21@cam.ac.uk pak21@kendalls.demon.co.uk)

;redcode
;name Back from the Grave
;author Philip Kendall
;strategy A _simple_ vampire
;assert CORESIZE==8000

;BDECWT round 3
;opponent Myer Bremner :-(

;Oh well, I don't know much (anything, really) about progamming in '88, so
;I'm not expecting to do that well here (unless Myer fails to come up with a
;warrior again :-) ). What this is: just a 33% c self-splitting vampire stone,
;with a dat coreclearing pit - the stone jumps to the pit at the end of the
;bombing run - in '94, it scores 93 Wilkes or 103 Wilbez, and gets thrashed
;by Timescapes (no worries), Cannonade and Bluefunk (bigger worries - not
;sure how big). As for what Myer will come up with, I have no idea...
;hopefully I will do better than I did last time :-)

step    equ     3196
clear   equ     (vbomb-8)
stream  equ     (start-208)

bdist   equ     1024
hide    equ     5814

vbomb   jmp     (pit-hit+3-step),(hit+2+step)

;       2 instructions here

start   spl     0,<stream
loop    mov     (vbomb-2),@(vbomb-2)
        add     inc,(vbomb-2)
hit     djn     loop,<stream
inc     dat     #-step,#step

;       3 instructions here

pit     mov     clear,<clear
        spl     -1,<(clear+1)
        spl     -2,<(clear+1)
pitend  jmp     -3,<(clear+1)  ; overwritten by a bomb saying jmp -3,xxx

i       for     (MAXLENGTH-CURLINE-(pitend-vbomb+1)-4)
        dat     <(i+300),<(i+400)
        rof

bptr01  mov     pitend,(pitend+bdist+3)
i       for     (pitend-pit)
        mov     (pitend-i),<bptr01
        rof
bptr02  mov     inc,(inc+bdist)
i       for     (inc-start)
        mov     (inc-i),<bptr02
        rof
        spl     (start+bdist),<-1000
bptr03  mov     vbomb,(vbomb+bdist-2)
i       for     3
        add     #hide,bptr&i
        rof

        end     bptr01


