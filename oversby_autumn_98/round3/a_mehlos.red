From: 	Andrew S Mehlos
Sent: 	04 December 1998 22:44
To: 	ian@i-next.co.uk
Subject: 	hope this isn't late

;redcode
;name Token Effort
;author A.S. Mehlos
;strategy scanner/bomber -- Gray Warrior round in Ian's tournament.
;strategy More anti-imping on the clear
;strategy (Ya know, midnight CST is a bit off from midnight GMT. D'oh.)
;strategy (This one is kind of rushed... It's a little on the big side,
;strategy  but there's no scanner to worry about, so it might not be 
;strategy  --too-- bad. 
;assert CORESIZE==8000

org incr

SCANSTEP equ 5         ;
BOMBSTEP equ 2340       ; mod (SCANSTEP*4) = 20
COUNTS   equ 390
MAXSTUNS equ 4
gate equ bomb-20
FIRSTCHK  equ BOMBSTEP-8

for 10
	dat 0,0
rof

bomb   spl   #SCANSTEP, <SCANSTEP
cPtr   spl   #-4,   #3
       dat   #8,    <1
       spl   #8,    #1
cSt    spl   #8,    #2
       mov   @cPtr, }cPtr
       mov   @cPtr, }cPtr
       djn.f -2,    <-9
addt   dat  <BOMBSTEP, <BOMBSTEP
incr   add.f addt,      scan
toss   mov   bomb      ,@scan
       mov   bomb     ,*scan
scan   seq.i  @FIRSTCHK ,@FIRSTCHK+(SCANSTEP*2)
chk    slt.ab   #5,scan
dct    djn.b  incr,    #COUNTS
aim    add.a   scan, cPtr
       jmp cSt



