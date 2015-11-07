;redcode-94
;assert CORESIZE == 8000

;author Kurt Franke
;name System Trap

;strategy for JK Lewis' "Intelligent Warrior Tournament"
;strategy handshake for self-wins, and then:
;strategy 6/7 c scan looking for redOS
;strategy  vamp redOS process to help with 1.5 c coreclear
;strategy  or go to silk paper as a backup

;; - - - - - - - - - handshake constants - - - - - - - - - - - - - - -

	PIN	191

MAGICP		equ	378
WINP		equ	379
LOSEP		equ	380
WARRIOR		equ	decoy		;; if handshake requires many cycles
QWARRIOR	equ	decoy		;; if we have more time

;; - - - - - - - - - handshake initialize - - - - - - - - - - - - - -

magic	ldp.ab	>mptr, #0
	jmn	QWARRIOR, $magic	;; if flag is set, fight

last	ldp	#0, #0
	sne	#-1, $last		;; if it is the first round, set
mptr	jmp	search, #magicp		;; special routine for first round

;; - - - - - - - try handshake - - - - - - - - - - - - - - - - - - - - -

shake	jmz	lost, $last		;; the actual handshake
won	stp	#0, #LOSEP		;; reset the expected flag
	stp	#1, #WINP
loser	ldp	#LOSEP, #0		;; and then check it
	jmz	>foe, $loser		
wptr	jmp	#WARRIOR		;; wait for end of round and win again

lost	stp	#0, #WINP		;; reset the expected flag
	stp	#1, #LOSEP
winner	ldp	#WINP, #0		;; and then check it
	jmz	>foe, $winner
magicp	dat	#MAGICP, #0		;; lose again

;; - - - - - - - - - - - flag enemy warrior - - - - - - - - - - - - - - -

foe	stp.a	#1, @0
magicp2	jmp	*wptr, *magicp		;; also the key (see below)

;; - - - - - - - - - special first round routine - - - - - - - - - - - - -

;; Determine who moved first without pspace
;;  1st version waits till timeout and second kills itself

key	equ	(count-1)		

count	nop	#key+3, }count		;; scan our own key last
search	seq.i	$key, }count		;; 33% mod 3 scanning for other key
	jmp	count, }count

	sne.i	$count, }count		;; not equal for second warrior
wait	jmp	wait, }count		;; wait if we are #1
	mov	0, $key			;; erase key and quit if we are #2

;; - - - - - - - - - - - scanner step - - - - - - - - - - - - - - - - - -

WIDTH	equ	35
STEP	equ	(2*WIDTH)

incr	dat	{STEP, <STEP		;; increment for scanner

;; - - - - - - - - silk replicator as a backup strategy - - - - - - - - -

ASTEP equ 2268
BSTEP equ 5879
CSTEP equ 7901

paper	spl	1, <-200
	mov	-1, 0
	spl	1, <-400

	mov	<pptr, {pptr
pptr	spl	2000, three+1			;; start another copy

one	spl	@one, }ASTEP			;; and also the original
onea	mov	}one, >one
two	spl	@two, }BSTEP
twoa	mov	}two, >two
threea	mov	{two, <three
three	jmp	@three, >CSTEP

;; - - - - - - - - - - make decoy - - - - - - - - - - - - - - - - - -

DECOY	equ	(sbomb-200)

decoy	;; make a decoy -- 100 places in front should deter qscanners
	;; using code from the FAQ (Neat - I didn't realize I could do
	;; this at 3c)

qbomb	for	17
	  mov.i	<DECOY+(qbomb-1)*3, {DECOY+(qbomb-1)*3+2
	rof

jmp	scan1

;; - - - - - - - - - - just a core clear as main strategy - - - - - - - -

ptr	equ	(sbomb-4)

sbomb	spl	#0, #dbomb+5-ptr
clear	mov	$sbomb, >ptr			;; should be 1.5c with redOS
	mov	$sbomb, >ptr
	mov	$sbomb, >ptr
	djn.a	clear, $sbomb
	mov	$dbomb, $sbomb
dbomb	dat	#0, #dbomb+1-ptr


;; - - - - - - - - - - fast scan for redOS with verify - - - - - - - - -

FIRST	equ	(magic+200)
ACTION	equ	boot
BACKUP	equ	paper
BOOT	equ	-2793
EMPTY	equ	(magic+110)

match1 mov.i $6, $-30				;; a couple lines to check OS
match2 stp.b $-2, #1

reset	mov.i	EMPTY, @scan1
	mov.ba	$scan1, $scan1
	sub.a	#35, $scan1

next1	add.f	$incr, $scan1			;; am I overdoing this? :-)
scan1	sne.i	$FIRST, $FIRST+WIDTH
next2	add.f	$incr, $scan1
scan2	sne.i	*scan1, @scan1
next3	add.f	$incr, $scan1
scan3	sne.i	*scan1, @scan1
timer	djn	$next1, #36

	jmz.b	BACKUP, $timer			;; couldn't find redOS
	sne.i	EMPTY, @scan1
	mov.x	$scan1, $scan1

	mov	$scan1, $scan1+40
	jmn.f	reset, @scan1+40		;; too big --> it's a decoy

	jmn.f	0, >scan1			;; find the end

	sub	#7, $scan1			;; verify redOS
	sne.i	@scan1, $match1
	sub	#11, $scan1
	seq.i	@scan1, $match2
	jmp	reset

	sub	#12, $scan1			;; put a jmp onto redOS's wait
	sub.ba	$scan1, $vamp
	mov	$vamp, @scan1			;; hope redOS is waiting
	jmp	BACKUP				;; back up strategy

vamp	jmp	slave-scan1			;; vamp for redOS
recall	jmp	ACTION-BACKUP			;; vamp for me

slave	mov	$recall, $BACKUP		;; stop paper strategy

boot	mov.i	$dbomb, $BOOT			;; boot coreclear

	for	3
	  mov.i	{boot, <boot
	rof
launch	spl	@boot				;; start the coreclear

	for	3				;; just in case we didn't
	  mov.i {boot, <boot			;;  really get redOS
	rof
	mov	EMPTY, boot			;; paranoid.. erase pointer

;; - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

	end	magic
