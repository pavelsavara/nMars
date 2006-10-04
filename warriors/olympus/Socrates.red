;redcode-94
;assert 1

;author Kurt Franke
;name Socrates

;strategy Know Thyself
;strategy  Handshake -> wait

wait	jmp	wait			;; real tough guy :-)

;; - - - - - - - - - handshake constants - - - - - - - - - - - - - - -

        PIN     1

ENEMYP          equ     1		;; flag for enemy warrior
WINP            equ     2
LOSEP           equ     3
HWARRIOR        equ     wait		;; our regular warrior

;; - - - - - - - - - handshake initialize - - - - - - - - - - - - - -

enemy   ldp	#ENEMYP, #0
        jmn     HWARRIOR, $enemy        ;; if flag is set, fight

last    ldp     #0, #0
        sne     #-1, $last              ;; check for first round
        jmp	search			;; special routine for first round

;; - - - - - - - - - - - - try handshake - - - - - - - - - - - - - -

shake   jmz     lost, $last             ;; the actual handshake
won     stp     #0, #LOSEP              ;; reset the expected flag
        stp     #1, #WINP
loser   ldp     #LOSEP, #0              ;; and then check it
        jmz     foe, $loser
        jmp     0                       ;; wait


lost    stp     #0, #WINP               ;; reset the expected flag
        stp     #1, #LOSEP
winner  ldp     #WINP, #0               ;; and then check it
        jmz     foe, $winner
	dat     $0, $0			;; lose again

;; - - - - - - - - - - - flag enemy warrior - - - - - - - - - - - - - - -

foe     stp	#1, #ENEMYP
	jmp     HWARRIOR

;; - - - - - - - - - special first round routine - - - - - - - - - - - - -

;; Determine who moved first without pspace
;;  1st version waits till timeout and second kills itself

search  jmz.f   search, {count          ;; find the other copy

count   sne.i   #-100, {count           ;; skip the next line if we are #2
        jmp     $0, {count

;; - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        end     enemy
