;redcode-b
;name Uvavu
;author Scott Manley
;strategy 0.6 c Mod 10 Vamp -> core clear
;******
;DECOY
for 40
	spl	#1, 1
rof
;******
boot	SPL	1,0
	SPL	1,1
	SPL	1,2
	SPL	1,3
	MOV	}copy,>copy
	DJN	2,#1
	JMP	2434,#1
	MOV     }-10,>-10	
copy	DAT	0, 2430
jmpb	JMP	-2  , <-4 
begin	MOV.I	splb , @targ
	MOV.I	jmpb , *targ
targ	MOV.I	*-2430,@-2432
	ADD.F	inc,targ
	DJN	-4,#799
splb	SPL	0,1
	MOV	1,<-2
inc	DAT	}-2430,>-2430
;********
;Decoy
for MAXLENGTH-CURLINE
	spl	#1, 1
rof
;********
	END	boot
