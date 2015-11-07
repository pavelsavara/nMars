FOR 0
	Well, I doubt many new warriors will appear this round... but someone may
	submit a '94 style Q^2 scan variation (?).

	I didn't have the energy to learn the '88 standard so I just grabbed one
	of the better warriors I could find. I'm hoping Ross will submit an 
	aggressive warrior... and no qscan :-)
ROF

;redcode
;name Tie Fighter
;author Anton Marsden
;strategy Something from the '93 tournament
;assert 1

;Pergament

step EQU 8
cl1 EQU -600
cl2 EQU -920
d EQU 2667

spl scis
spl spir

spl 1
spl 1
spl 8
spl 4
spl 2
jmp paps+1
jmp paps+9
spl 2
jmp paps+17
jmp paps+25
jmp 1
spl 2
jmp paps+33
jmp paps+41

paps mov #8,8
mov <-1,<2
mov <-2,<1
spl @0,1111
mov 2, <-1
jmz -5,-5
dat <2667, <5334
mov 0, <1
mov #8,8
mov <-1,<2
mov <-2,<1
spl @0,1311
mov 2, <-1
jmz -5,-5
dat <2667, <5334
mov 0, <1
mov #8,8
mov <-1,<2
mov <-2,<1
spl @0,1511
mov 2, <-1
jmz -5,-5
dat <2667, <5334
mov 0, <1
mov #8,8
mov <-1,<2
mov <-2,<1
spl @0,1711
mov 2, <-1
jmz -5,-5
dat <2667, <5334
mov 0, <1
mov #8,8
mov <-1,<2
mov <-2,<1
spl @0,1911
mov 2, <-1
jmz -5,-5
dat <2667, <5334
mov 0, <1

	dat #0

scis: spl 0, cl1
	mov scis, <scis
	mov jump, @scis
	sub #step, scis
	djn -3, #(cl1-cl2)/step
	mov 0, -1
loop: mov @100, <cl1
jump: jmp -1

	dat #0
imp:  mov 0, d

i0 EQU spir+30
i1 EQU i0+666
i2 EQU i0+1333
i3 equ i0+2000

spir: mov imp, i0
	mov imp, i1
	mov imp, i2
	mov imp, i3
	spl 1
	spl 1
	spl 1
	spl 1
	spl 1
	spl 10
	spl 5
	spl 2
	jmp @0, i0
	add #d, -1
	dat #0
	spl 2
	jmp @0, i1
	add #d, -1
	dat #0
	spl 5
	spl 2
	jmp @0, i2
	add #d, -1
	dat #0
	spl 2
	jmp @0, i3
	add #d, -1
	dat #0
end

