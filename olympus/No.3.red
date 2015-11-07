;redcode
;name No.3
;author Automatic Player

DIST    equ 212

scan    ADD  #DIST, scanptr
scanptr MOV  slow,  scanptr
        JMN  scan,  scanptr
bloop   DJN  bloop, <scan+2
        JMP  bloop
slow    JMP  @-DIST

        end scan
