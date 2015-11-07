;redcode-94
;name W0078V00
;author RC94 Evolver v2
;fitness score 106
;   vs Rave 4.1 Results: 6 19 0
;   vs Pyramid2 Results: 18 3 4
;   vs Blitz 94 Results: 2 11 12
;   vs Paradox2 Results: 0 13 12
ORG 3
DAT.B  #  -13, $   -6
DAT.F  <  -15, >   -7
MOV.BA >  -10, @  -13
MOV.BA >   -9, <   -9
SEQ.F  <  -15, @    3
MUL.F  @   -8, $   -9
DJN.X  #    9, >   10
SPL.X  #   -2, >    1
SPL.X  #   -2, >   13
SPL.A  <   -2, >   13
SLT.I  >    6, >   11
DAT.F  #   -4, #   12
MOD.X  >   -3, <   -6
JMP.AB #    7, @   15
SLT.I  #  -13, <    1
JMZ.F  <    2, @   -9
NOP.F  <    1, @  -13
SPL.X  <   -2, >  -15
SPL.F  >  -15, <    8
MUL.F  @   -8, $   -9
SPL.X  <   -2, >  -15
SEQ.F  <  -15, @    8
MUL.F  @   -8, $   -9
DJN.X  #    9, >   10
SPL.X  #   -2, >   13
MOV.F  <    2, @   -9
SUB.B  <    5, #  -14
SPL.F  <  -15, @    9
DAT.A  >   -2, <   10
JMZ.X  @   12, $  -15
SLT.I  #    5, @   -8
DJN.AB $    7, <  -15
DAT.X  $    9, $   -3
MOD.X  >   -3, <   -6
JMP.AB #    7, @   15
SLT.I  #  -13, <    1
JMZ.F  <    2, @   -9
NOP.F  <    1, @  -13
DAT.BA $    1, <   13
DAT.BA $    4, $   12
SLT.F  <   13, >   -6
SLT.I  <    6, >   11
SLT.I  #    5, @   -8
SPL.X  <   -2, >  -15
SEQ.F  <  -15, @    9
MUL.AB @   -8, $   -9
DJN.X  #    9, >   10
SPL.X  #   -2, >   13
SPL.X  #   -2, >   13
JMZ.F  <    2, @   -9
NOP.F  <   -2, @  -13
SPL.X  <   -2, >  -15
SPL.F  >  -15, <    8
SUB.B  <    5, #   15
MOD.X  >  -12, <    2
SLT.I  #  -13, <    1
JMZ.F  <    2, @   -9
NOP.F  <    1, @  -13
SPL.X  <   -2, >  -15
MOV.BA >  -10, @  -13
SEQ.A  #  -12, >-3998
MOV.X  #   -5, @    6
MUL.A  >  -10, @ 2950
JMN.X  <   -7, @  -10
DAT.I  >   -2, @    5
DAT.BA >   -7, <   10
SLT.I  >    6, >   11
SPL.X  >  -12, $    2
DAT.BA <  -15, >   -7
JMP.BA >  -10, @  -13
ADD.AB <  -12, >-3998
SEQ.BA $   -4, @   -9
SEQ.A  <   11, >-3998
SEQ.BA $   -4, #   -9
DIV.BA @    5, @    4
SPL.B  >  -12, $    2
NOP.AB #   12, #   -4
DJN.AB $    7, <  -15
MOV.X  #   -5, @   10
SUB.B  @    5, #   15
SUB.BA >   -7, #   -4
NOP.BA $    5, $    4
SPL.I  >  -12, <    2
NOP.AB >   12, #   -4
SPL.X  >  -12, <    2
DAT.BA $    1, <   13
DJN.X  #    9, >   10
SPL.X  #   -2, >   13
SLT.I  <   13, @   -6
SLT.I  >    6, >   11
ADD.F  #   -4, #   12
SPL.X  <   -2, >  -15
DJN.X  #    9, >   10
SPL.X  #   -2, >   13
SLT.F  <   13, @   -6
MOV.BA >   -9, <   -9
SEQ.F  <  -15, @    3
SPL.A  #  -12, >   11
DAT.I  #   -4, $ 7881
SPL.A  #  -12, >    7
