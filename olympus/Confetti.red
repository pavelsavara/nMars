;name confetti (maybe skipping stone would be a better name, better, or flying carpet, or paper airplane....)
;author marshall
org start 
start    SPL 1
		SPL 1
		SPL 1
		JMP 2 ;do this once wont have to after first replication
aim	DAT 0,	100 ;step size is completely arbitrary
		MOV }aim, >aim  ;allows skipping of counter reset
		MOV  aim, >aim
		MOV  aim, >aim
		MOV  aim, >aim ; a bigger carpet of bombs
		MOV  aim, >tep
