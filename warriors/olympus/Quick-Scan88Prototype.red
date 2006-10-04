;redcode
;name Quick-Scan '88 Prototype
;author Brant D. Thomsen
;strategy Add this to the front of your warrior,
;strategy  and see if it improves your score.
;assert CORESIZE == 8000

space   equ     (8000/81)       ; Step when scanning for code.
qbomb   equ     6               ; Step when bombing whatever we found.

scan    cmp     space*1+bottom, space*41+bottom
        mov     #space*1+bottom-found, found
        cmp     space*2+bottom, space*42+bottom
        mov     #space*2+bottom-found, found
        cmp     space*3+bottom, space*43+bottom
        mov     #space*3+bottom-found, found
        cmp     space*4+bottom, space*44+bottom
        mov     #space*4+bottom-found, found
        cmp     space*5+bottom, space*45+bottom
        mov     #space*5+bottom-found, found
        cmp     space*6+bottom, space*46+bottom
        mov     #space*6+bottom-found, found
        cmp     space*7+bottom, space*47+bottom
        mov     #space*7+bottom-found, found
        cmp     space*8+bottom, space*48+bottom
        mov     #space*8+bottom-found, found
        cmp     space*9+bottom, space*49+bottom
        mov     #space*9+bottom-found, found
        cmp     space*10+bottom, space*50+bottom
        mov     #space*10+bottom-found, found
        cmp     space*11+bottom, space*51+bottom
        mov     #space*11+bottom-found, found
        cmp     space*12+bottom, space*52+bottom
        mov     #space*12+bottom-found, found
        cmp     space*13+bottom, space*53+bottom
        mov     #space*13+bottom-found, found
        cmp     space*14+bottom, space*54+bottom
        mov     #space*14+bottom-found, found
        cmp     space*15+bottom, space*55+bottom
        mov     #space*15+bottom-found, found
        cmp     space*16+bottom, space*56+bottom
        mov     #space*16+bottom-found, found
        cmp     space*17+bottom, space*57+bottom
        mov     #space*17+bottom-found, found
        cmp     space*18+bottom, space*58+bottom
        mov     #space*18+bottom-found, found
        cmp     space*19+bottom, space*59+bottom
        mov     #space*19+bottom-found, found
        cmp     space*20+bottom, space*60+bottom
        mov     #space*20+bottom-found, found

        jmn     found, found    ; Get out early if found something.

        cmp     space*21+bottom, space*61+bottom
        mov     #space*21+bottom-found, found
        cmp     space*22+bottom, space*62+bottom
        mov     #space*22+bottom-found, found
        cmp     space*23+bottom, space*63+bottom
        mov     #space*23+bottom-found, found
        cmp     space*24+bottom, space*64+bottom
        mov     #space*24+bottom-found, found
        cmp     space*25+bottom, space*65+bottom
        mov     #space*25+bottom-found, found
        cmp     space*26+bottom, space*66+bottom
        mov     #space*26+bottom-found, found
        cmp     space*27+bottom, space*67+bottom
        mov     #space*27+bottom-found, found
        cmp     space*28+bottom, space*68+bottom
        mov     #space*28+bottom-found, found
        cmp     space*29+bottom, space*69+bottom
        mov     #space*29+bottom-found, found
        cmp     space*30+bottom, space*70+bottom
        mov     #space*30+bottom-found, found
        cmp     space*31+bottom, space*71+bottom
        mov     #space*31+bottom-found, found
        cmp     space*32+bottom, space*72+bottom
        mov     #space*32+bottom-found, found
        cmp     space*33+bottom, space*73+bottom
        mov     #space*33+bottom-found, found
        cmp     space*34+bottom, space*74+bottom
        mov     #space*34+bottom-found, found
        cmp     space*35+bottom, space*75+bottom
        mov     #space*35+bottom-found, found
        cmp     space*36+bottom, space*76+bottom
        mov     #space*36+bottom-found, found
        cmp     space*37+bottom, space*77+bottom
        mov     #space*37+bottom-found, found
        cmp     space*38+bottom, space*78+bottom
        mov     #space*38+bottom-found, found
        cmp     space*39+bottom, space*79+bottom
        mov     #space*39+bottom-found, found
        cmp     space*40+bottom, space*80+bottom
        mov     #space*40+bottom-found, found

        jmz     warrior, found  ; Don't Quick-bomb if nothing found.

found   cmp     bottom, 0       ; Find which instruction is not blank.
        jmp     2               ; CMP / JMP 2 is the '88 equivalent of SNE.

        add     #40*space, found ; Goto second location if first is blank.

forward mov     jump, @found    ; Use a SPL/JMP bomb.
        mov     split, <found
        add     #(qbomb+1), found
        jmn     forward, @found ; Keep bombing while B-Field is not 0.


        ; Regular warrior starts here.
        ; The first instruction should be labeled "warrior".
        ; Must include the code for a two-line bomb.
        ; (Or, of course, you are welcome to use a different bomb,
        ;  such as a single DAT statement.)

warrior jmp     0, <-100        ; Replace this with your own code.

split   spl     0
jump    jmp     -1

bottom  end     scan
