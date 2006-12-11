;redcode
;name H-Bomb
;author Josh Yeager
;strategy Two cc's running in parallel.
;assert 1

	spl.ab 0,<1443
start	mov.ab bomb,>99
	mov.ab bomb,<-99
      	jmp.ab start,<2667
bomb	dat.ab 0,1

end
