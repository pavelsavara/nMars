;To see the starfield please run pMARS like this:
;PMARSV.EXE PStars.red -v 011 -c 999999999
;If know, the colours arn't that good. It would have been better
;do the animation over several rounds.
;This is propably my last entry for this tournament because I'm
;going to stay a term in London and I don't know if I'm able to
;do Core War there. Thank you for the great tournament, Philipp
;name PStars v1.0
;author Philipp Offermann
;strategy Starfield
;url http://home.t-online.de/home/offermann
;assert CORESIZE==8000

		org clear

l               equ 158
laenge          equ (ende-empty+1)
speed           equ 8000           ;If the simulation runs to slow
				   ;you may use a smaller value!


empty           dat.f   -1,1
d               jmp.a   0,0
stars           jmp.a   -(l*30+70+1),l*30+70
		jmp.a   -(l*34+57+1),l*34+57
		jmp.a   -(l*6+84+1),l*6+84
		jmp.a   -(l*8+74+1),l*8+74
		jmp.a   -(l*8+138+1),l*8+138
		jmp.a   -(l*38+124+1),l*38+124
		jmp.a   -(l*11+33+1),l*11+33
		jmp.a   -(l*19+109+1),l*19+109
		jmp.a   -(l*13+154+1),l*13+154
		jmp.a   -(l*46+71+1),l*46+71
		jmp.a   -(l*30+150+1),l*30+150
		jmp.a   -(l*47+135+1),l*47+135
		jmp.a   -(l*39+145+1),l*39+145
		jmp.a   -(l*49+110+1),l*49+110
		jmp.a   -(l*24+46+1),l*24+46
		jmp.a   -(l*18+141+1),l*18+141
		jmp.a   -(l*45+141+1),l*45+141
		jmp.a   0,0
		jmp.a   -(l*45+36+1),l*45+36
		jmp.a   -(l*27+104+1),l*27+104
		jmp.a   -(l*34+108+1),l*34+108
		jmp.a   -(l*22+122+1),l*22+122
		jmp.a   -(l*22+135+1),l*22+135
		jmp.a   -(l*22+5+1),l*22+5
		jmp.a   -(l*12+25+1),l*12+25
		jmp.a   -(l*31+103+1),l*31+103
		jmp.a   -(l*4+19+1),l*4+19
		jmp.a   -(l*6+139+1),l*6+139
		jmp.a   -(l*24+141+1),l*24+141
		jmp.a   -(l*37+14+1),l*37+14
		jmp.a   -(l*23+83+1),l*23+83
		jmp.a   -(l*43+32+1),l*43+32
		jmp.a   -(l*11+88+1),l*11+88
		jmp.a   -(l*2+71+1),l*2+71
		jmp.a   -(l*2+60+1),l*2+60
		jmp.a   0,0
		jmp.a   -(l*44+52+1),l*44+52
		jmp.a   -(l*40+54+1),l*40+54
		jmp.a   -(l*4+43+1),l*4+43
		jmp.a   -(l*3+118+1),l*3+118
		jmp.a   -(l*4+15+1),l*4+15
		jmp.a   -(l*22+94+1),l*22+94
		jmp.a   -(l*34+42+1),l*34+42
		jmp.a   -(l*48+14+1),l*48+14
		jmp.a   -(l*39+24+1),l*39+24
		jmp.a   -(l*32+152+1),l*32+152
		jmp.a   -(l*9+43+1),l*9+43
		jmp.a   -(l*32+98+1),l*32+98
		jmp.a   -(l*9+83+1),l*9+83
		jmp.a   -(l*36+111+1),l*36+111
		jmp.a   -(l*48+148+1),l*48+148
		jmp.a   -(l*23+113+1),l*23+113
		jmp.a   -(l*14+16+1),l*14+16
		jmp.a   0,0
		jmp.a   -(l*24+112+1),l*24+112
		jmp.a   -(l*18+19+1),l*18+19
		jmp.a   -(l*31+68+1),l*31+68
		jmp.a   -(l*30+130+1),l*30+130
		jmp.a   -(l*12+13+1),l*12+13
		jmp.a   -(l*21+6+1),l*21+6
		jmp.a   -(l*49+53+1),l*49+53
		jmp.a   -(l*6+143+1),l*6+143
		jmp.a   -(l*37+25+1),l*37+25
		jmp.a   -(l*4+21+1),l*4+21
		jmp.a   -(l*34+154+1),l*34+154
		jmp.a   -(l*15+59+1),l*15+59
		jmp.a   -(l*6+153+1),l*6+153
		jmp.a   -(l*22+123+1),l*22+123
		jmp.a   -(l*42+21+1),l*42+21
		jmp.a   -(l*16+70+1),l*16+70
		jmp.a   -(l*8+15+1),l*8+15

wo              dat.f   stars,0
sdec            jmp.a   -(l+1),l
cinc            dat.f   -1,1
cjump           jmp.a   -(ende+1-wo),ende+1
clear           mov.i   cjump,@cjump
		spl.a   @cjump
		add.f   cinc,cjump
		djn.b   clear,#CORESIZE-laenge

init            mov.a   #stars-wo,wo
		sub.f   cinc,cinc
schneller       add.f   empty,cinc
anim            mov.i   *wo,d
		mov.i   d,@d
		spl.a   @d
		add.f   cinc,d
		slt.b   d,#7900
		mov.i   sdec,d
		mov.i   wo,@d
		spl.a   @d
		mov.i   d,}wo
		jmn.b   anim,}wo
		djn.b   schneller,#4
		mov.ab  #4,-1
		djn.b   0,#speed         
		mov.ab  #speed,-1         
ende            jmp.a   init
		end
