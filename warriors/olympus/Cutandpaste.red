;redcode-94
;name Cut and paste
;author Ilmari Karonen
;assert CORESIZE==8000
;strategy I'm too tired to write anything special for this last round, so I
;strategy just, um, borrowed Paul Kline's little stones from Corewarrior 65
;strategy and slapped in a Q^2 scan..

        ORG start

QS      EQU 100              ; Unmodified from Benj's Revenge
QD      EQU 4000             ; Ditto.
QB      EQU (start+14*QS)    ; Ditto.
CR      EQU (fnd-which)
datz    EQU (table-3)

away1   equ     1234
away2   equ     5678

        dat     9*QS,  1*QS     ; can get 28 values from this table
table:  dat     5*QS,  2*QS     ;  
        dat    13*QS, 17*QS     ;  

P:      add.f  table,table  ; point into table. Nudge with }{>< and djn.f.
slow:   add.ab *P,fnd       ; adds an element A column (usually)       
fast:   add.b  @P,@-1       ; adds an element B column (usually)       

which:  sne.i  datz,@fnd    ; which half of scan hit?
        add.ab #QD,fnd

; ----------------------------------------------
; Original Probe attack

COUNT   EQU 6
GAP     EQU 15
REP     EQU 6

         mov.i  qbomb,@fnd
fnd:     mov.i  -GAP/2,@QB    ; picks up table as bomb...
         add.ba fnd,fnd
         mov.i  qbomb,*fnd
         add.f  qinc,fnd
         mov.i  qbomb,@fnd
         djn.b  -3,#REP

boot1   spl     away1, {666
        z for 3
        mov.i   stone1+z-1, }boot1
        rof
        div.x   #0, boot1

stone1    mov    {1685    ,1-4154
          sub.x  #4154    ,-1
          jmp    -2       ,}-2

qbomb:   jmp    -200,GAP
qinc:    dat    GAP,-GAP


; ----------------------------------------------
;                  0/1 cycle 
; ----------------------------------------------

start:
        seq.i  QB+QS*0,QB+QS*0+QD
        jmp    which, 0                ; 0

        seq.i  QB+QS*2,QB+QS*2+QD
        jmp    fast, 0                 ; E
        seq.i  QB+QS*1,QB+QS*1+QD
        jmp    fast, <P                ; D
        seq.i  QB+QS*17,QB+QS*17+QD
        jmp    fast, >P                ; F

; ----------------------------------------------
;                   2 cycles
; ----------------------------------------------

        seq.i  QB+QS*7,QB+QS*7+QD
        jmp    slow, 0                 ; BE
        seq.i  QB+QS*6,QB+QS*6+QD
        jmp    slow, <P                ; BD
        seq.i  QB+QS*22,QB+QS*22+QD
        jmp    slow, >P                ; BF
        seq.i  QB+QS*11,QB+QS*11+QD
        jmp    slow, {P                ; AE
        seq.i  QB+QS*15,QB+QS*15+QD
        jmp    slow, }P                ; CE
        seq.i  QB+QS*10,QB+QS*10+QD
        djn.f  slow, P                 ; AD

        seq.i  QB+QS*5,QB+QS*5+QD
        jmp    >fast, 0                 ; B
        seq.i  QB+QS*9,QB+QS*9+QD
        jmp    >fast, {P                ; A
        seq.i  QB+QS*13,QB+QS*13+QD
        jmp    >fast, }P                ; C

; ----------------------------------------------
;                   3 cycles
; ----------------------------------------------

        seq.i  QB+QS*14,QB+QS*14+QD
        jmp    P, 0                     ; BBEE
        seq.i  QB+QS*8,QB+QS*8+QD
        jmp    P, <P                    ; BDE
;        seq.i  QB+QS*24,QB+QS*24+QD             ; KO to avoid self scan!
;        jmp    P, >P                    ; BEF   ; KO to avoid self scan!
        seq.i  QB+QS*12,QB+QS*12+QD
        jmp    P, {P                    ; ADE
        seq.i  QB+QS*32,QB+QS*32+QD
        jmp    P, }P                    ; CEF
        seq.i  QB+QS*20,QB+QS*20+QD
        djn.f  P, P                     ; AADD

        seq.i  QB+QS*4,QB+QS*4+QD
        jmp    }slow, 0                 ; EE
        seq.i  QB+QS*3,QB+QS*3+QD                  
        jmp    }slow, {P                ; DE
        seq.i  QB+QS*19,QB+QS*19+QD
        jmp    }slow, }P                ; FE
;        seq.i  QB+QS*2,QB+QS*2+QD               ; Duplicates a faster scan
;        djn.f  }slow, P                 ; DD    ; Duplicates a faster scan
         
;        seq.i  QB+QS*10,QB+QS*10+QD             ; Duplicates a faster scan
;        jmp    <fast, 0                ; BB     ; Duplicates a faster scan
        seq.i  QB+QS*18,QB+QS*18+QD
        djn.f  <fast, P                ; AA
         
        seq.i  QB+QS*36+CR,QB+QS*36+QD+CR         ; CR corrects for the gap
        jmp    }fast, 0                ; BBBBG    ; between fnd and which.
;        seq.i  QB+QS*26+CR,QB+QS*26+QD+CR
;        jmp    }fast, >P               ; BBG
        seq.i  QB+QS*34+CR,QB+QS*34+QD+CR
        jmp    }fast, {P               ; AAG
        seq.i  QB+QS*42+CR,QB+QS*42+QD+CR
        jmp    }fast, }P               ; CCG
        seq.i  QB+QS*52+CR,QB+QS*52+QD+CR
        djn.f  }fast, P                ; AAAAG
        seq.i  QB+QS*16+CR,QB+QS*16+QD+CR
        djn.f  }fast, }slow            ; G
         
boot2   spl     away2, {999
        z for 3
        mov.i   stone2+z-1, }boot2
        rof
        div.x   #0, boot2

stone2    mov    {1545     ,1-3174
          sub.x  #3174    ,-1
          jmp    -2       ,}-2

        end
