;redcode
;name Fever 0
;author Planar
;strategy I cannot write a decent scanner.
;strategy But I love this tournament.
;strategy one-shot scanner, dirty clear
;assert CORESIZE == 8000

;; Entry for round 3 of the Redcode Maniacs Tournament.
;; Gets about 130 points against the papers.

;; Should p-space with a spiral clear to kill Die Hard.


step    equ     70

Nparam  equ     5
Sparam  equ     3
Gparam  equ     40
Lparam  equ     50


        org     start

begin:

gate:   dat     0, start-Sparam
        dat     0, 0

attack: spl     #1, >gate
loop:
i FOR Nparam
        mov.i   *bptr, >gate
ROF
        djn.b   *attack, >gate
        dat     {gate, >gate

bomb3:  dat     bomb3-bptr, bptr-gate
bomb2:  spl     #bomb3-bptr, bptr-gate
bomb1:  spl     #bomb2-bptr, bptr-gate
bptr:   dat     bomb1, bptr-gate

i FOR Gparam
        dat     0, 0
ROF

steps:  dat     4*step, 4*step
scan:   add.f   steps, 1
start:  sne.i   begin+1*step, begin+2*step
        djn.b   scan, #Lparam

found1: jmn.f   found2, *start
        mov.ba  start, gate
found2: add.ab  start, gate
        jmp     attack

        end

