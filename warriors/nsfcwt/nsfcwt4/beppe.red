;redcode-94
;name sort of sorter
;author Beppe Bezzi
;contact bezzi@iol.it
;NSFCWT round 4
;strategy enter the core in battle lust and, if the enemy is at
;strategy location 4001+, sorts it according to cell 4000
;strategy if cell 4000 has an a-field diffrent from zero
;strategy gets enraged and kill off its duplicate cells

;assert CORESIZE > 4002   ;-)

org     sortem
void    equ     start-1
moves   equ     start-5
buf1    equ     start-10
buf2    equ     start-15

start
point   dat     4001,4002
point1  dat     4001,4002
point2  dat     4001,4002
;part 1 sort 'em, ascending
end1
	mov     point1, point
	mov     #0,     moves
sortem  slt.b   *point, @point  ;x.b < x+1.b
	jmp     lookeqb         ;no look if equal .b
next    add.f   incr,   point   ;yes next pair
	seq.i   void,   @point  ;last pair
	jmp     sortem          ;no continue
	jmz.b   readflb,moves   ;yes no moves pass => finish
	jmp     end1            ;repeat loop

lookeqb seq.b   *point,  @point
	jmp     swap            ;non< non= => > => swap
looka
	slt.a   @point, *point  ;x+1.a < x.a
	jmp     next            ;yes next couple
	jmp     swap
lookeqa 
swap    mov     *point, buf1
	mov     @point, *point
	mov     buf1,   @point
	jmp     next,   >moves
readflb
	jmz.b   readfla,4000+start

;part 2 invert order
swapem
	sub.ab  point1, point
	mov.b   point,  swloop
	div.ab  #2,     swloop
	sub.a   #1,     point1  ;point1.a points first data

sw0     mov     *point, buf1    ;last in buf
	mov     *point1,*point  ;first in last 
	mov     buf1,   }point1 ;buf in first - incr first
	jmp     1,      {point  ;decr last
swloop  djn.b   sw0,    #0

readfla 
;part 3 delete doubles
	jmz.a   buf1,  4000+start ; here I'm 
	jmn.b   newloop-1,start+4000 ;just calculated when inverting
	sub.ab  point1, point
	mov.b   point,  djnrem  ;n. of compares

newloop mov.a   point2, point   ;reset poin.a to first
	mov.i   point,  buf1    ;save pointer to compare
	mov.i   }point, buf2    ;instr. to compare -> buf2 incr pointer

remloop sne.i   }point, buf2    ;compare and increment
	jmp     remove, {point  ;remove line
	seq.i   void,   *point  ;end?
	jmp     remloop         ;no compare to same
	mov.a   point2, point   ;yes update point
	add.i   incr,   point2  ;
djnrem  djn     newloop,#0      ;repeat to the end
incr    dat     1,      1       ;here to stop
;remove instruction and move block up
;data to remove is pointed by *buf1
;neext instruction in @point
remove
	mov.i   point,  point1
	mov.b   djnrem, djnrem1 ;set cycles
	mov.ab  buf1,   point 
	mov.a   buf1,   point   ;pointer at to be removed
	add.ab  #1,     point   ;@point ->*point

rmloop  
	mov     @point,*point
	add     incr,   point
djnrem1 djn     rmloop, #0
	mov.i   point1, point
	jmp     newloop,<djnrem
end
