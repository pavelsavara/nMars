;;Retrovirus v1.0
;;By Ray Cromwell (rjc@gnu.ai.mit.edu)
;;USA
;;December 1991
;;Technique: Subvert other program, so that it impstomps and copies
;;	     our virus for it.
;; (not optimized, yet)
;; Idea came from Tierra (artificial life program),
;;	see comp.theory.cell-automata for more details.

rnaoffset   equ virusrna-memptr
exoff	    equ (833-(endprog-startprog)+(execaddr-dest))
pend	    equ endprog-ptr

;;
;; Impstomp. Opposing warrior usually executes this.
;;
startprog   dat #0
impstomp    mov #0, startprog
imp2	    mov #0, startprog
	    mov #0, startprog
	    mov #0, startprog
	    jmp impstomp

;;
;; Constants and pointers
;;
jmp0	    jmp 0
jmp1	    jmp 1
jmp5	    jmp 5
jmpvec	    jmp 600+rnaoffset ;make sure jmp points to "virusrna" routine
memptr	    dat #-600
tmp	    dat #0
imp	    mov 0, 1
size	    dat #0
ptr	    dat #0
dest	    dat #0
delta	    dat #0

;;
;; Startup
;;
start	    mov stopper, virusrna	       ;inialize some constants
					       ;  and vectors
	    mov jmp5, tmp		       ;
	    sub jmp0, tmp		       ;Find jmp5-jmp0
	    mov jmp1, delta		       ;
	    sub jmp0, delta		       ;Find jmp1-jmp0

;;
;; Scan loop
;;
mainloop    cmp dabomb, @memptr		       ;scan for nonzero code
	    jmp subvert 		       ;if non zero, subvert it!
s4	    sub #5, memptr		       ;sub 5 from ptr
	    add tmp, jmpvec		       ;add 5 to jmp instruction
tjmp	    jmp mainloop		       ;loop

;;
;; Bombing after subversion
;;
	    mov njmp,   tjmp		       ;fix vector
	    mov memptr, delta		       ;temporary register
	    add #60,    delta		       ;fudge for time-delay
bombit	    cmp @delta, tagid		       ;about to bomb us?
	    jmp bomb			       ;bomb!
	    sub #(endprog-startprog+6), delta  ;skip us!
bomb	    mov dabomb, <delta		       ;bombs away
bjmp	    jmp bombit			       ;loop

;;
;; Execute copy
;;
exec	    spl @dest			       ;fallthrough, execute copy

;;
;; Destroy copy routine, I had problems with spl warriors running it twice
;;
	    mov #(endprog-virusrna+1), size    ;bomb copy routine
	    mov #(endprog-jmp5), jmp5          ;so other subversions die
kill	    mov dabomb, <jmp5		       ;bombs away!
	    djn kill, size		       ;loop

dabomb	    dat 0, 0			       ;die!
njmp	    jmp -4			       ;constant

;;
;; Subvert addresses. Checks for imps, and ourselves
;;
subvert     cmp imp, @memptr		       ;dont try to subvert an imp!
	    jmp s3
	    jmp s4
s3	    cmp tagid,  @memptr		       ;about to subvert ourselves?
	    jmp s2
	    sub #(endprog-startprog+6), memptr ;yes, leap over ourselves
	    jmp mainloop
s2	    mov jmpvec, @memptr		       ;poke jmp vector(subvert!)
	    sub #1, memptr       	       ;sub 1 from ptr
	    add delta, jmpvec		       ;add 1 to jmp vector
	    jmp mainloop		       ;loop

stopper     mov (dabomb-1), 0                  ;constant

;;
;; Copy Routine. Subverted tasks execute this, but we run the final copy!
;;
virusrna    mov dabomb, 0		       ;routine is not reentrant!
					       ;two tasks must not be
					       ;running this at once!

	    spl impstomp		       ;make other program protect us
	    mov jmp1,  tjmp		       ;start bombing routine
	    mov #(endprog-startprog+1), size   ;find size
	    mov #pend, ptr		       ;get ptr at end
	    mov #833, dest		       ;copy 833 ahead
cploop	    mov <ptr, <dest		       ;copy it
	    djn cploop, size		       ;
exc	    add #(start-startprog+1), dest     ;exec beginning of code
	    mov jmp1, bjmp		       ;trigger execution
	    jmp dabomb			       ;die!
					       ;only impstomper remains

tagid	    sub #1234, #4321		       ;tag buffer to prevent
	    sub #1234, #4321		       ;  outselves from
	    sub #1234, #4321		       ;   being subverted
	    sub #1234, #4321		       ;
endprog     sub #1234, #4321		       ;
	    end start
