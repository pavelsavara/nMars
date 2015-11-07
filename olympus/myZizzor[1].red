;redcode-94
;name myZizzor
;author Paulsson
;strategy Cissors (or whatever way you spell it)
;startegy One pass -> coreclear. Tiny I'd say.
;strategy Let's se how hard Die Hard is this time :-)		;I've changed it from the hill, wouldn't want
								;to tell you how to kill Die Hard :-)
;assert CORESIZE > 1


org start
step    equ             8
i for step
                dat             1,1		;8 bytes of target to hit (same as step size)
rof
check   	dat             1,0		;when bombed -> coreclear
i for 40
                dat             0,0		;safety distance to program
rof

start
p               add.ab  #step,#check+100	; \                  (doubles as ptr in coreclear!)
rep             jmz.f   p,@p			; / scan 1/2 c
                mov.i   b2,>p			; carpet bomb
                jmz.b   rep,check		; check if time to coreclear
b2      	spl     #b3-p,b1-p+2		; core clear, first bomb used (in spl/dat coreclear)
                mov.i   *p,>p			; clear
                djn.f   -1, <p-b1+p-2		; put a djn stream in clear
b3      	dat.f   b3-p, b1-p+2		; kill, second one in coreclear
b1      	spl     #b2-p,b1-p+2		; couldn't get rid of this (?)
