;redcode
;name Train
;author Pavel Savara
;strategy Train 
;created using nMars, see http://nmars.sourceforge.net/

        ORG start
start   SPL slow
        SPL loco
slow    JMP loco

src     DAT 4,5
        DAT 4,5
loco    MOV {src,     <src
wagon   NOP 0,0   
blade   DAT 0,0
