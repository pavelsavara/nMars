*	
*	OGRE is a version of dwarf which takes advantage of the PCT command
*	to protect a location behind it so that it can't be run over by
*	IMPs.
*
@-2
	dat 0
bompt	dat -2
	pct -2
lup	add #11 bompt
	mov #0 @bompt
	pct @bompt
	jmp lup
