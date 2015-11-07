;
; QUARTER       by Stefan Haenssgen
;
; Copies a killer to every quarter of the core and SPLits into four
; processes, each one bombing its slice of memory.
; Not very subtle but quite powerful since the killers produce a bomb
; with every second instruction and are difficult to hit.
; (The killers destroy each other after they have bombed through their
; quarter, but the battle should be decided before this happens. Speed
; is the important factor)
;

slen    equ     CORESIZE
dist    equ     (loop-z1)       ; Distance from killer to start of program
                                ; (killers should be at equal distances)

z1      DAT     #slen/4+dist    ; Pointer to copies
z2      DAT     #slen/2+dist
z3      DAT     #slen*3/4+dist

start   MOV     kill,    <z2     ; Copy one killer ..
        MOV     loop,    <z2     ; .. and ..
        SPL    @z2               ; .. start it
        MOV     kill,    <z1     ; (no fancy loops here, we want speed!)
        MOV     loop,    <z1
        SPL    @z1
        MOV     kill,    <z3
        MOV     loop,    <z3
        SPL    @z3
        JMP     loop             ; Start the fourth killer

ptr     DAT     #0               ; Pointer to target (not copied, since ..
                                ; .. core is initialized with "DAT #0")
loop    MOV     ptr,     <ptr    ; Bomb with DATs ..
kill    DJN     loop,     ptr    ; .. every second location in memory

        END     start
