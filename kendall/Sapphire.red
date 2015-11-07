;redcode-b
;name Sapphire
;author Philip Kendall
;strategy Stone (Emerald)/3-pt imps
;strategy 1.2: changed to 3-pt imps
;assert CORESIZE==8000

;BDECWT round 1
;opponent David Moore

;The theory behind this one is that David, as an '88 player, won't go and
;produce a paper; therefore a stone should be fairly safe and the 3-pt imps
;as safe as anything else, as only papers carry specialised anti 3-pt imp
;bombs. Also, no qscan in the hope David will get one from somewhere
;and use that. Well, that's the theory, how will it do :-)

sboot	equ	5064
step	equ	3044

istep	equ	2667
iaway	equ	3013
impproc equ	16

i1	equ	(imp+iaway)
i2	equ	((i-1)*2)

emerald spl.a	#-step,<step
stone	mov.i	>-step,step+1
	add.f	emerald,stone
cnt	djn.f	stone,<emerald-50

start	spl.a	impst,}4000
	mov.i	cc,(emerald+sboot+5)
i	for	(cnt-emerald+1)
	mov.i	emerald+(i-1),>sbptr
	rof
sbptr	spl.a	emerald+sboot,emerald+sboot
	mul.f	sbptr,sbptr
cc	dat.f	0,#-7

imptab
i	for	(impproc/2)
	dat.f	i1+(istep*i2),i1+(istep*(i2+1))
	rof

impst	mov.i	imp,imp+iaway
	spl.a	1,>-1000
	spl.a	1,}-2000
	spl.a	1,>-3000
	spl.a	2,}-4000
	jmp.a	*imptab,}0
iend	jmp.a	@imptab,}0

imp	mov.i	#istep,*0

i	for	(MAXLENGTH-CURLINE)
	dat.f	}(i+100),>(i+200)
	rof

	end	start
