;redcode-94
;name Miss Playful
;NSFCWT Round 6

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Build up a record of working tactics ...
;strategy ... for unknown/win/lose/tie situations and use them.
;strategy Written in '94 code.
;strategy ... because I had to use Pspace.
;strategy Submitted to NSFCWT Round 6: 18th November 1995

;White warrior that plays the game of Paper-Scissors-Stone in NSFCWT round 6
;Needs to be paired with one opponent exactly half the coresize apart (-d 4000)
;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80

;my/your_hand are used to communicate between players
your_hand   equ (my_hand+CORESIZE/2)
PAPER       equ #1              ;some useful constants
SCISSORS    equ #2
STONE       equ #3

org         start
my_hand     dat 0,0
;
;           Variable part starts here. This is where I decide what hand to
;           use next. I can use the value of the RESULTS cell (0 if lost,
;           1 if won, 2 if drawn last round) and any other values I choose
;           to store in pspace. The hand I decide to show is stored in the
;           B-field of instruction 'my_hand'.
;---BEGIN-VARIABLE-PART-----------------------------------------------------

memory          equ 256                 ; 4^(n-1), where n is the number
                                        ; of previous results to remember

_RESULT         equ #0                  ; our last result
_RESULTS        equ #1                  ; our last n results
_SEED           equ #2                  ; our last pseudo random number
_MOVE           equ #3                  ; our last move
_TACTICS        equ #4                  ; our table of tactics
                                        ; stored in the order ...
                                        ; unknown, unknown, ulwt
                                        ; unknown, loss, ulwt
                                        ; unknown, win, ulwt
                                        ; unknown, tie, ulwt
                                        ; loss, unknown, ulwt
                                        ; loss, loss, ulwt
                                        ; etc.

; load the last round's values ...

start
random          ldp _SEED, #random
move            ldp _MOVE, #move
result          ldp _RESULT, #result
results         ldp _RESULTS, #results

; make the next 'random' number ...

                mul.ab #577, random     
                add.ab #3631, random
                                        
; update the tactic table
                
                add.ba result, switch   ; update according to the result
switch          jmp @1, firstrnd        ; ... first round
                dat #0, loss            ; ... we lost
                dat #0, win             ; ... we won
                dat #0, draw            ; ... we drew

loss                                    ; we didn't win so change tactics ...
draw

update          mov.ba results, tupdate ; lookup the tactic table ...
                div.a #4, tupdate
umask           mod.a #memory, tupdate
                add.a _TACTICS, tupdate
tupdate         ldp _TACTICS, #tupdate
                mov.b tupdate, tempu    ; separate the ulwt tactics
                mov.b tempu, tempp
                mod.ab #4, tempu
                div.ab #4, tempp
                mov.b tempp, temps
                mod.ab #4, tempp
                div.ab #4, temps
                mov.b temps, tempr
                mod.ab #4, temps
                div.ab #4, tempr
                mov.ba results, tempu   ; select the correct tactic ... 
                mod.a #4, tempu
                add.ab #3, *tempu       ; update the tactic ...
                mod.ab #4, *tempu
                mul.ab #4, tempr        ; combine the ulwt tactics ...
                add.b tempr, temps
                mul.ab #4, temps
                add.b temps, tempp
                mul.ab #4, tempp
                add.b tempp, tempu
                mov.ab tupdate, tusave  ; update the tactic table
tusave          stp tempu, _TACTICS
                div.a #4, umask         ; update a simpler situation
                slt.a umask, #4         ; Is there a simpler situation ?
                jmp update              ; Yes, select it ...
                jmp predict             ; No, carry on

firstrnd        add.ab #1, result       ; first round
win                                     ; we won so leave things be

; make the prediction

predict         mov.ba move, nmove      ; okay what's our next move
                mul.ab #4, results      ; add latest result to the list ...
                add.ab switch, results
                mod.ab #memory, results ; remove the oldest result
tryagain        mov.ba results, tlookup ; lookup the tactic table ...
                div.a #4, tlookup
lmask           mod.a #memory, tlookup
                add.a _TACTICS, tlookup
tlookup         ldp _TACTICS, #tlookup
                mov.b tlookup, tempu   ; separate the ulwt tactics
                mov.b tempu, tempp
                mod.ab #4, tempu
                div.ab #4, tempp
                mov.b tempp, temps
                mod.ab #4, tempp
                div.ab #4, temps
                mov.b temps, tempr
                mod.ab #4, temps
                div.ab #4, tempr
                mov.ba results, tempu   ; select the correct tactic ... 
                mod.a #4, tempu
                jmn.b known, *tempu     ; Is it a known situation ?
                div.a #4, lmask         ; No, try a simpler situation
                slt.a lmask, #4         ;   Is there a simpler situation ?
                jmp tryagain            ;   Yes, select it ...
                mov.b random, *tempu    ;   No, pick a move at random
                mod.ab #3, *tempu       ;   making it legal ...
                add.ab #1, *tempu
known           mov.b *tempu, move      ; Yes, use the current tactic
                sub.ab #1, move         ; remove coding offset
                mul.ab #4, tempr        ; combine the ulwt tactics ...
                add.b tempr, temps
                mul.ab #4, temps
                add.b temps, tempp
                mul.ab #4, tempp
                add.b tempp, tempu
                mov.ab tlookup, tlsave  ; update the tactic table
tlsave          stp tempu, _TACTICS
                add.ba move, nmove
                mod.a #3, nmove
                jmp nmove

; save the new position ...

nmove           stp #nmove, _MOVE
                stp random, _SEED
                stp results, _RESULTS
                add.a #1, nmove         ; make our move ...
                mov.ab nmove, my_hand
                jmp wait

tempu           dat 0, 0                ; workspace for table
tempp           dat 0, 0                ; manipulation
temps           dat 0, 0
tempr           dat 0, 0

;---END-VARIABLE PART-------------------------------------------------------
;           End of variable part. I wait for the other player to show his hand.
;           I then analyze the outcome of the game.
;
wait        jmz.b wait,your_hand
work        mov.b your_hand,#work
            sub.b my_hand,work          ;your_hand minus my_hand, loss=1,-2
            add #2,work                 ;loss=3,0
            mod #3,work                 ;loss=0
live        jmn live,work               ;die if lost, live if won or drawd

            end




MicroSoft Network may not carry this message without license
 to do so.  License to carry this message requires a fee of 
 $1000, payable within 30 days to Derek Ross.  Appearance of this 
 message on MicroSoft Network constitutes an agreement to terms.





