;redcode
;name     so i won't lose a lotta points this round
;author   Anders Scholl
;contact anders@kamsc.seds.org
;NSFCWT Round 2
;strategy a REAL generic spiral;
;strategy just so i tie as close to 100% as possible ;)
;assert CORESIZE==8000

launch  spl 8
        spl 4
        spl 2
        jmp imp
        jmp imp+2667
        spl 2
        jmp imp+5334
        jmp imp+1
        spl 4
        spl 2
        jmp imp+2668
        jmp imp+5335
        spl 2
        jmp imp+2
        jmp imp+2669

imp     mov 0,2667
