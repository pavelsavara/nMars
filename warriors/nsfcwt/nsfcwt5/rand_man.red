;redcode-94
;name Rand-Man
;kill Rand-Man
;author Randy Graham
;contact hp715!rgraham@peridot.spawar.navy.mil
;NSFCWT round 5
;assert 1
;strategy Fight in a random core size.  Move weak stone away from decoy
;strategy and launch gate-crashing imp spiral.  Use pspace to save time
;strategy on later boots (but protect against brainwashing).

IMPOFF    equ    (imp+500)
IMPSIZE   equ    #3    ;what step size we think we need
PDATPTR   equ    #2    ;save # of points to verify step size
STONESAVE equ    #1    ;what stone step we want
STONESTEP equ    36    ;what to start check at
STONEMAX  equ    50    ;what to stop at

imp       mov.i  #3044,      -1
imp2      mov.i  #1143,      1
launch3   spl.a  adder3,     <-330
jmpto3    jmp.a  IMPOFF+6,   <-91
adder3    add.ba imp2,       jmpto3
datptr    dat.f  13,         getptr
          dat.f  11,         0
          dat.f  7,          0
          dat.f  5,          0
getsize   ldp.ab IMPSIZE,    #0      ;these 2 lines double as data
getptr    ldp.ab PDATPTR,    datptr  ;statements
          mul.ab @datptr,    getsize
          seq.ab #1,         getsize
counter   jmp.a  starter-1,  0
getstone  ldp.a  STONESAVE,  setstone
          ldp.ab IMPSIZE,    imp      ;restore location
          jmp.a  postsave,   <-431

          mov.ab #(getptr-datptr), datptr
starter   div.ab #2,         imp
          add.ab #1,         imp      ;set imp.b to CORESIZE/2
moder     mod.ba #-1,        #2
          jmz.a  psave,      moder    ;make 2-point imp if odd core

check     mov.a  <datptr,    gotit    ;do some housekeeping for each test
          sub.a  #1,         gotit
          mov.ab #0,         counter
          mov.ab #-1,        skipper

;from Jay Han's MakeImp.c, R = CoreSize % Points  --> R=m%p
; I can't do Coresize % Points, but I can do (Coresize-1)%points
; Then, add one to make up for the one we subtracted.  Finally, mod
;   that with points again to make sure we have the real mod.

setup     mod.ab @datptr,    skipper
          add.ab #1,         skipper
skipper   mod.ab @datptr,    #0       ;after this, we have our mod

;The next part is a hybrid of Brant D. Thomsen's Imp-Spiral Finder in
;  the May 4, 1994 issue of The 94 Warrior and Jay Han's routine in
;  makeimp.c.  This calculates the N value for Jay's
;    ImpStep = (CoreSize * N + 1) / ImpSize  ---> x=(m*n+1)/p
;The idea for only looping through ImpSize-1 times and checking is 
;  from Brant's program's data lines (get the program and see it)
;Now, to actually check if our attempted point size is an impstep, we
;  use Jay's lines
;    Counter = 0
;    if (Counter+R) % Points == Points - 1   --> if ((c=(c+r)%p) == p-1)
;  until we have checked Points-1 times or we get the match
          
          mov.ab gotit,      loop  
check2    mov.ab #0,         gotit
setN      add.ab #1,         counter
          add.b  skipper,    gotit
          mod.ab @datptr,    gotit
gotit     sne.ab #0,         #0
          jmp.a  sizer,      <-100
loop      djn.b  setN,       #loop
          jmn.b  check,      datptr   ;in case this fails, at least stone

;Here was the hard part.  Given the number of points we can theoretically
;  run in this core size, and knowing Coresize/2, figure out the correct
;  step size.  In Jay's program, he used
;    ImpStep = (CoreSize * N + 1) / ImpSize  ---> x=(m*n+1)/p
;  as noted above.  We have the N now, but how to do the math in a
;  modular world.  Well, I finally decided to give up on getting it right,
;  and just get close.  Then I can find the exact amount.  So, throw
;  away the +1, combine the terms, and remember that you know CoreSize/2
;  Use the above ImpStep equation, modified for what you have
;    ImpStep = (CoreSize / 2 / ImpSize * N) * 2  (approximately)
;By doing the division first, then multiplying, we don't have the
;  wraparound effect of the Modular world mess us up.  And, we get
;  pretty close to the correct value.  Also, since we are using integer
;  division and we ignored the +1 above, we know we will be slightly 
;  BELOW the correct value.  So, add one, multiply it by the number of
;  points.  If it is equals 1 (in a modular world), then it is correct.
;  If not, loop back, add one more, multiply again, and go until you get
;  a 1.  Then, you have what you need, so move your imp out and launch 
;  it (using a jmp/add launch which let's you add in your step as you go)
;As for why this works, I don't exactly know.  You have to ask Jay for
;  details.  I just converted his C code to Redcode.  ;-)

sizer     div.ab @datptr,    imp    ;approximate the step size
          mul.ab #2,         imp
          mul.b  counter,    imp
exact     mov.b  imp,        #0
          mul.ab @datptr,    -1
          seq.ab #1,         -2
          jmp.a  exact,      >imp

psave     stp.b  datptr,     PDATPTR
          stp.b  imp,        IMPSIZE

;Ffrom Jay Han's corestep, find a number from mod-4 to mod-7.  If no
;number is usable, then use 7 (per moonstone).  C code was:
;  uint modsize (uint s)
;  {
;     uint r, b=s, a=coresize;
;     if (s == 0 || s == 1) return s;
;     while (r=a%b)
;     {
;        a=b;
;        b=r;
;     }
;     return b;
;  }
;
;where uint is an unsigned integer, and s is the number to find the
;  modsize for
;I used from 36 to 51 as my s.
;I only stopped on s == 0 (save 2 instructions, waste 5 cycles - but
;  those two instructions would be executed every time otherwise).
;When I found a modsize between 4 and 7 (inclusive) I used it
;Man I like Jay's code.  Helped a lot on this round
;I just hope I do OK.  I am REALLLLLY slow launching because of finding
;  my stone step size - especially in prime size cores

setstone  mov.a  #STONESTEP, findstone        
          mov.ab #-1,        findstone
          mod.ab setstone,   findstone
          add.ab #1,         findstone
findstone mod.ab #0,         #-1
          jmz.b  keepstone,  findstone
          mov.b  findstone,  a
          mov.ab findstone,  findstone
          mov.ba a,          findstone
a         jmp.a  findstone,  0

keepstone slt.ab findstone,  #8   ;want at most mod-7
          jmp.a  keepstone+4,0
          slt.ab findstone,  #4   ;keep it if mod4-mod7
          jmp.a  psave2,     0
          slt.a  #STONEMAX,  setstone    ;found nothing, work with what we
          jmp.a  setstone,   }setstone   ;have
          mov.a  #7,         setstone    ;use some small step

psave2    stp.ab setstone,   STONESAVE
postsave  add.b  imp,        imp2

          mov.a  @datptr,    build     ;build up processes
          add.a  build,      build
          mul.ab #2,         enough
build     slt.ab #0,         enough
          jmp.a  -2,         <-300
          mov.i  imp,        IMPOFF
          spl.a  l_stone,    <enough
          spl.a  1,          <enough
enough    jmn.b  -1,         #4        ;build up at least 2+impsize
setimp2   mov.i  imp2,       >launch1  ;set up gate crashing imps

threeway  spl.a  launch1,    <-190
          spl.a  launch3,    <-150

launch2   spl.a  adder2,     <-135
jmpto2    jmp.a  IMPOFF+4,   <jmpto3
adder2    add.ba imp2,       jmpto2
datend2   dat.f  <-150,      <-250

launch1   spl.a  adder1,     IMPOFF+4  ;now jmp/add launch
jmpto1    jmp.a  IMPOFF,     <-275

stone     spl.a  #0,         <-12    ;weak self-destructing stone
          add.f  sweep,      1
          mov.i  <1,         1
          jmp.f  -2,         -2
sweep     mov.i  0,          <0

l_stone   add.a  setstone,   sweep
          sub.ab setstone,   sweep
          mov.i  <j_stone,   {j_stone
          mov.i  <j_stone,   {j_stone
          mov.i  <j_stone,   {j_stone
          mov.i  <j_stone,   {j_stone
          mov.i  <j_stone,   {j_stone
;delay launch as long as possible in case of low process limit
j_stone   spl.a  imp+383,    stone+5
          mov.i  2,          j_stone  ;cover our pointer
adder1    add.ba imp,        jmpto1

end getsize
