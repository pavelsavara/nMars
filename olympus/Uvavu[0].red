;redcode b
;name Uvavu
;author Scott Manley
;strategy Lot's of scanners/bombers in paralel. Still trying to make it work

increment EQU 128


cycles1 EQU 30
cycles2 EQU 30
cycles3 EQU 60
cycles4 EQU 122
cycles5 EQU 245
cycles6 EQU 491

         ORG       begin

gate     MOV.I     g2 , gate-5     ;imp gate generator
         MOV.I     g1 , gate-5
         JMP       gate-5
clear1   MOV.I     g2 , 0
         MOV.I     g1 , gate-6     ;2 pass core clear
cloop    MOV.I     g1 , {gate-6
         DJN       -1 , #-20
         MOV.I     clbom , 0
g1       SPL       0 , > -3
         MOV       clbom , < -2
         JMP       -1 , > -5
clbom    DAT       0 , 0
g2       DAT       > -4 , > -5
begin    MOV.I     g2 , gate-4
         SPL       scan2
loop1    CMP.F     *targ1 , @targ1
         JMP       bomb1 , > targ1
cont1    ADD.F     inc2,targ1
         DJN       loop1,#cycles1
         JMP       gate
bomb1    MOV.I     j1 , @ targ1
         MOV.I     g1 , < targ1
         MOV.I     j1 , * targ1
         MOV.I     g1 , { targ1
         JMP       cont1 , } targ1
scan2    SPL       scan3
loop2    CMP.F     *targ2 , @targ2
         JMP       bomb2 , > targ2
cont2    ADD.F     inc2,targ2
         DJN       loop2,#cycles2
         JMP       confuse
bomb2    MOV.I     j1 , @ targ2
         MOV.I     g1 , < targ2
         MOV.I     j1 , * targ2
         MOV.I     g1 , { targ2
         JMP       cont2 , } targ2
scan3	 SPL       scan4
loop3    CMP.F     *targ3 , @targ3
         JMP       bomb3 , > targ3
cont3    ADD.F     inc3,targ3
         DJN       loop3,#cycles3
         JMP       gate
bomb3    MOV.I     j1 , @ targ3
         MOV.I     g1 , < targ3
         MOV.I     j1 , * targ3
         MOV.I     g1 , { targ3
         JMP       cont3 , } targ3
scan4    SPL       scan5
loop4    CMP.F    *targ4 , @targ4
         JMP       bomb4 , > targ4
cont4    ADD.F     inc4,targ4
         DJN       loop4,#cycles4
         JMP       gate
bomb4    MOV.I     j1 , @ targ4
         MOV.I     g1 , < targ4
         MOV.I     j1 , * targ4
         MOV.I     g1 , { targ4
         JMP       cont4 , } targ4
scan5    SPL       loop6
loop5    CMP.F     *targ5 , @targ5
         JMP       bomb5 , > targ5
cont5    ADD.F     inc5,targ5
         DJN       loop5 , #cycles5
         JMP       gate
bomb5    MOV.I     j1 , @ targ5
         MOV.I     g1 , < targ5
         MOV.I     j1 , * targ5
         MOV.I     g1 , { targ5
         JMP       cont1 , } targ5
loop6    CMP.F    *targ6 , @targ6
         JMP       bomb6 , > targ6
cont6    SUB.F     inc6,targ6
         DJN       loop6,#cycles6
         JMP       clear1
bomb6    MOV.I     j1 , @ targ6
         MOV.I     g1 , < targ6
         MOV.I     j1 , * targ6
         MOV.I     g1 , { targ6
         JMP       cont1 , } targ6 
j1       JMP       -1 , < -3
confuse  MOV.I     g1,*targ7
         MOV.I     g1,@targ7
         ADD.F     inc7,targ7
         DJN       confuse,#984
;targ1    DAT       start1 , start1+increment
;targ2    DAT       start2 , start2+increment
;targ3    DAT       start3 , start3+increment/2
;targ4    DAT       start4 , start4+increment/4
;targ5    DAT       start5 , start5+increment/8
;targ6    DAT       start6 , start6+increment/16
targ1    DAT       15,143
targ2    DAT       78,206
targ3    DAT       45,109
targ4    DAT       28,60
targ5    DAT       19,35
targ6    DAT       7870,7882
targ7    DAT       11,15
inc2     DAT 	   increment*2 , increment*2
inc3     DAT       increment , increment
inc4     DAT       increment/2 , increment/2
inc5     DAT       increment/4 , increment/4
inc6     DAT       increment/8 , increment/8
inc7     DAT       8,8

