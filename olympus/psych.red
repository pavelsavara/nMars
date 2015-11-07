;redcode-94
;author JKW
;name psych
;assert (CORESIZE == 8000)
;contact jkw@koth.org
;strategy Ya know... it's kinda odd, but I did some statistical tests, and
;strategy as near as I can figure, I can't possibly score less than 67
;strategy tournament points for this round.  My warrior does nothing but boot
;strategy straight to timescape, and then proceeds to beat any pspacer that
;strategy takes more than 7 cycles to boot.  Even if the opponent always
;strategy chooses HSA, the 7 cycles I save by not having any pspace routines
;strategy allows me to come out slightly ahead.
;strategy And since as far as I know any warrior capable of remembering the
;strategy results for more than past round will require at least 7 cycles...
;strategy so thusly this program beats any possible pspacer for this round.
;strategy
;strategy Worst case scenario: an infinite number of people submit warriors,
;strategy and they all boot straight to timescape.  And one other person
;strategy submits a warrior which boots straight to HSA.  We all score 67
;strategy and the HSA guy scores 100.
;strategy
;strategy I felt the need to justify my warrior choice with a lot of strategy
;strategy lines, since it's so incredibly lame. :)

org start

;********** [Mini He Scans Alone]

step EQU 9
ptr EQU (bomb-5)

bomb: spl    #1,{1
kill: mov    bomb,<ptr
mptr: mov    >ptr,>ptr
      jmn.f  kill,>ptr
a:    add    #step+1,@mptr
scan: jmz.f  a,<ptr
      slt    @mptr,#btm-ptr+3
      djn    kill,@mptr
      djn    a,#16
btm:  jmp    a,{kill

;********** [Carbonite]

dbomb   dat     >-1, >1
carbonite
        spl     #0, <-100
        mov     dbomb, tar-197*3500
tar     add     #197, -1                ; gets bombed to start coreclear
        djn.f   -2, <-1151

;********** [Timescape (1.0)]

TSTEP equ 1800
CSTEP equ 3740
NSTEP equ -1922
FSTEP equ 1870

        for 70
        dat #1, <-1
        rof

        dat 0,0
        dat 0,0
        dat 0,0

start
timescape
        spl     1,              <-200
        spl     1,              <-300
        mov.i   -1,             0

tim1    spl     @tim1,          }TSTEP
        mov.i   }tim1,          >tim1
cel1    spl     @cel1,          }CSTEP
        mov.i   }cel1,          >cel1
        mov.i   {-FSTEP,        <FSTEP
        mov.i   {cel1,          <ncl1
ncl1    jmp     @ncl1,          >NSTEP

        dat 0,0
        dat 0,0

end
