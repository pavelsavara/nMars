;
;    Warrior: Spook
;  File name: spook.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: JOE E. ROBERTSON III / ESCONDIDO / CA / USA
;
GO	MOV	#25,    GO
	ADD	5,	GO
STOPIMP	MOV	#0,	<PTR
	SUB	#5,	PTR
	JMN	STOPIMP,PTR
START	SPL	STOPIMP
PTR	DAT		-5
	END     start
