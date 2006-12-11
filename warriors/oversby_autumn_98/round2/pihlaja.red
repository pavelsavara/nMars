;redcode
;name Genetic Beef
;author M Joonas Pihlaja
;strategy clear with strip bombing - sort of.
;assert 1

 spl.f  0, 0		; Wait for oneshots to pass us and gather up some
 spl.f  0, 0		;  vital processes for later.
 spl.f  0, 0
 spl.f  0, 0
 spl.f  0, 0
 sub.f <0,>0		; These early addressing modes try to sub whatever
 sub.f *0,>0		;  the enemy clears us with to yield spl 0,0's.
 spl.f  0,{0		;  Very necessary against backward (+forwd.) clears
 sub.f }0,<0		;  that catch us early.
 sub.x >0,{0
 sub.f }0,{0
 sub.x }0,>0
 sub.f >0,<0
 sub.f }0,>0
 sub.x {0,>0
 sub.x  0,}0
 spl.x {0,>0
 sub.f <0,>0
 spl.f >0,}0		; A final concentrated effort to jump ship.
 spl.x <0,{0

end

Early on, a quickish forward 0,0 clear cripples the enemy in front of the
warrior, and pretty soon it's joined by a backward clear that finishes
covering the core.  Works better than head on random scrambling.

Adds or subs make for a better attack than movs, since they create better
clear bombs of the increments and decrements.  This also means that if the
body is continuously overwritten by some constant (e.g.  by a clear or
HSA), then the warriors only hope is changing it's clear pointers radically
before we are overwritten again.  With mov.f/x, the pointers are simply
reset with something, whereas with add/sub, they are incremented => better
coverage.

I think subs have only one advantage over adds, and that is the possibility
of subtracting a freshly overwritten (by the enemy) piece of the code
by whatever it was overwritten by, thus undoing the enemy's work.  It's
not as foolproof as I would like it to be, but it does help some.

A genetic algorithm bred the proper mix of spls, subs, and addressing modes
to get the most punch out of each line.  Each candidate was benchmarked
against a test suite of 16 warriors consisting of 2 backward clears and
oneshots, 4 forward (d-)clears and oneshots, four scanner variants (HSA,
Neverland, jmz.f blur -> d-clear, and The Machine), three stone variants
(Rosebud, Newt, .66 bomber->clear), and finally an all 20 spl 0,0 warrior.
The two remaining positions were filled by the top two warriors of the
previous generation, which hopefully gives the proper amount of resistance
to other similar warriors that may come up.

At *least* it doesn't suicide. :)

Joonas

