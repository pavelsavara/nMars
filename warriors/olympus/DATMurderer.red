;redcode-94
;name DAT Murderer
;author Josh Yeager
;assert 1
;strategy It initializes and then sweeps about 98% of the core with JMP 0,
0 
;strategy bombs then it splits into 5 bombers and an imp-gate. The 
bombers 
;strategy immediately start DAT 0,0 bombing. 
;version numbers:
;1.0	the original program
;1.1  fixed small bugs
;1.2  added a decoy and move routine to counteract scanners
;2.0  not here yet; want to add a pspace routine

boot
count	for    MAXLENGTH	mov count+6,count+3000	
rof
decoy
for 100
DAT 1,1
rof
;coreclear
dat 0,(t=7840)
stun
mov 1,t+80
JMP 0,0
djn stun,t
dat 0,(t=7840)
kill	mov 1,t+80
DAT 0,0
djn kill,t
end
