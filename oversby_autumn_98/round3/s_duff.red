;name Upside Ya head
;author Simon Duff
;strategy P-Warrior
;strategy   ->  Simple Vampire       (SCISSORS)
;strategy   ->  Stone/Imp            (ROCK)
;assert 1

for 0
    Just got home from Snoop Dogg's First Australian Concert - and then
    I realise I still have a Core War Warrior to make. So I just pulled
    various codes from place in the hope if makeing something that works.
    Then nuked it all, and decided to write a P-Warrior (my first, BTW).
    This warrior kills my Grey occassionally, but most often loses or ties.
    Bah - another round where I'm gonna do poorly!
rof

;==[ PSPACER ]===========================================================
;  The pSpacer is based on code by P Kendall ( Core Warrior 57? )
;========================================================================

pResult equ     0
pNum    equ     2
pSpace1 equ     1               ; used to store the current strategy
pSpace2 equ     2               ; used to store the loss counter
pLosses equ     3               ; how many losses before we switch

pGo     ldp.ab  #pResult, #0
        ldp.a   #pSpace1, pTable
pJump   jmn.b   pWin, pGo
pLoss   ldp.ab  #pSpace2, #0
        nop.f   >pLoss, }-1000
        mod.ab  #pLosses, pLoss
pThink  jmn.b   pWin, pLoss
        nop.f   }pTable, }-2000
        stp.ab  pTable, #pSpace1
pWin    stp.b   pLoss, #pSpace2
        mod.a   #pNum, pTable
pTable  jmp.a   @0, main
        dat.f   0, vamp
;==[ ROCK ]==============================================================
;  Rock Element is "Night Crawler Stone" by Wayne Sheppard
;========================================================================
main    SPL     0, <-1001
        MOV     <21, 1+2234
        SUB     1, -1
        DJN     -2, <-2234
;==[ SCISSORS ]==========================================================
;  Very (Too!) Simple vampire
;========================================================================
const EQU 2365

        SPL     0            ; self splitting
vamp    MOV     ptr, @ptr    ; throw pointer
        ADD     data, ptr    ; update pointer
        DJN     vamp, <2339  ; loop back + non-lethal attack

ptr     JMP     trap, ptr    ; pointer to...

trap    SPL     1, -100      ; ...here
        MOV     data, <-1
        JMP -2
data    DAT #const, #-const
        end     pGo

