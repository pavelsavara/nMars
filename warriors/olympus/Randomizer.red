;name Randomizer
;author Robert Hale
;assert CORESIZE == 8000

;Strategy	randomly (pseudo randomly) pick between 3 options
;strategy		Coreclear
;strategy		Mini HSA
;strategy		TimeScape
;strategy  
;strategy  I could have done a switch of lose or switch on tie, 
;strategy  I could have even do a complicated table but 
;strategy  I did not see how I could outsmart the rest of the players 
;strategy  so a random choice seemed like a good idea.  
;strategy  I choose a random strategy in 11 cycles.  
;strategy  I could eliminated 2 cycles but I liked adding one if I won.  
;strategy  It made the behavior that much more random.  Hope it works :)

;********** Brain ***********************************

_RES    	equ     0
_STR    	equ     72
SEED            equ     5313
RND1            equ     557
RND2            equ     7979

brain
;Load if we won and the random seed
res     	ldp.ab  	#_RES, #0
        	ldp.a   	#_STR, seed

;if seed is zero set to initial SEED value
	  	sne.a	 	#0, seed 	
		mov.a		#SEED, seed

;seed * RND1 - mod(seed, RND2)
		mul.a		#RND1, seed
		mod.a		seed, store
		sub.a		store, seed

;add 1 if we won and save new seed
	  	add.ba   	res, seed
        	stp.ab  	seed, #_STR

;mod seed by 3 so we always get a good number
        	mod.a   	#3,     seed

;jump to choosen strategy
seed    	jmp     	@0, hboot
store      	dat     	#RND2, cc
        	dat     	0, time

;--------
;MINI HSA
;--------

hboot: mov    btm,@dest
N FOR 8
      mov    btm-N,<dest
ROF
      spl    @dest,1
dest: mov    #250,@away
      mov    bomb,<dest
      div.f  #0,dest

	dat	0, 0

step EQU 9
ptr EQU (bomb-5)
away EQU (-3621)

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


;[Carbonite]
cc      mov     }aptr, >aptr
        spl     @aptr
        mov     }aptr, >aptr
        mov     }aptr, >aptr
        mov     }aptr, >aptr
        mov     }aptr, >aptr
aptr    dat     dbomb, away

dbomb   dat     >-1, >1
        spl     #0, <-100
        mov     dbomb, tar-197*3500
tar     add     #197, -1                ; gets bombed to start
coreclear
        djn.f   -2, <-1151

;[Timescape (1.0)]

for MAXLENGTH - CURLINE - 10
        dat     0, 0
rof

TSTEP equ 1800
CSTEP equ 3740
NSTEP equ -1922
FSTEP equ 1870

time
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

	end 	brain
