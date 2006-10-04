;redcode-94
;name Fern 1c
;author Ilmari Karonen
;strategy ** Anton's Core War Tournament round 3 entry **
;strategy  I hope this one's something a bit different:
;strategy  A fractal fern, created using a simple random
;strategy  bounce algorithm.
;strategy Best viewed with: "pmarsv -b -v 114 fern1c.red"
;strategy  I used the 286 version, but it should work on
;strategy  others as long as the line width is the same.
;author Ilmari Karonen
;history 1b - works, fixed a math bug
;history 1c - looks a lot nicer
;date Aug 22, 1997
;planar boot, other
;assert CORESIZE == 8000

; Line width:
WIDTH   equ     154

; Screen attributes:
HEIGHT  equ     ((CORESIZE-MAXLENGTH)/WIDTH)
XDISP   equ     (WIDTH/2)

; Probabilities of different parts:
prb01   equ     4560
prb02   equ     1639
prb03   equ     1639
prb04   equ     (CORESIZE-prb01-prb02-prb03)    ; 162

; Magic constants for RNG:
magic   equ     4221
seed    equ     (prb01+prb02)

; Boot distance:
away    equ     (bptr-dest)

	org     start

; Boot:
start   mov.i   >dest, >bptr    ; will overwrite itself
bptr    jmp     start, #away

; Scaling constants:
mulc01  dat     #7, #7
divc01  dat     #10, #10

mulc02  dat     #3, #1
divc02  dat     #5, #4
addc02  dat     #XDISP-((HEIGHT*3)/5), #HEIGHT-((HEIGHT*1)/4)+((XDISP*1)/4)

mulc03  equ     mulc02
divc03  equ     divc02
addc03  dat     #XDISP+((HEIGHT*3)/5), #HEIGHT-((HEIGHT*1)/4)-((XDISP*1)/4)

mulc04  dat     #0, #3
divc04  equ     divc01
addc04  dat     #XDISP, #HEIGHT-((HEIGHT*3)/10)

;limits  dat     #WIDTH, #HEIGHT

; Pseudorandom number generator: rand = (rand*magic+1)%CORESIZE
rand    mul.ab  #magic, #seed

; Part selector:
select  slt.ab  #prb01, rand
	jmp     move01, >rand
	jmn.f   1, @rand        ; ground
	slt.ab  #prb01+prb04, rand
	jmp     move04, >rand
	mov.a   #XDISP-((XDISP*7)/10), addc01
	slt.ab  #prb01+prb04+prb02, rand
	jmp     move02, >rand

; Part 3 - right leaf
move03
coord   mov.x   #XDISP, #HEIGHT
	mul.f   mulc03, coord
	div.f   divc03, coord
	mul.a   #-1, coord
	add.f   addc03, coord
	jmp     plot, >rand

; Part 4 - stem:
move04  mov.a   #XDISP-((XDISP*7)/10), addc01
	mul.f   mulc04, coord
	div.f   divc04, coord
	add.f   addc04, coord
	jmp     plot

; Part 1 - top:
move01  mul.f   mulc01, coord
	div.f   divc01, coord
addc01  add.a   #XDISP-((XDISP*7)/10), coord
	jmp     plot, {addc01

; Part 2 - left leaf
move02  mov.x   coord, coord
	mul.f   mulc02, coord
	div.f   divc02, coord
	mul.ab  #-1, coord
	add.f   addc02, coord

; Plot coordinates:
plot    ;mod.f   limits, coord   ; safety
	jmz.b   move04, coord   ; kluge
	mov.b   coord, dest
	mul.ab  #WIDTH, dest
	add.ab  coord, dest
dest    djn.b   rand, >bptr+1   ; bfield used as boot ptr

	end
