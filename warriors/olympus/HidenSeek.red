;redcode-x
;name Hide 'n' Seek
;author Warren Kurt vonRoeschlaub
;strategy Play hide and seek, you're it.
source  dat #0
start   mov #dest-source,source
cloop   mov @source,<dest
        djn cloop,source
        spl (249+start+start-dest)
        mov hide,123
        jmp 122
hide    jmp hide
dest    dat #250+start,#250+start
        end start
