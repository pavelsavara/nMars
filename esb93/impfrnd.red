;redcode  
;name ImpsAreMyFriend
;author J.Layland
;contact jlayland@grissom.jpl.nasa.gov 

;strategy Look Mommy!  My very first imp-stone.

;  An imp-stone worked in round 1, so hopefully this will
;  do the trick.  For the record, my guess is that my
;  opponent is either a vampire or possibly one of the former
;  generation of scanners before gates & other anti-imp mods.

;strategy  Components ruthlessly appropriated from Sphinx, Imprimis
;strategy  Thrown together for EBS Tournament round 2, so I haven't 
;strategy  played around much with the spacing yet.  Seems to work though...
;strategy  16 process, 3 point imp, binary launch
;strategy  stone from imprimis
;strategy _no_ coreclear or imp gating (Imprimis stone kills imps, though)
;  This all sort of fell together-- don't know why it works, but...
;> 1  39/ 25/ 37           ImpsAreMyFriend            J.Layland     153      17
;> 2  38/ 25/ 37              FlyPaper 2.0            J.Layland     151      48 
; ... I can't complain :-)

offset1 equ 1212	; constants randomly chosen from thin air
offset2 equ 2551

IMP0    EQU IMP+offset2
IMP1    EQU IMP0+2667
IMP2    EQU IMP1+2667

boot  	mov <src, <dst
	mov <src, <dst
	mov <src, <dst
	mov <src, <dst
	mov <src, <dst

dst	spl @0, src-offset1
	mov IMP, IMP0

;binary launch like (i.e. copied from) Sphinx
launchimps
	spl 16, <257
        SPL 8, <514
        SPL 4, <771
        SPL 2, <1028
        JMP IMP0, <1435
        JMP IMP1, <1542
        SPL 2, <1799
        JMP IMP2, <2056
        JMP IMP0+1, <2313
        SPL 4, <2470
        SPL 2, <2827
        JMP IMP1+1, <3084
        JMP IMP2+1, <3341
        SPL 2, <3598
        JMP IMP0+2, <3855
        JMP IMP1+2, <4112
        SPL 8, <4369
        SPL 4, <4626
        SPL 2, <4883
        JMP IMP0, <5140
        JMP IMP1, <5397
        SPL 2, <5654
        JMP IMP2, <5911
        JMP IMP0+1, <6168
        SPL 4, <6425
        SPL 2, <6682
        JMP IMP1+1, <6939
        JMP IMP2+1, <7196
        SPL 2, <7453
        JMP IMP0+2, <7710
        JMP IMP1+2, <224

; extra-extra-- Read all about it!
; imp-killing stone from Imprimis, copied intact
; Maybe I can play with constants this weekend, but KOTH says this
; works pretty well... :-)
; and the few variations I tried did _much_ worse.

stone    mov <5630,stone+3044+3
extra    spl -1,<inc-129-1100        ; stone soaks up cycles early
         add inc,stone               ; but kills itself after mod-4 is complete
cnt      djn extra,<inc-129-1100
inc      dat #2667,#3044

src	dat #0

IMP     MOV 0, 2667

decoy
 	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
	dat <src, #1
 
end boot
