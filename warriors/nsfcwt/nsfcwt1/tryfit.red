;redcode
;name  Try fitting THIS name into eight characters or less!
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSFCWT Round 1
;assert CORESIZE == 8000
;assert VERSION >= 80



for 0

The challenge:  Get a warrior that scores well in single-warrior and multi-
warrior combat.  I expect >90% of the warriors will be using P-space
switching algorithms.

The strategy:  Boot Quickly.  If multiwarrior (i.e. more than 2 warriors
left at the end of the round), use Son of Imp-type strategy.  It's stupid,
but it survives.  If singlewarrior, go to quick scanning code to defeat
slow launchers.  Also brainwash.

rof

org begin

step equ 2849
small equ 12


stream equ qscan+3012
stream2 equ qscan+2500

impa equ begin+7800
offa equ begin+3800
impb equ begin+7800+3556
offb equ begin+3800+3556
impc equ begin+7800+7112
offc equ begin+3800+7112

      jmp son,<1   ;-12
for 9
      stp <1,<1
rof

begin ldp.a #0,launch
jump  jmp @-1,<stream

son   spl b,<stream2               ;0
      spl c
a     mov imp,impa+2
      mov imp,<a
      mov imp,<a
pa    mov jump,offa+2
      mov addvec,<pa
      mov @ccx,<pa
      jmp @pa

      stp <1,<1
      
      stp <0,#son-small            ;10
launch jmp @1,<son
      stp <0,#qscan
      stp <0,#qscan
for 27
      stp <0,#son                  ;14-40
rof
p       dat #son-small,{son
        dat #qscan+11-p,{son-small
        stp.b #qscan+11-p,{son-small
cc      spl #qscan+11-p,{son-small

      stp <0,#son+small            ;45
      
qscan   add d,@1
        sne *p,@p
        add d,@1
        sne *p,@p
        add d,@1
        sne *p,@p
        djn.f -6,<stream
        mov @1,}p
ccx     djn.b -1,<cc
        jmp -2

        dat 0,0                    ;56
        
d       stp #step,{step

b       mov {imp,impb+2
        mov imp,<b
        mov imp,<b
pb      mov jump,offb+2
        mov addvec,<pb
        mov @ccx,<pb
        jmp @pb

        dat 0,0
        dat 0,0
        dat 0,0
        dat 0,0                   ;68
c       mov imp,impc+2
        mov imp,<c
        mov imp,<c
pc      mov jump,offc+2
        mov addvec,<pc
        mov >ccx,<pc
        jmp @pc

imp     mov.i #1,2667

addvec  add #2668,#(impc)-(offc)-1-2668

end
