;redcode-94
;name Psst
;author Robert Macrae
;strategy Adaptive play based on frequencies of opponent choices 
;strategy conditioned on previous round. Use random numbers only as
;strategy last resort. Handshake for 1000/0/0 against self.
;strategy      (I'd suggest NO self fights this round...)
;strategy Hope other players can't write random number generators :>

; I did not have time to integrate imp spiral, but smell that garlic :)
; Hope that _first_ score counts in self-fights!

;Warrior that plays the game of Paper-Scissors-Stone in NSFCWT round 5
;Needs to be paired with one opponent exactly half the coresize apart 

;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80

;my/your_hand are used to communicate between players
your_hand   equ (my_hand+CORESIZE/2)
PAPER       equ #1              ;some useful constants
SCISSORS    equ #2
STONE       equ #3

org         start
my_hand     dat 0,0

;           Variable part starts here. This is were I decide what hand to
;           use next. I can use the value of the RESULTS cell (0 if lost,
;           1 if won, 2 if tied last round) and any other values I chose
;           to store in pspace. The hand I decide to show is stored in the
;           B-field of instruction 'my_hand'.

;---BEGIN-VARIABLE-PART-----------------------------------------------------

; P-Space Variables. Note I also use an array [1..3,1..3,1..3] which maps 
; onto 21 to 63. Spurious accesses will occur in the first two rounds, so
; I keep other variables up above this space.

_Result EQU #0
_Rounds EQU #71
_Me1    EQU #72
_Me2    EQU #73
_Him2   EQU #74
_STRAT  EQU #75
_SlowP  EQU #76
_IsSlow EQU #77
_Friend EQU #78
_Rand1  EQU #79
_Rand2  EQU #80
_Score  EQU #81

; --------------------------------------------------------------------------

start

Top1    JMP     UpdateFreq      ; Collects result and updates frequencies
Top11   SNE     Result, #-1     ; On first move
	 JMP     HandShake      ;  check for self-fights
Top2    JMP     HandleSlow      ; Checks for slow cycle and if found, moves
Top3    SEQ     IsSlow, #1      ; Unless I believe slow cycle model
	 JMP    CollectCounts   ;  make best move based on past frequencies
Top4    SNE     Rounds, #1      ; If second round
	 JMP    MoveTwo         ;  apply special rule   
Top41   JMP     Random          ; Make random move if I'm losing badly
Top5    JMP     DoMove          ; Check handshake, and, not play and exit.

MyPlay  DAT     #0, #0          ; (Global variable?!)

; --------------------------------------------------------------------------

UpdateFreq

Result  LDP     _Result, #0
Rounds  LDP     _Rounds, #0     
Me1     LDP     _Me1, #0        ; My last play
Me2     LDP     _Me2, #0        ; and preceding.
Him2    LDP     _Him2, #0
	MOV.b   Me1, Him1
	ADD.b   Result, Him1
Him1    MOD.ab  #3, #0          
	ADD.ab  #1, Him1        ; Deduce his last from Result and my last
	SNE.ab  #-1, Result 
	 MOV.ab #0, Him1        ; Correct for first round

Ptr     MUL.b   Him2, #16
	MUL.b   Me2, #4
	ADD.b   -1, Ptr
	ADD.b   Him1, Ptr       ; Use past moves to index into an array
	MOV.ba  Ptr, GetCnt
	MOV.b   Ptr, StorCnt
GetCnt  LDP     #0, #0          ; and get appropriate frequency
	ADD.ba  GetCnt, StorCnt
StorCnt STP     #1, #0          ; increment and store.

	SNE.ab  #-1, Result 
	 STP     #1000, _Score  ; Initialise _Score to 1000
GetScor LDP     _Score, #0      ; Get cumulative score (so I can tell if
	MOV.ba  GetScor, StoScor ; I should play randomly)
	SNE.ab  #1, Result
	 ADD.a  #1, StoScor
	SNE.ab  #0, Result
	 ADD.a  #-1, StoScor
StoScor STP     #0, _Score      ; update and store.

	JMP     Top11           ; 'Return'

; --------------------------------------------------------------------------

HandShake

	MOV     Hand, start+1158               ; Store a flag
	SEQ     start+1158, start+1158+4000    ; If opponent didn't, exit 
	 JMP    Top2 
	STP     #1, _Friend                    ; Flag fact we're friends
	SEQ     @start+1158+4000, >start+1158  ; If I move second, then
	 JMP    Top2                           ;  return and play normally.
	MOV.ab  #1, MyPlay                     ; Otherwise play paper
	JMP     Last                           ; (Structure be damned).

; This method is messy. I hit some problem with both versions sharing  
; P-Space, so I couldn't simply store an instruction on what to play.
; Having "fixed" the first round as a win, I then fix all subsequent
; rounds so that the previous winner wins again.

Hand    DAT >2667, #4000        ; .B points to to other flag.

; --------------------------------------------------------------------------

HandleSlow      

; Runs a copy of the slow-rotation code and bets with it if it has worked 
; 5 times or more _and_ has never failed.

IsSlow  LDP     _IsSlow, #0
	
	SNE.ab  #2, IsSlow      
	 JMP    Top3            ; Slow prediction has failed in the past.	
	SNE.ab  #5, Rounds      ; After 5 hits, move from observing 
	 MOV    #1, IsSlow      ; (IsSlow=0) to acting (IsSlow=1)

SlowP   LDP     _SlowP, #0      ; Get last prediction
	SEQ.b   SlowP, Him1     ; Did slow prediction succeed
	 MOV    #2, IsSlow      ; Store the fact that slow prediction failed.

strgy   ldp     _STRAT, #strgy            
	add     #1, strgy       ; next strategy no matter what            
	stp     strgy, _STRAT   ; but slowly            
	div     #5, strgy            
	mod     #3, strgy       ; 1111222223333311111..
store   add.ab  #1, strgy            
	mov.ba  strgy, StrSlP   
StrSlP  STP     #0, _SlowP      ; Store prediction for next time

	MOD.ab  #3, strgy
	ADD.ab  #1, strgy       ; convert prediction to winning play   
	SNE     IsSlow, #1
	 MOV    strgy, MyPlay   ; Make play if slow prediction is working.
	MOV.ba  IsSlow, StorSlo
StorSlo STP     #0, _IsSlow     ; Store IsSlow status

	JMP     Top3            ; 'Return'

; --------------------------------------------------------------------------

CollectCounts

Ptr2    MUL.b   Him1, #16       ; Find appropriate row of array
	MUL.b   Me1, #4
	ADD.b   -1, Ptr2
	ADD.ba  Ptr2, PapC      ; and get all 3 alternatives
	ADD.ba  Ptr2, SciC
	ADD.ba  Ptr2, StoC
PapC    LDP     #1, #0          ; This gets frequencies conditioned on  
SciC    LDP     #2, #0          ; Me1 and Him1 ie on the last round.
StoC    LDP     #3, #0          

PapSc   MUL.b   StoC, #3        ; Anticipated score for playing paper
	ADD.b   PapC, PapSc
SciSc   MUL.b   PapC, #3        ; ... scissors
	ADD.b   SciC, SciSc
StoSc   MUL.b   SciC, #3        ; ... and stone
	ADD.b   StoC, StoSc

BestSc  MOV     PapSc, 0        ; Find the best score
	SLT.b   SciSc, BestSc   
	 MOV     SciSc, BestSc
	SLT.b   StoSc, BestSc
	 MOV     StoSc, BestSc

	SNE.b   PapSc, BestSc   ; Store the best move (if tie, later)
	 MOV     #1, MyPlay     ; in MyPlay
	SNE.b   SciSc, BestSc
	 MOV     #2, MyPlay
	SNE.b   StoSc, BestSc
	 MOV     #3, MyPlay
	
OddRnd  MOV.b   Rounds, 0
	MOD.ab  #2, OddRnd 
	JMZ     Top4, OddRnd    ; On even rounds, Return
	 
	 SNE.b  SciSc, BestSc   ; On odd rounds, use earlier of ties
	  MOV   #2, MyPlay      ; (to avoid bias towards stone.)
	 SNE.b  PapSc, BestSc   
	  MOV   #1, MyPlay      

	JMP     Top4            ; 'Return'

; --------------------------------------------------------------------------

MoveTwo

	MOV.b   Him1, MyPlay    ; Get his first move
	MOD.ab  #3, MyPlay      ; and play whatever beats it. 
	ADD.ab  #1, MyPlay      ; Speeds lock on constant strategies.	
	JMP     Top41           ; 'Return'
	
; --------------------------------------------------------------------------

Random
	SLT.ab  #100, Rounds    ; If less than 100 rounds
	 JMP    Top5            
	SLT.ab  StoScor, #990   ; or I am less than 10 behind
	 JMP    Top5            ;  then keep trying to predict.

; otherwise, generate a random play.

Rand1   LDP     _Rand1, #0      ; Linear congruential generators, so     
Rand2   LDP     _Rand2, #0      ; don't need initialising (I hope)     

	MOV.b   Rand1, Count
Count   MOD     #5, #0          ; Number of times to churn generator

Reroll  MUL     #39, Rand1      ; Roll those dice (#39 is a not as 
	ADD     #13, Rand1      ; prime as I thought.)
	MOD     #73, Rand1
	
	MUL     #31, Rand2      ; Two different, weak generators will 
	ADD     #23, Rand2      ; be stronger when combined...
	MOD     #71, Rand2      

	SUB.ab  #1, Count
	SLT.ab  #6, Count
	 JMP     Reroll, Count  ; Churn 1-5 times.

	MOV.ba  Rand1, StRand1
	MOV.ba  Rand2, StRand2    
StRand1 STP    #0, _Rand1
StRand2 STP    #0, _Rand2       ; Update state

Out     ADD.b  Rand1, #71
	SUB.b  Rand2, Out       
	MOD.ab #72, Out         ; Combine (should be 71 or 73?)  
	
	DIV.ab #8, Out          ; Drop tail of low digit
	MOD.ab #3, Out          ; Drop head of high digit
	ADD.ab #1, Out          ; Convert to a play
	MOV.b  Out, MyPlay      ; and store

	JMP Top5

; --------------------------------------------------------------------------

DoMove

	MOV.ba  MyPlay, StMe1           ; Update record of plays 
	MOV.ba  Me1, StMe2              ; for last two games 
	MOV.ba  Him1, StHim2
	
	ADD.ba  Rounds, IncRnd          ; Update round counter
IncRnd  STP     #1, _Rounds

StMe1   STP     #0, _Me1                ; Store state
StMe2   STP     #0, _Me2                
StHim2  STP     #0, _Him2               

Friend  LDP     _Friend, #0
	JMZ     Last, Friend            ; If I am playing myself,
	 SNE.b  Result, #1
	  MOV.ab #2, MyPlay              ;   Winner plays scissors
	 SNE.b  Result, #0
	  MOV.ab #1, MyPlay              ;   Loser plays paper

Last    MOV.b   MyPlay, my_hand         ; Make the play!

;---END-VARIABLE PART-------------------------------------------------------
;           End of variable part. I wait for the other player to show his hand.
;           I then analyze the outcome of the game.
;
wait        jmz.b wait,your_hand
work        mov.b your_hand,#work
	    sub.b my_hand,work          ;your_hand minus my_hand, loss=1,-2
	    add #2,work                 ;loss=3,0
	    mod #3,work                 ;loss=0
live        jmn live,work               ;die if lost, live if won or tied

	    end


I hope I have defeated (defeatured? debugged?) the word-wrap this time...



Regards,  Robert Macrae



