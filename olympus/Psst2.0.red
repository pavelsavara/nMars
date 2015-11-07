;name Psst 2.0
;author Robert Macrae
;strategy Adapted Psst for '98 tournament
;strategy Adaptive play based on last two plays and last result
;strategy Based on simplified NSFCWT PSST
;strategy Still no imp spiral, but remember the garlic Paul? ;-]

;assert VERSION >= 80

; --------------------------------------------------------------------------

; P-Space Variables. Note I use an array [0..2,0..2,0..2] which
;  extends from 9 to 35.  

_Res1   EQU #0
_Array  EQU #9
_Me1    EQU #72
_Me2    EQU #73
_Res2   EQU #74
_Key    EQU #75

;; ASSERT ((Array %% 9) == 0)      ; broken assert removed by Planar

; --------------------------------------------------------------------------

; Slow scanner with a decoy.

     for 1
        dat     1, 1
     rof

; --------------------------------------------------------------------------

BrainWash                        ; Rare but damaging...

Check   LDP     _Key,  #0
        SUB     #3055, Check
        JMZ.b   UpdateScores,  Check ; If key is in place execute engine

InitLp  STP     #200, _Array+26  ; Otherwise re-initialise array
        STP     #200, _Array+13
        NOP     <-1,   <-2
        DJN.b   InitLp, #14      ; 52 cycle loop :-(
Lock    STP     #3055, _Key      ; Store the flag and fall through to update
        JMP     NoRead           ; Skip reading the other P-variables

; --------------------------------------------------------------------------

UpdateScores

        LDP.a   _Me1, Me1       ; My last play
        LDP.ab  _Res1, Res1     ;  and Result (which points into score table)
Me2     LDP     _Me2, #0        ; Preceding play
Res2    LDP     _Res2, #0       ;  and Result.

NoRead  ADD.ba  Me2,  GetSco
        MUL.a   #3,   GetSco
        ADD.ba  Res2, GetSco
        MUL.a   #3,   GetSco
        ADD.a   Me1,  GetSco    ; GetSco now contains the 
        MOV.ab  GetSco, StorSco ;  index into the P-array of scores

GetSco  LDP.a   _Array/9, StorSco  ; Get appropriate score
        ADD.a   @Res1, StorSco     ; Add latest score
StorSco STP     #0,    #0          ; And store back in same location.
        MOV.i   #0,    -1

        MOV.i   0,    InitLp       ; Clean up the initialisation 
        MOV.i   0,    InitLp+1     ; STPs while I'm at it.
        MOV.i   0,    Lock

; --------------------------------------------------------------------------

CollectScores

        ADD.a   Me1,  PapC        
        MUL.a   #3,   PapC
        ADD.ba  Res1, PapC
        MUL.a   #3,   PapC      ; PapC now points to first element in row
        ADD.a   PapC, SciC      ; Complete the other two indexes 
        ADD.a   PapC, StoC      ;

PapC    LDP     _Array/9, #0    ; Get the scores of each of the choices
SciC    LDP     #1, #0          ;  conditioned on the last round Me and Res.
StoC    LDP     #2, #0          

; Re-order in ascending preference as SLT chooses later of ties.
; Ensure that MyPlay.a is initialised to #0.

        SLT.b   SciC, PapC   
         MOV.a  #1,   MyPlay
        SLT.b   SciC, PapC      ; Update PapC to SciC if Sci is best so far
         MOV.b  SciC, PapC
        SLT.b   StoC, PapC       
         MOV.a  #2,   MyPlay      
        SLT.b   StoC, PapC      ; Update PapC to highest score for ABW check.
         MOV.b  StoC, PapC
        SLT.b   PapC, #400      ; If any score > 400, flag brainwash.
         STP    #0,   _Key

; --------------------------------------------------------------------------

DoMove
	
StMe1   STP.ab  MyPlay, _Me1           ; Store this play for use next time
Me1     STP.ab  #0,     _Me2           ; and previous play 
        STP.b   Res1,   _Res2          ; and previous result (0,1,2)
        MOV.i   #0,     {0             
        DJN     -1,     #4

MyPlay  JMP     @0, PapAd              ; Make the play!
        DAT     0,  SciAd              ;  (Was it *really* worth all that?)
        DAT     0,  StoAd

; --------------------------------------------------------------------------

ScoreTable

; Res1.b indexing into the .a fields converts -1,0,1,2 code into
; points-1. I avoid DAT 0,0 cells to slow the scanner.

        DAT     0,  1            ; (Should not be needed)
Res1    DAT     -3, 0            ; Res1 is stored in b field
        DAT     3,  1            ; a field converts result into score
        DAT     -1, 1

; Not quite enough space to sqeeze in stone?

        dat     0, 0                           
        dat     0, 0                           
        dat     0, 0                        ; Scan here 
        dat     0, 0                        
        dat     0, 0                         
        dat     0, 0                        
        dat     0, 0                         

; ---------------------------------------------------------------
; Scanner is too big to miss, so just ensure that the carpet starts
; in the last couple of cells to give a draw not a loss. 15 cells.

step  EQU    9
ptr   EQU    (bomb-5)
SciAd EQU    mptr                       ; Note ruling that start-point
                                        ; need not be kill.

      dat    0,0                        ; Pointer must be dat 0,0 
      dat    0,0                        
      dat    0,0                         
      dat    0,0                        ; Scan and miss here 
      dat    0,0                         

bomb: spl    #1,{1                      ; for testing only....
kill: mov    bomb,<ptr
mptr: mov    >ptr,>ptr
      jmn.f  kill,>ptr
a:    add    #step+1,@mptr              
scan: jmz.f  a,<ptr                     
      slt    @mptr,#btm-ptr+3           ; Stun starts here
      djn    kill,@mptr                 ; Scan and hit here
      djn    a,#16
btm:  jmp    a,{kill

; ---------------------------------------------------------------
; Garlic counterstrike wins some extra scanner vs scanner battles

      NOP    0,       0                 ; End carpet here
      MOV    bomb-1,  >ptr              ; [ how convenient  :-]       
      JMP    -1,      >ptr

; ---------------------------------------------------------------
; Paper is also too long for scanner to miss; stun at end. 12 cells.

TSTEP equ 1800
CSTEP equ 3740
NSTEP equ -1922
FSTEP equ 1870

PapAd
split   spl     1,              <-200       
        spl     1,              <-300       
        mov.i   -1,             0
tim1    spl     @tim1,          }TSTEP
        mov.i   }tim1,          >tim1
cel1    spl     @cel1,          }CSTEP
        mov.i   }cel1,          >cel1       ; Stun here with L4 carpet 
        mov.i   {-FSTEP,        <FSTEP      ; Scan and hit here
        mov.i   {cel1,          <ncl1       
ncl1    jmp     @ncl1,          >NSTEP


; ---------------------------------------------------------------
; stone will be missed completely. 

StoAd   equ     dbomb+1

        dat     0, 0                        ;  
        dat     0, 0                        ;  

dbomb   dat     >-1, >1
        spl     #0, <-100
        mov     dbomb, tar-197*3500
tar     add     #197, -1                    ; gets bombed to start coreclear
        djn.f   -2, <-1151

        END     BrainWash
