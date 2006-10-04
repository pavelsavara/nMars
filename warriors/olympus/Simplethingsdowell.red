;redcode-94
;name Simple things do well
;author Beppe
;strategy round 4 entry
;strategy switch on loss
;strategy tried some other strategy some rather refined and also weighted random
;strategy simple switch on loss seems to be the best.
;strategy BTW 2nd best seems to be using but Timescape :-/

;assert CORESIZE == 8000
org     think                   ;v 1.00


RES     equ     #0
PST     equ     4       ;p-status location
STATES  equ     9       ;max states



c1      equ     timesc
c2      equ     carbon
c3      equ     minihsa




paper


for 1
	dat     0,0
rof
	dat     0,init_state-state
in      dat     0,losstab-state
	dat     0,wintab-state
	dat     0,tietab-state

think
	ldp.a   #0,in              ; get input value
load    ldp.a   #PST,   state      ; load old state
	mod.a   #STATES,state      ; brainwash protection
	add.ba  *in,state          ; select correct state table
store   stp.a   *state,load        ; store new state


;I dont need such a big table but it works well as a decoy :-)

wintab
state   jmp     @0,     c1      ;0      jump to warrior code
	dat     0,      c1      ;1
	dat     1,      c1      ;2
init_state        
	dat     3,      c2      ;3
	dat     3,      c2      ;4
	dat     3,      c2      ;5
	dat     6,      c3      ;6
	dat     6,      c3      ;7
	dat     6,      c3      ;8


losstab
	dat     3,      c2      ;0
	dat     3,      c2      ;1
	dat     3,      c2      ;2
	dat     6,      c3      ;3
	dat     6,      c3
	dat     6,      c3      ;5
	dat     0,      c1
	dat     0,      c1      ;7
	dat     0,      c1

tietab
	dat     1,      c1      ;0
	dat     2,      c1
	dat     6,      c3      ;2
	dat     3,      c2
	dat     4,      c2      ;4
	dat     5,      c2      ;5
	dat     6,      c3
	dat     7,      c3
	dat     8,      c3

for 4
	dat     0,0
rof

;[Carbonite]

dbomb   dat     >-1,    >1
carbon
	spl     #0,     <-100
	mov     dbomb,  tar-197*3500
tar     add     #197,   -1              ; gets bombed to start coreclear
	djn.f   -2,     <-1151

for 5
	dat     0,0
rof

;[Timescape (1.0)]

TSTEP equ 1800
CSTEP equ 3740
NSTEP equ -1922
FSTEP equ 1870

timesc
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


for 6
	dat     0,0
rof
for 9   
	dat     1,1
rof

	dat     0,20    ;ptr
	dat     1,1
	dat     1,1
	dat     0,0
	dat     0,0
	


;[Mini He Scans Alone]

step EQU 9
ptr EQU (bomb-5)

bomb:   spl     #1,     {1
minihsa
kill:   mov     bomb,   <ptr
mptr:   mov     >ptr,   >ptr
	jmn.f   kill,   >ptr
a:      add     #step+1,@mptr
scan:   jmz.f   a,      <ptr
	slt     @mptr,  #btm-ptr+3
	djn     kill,   @mptr
	djn     a,      #16
btm:    jmp     a,      {kill


end
