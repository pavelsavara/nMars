;redcode-94
;name Eights
;kill Eights
;author Randy Graham
;contact hp715!rgraham@peridot.spawar.navy.mil
;NSFCWT Round 3
;assert 1
;strategy mod-5 stone that is partnered with Aces.

OPT     equ    2365  ;mod-5 bomber
ADJ     equ    711   ;make sure this matches Aces

first   dat.f  0,       <2667
for 30          ;dummy lines to protect against single pass scanners
        dat.f  first,   <2667
rof
for 40
        dat.f  0,       0       ;spacing to protect against core-clears
rof
compare mov.i  #0,      0       ;here's where we'll test for our flag
begin   jmz.b  begin,   {adder  ;speed of light search for partner
check   mov.f  *adder,  compare ;now see if it is our signal
OK      seq.i  compare, *adder
failed  jmp.a  begin,   <-30    ;false alarm, keep going
adder   add.a  first,   moveto  ;adjust our move to pointer
adder2  add.a  adder,   moveto

        mov.i  <moveto, {moveto ;get out of here
        mov.i  <moveto, {moveto
        mov.i  <moveto, {moveto
        mov.i  <moveto, {moveto
moveto  spl.a  ADJ,     looper+1
        dat.f  0,       0       ;stop now so the bomber runs elsewhere

stone   spl.a  #OPT,    <-OPT   ;just a dumb mod-5 perpetual bomber
mover   mov.i  }-2+OPT, 3-OPT
changer add.f  stone,   mover
looper  djn.f  mover,   <-164

end begin
