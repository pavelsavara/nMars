;redcode-94x
;name Stabbing Forward
;author Christian Schmidt
;strategy no .i, no #, mmmhhh...
;strategy the most effective strategy for this round seems to be a coreclear.
;strategy Ok, let's programm an a-field incrementing d-clear with a maximum
;strategy increment/decrement protection. I know that this isn't the only
;strategy clear in the round, so I thought about how can I get an advantage.
;strategy And the answer is: make it as fast as possible :-)
;assert 1

aPtr    spl.b   200,    0

for 4
        spl.b   0,      0
rof

cStart spl.b   0,      }aPtr
cLoop mov.a   cBomb,  }aPtr
   for  3
        mov.a   cBomb,  }aPtr
   rof
 djn.f   cLoop,  }aPtr

for 4
        spl.b   0,      0
rof

cBomb spl.b   }27,    }cBomb-aPtr

for 4
        spl.b   0,      0
rof

        end cStart

