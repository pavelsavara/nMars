;redcode-94
;name NC 94
;author Wayne Sheppard
;strategy Small bomber and spiral


;I can't believe it's Friday already.
;This is the only thing I have lying around that has
;a chance of winning.
;This is totally unoptimized.  No decoy, no b-field decrements
;I don't even have the right ratio of process in the stone/spiral.
;I need to get some launch code for the bomber.  It's getting
;chewed up by carpet layers and quick-cmps.
;  Just wait until my quick-cmp comes out ;)


i equ imp+202
mov s+2,j-3044
mov s+1,<-1

mov s,<-2
spl imps
spl 1
spl #-3044,<3044
add -1,1
mov >-1-3044-3044-3044,1
j jmp -2
s spl #0,<-5
  mov 1,<-3
  dat <-6,<-7
;Binary imp launch
imps SPL 8
SPL 4
SPL 2
JMP i+0
JMP i+2667
SPL 2
JMP i+5334
JMP i+1
SPL 4
SPL 2
JMP i+2668
JMP i+5335
mov imp,i ;waiting
JMP i+2
imp mov.i #-20,2667
