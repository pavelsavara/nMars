;REDCODE
;name G007W008
;author RC94 Evolover
;Parents: G006W037 G005W033
org 2
DAT.I  @1043,>0041
MOV.I  #4101,@0029
SPL.A  #0033,<0007
MOV.F  #4101,@0061
SPL.A  #0033,<0007
JMZ.F  >0041,>0017
MOV.F  #4101,@0029
SPL.B  #0033,<2055
JMZ.F  >0169,>0001
MUL.A  @1058,<0006
MOV.F  #4101,@0029
SPL.A  #0033,<0007
JMZ.F  >0040,>0049
MUL.A  $0042,<0006
JMZ.AB  @1032,#0045
MOV.F  #8197,@1053
SPL.A  #0033,<0007
MUL.A  $0042,<2054
MUL.BA  $0026,>0012
SPL.BA  #0009,$0043
MUL.BA  $0026,>0012
SUB.X  @0004,$0047
JMZ.F  >0041,>0017
MOV.F  #0261,@0029
SPL.A  #0033,<0007
JMZ.F  >0041,>0017
SPL.F  #0019,$0048
SPL.A  #0033,<0007
JMP.X  >0008,@0016
ADD.AB  @0154,$0005
ADD.AB  @0026,$0005
ADD.BA  >0031,@0038
SLT.BA  <1067,$0045
MOV.F  #0005,@1053
SPL.A  @0041,<0007
MUL.A  $0042,<0006
JMZ.AB  @1032,#0045
MOV.F  #0005,@1053
JMN.A  #0016,>0058
SUB.X  @0004,$0047
ADD.AB  @0026,$0005
SPL.F  #0019,$0052
JMN.A  #0016,>0042
SUB.X  @0004,$0063
SUB.X  @0004,$0047
SPL.F  #0019,$0048
JMZ.A  @0004,$0003
SPL.F  #0019,$0048
CMP.BA  <0030,$0004
CMP.B  #0135,>0016
ADD.F  >0029,@0003
JMP.X  >0008,@0272
JMZ.BA  @0048,$0037
SPL.I  >0002,#0040
JMP.X  >0008,@0016
MUL.AB  <0003,@0043
SPL.F  <0018,@0010
ADD.BA  <0032,>0072
DJN.X  #0108,@0035
SLT.A  $0010,>0104
MUL.AB  <0003,#0043
DAT.I  >0032,>0045
DJN.X  @2089,@0008