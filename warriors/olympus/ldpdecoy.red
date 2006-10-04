;redcode-94
;name ldpdecoy
;assert 1

dc	equ	go-1500

go	nop	}dc,	}dc+2
	ldp.ab	}dc+1,	{dc+4		; uses p.0
	ldp.a	<dc+5,	{dc+7		; uses p.-1

; creates
;
;dc	dat	1,	0
;	dat	1,	0
;	dat	0,	1
;	dat	0,	p.0
;	dat	-1,	0
;	dat	0,	-1
;	dat	p.-1,	0
;	dat	-1,	0
