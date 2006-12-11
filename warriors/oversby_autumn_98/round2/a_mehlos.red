;name Misplaced Optimism
;author A. S. Mehlos
;strategy Submission for round 2 of Ian's tournament:
;strategy 
;strategy I've got _no_ idea how this guy's gonna do, since I 
;strategy really only had my own other warriors to test it 
;strategy with. As I see it, with no "mov.i"'s to deal with,
;strategy there's no good reason not to make every one of the 
;strategy 20 instructions valid. This should be interesting, though.
;strategy (Though I fear I'll do worse this round than last.)
;assert CORESIZE == 800

org addr
spares spl 0, }140
       spl 50, }190
       spl 0, }-140
       spl 0, }-200
       spl 0, }-351
addr    spl 0, }-113
middle  spl 1, }30
        sub.b addr, middle
	spl 1, }110
	spl 0, }211
        spl 0, }311
        spl -50, }312
        spl addr, }-160
        spl middle, }-190
        spl 0, }177
        spl 0, }-210
        spl spares, }-199
        spl middle, }321
        spl 50, }-222
        spl addr-3, }99

end
