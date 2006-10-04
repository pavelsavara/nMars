;redcode
;name myVamp3.7 :-)
;author Paulsson
;strategy Nahe, more like stone imp.
;contact mpn@ifm.liu.se
;NSFCWT Round LAST

;Almost forget to send it in, 4 3 line stones and
;a 4 process imp.
;Merry X-mass

start   spl             imp
                spl             ett
                spl             tre
fyra    
                mov             bomer,start+2000*1              
                mov             bomer+1,start+2000*1+1          
                mov             bomer+2,start+2000*1+2          
                spl             0
                jmp             start+2000*1
tre     
                mov             bomer,start+2000*2              
                mov             bomer+1,start+2000*2+1          
                mov             bomer+2,start+2000*2+2          
                spl             0
                jmp             start+2000*2

bomer   mov             -1,-4*13-1
                add             #27*4,-1
                jmp             -2
                
; Some one knows what the hell the 8 generators
;for SU(3) does? I mean like the 3 generators in
;SU(2) that generate rotations in spinspace!

tva
                mov             bomer,start+2000*3              
                mov             bomer+1,start+2000*3+1          
                mov             bomer+2,start+2000*3+2          
                spl             0
                jmp             start+2000*3
ett             spl             tva     
                mov             bomer,start+2000*4              
                mov             bomer+1,start+2000*4+1          
                mov             bomer+2,start+2000*4+2          
                spl             0
                jmp             start+2000*4

imp             spl             i1
                spl             i2
                jmp             impy
i1              spl             impy
                jmp             impy+8193/3*2
i2              jmp             impy+8193/3*1
impy    mov             0,8193/3

end start
