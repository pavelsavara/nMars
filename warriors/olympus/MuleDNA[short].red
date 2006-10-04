; NOTE: This is a shortened version of Mule DNA, one of the '88
;  finalists. The complete version can be found in DMDMULE.RED.
;
;Mule DNA
;by Douglas McDaniels
;United States of America
;
VA            DAT                    1588
VB            DAT                    1337
VC            DAT                    123
GOTCHA        SPL,                   GOTCHA
START         SPL,                   17
SKIPA         CMP    <VA,           <VB
              MOV     GOTCHA,       @VA
              CMP    <VA,           <VB
              MOV     GOTCHA,       @VB
              DJN     SKIPA,         VC
SKIPC         MOV    #1589,          VA
              MOV    #168,           VC
SKIPB         MOV     VA,           <VA
              MOV     VA,           <VA
              MOV     VA,           <VA
              DJN     SKIPB,         VC
              JMP     SKIPC

COPY equ 1
ONE equ 1588
TWO equ 1337

iONE equ (ONE+86*i)
iTWO equ (TWO+86*i)

i FOR 63
              DAT                    iONE   ;  1674
              DAT                    iTWO   ;  1423
              DAT                    123
              SPL                    0
              SPL                    17
              CMP    <-5,          <-4
              MOV     -3,          @-6
              CMP    <-7,          <-6
              MOV     -5,          @-7
              DJN     -4,           -7
              MOV    # iONE+1,      -10      ;  1675
              MOV    # 168,         -9
              MOV     -12,         <-12
              MOV     -13,         <-13
              MOV     -14,         <-14
              DJN     -3,           -13
              JMP     -6

ROF

              END      START
