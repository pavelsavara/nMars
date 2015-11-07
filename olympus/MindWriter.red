;redcode-94
;name Mind Writer
;author David Moore
;strategy Use brainwashing core-clear to get wins over the 3 HSA warriors.
;strategy Then try to take advantage of Probe & Gigolo's boot distances
;strategy If all else fails then make permanent switch to scanner
;assert 1

pKey equ 400

sd equ 6000

aprobe mov adjust, sptr
scan   mov <sptr, {sptr
  for 9
       mov <sptr, {sptr
  rof

sptr   djn.a sd+10, #top+10

top    mov.b 2, #0
       mov 4, >-1
       add #-723, #0+(723*2208)
       jmz.f -2, @-1
       jmn -4, * -4
       spl 0, 0
       mov 2, > -9
       djn.f -1, > -10
       dat 0, 13

       dat 0,0

probe  add.f bab,  bp
bp     sne    10, 110
       jmp    -2,   0
       add.f baa,  bp
baa    spl #3369-99, 4082+10
       mov    bb, }bp
       mov    bb, <bp
       jmp    -2, <probe-3
bb     dat <2667, <5334
bab    dat   200,  200

for 6
 dat 0,0
rof

adjust djn.a 209, #(probe-sptr)+10

       dat   ft-what,0
where  dat   lt-what,0
       dat   wt-what,0
       dat   0,0

boot   ldp.ba   4, what
       mod.a  #12, what
       ldp.ab  #0, where
       add.a @where, what
       stp.ab *what, #pKey
what   jmp @0, aprobe
ft     spl #2, first
       spl #3, first
       spl #4, anti
       spl #5, anti
       spl #0, aprobe
       spl #6, scan
       spl #8, aprobe
       spl #0, aprobe
       spl #10, aprobe
       spl #10, aprobe
       spl #11, aprobe

lt     spl #8, aprobe
       spl #2, first
       spl #3, first
       spl #4, anti
       spl #5, anti
       spl #0, aprobe
       spl #6, scan
       spl #6, scan
       spl #7, aprobe
       spl #0, aprobe
       spl #9, aprobe
       spl #11, aprobe

wt     spl #9, aprobe
       spl #2, first
       spl #3, first
       spl #3, anti
       spl #3, anti
       spl #3, anti
       spl #6, scan
       spl #0, aprobe
       spl #9, aprobe
       spl #10, aprobe
       spl #11, aprobe
       spl #11, aprobe

       add  fi1, @fp
first  sne (MAXLENGTH-CURLINE)+1, (MAXLENGTH-CURLINE)+101
       jmp   -2, <what-1
       add  fi2, @fp
       mov bwb1, }first
fp     mov bwb2, >first
       jmp   -2,  first
fi1    dat  200, 200
fi2    dat 1868-99, 4031-199

       dat 0,0
       dat 0,0
      
anti   mov  3, >2
       mov  3, >1
       jmp -2,  4

bwb1   stp.ab  #12, #123
bwb2   stp.ab   #3, #250

      end boot
