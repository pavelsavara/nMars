;redcode-94
;name aMixture
;author Paulsson
;strategy myVamp(theMystery) in a deadly(coward) mixture.
;assert CORESIZE ==8000
;contact mpn@ifm.liu.se
;NSFCWT Round 1

step    equ 3024        ; hide this, anything * 16
boot    equ     8*200          ;hide this, anything * 16
org     start

trap    jmp             11         ; pointer to actual trap
i       for     10
                dat   0, 0
rof
                spl             #0,<trap         ; change b-field of trap to get myVamp into core-clear
                spl             5,0              ; split of a bit to make trap a bit safer
                spl             #0,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                spl             #0,0
                jmp             -4,0
                
i       for     39-19
                dat.i   #1, i
rof
ptr1 dat 5+pap,pap+5+500
ptr2 dat pap+5,pap+5+2667+500
ptr3 dat pap+5,pap+5+2667*2+500

mV              mov.i   }ptr,>ptr     ; myVamp start, boot of!
i for 13
                mov.i   }ptr,>ptr
rof
                jmp             st+boot,1
ptr             dat.f   c2,boot+c2

c2      spl.f   #b1, b2+2
st      add.f   s, c            ;start of actual myVamp
                mov.i   c, @c                 ;Bomb with jmp *trap
                jmz.a   st, *c                ;scan a field
                mov.i   @0,*c                 ;0 in a field -> can scan this address
                mov.x   *c,*c                 ;Bomb with jmp *trap
exit    jmz.b   st, trap-boot   ; start core-clear if b field of trap != 0
b1      spl     #b2-c2, b2-c2+2 ;Coreclear
                mov.i   *c2, >c2
                djn.f   -1, {c2-b2+c2-2
b3      dat.f   <-2666, <2667   ;special to kill Die Hard!
b2      spl     #b3-c2, b2-c2+2
c       jmp     *trap-boot, 0   ; theBOMB the * was Beppes idea
s       dat.f   -step, step

step1   equ             1800
step2   equ             -1922
tM      spl 1        ;theMystery start
mov.i -1,0      ;create 5 processes
mov.i -1,0
mov {ptr2,<ptr2 ;move out 2 more copies of paper
mov {ptr1,<ptr1
spl 3
spl     4
jmp @ptr1
mov {ptr3,<ptr3
jmp     @ptr3
jmp @ptr2

pap spl step1,0 ;normal silk type paper
mov.i >-1,}-1
mov.i <-2,<1
spl     @0,}step2
mov.i #0,2667   ; theMystery! 3 papers making a disorginasied imp.

;switcher to make theMystery play in multiwarior play,
;and myVamp 3.7 in normal hill style play.
code    equ             2981
start   ldp.ab  #0,#0
                sne.ab  #-1,start
                jmp     mV
passwd  ldp.ab  #1,#0
                sne.ab  #code,passwd
                jmp             tM
                slt.ab  #2,start       ; if more than two programs tie use
theMystery
                        ; for the rest of the fights
                jmp             mV
                stp.ab  #code,#1
                jmp tM
