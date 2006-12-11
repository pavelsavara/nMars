Greetings...

This is my entry for round 6, hope it gets to you in time. Thanks for
resending the results and rules to my VAX account. Wish Pizza was
working, my redcode is improving in leaps and bounds and I'd like to
try it out.

Cyaz,

John



;redcode
;name Failure
;author John Metcalf
;strategy Didn't have enough time to optimise this against the listed
;strategy warriors particularly well, so I won't score much more than
;strategy 40 points or so in this round.
;strategy Thanks to Planar for emailing the warriors to me...
;assert CORESIZE==8000
z for 9
spl p&z+9,{-(800+q*100)
rof
z for 10
p&z:spl 1,{-(1600+z*200)
mov -1,0
spl 1,{-(1700+z*200)
spl @0,>1196+z*430
mov }-1,>-1
mov 3,<-110
add #90,-3
jmp -4,{-4
dat 1,1
rof
end



--
  Fidonet:  Grumpy 2:254/269
  Internet: grumpy@bsm-bbs.demon.co.uk

  Standard disclaimer : The views of this user are strictly their own.
  Don't delay, call today - Boiled Sweets Music BBS +44 (0)171 686 0135/6

