add #28,2     ;add the number 28 to the B field of 2 ahead
mov 2,@1      ;move the address(ie copy) 2 ahead at the number in the B field 1
jmp -2,#3201  ;ahead.  Jmp to add instruction.  # is like a DAT in the b field
dat #0,#0     ;This is the guy that gets placed in memory, he is very nasty
	      ;when executed, ie, he kills the other code.
	      ;This program will not kill itself, for it bombs every 4, and is
	      ;only 3 long(it doesnt matter if it bombs it's own dat #0,#0
	      ;it's not very efficent, but it gets the job done.
