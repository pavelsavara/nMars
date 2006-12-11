;redcode
;name Backup
;author WFB
;strategy Oversby Round 3.
;strategy Ah!  I'll make a warrior tailored to beat up the grey warrior even
;strategy if it kills me! I have excuses for my Round 2 performance...
;strategy Anyways, I wanna sit down and make a good warrior designed to tear
;strategy the Grey Warrior apart, but if I don't have time, this is my backup.
;strategy Not that this didn't take awhile...
;strategy soooooo, I took the incendiary bomber from Torcht18 and tagged d-clear
;strategy along with it.  Pu-leazeeeeeee work...
;assert CORESIZE==8000
step equ 54
count equ 2000
sp       spl   #-1-step,-step    ; spl half of the incendiary
in       sub   #step+step,@msp
msm      mov   sm,*tgt+(step*count)-17228
msp      mov   sp,@msm           ; bomb alternately with spl & mov
tgt      jmz   in,#0             ; bombed with spl to start clear
         jmp   start
         dat 0,0
sm       mov   step+1,>step+1    ; mov half of the incendiary
shift		equ -3000
ptr		dat >0,4000
                dat 0,0
start           spl #0,>ptr
		mov.i bomb,>ptr
		djn.f -1,>ptr
bomb		dat >2667,bomb-ptr+3
end sp
