;redcode-94
;name Sortidator
;author Christian Schmidt
;assert 1
;strategy ----------------------------------------------------------
;strategy 1. search for the lowest key value (hopfully save a lot of cycles)
;strategy 2. sort the itemlist starting with the value 
;strategy     found in part 1 and store the items behind the 
;strategy     itemlist.
;strategy 3. overwrite the itemlist by the generated list of items
;strategy ----------------------------------------------------------

SL      equ     (ITEMLIST+ITEMS+1)

;-------------------------------------------------------------------
;find the lowest keynumber of the itemlist 
;and store it as startvalue for the ascending sorting routine (13
instructions)
;-------------------------------------------------------------------
low     slt.b   *sqeptr,@sqeptr         ;has the comparing item a lower b-value 
incr    jmp.a   chsqe,  1               ;yes, get this item
plus    add.b   incr,   sqeptr          ;no, Ok the next one
	seq.b   next,   stor            ;or am I at the end of the list?
	jmp.a   low,    >stor           ;no, compare the next item
	add.b   *sqeptr,        ref             ;yes, set the startvalue for the sorting routine
stor    jmp.a   start,  2               ;and start the sorting
chsqe   sub.ab  sqeptr, sqeptr          ;uhhh, I do not find a better routine
	add.ba  sqeptr, sqeptr          ;for reseting this
	sub.b   sqeptr, sqeptr          ;but, it works
	add.ab  sqeptr, sqeptr          ;and that's it
	jmp     plus                    ;and look again
sqeptr  dat     ITEMLIST,       ITEMLIST+1      ;here are the pointer for this
;-------------------------------------------------------------------
;this is the sorting routine, which search in ascending
;order through the itemlist (15 instruction)
;-------------------------------------------------------------------
start   sne.b   *ptr,   @ptr            ;is this a item I need?
ref     jmp.a   sort,   0               ;yes, it is, go to the sorting routine
ad      nop     >ptr,   >reset          ;no, increment pointer and reset
	seq.b   next,   reset           ;am I at the end of the itemlist?
reset   jmp.a   start,  0               ;no, let's see what the next item brings
anz     jmp.a   back,   0               ;yes
sort    mov     @ptr,   @sziel          ;move the item to the sorting list
	nop     >anz,   >sziel          ;actualize pointer
	sne.b   next,   anz             ;do I have all items?
sziel   jmp     copy,   SL              ;yes, then copy them to the itemlist
next    jmp.a   ad,     ITEMS           ;and again
back    sub.b   reset,  ptr             ;now I'll go to the start of the itemlist
	sub.b   reset,  reset           ;reset the pointer and the reset itself
	jmp.a   start,  >ref            ;start again and increment the key-value
ptr     dat     ref,    ITEMLIST        ;this is the pointer
;-------------------------------------------------------------------
;copy now the sorted list to the itemlist (3 instructions)
;-------------------------------------------------------------------
copy    mov.i   }cc,    >cc             ;copy the sorted list   
	djn     -1,     #ITEMS          ;and finish
					;YESSSSS!!!!!!!!!!   I'm ready
cc      dat     SL,     (SL-ITEMS-1)    ;my copy pointer
