;redcode-94
;Name QComp-Hunter v2.2
;Author Randy W. Graham
;assert 1
;I always assert 1.  I make assumptions when programming, and it
;is my own problem if my assumptions fail.

;strategy cmp-scanning carpet bomber based on Rave.
;strategy v1.0 Added a small step QScan to hunter - only scan part of core
;strategy v2.0 Finally got right starting point after moving.
;strategy v2.1 Fixed bug that repeated a qscan triple & eliminated one line
;strategy v2.2 two lines longer but - made qscan bomb more efficiently
;strategy   and shortened bombing run on hunter

OPT equ 42      ;mod 2
LEN equ (fini-adder+1)   ;adjusted in v2.1 because we moved our code
     ;around in the decoy

DIFF equ 13    ;difference between sites in Hunter's cmp line
BOMBS equ DIFF+2        ;how many bombs to lay
MOVETO equ 1176 ;where we move to
MOVEADJ equ (MOVETO/OPT*OPT)   ;adjust to allow a full run

OFF equ -381    ;djn stream offset - not correct for longest run, but
        ;gives best score

QSTART equ -400  ;where to start QScan
QDIFF equ 70     ;how far apart to scan
QBOMBS equ 12    ;how many bombs to lay on QScan target

begin
qscana for 6      ;6 triples scan 4 sites each
         sne.i  QSTART-(QDIFF*(qscana-1)*4), QSTART-(QDIFF*(qscana-1)*4)-QDIFF
         seq.i  QSTART-(QDIFF*(qscana-1)*4)-QDIFF*2, QSTART-(QDIFF*(qscana-1)*4)-QDIFF*3
         mov.ab #-2-found, found        ;point to above sne line
rof
         jmn.b  found+1, found    ;if we found something, start attack


qscanb for 7      ;7 triples scan 4 sites each
         sne.i  QSTART-(QDIFF*(qscanb+5)*4), QSTART-(QDIFF*(qscanb+5)*4)-QDIFF
         seq.i  QSTART-(QDIFF*(qscanb+5)*4)-QDIFF*2, QSTART-(QDIFF*(qscanb+5)*4)-QDIFF*3
         mov.ab #-2-found, found        ;point to above sne line
rof
         jmn.b  found+1, found    ;if we found something, start attack

qscanc for 7      ;7 triples scan 4 sites each - grand total of 80
         sne.i  QSTART-(QDIFF*(qscanc+12)*4), QSTART-(QDIFF*(qscanc+12)*4)-QDIFF
         seq.i  QSTART-(QDIFF*(qscanc+12)*4)-QDIFF*2, QSTART-(QDIFF*(qscanc+12)*4)-QDIFF*3
         mov.ab #-2-found, found        ;point to above sne line
rof

found    jmz.b  moveme,   #0      ;if we don't have anyone, move me
found2   mov.ba found,    found   ;otherwise set up to attack
         mov.i  found,    found2  ;make found2 point to seq line

         add.f  *found,   found   ;adjust found to point to scanned location
         add.f  *found2,  found2  ;adjust found2 to scanned location
         add.a  #1,       found2  ;we will move this later, so adjust it

         sne.i  *found,   @found  ;if found points to difference, use it
         mov.i  found2,   found   ;otherwise set up to bomb found2
         jmn.f  attack,   *found  ;if a-field isn't empty, attack it
         mov.ba found,    found   ;otherwise 

attack   mov.i  spltrap,  }found  ;bomb a field
         djn.b  attack,   #QBOMBS

moveme   mov.i  >traps,   >moveto  ;move me away now

for 6                              ;simply rolled move into macro
         mov.i  >traps,   >moveto
rof

moveto   spl.a  MOVETO+1, #MOVETO  ;we haven't finished copying, but
    ;we can start scanning anyway.  We will finish copying in time
    ;to bomb or to add to our cmp line

for 4
         mov.i  >traps,   >moveto
rof
         mov.i  datadd,   >moveto
         mov.i  traps,    moveto
datadd   dat.f  >-1-OPT,  <-1-OPT+4     ;set up imp gate

adder    add.f  spltrap,  cmper ;adjust our compare sites

cmper    cmp.i  adder-DIFF-OPT-MOVEADJ-(OPT*2), adder-OPT-MOVEADJ-(OPT*2)
;cmper    cmp.i  adder-DIFF-OPT, adder-OPT

     ;see if they differ - need to skip past decoy.  This does
     ;leave some unscanned first time through, but otherwise I
     ;waste too much time bombing my own decoy first time through

         slt.ab #LEN+BOMBS, cmper
     ;above cmp found a difference.  We must make sure that
     ;my code isn't the difference.

         djn.i  adder,    <OFF  ;lay djn stream, jump to add line
     ;if the cmp found nothing, or if the slt sees we are about to
     ;bomb ourself, we hit this djn line.  It decrements to a and b
     ;fields of whatever OFF points to after being decremented.
     ;IFF the field contains 1 in a and b, we would fall through to
     ;the bomb routine, otherwise we loop back to our adder.

setup    mov.ab #BOMBS,   traps ;get bombs ready

         mov.i  spltrap,  }cmper        ;start carpetting

traps    djn.b  -1,       #adder        ;keep bombing for a while
     ;use b-field of traps above in MOVEME routine

         sub.a  #BOMBS,   cmper ;reset cmp pointer

         jmz.i  adder,    adder-1       ;if we haven't bombed ourself, scan more

spltrap  spl.a  #0-OPT,   >0-OPT        ;trap, and stay alive line.
     ;by adding the f value in adder above, we make our way backwards
     ;scanning memory 13 locations apart

sweep    mov.i  1,        <traps        ;lay dats down til we bomb here
     ;we copy this throughout memory to kill of spl-trapped opponents

fini     end    begin
