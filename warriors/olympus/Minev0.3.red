;redcode-94
;name Mine v0.3
;author John K Wilkinson
;jkw@austin.rr.com
;strategy my entry. this is mine. hence the name.

PLAYER equ 2

; Start off with the best 1-proc bomber, Tornado.
; After stunning opponent, take my sweet time b-scanning
; every core space, in order, comparing them to the redos
; version number and that dat -45 thingy if I find anything.
;
; Ok the way I see it, QScanning is practically useless...
; If I find the RedOS and bomb it, I still have to use
; a scanner to set my score... nevertheless, I guess it's
; still good to bootstrap, cause my oppenents may be pure
; scanners (likely?)...
;
; This beats the test thing with a score of 7999 close to
; 100% of the time, since the tester almost always gets
; stuck looking at my decoy code I boot away from.  I doubt
; my opponents will have that problem though.  Heh.

step EQU 2376
count EQU (8000/8/3)-1
ptr EQU scan+100

incr    dat     3*step,    3*step
bombd   jmp.i   #step,     #0
start   mov     bombd,     *stone
        mov     bombd,     @stone
stone   mov     *(2*step)+5, *(3*step)+5
        add     incr+4000,      stone
jump    djn.b   start,     #count
scan    jmz.b   #0,        >ptr
        sne.i   <ptr,      cmp36+4000  ; reset to found loc with <
        jmp     found,     0
        seq.i   >ptr,      cmp045+4000 ; ptr is now +1, so 1+PLAYER+1 =
2+PLAYER
        jmp     scan,      0
found   add     #PLAYER+1, ptr          ;2+PLAYER for cmp045 -- 1+PLAYER
for cmp36
        mov.i   us+4000,   >ptr           ; set us to 7999
        mov.i   them+4000, >ptr           ; and them to zero
bottom  jmp     scan
        dat 3,0
dat 3,0

for 8*4
dat 3,0
rof

us:     jmp #-1,0
them:   jmp #0,1

for (8*4-2)
dat 3,0
rof

cmp045: dat 0,-45
cmp36:  dat 3,6

boot:
i for (bottom+1-bombd)
mov bombd+i-1, (bombd+i-1)+4000
rof
jmp start+4000

end boot 
