;redcode-94
;name Ever Cautious
;author Ian Oversby
;strategy P-Spacer with permanent switch
;strategy Firstly a small stone
;strategy then Tornado -> d-clear
;assert 1

org first

plc     equ     250     ; P-Space

dis     equ     2150    ; Boot distances

step    equ     -45     ; Torn Limb
gate    equ     (cbomb-1)


;------------------------------------------------------------

for 12
        SPL.B   #1,     >1
        STP.AB  #1,     <1
        JMP.B   #1,     <1
rof

for 12
        SPL.B   #1,     <1
        STP.AB  #1,     >1
        JMP.B   #1,     >1
rof

;------------------------------------------------------------

first   LDP.A   #plc,   pval    ;load wins/losses
        ADD.A   pval,   check
        MOD.A   #31,    check
        JMN.A   torn,   check   ;permanent switch

res     LDP.AB  #0,     #0
        SNE.AB  #0,     res     ;check for loss
lost    ADD.A   #31,    pval
        SNE.AB  #1,     res     ;check for win
won     SUB.A   #31,    pval
        STP.AB  pval,   #plc

;------------------------------------------------------------

boot    MOV.I   <loc,   <pos
for 5
        MOV.I   <loc,   <pos
rof
        SPL.B   @pos,   <-200
pos     DIV.F   #dis,   #dis

        DAT.F   $0,     $0

;----------------------- Tiny Limb --------------------------

pst     SPL.B   #76,    <-76
ploop   MOV.I   {0+76,  phit-76
        ADD.F   pst,    ploop
phit    JMP.B   ploop,  <-79
        MOV.I   76,     <-76
        JMP.B   -1      <-76-2667

loc     DAT.F   $0,     $0

;------------------------------------------------------------

check   DAT.F   $7781,  $0      ; 31 / 8
pval    DAT.F   $0,     $0

;------------------------------------------------------------

torn    MOV.I   <tloc,  <tpos
for 11
        MOV.I   <tloc,  <tpos
rof
        SPL.B   *tpos,  <-200
tpos    DIV.F   #dis-11,        #dis

;----------------------- Torn Limb --------------------------

cbomb   DAT.F   >2667,  #15
bombs   SPL.B   #(step+1),  -step           ;hit spl
start1  SUB.F   incr,   @b1           
stone   MOV.I   (0*step)+jump+1,*(1*step)+jump
b2      MOV.I   bombs,  @stone
b1      MOV.I   bombm,  *stone
jump    JMZ.B   start1, #0         ;hit by spl
clr     MOV.I   cbomb,  >gate
djmp    DJN.F   clr,    >gate
        JMP.B   clr,    >gate-2667
incr    DAT.F   >-3*step,>-3*step      
bombm   JMP.B   #1,     {1

tloc    DAT.F   $0,     $0

;------------------------------------------------------------

for 12
        SPL.B   #1,     }1
        STP.AB  #1,     *1
        JMP.B   #1,     {1
rof

for 12
        SPL.B   #1,     {1
        STP.AB  #1,     }1
        JMP.B   #1,     }1
rof

;------------------------------------------------------------

end
