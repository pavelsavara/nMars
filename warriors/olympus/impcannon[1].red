*
*	If one IMP is a formidable weapon, then many ought to be more so.
*	Here is a program that fires off an imp every 150 turns. Actually
*	the reasoning is not valid, since each new imp robs the other of 
*	execution time, and they all slow down. A slow IMP is very easy to
*	kill (left as an exercise for the reader).	
*
@-1
dat 10		* timer initially set to 10
djz 2 -1
jmp -1
mov #150 -3	* timer reset to 150 (change at your discretion)
spl 2
jmp -4
mov 0 1
