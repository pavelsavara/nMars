;redcode-94 quiet
;name Negative Energy
;author Zul Nadzri
;kill Negative Energy
;strategy  Pspacing Stunners.
;assert 1
;-------- OVERVIEW ---------- 
;(First Round BDECWT : Submitted 8 Oct 1996) 
;I use stunner in this tournament to steal some points against papers. 
;However, this warrior would have difficulties in defeating (escaping?) 
;all those scanners. I need 'stone' to strike at the scanners before 
;proceeding with the core clear. That's why I included warrior 2 (credit 
;to 'Storm') to do some bombing, and then run those stun-n-clear process, 
;which is the theme of this campaign. END.

;-------- Variables ---------

gate1   equ     gate-1
desti   equ     5678
minus   equ     100             ;no decoy at all.

;-------- Warrior 1 ---------

w3      mov     gate+0, desti   ;booting Warrior 1 away.
        mov     gate+1, desti
w11     mov     gate+2, desti
        mov     gate+3, desti
        mov     gate+4, desti
        mov     gate+5, desti
        mov     gate+6, desti
        mov     gate+7, desti
        jmp     desti+w11, <1234

gate    dat     -5,     jump-gate1+5    ;stunner and core clear
        spl     #-515,  jump-gate1+505
w1      spl     #-10,   #10
        mov     @jump,  >gate1
        mov     @jump,  >gate1
jump    djn     w1+1,        {gate+1
        jmp     w1+1,        >gate1


;-------- Warrior 2 --------

boot    EQU Storm+4000          ;I need support for the first warrior. 
step    EQU 155                 ;again, credit to 'Storm'.
init    EQU step
away    EQU 18

FOR     100-minus               ;no decoy.
        spl #w2, #x
        ROF
x       DAT #2, #1

w2      MOV Storm+4, boot+4     ;booting away.
        MOV Storm+3, <w2
        MOV Storm+2, <w2
        MOV Storm+1, <w2
        MOV Storm+0, <w2
        MOV Storm-1, <w2
        MOV core, away+boot
        MOV fire, boot+Storm-ptr-away
        JMP boot, <2000

ptr     SPL 0, <Storm-away       ;bombing and then dclear. 
Storm   MOV <1-step, 2+step
        SUB Storm+away, -1
        JMP -2, <-2000
clear   MOV @Storm, <Storm+away
        DJN -1, <3975
core    DAT #step, #0-step
fire    DAT <Storm-ptr-away-1, #0


;----------- Reading Pspace Data ------------ 
;  (credit to those who programmed this)

toffs   equ     (table-tindex)
TIDX    equ     72                           ;pick your own number here.

starter LDP.ab  #TIDX,          tindex 
result  LDP.ab  #0,             #0
        ADD.b   result,         tindex
        SEQ.ab  #0,             tindex       ;brainwash check - zero
        SLT.b   tindex,         #endtab+1-tindex ;brainwash check-too large 
        MOV.ab  #fsttab-tindex, tindex       ;use data at fsttab on first
                                             ;round and when brainwashed
        STP.ab  @tindex,        #TIDX
        MOV.ba  @tindex,        jumper
jumper  JMP     0
fsttab  DAT     #toffs+0,       #w3-jumper   ;this is used for the first 
round
                                             ;and when brainwashed
tindex  DAT     #0,             #0           ;index into table 
table   DAT     #toffs+3,       #w2-jumper   ;w1->w2 on loss
        DAT     #toffs+0,       #w3-jumper   ;w1->w1 on win 
        DAT     #toffs+3,       #w3-jumper   ;w1->w1 on tie 
        DAT     #toffs+6,       #w3-jumper   ;w2->w1 on loss 
        DAT     #toffs+3,       #w2-jumper   ;w2->w2 on win
endtab  DAT     #toffs+3,       #w2-jumper   ;w2->w2 on tie

        end     starter
