;
;    Warrior: Cat Can
;  File name: catcan.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: A. Kirchner
;  Assisting: W. Rohmann
;             J. Tenzer
;
start       mov       grave,      @ dest
            mov       prog,       < dest
            sub     # 7,            dest
            jmn       start,        dest
            sub     # 4,            dest
kill        mov       dest,       < dest
            jmn       kill,         dest
prog        spl                     prog
grave       jmp       grave-1
dest        dat                     dest-16
            end       start


