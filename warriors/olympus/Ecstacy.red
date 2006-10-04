;
;    Warrior: Ecstacy
;  File name: xtc.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Stefan Roettger / Sandstrasse 3 / W-8525 Uttenreuth / Germany
;
; This warrior was originally designed for core size=8192 but it
; also runs very well with core size mod 4 = 0 (e.g. 8000).
; Although it runs under the 1988 standard there are no changes
; necessary to make it run under 1986 standard.
; The startegy used by XTC is the following:
; The warrior compares every fourth core location to zero by
; incrementing a search pointer by #412. To avoid being hit
; by itself every fourth instruction has a B-Operand equal to
; zero. If a supposed foe is found 23 core cells around this foe
; are set to 'SPL -1 -1' by a simple copy loop. This causes the
; foe to be slowed down quite well but not yet kills him. If all
; spawns have been treated like that they are subsequently killed
; by shooting some deadly 'DAT 0' instructions at them.
; Empirical studies have shown the the warrior XTC by far outruns
; nearly all warriors of ICWST 86 and ICWST 88. For example it
; defeats ferret in 70% and mice in 90% of all cases.
; The reasons for this are:
; -XTC is very small cause of tricky programming
; -XTC's search loop is very very quick
; -The method by which XTC kills foes is highly reliably.
; All this makes XTC my warrior of choice. :-)
; Please start XTC at the label 'loop'.
  
loop  add #412, ptr
ptr   jmz loop, trap
      mov ptr,  dest
cnt   mov #23,  cnt
kill  mov @trap, <dest
      djn kill, cnt
      jmp loop
      dat 0
      dat 0
      dat 0
      dat 0
      dat 0
      dat 0
dest  dat 0
      dat 0
      dat 0
      dat 0
      dat 0
      dat 0
trap  dat bomb
bomb  spl trap, trap
