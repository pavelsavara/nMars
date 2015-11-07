; Memory 1.0           Chris Beauregard           Dec 1,1991

; INTRODUCTION 
; This is an implementation of a concept called "memory
; bombing."  A program will, somehow, find the location of
; a program, and "remember" its location. The program then
; has the locations available for later use, be it bombing,
; vampire fangs, or anything else... 

; METHOD
; Sends out Howitzer fangs, and as data comes in, puts the
; locations at the end of the program.  Every once in a while
; it bombs the area.

; Howitzer fangs, btw, are derived from a program I wrote
; called <duh> Howitzer.  Instead of having the target jump
; to where we are, it just returns its address relative to
; us back to a certain location, and we do something with it.
; Howtizer would bomb the area and then replace the fang.
; Combined with the PCT command on the fangs, this could
; kill just about anything...

; SPECIFICS
; The main loop does a typical vampiric fang placement, the
; fangs being modified so that instead of the program jumping
; back, it returns its location to gotone and dies.

; If the main program finds something in gotone, it adds it
; onto the end of a series of target locations, and increments
; the number of known targets.

; After every 100 fangs placed, the main program goes and
; bombs all target addresses known.  This value could be
; changed depending on preferences.

; COMMENTS
; Very deadly to regenerating programs.  At least the ones
; that regenerate in the same location (i.e. Five Musketeers)

; As the number of target locations increases, the length of
; the bomb time increases.  This could be a problem.

; No protection from imp based programs, and non-mobile.  It's
; just a test program though.

; The fang placement is way too slow.  Using ICWS standard
; opcode would change that.

; Does not use ICWS standard.  Uses original A.K. Dewdney,
; with 1985 SPL opcode added.  For R.Martin Mac version of
; Core Wars, 1985

	org start

target  dat 63                  ; target for fang drops
fang    mov bite,@bite          ; basic fang code
bite    dat -34                 ; return value for fang
                                ; points to gotone

start   mov #63,target          ; set fang pointers
        mov #-34,bite
mainlup jmg got,gotone          ; if we have a return, process
        add #9,target           ; place fangs
        jmz start,target        ; uses standard vampiric
        mov bite,@target        ; fang placement
        sub #1,target
        mov fang,@target
        sub #8,bite
        djz memory,count        ; countdown for memory bomb
        jmp mainlup             ; loop back
memory  mov #100,count          ; memory bomb.  reset counter
        jmz mainlup,numgot      ; if nothing, return
        mov numgot,curgot       ; set for attack loop
        add #1,curgot
loop    mov #-5,target2         ; setup for bomb.  
        sub @curgot,target2
        mov #10,attacks         ; we bombs 10 cells at target
                                ; area.
loop2   mov #0,@target2         ; main bomb loop
        add #1,target2
        sub #1,attacks
        jmg loop2,attacks
        sub #1,curgot
        cmp curgot,#1
        jmp mainlup
        jmp loop
got     add #1,numgot           ; add a target point
        mov gotone,@numgot
        mov #0,gotone           ; reset gotone
        jmp mainlup+1
count   dat 100

@34
target2
gotone  dat 0                   ; where fangs return values
attacks dat 0
curgot  dat 0
numgot  dat 0                   ; number of known targets
                                ; points to last in series
; target data starts here, as it's added.
;CB
