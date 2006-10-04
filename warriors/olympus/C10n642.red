;
;    Warrior: C10n642
;  File name: c10n642.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: John R. Perry
;
         DAT       < 00568      < 01AC4
         JMP       $ 0FFFE      $ 0F10A
         JMP       $ 0FFFC      < 0F7AE
         JMP       $ 0FFFC      < 0F7AE
         CMP       @ 0FFE1      $ 0FFE3
         MOV       @ 0FFFD      @ 0FFF7
         CMP       @ 00011      @ 0000D
start    JMZ       $ 00003      $ 00004
         MOV       @ 0FFFF      < 0FFF0
         MOV       @ 0FFFD      @ 0FFF7
         MOV       < 0FFFD      < 0FFF7
         MOV       @ 0FFFF      < 0FFF0
         DJN       $ 0FFFF      $ 0FFFC
         CMP       @ 0FFF8      @ 0FFFD
         MOV       @ 0FFFF      < 0FFF0
         DJN       $ 0FFFF      $ 0FFFC
         ADD       $ 00002      < 000CE
         MOV       $ 00001      < 01189
         JMP       $ 0FFFC      < 0F7AE
         SUB       $ 00002      @ 00002
         JMZ       $ 00006      # 00007
         JMP       $ 00001      < 0195E
         JMP       $ 0FFFC      < 0F7AE
         JMN       $ 0FFFA      # 0FFFE
         JMZ       $ 0FFFE      @ 0FFFB
         JMP       $ 0FFFE      $ 0F10A
         SUB       < 0FFFD      < 0FFF0
         CMP       @ 00011      @ 0000D
         DJN       $ 0FFFF      $ 0FFFC
         JMP       $ 0FFFE      $ 0F48C
         ADD       # 00005      < 00000
         SUB       # 00001      < 00000
         CMP       $ 00022      $ 00021
         DAT       @ 0EEED      $ 0EE23
         DJN       < 00001      $ 00005
         DAT       @ 01942      @ 011BE
         SUB       # 0FFFC      $ 0F5E4
         ADD       $ 00002      < 00000
         JMZ       < 0FFF9      $ 0FFFA
         ADD       # 00005      < 00000
         DJN       $ 0FFFF      $ 0FFFC
         JMP       $ 0FFFC      < 0F7AE
         DAT       @ 0F143      $ 0EC96
         DAT       @ 01DED      @ 00A10
         SUB       # 0FFFB      < 0FFF7
         SPL       $ 00000      < 00314
         JMP       $ 0FFFC      < 0F7AE
         CMP       < 00003      < 00016
         SPL       < 00006      $ 00483
         MOV       @ 0FFFD      @ 0FFF7
         MOV       @ 0FFFF      < 0FFF0
         DJN       $ 0FFFF      $ 0FFFC
         DJN       < 00004      @ 00003
         JMZ       $ 00006      # 00007
         SUB       # 00002      < 0000E
         ADD       $ 00001      @ 01AC4
         JMP       < 00003      @ 00958
         DJN       < 0FFF9      $ 0FFFE
         DAT       < 00013      @ 00007
         ADD       # 0FFFC      < 0EF7A
         DAT       < 011E3      < 01A1B
         CMP       @ 0FFF8      @ 0FFFD
         DAT       $ 0FFD5      < 0FFE9
         CMP       # 00010      # 00008
         CMP       @ 00011      @ 0000D
         END         start
P