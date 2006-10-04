;redcode-94
;name  v15
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSFCWT Round 2
;assert CORESIZE == 8000
;assert VERSION >= 63

;note that this only works for versions better than 63 and I only got
;to version 15.  If I only had another week!

;strategy  Serious scanner.
;strategy  v15:  Optimized constants for the white warrior
;strategy        added 1800-step-size kludge.

for 0
  Strategy:  Hunt the paper!  (Ignore the bombs at the start.)
             Scan at .86c
             -- No djn trail, to keep core as clean as possible
             -- Pointer at top of code aids in program not bombing
                itself 
             -- Use .f modifier to prevent my bombs from being detected
             -- Mod 1, minimized find-8,find-6,find-13,and find-2

             SPL carpet bomb
             -- Move back an instruction
             -- Bomb ;foreward, until no more enemy instructions
             -- Invisible bombs

             Kludge
             -- Check 1800 instructions ahead, where another paper may be

             Timer
             -- Add half-step to p1 in case the enemy was found in the
                A-field.  Jump near end of scan loop for speed if
                A-field points to enemy 
             -- Scan all the way through a mod 1 cycle (8000 steps!)
             -- Eventually the working pointer (B-field of p1-1)
                bombs itself, to trigger the core-clear.

             Two-pass core-clear
             -- DJN-stream moves ;foreward so that core-clear data is away
                from  p1-1, which if hit starts premature core-clear
             -- simple SPL-DAT combo is about all that is needed by this time

  Score against White Warrior (practice):
            (  W  /  L  /  T  )   Score      n=
             76.40/17.34/ 6.26    235.46     3288

  Other comments:
             Most labels end in "1", because I originally had this code
               duplicated ;for added redundancy against the bombing run.
               That didn't help.
             This is the toughest White Warrior I have ever seen.
               Good job, Nandor & Stefan!

rof

;code starts here:

org other1

step equ 3889

p1     dat -step-step-1,-step-1

d1     dat step+step,step+step

c1     dat -step,-step

loop1  sub d1,p1
       sne.f *p1,@p1
       sub d1,p1
       sne.f *p1,@p1
       sub d1,p1
other1 seq.f *p1,@p1
       slt #cc-p1+1,p1
       jmp loop1
       mov p1,p1-1
       mov s1,>p1-1
timer1 jmn.f -1,@p1-1
       add #1800-6,p1-1     ;these next 3 lines add about 30 points!
       slt p1-1,#cc-p1+2    ;Important: don't accidently bomb self.
       jmn.f -4,@p1-1
       add c1,p1
       jmn.a other1,p1-1
s1     spl #0
       mov @1,<cc
       djn -1,}cc-1
       
       dat 1,-4
       spl #1,-5
cc     dat 1,-6

end
