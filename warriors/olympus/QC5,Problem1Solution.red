;redcode
;name QC#5, Problem #1 Solution
;author Mark A. Durham
;assert CORESIZE==8192

code	EQU	(top-to+1)
size	EQU	(top-from)
from	DAT		#top
start	MOV	#size,	 from
	MOV	<table,	 to
wait	JMZ	 wait,	 table
loop	MOV	@from,	<to
	DJN	 loop,	 from
	SPL	@to
	JMP	 start
to	DAT		#4096+code
table	DAT		#top+1
	DAT		#13+code
	DAT		#32+code
	DAT		#64+code
	DAT		#128+code
	DAT		#256+code
	DAT		#512+code
	DAT		#1024+code
	DAT		#2048+code
top	DAT		#4096+code
	END	 start
