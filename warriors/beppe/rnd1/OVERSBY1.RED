Hi Beppe,

The code following is my tournament entry, Falcon v0.5.  I chose this
because I expect a pspacer opponent along the lines of "Ties, Ties Ties".

A quick word on the strategy:  Falcon is a pspacer switching two components,
a one-shot scanner and an imp/stone.  The plogic is a little different to
most, it switches to the scanner on a tie.  It also runs the imp/stone for
two losses before switching back to the scanner.  I hope this improves my
score against bombers like Tornado/Torch.

The imp/stone is based on Simple which is quite similar to Juliet Storm.
It now has a d-clear and 16 point die-hard imp-spiral.  Both the imp
launch and the stone are booted away from the main body.  The scanner is
Tsunami v0.3, a one-shot with an imp-gate.  It is quite effective against
papers and older imp/stones like Juliet and Impfinity but loses to Die
Hard, Ompega and Rosebud :-(

To summarize, I would expect to score quite well against p-spacers thanks
to the confusing (?) switch on tie.  Papers without imps are easily defeated.
It scores OK against bombers as well.  QScans are a little bit of a problem
but the score is still reasonable.  The only opponent type I am really
worried about is a die-hard type.

Ian

;redcode-94
;name Falcon v0.5
;author Ian Oversby
;strategy P-Spacer
;strategy Switching Scanner and Stone/Imp
;assert 1

org prev

plc     equ     253             ; for the P-Space table

impstep equ     2667            ; Impish v0.1
sval    equ     5350
ival    equ     3350
dist    equ     3
gat1     equ     (init-3-dist)

gate1   equ     (gate-3)        ; Tsunami v0.3
final   equ     (cptr+1)
first   equ     106
half    equ     15
step    equ     (half*2)
tval    equ     14 + (180 * 15)

;;------------------------------------------------------------

prev    LDP.AB  #0,     #0      ; Results from previous round
        LDP.A   #plc,   table
        SNE.AB  #0,     prev    ; Did we lose?
        ADD.A   #1,     table
        SNE.AB  #2,     prev    ; Was it a draw?
        MOV.A   #0,     table
        MOD.A   #3,     table
        STP.AB  table,  #plc

table   JMP.B   @0,     tsunami ; Run this on draw
        DAT.F   $0,     $simple
        DAT.F   $0,     $simple

;;------------------------------------------------------------

        DAT.F   $0,     $0
        DAT.F   $0,     $0      ; Scanned
        DAT.F   $0,     $0

tsunami MOV.I   {pos,   <tptr
for 9
        MOV.I   {pos,   <tptr
rof
        SPL.B   *tptr,  <-200

tptr    DIV.F   #tval-7,#tval

        DAT.F   $0,     $0
        DAT.F   $0,     $0      ; Scanned
        DAT.F   $0,     $0

gate    DAT.F   -25,    final-gate1+3
        SPL.B   #-20,   #20
bomb    SPL.B   #first+half, #first
sloop   SUB.F   cons,   @scan
scan    SNE.I   *bomb,  @bomb        
        JMZ.B   sloop,  #0      ; From Torch
cons    SPL.B   #-step, >-step
cloop   MOV.I   @cptr,  >gate1
        MOV.I   @cptr,  >gate1
cptr    DJN.B   cloop,  {bomb

pos     DAT.F   $0,     $0
        DAT.F   $0,     $0
        DAT.F   $0,     $0
        DAT.F   $0,     $0      ; Scanned
        DAT.F   $0,     $0

;;------------------------------------------------------------

mimp    SPL.B   1,      <-500
        SPL.B   1,      {-500
        SPL.B   1,      {-500
        SPL.B   1,      <-500

        SPL.B   2,      {-500
        JMP.B   imp,    <-500
        ADD.A   #impstep, -1
die     DAT.F   $0,     $0
imp     MOV.I   #impstep, *0

        DAT.F   $0,     $0
        DAT.F   $0,     $0
        DAT.F   $0,     $0
        DAT.F   $0,     $0
        DAT.F   $0,     $0      ; Scanned
        DAT.F   $0,     $0

simple  MOV.I   {sptr,  <sptr
for 6
        MOV.I   {sptr,  <sptr
rof

for 4
        MOV.I   {iptr,  <iptr
rof
        JMP.B   gap,    <-200

        DAT.F   $0,     $0
        DAT.F   $0,     $0      ; Scanned
        DAT.F   $0,     $0

gap     MOV.I   {iptr,  <iptr
for 4
        MOV.I   {iptr,  <iptr
rof

        SPL.B   @sptr,  <-200
        SUB.AB  #dist,  sptr
        MOV.I   gat,    @sptr
        SPL.B   @iptr,  <-200

iptr    DIV.F   #imp+1, #ival
sptr    DIV.F   #gat,   #sval

        DAT.F   $0,     $0
        DAT.F   $0,     $0
        DAT.F   $0,     $0      ; Scanned
        DAT.F   $0,     $0

init    SPL.B   #0,     <-94
stone   SPL.B   #95,    <-95
loop    MOV.I   {0+95,  hit-95
        ADD.F   stone,  loop
hit     DJN.F   loop,   <-98
        MOV.I   init-dist, >gat1
last    DJN.F   -1,     >gat1

gat     DAT.F   >2667,  #3+hit-gat1

;;------------------------------------------------------------

for 3
        DAT.F   $0,     $0
rof

end
-- 
------------------------------------------------------------------------------
E-mail     	: ee31io@surrey.ac.uk
Disclaimer      : No-one, but me, believes any of this.

Murphy's laws   : If anything inconvenient can happen it will.
		  If anything bad can happen it will... repeatedly.

   	"Please don't insult my ignorance"           - Anonymous 
	"Behind the smile lies the assassin's blade" - Anonymous
	
	I know it's not very eloquent but I'm working on it.
------------------------------------------------------------------------------
