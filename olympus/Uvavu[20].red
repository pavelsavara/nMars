;redcode-b
;name Uvavu
;author Scott Manley
;Strategy 0.5 c stone

start	SNE	-100,-200
	SEQ	-300,-400
	MOV.A	#-400,tar
	SNE	-500,-600
	SEQ	-705,-805
	MOV.A	#-805,tar
	SNE	-905,-1005
	SEQ	-1105,-1205
	MOV.A	#-1205,tar
	SNE	-1310,-1410
	SEQ	-1510,-1610
	MOV.A	#-1610,tar
	SNE	-1710,-1810
	SEQ	-1910,-2010
	MOV.A	#-2010,tar
tar	ADD.ab	#0,i2
	MOV	i1,500
	MOV	begin,500
	MOV	i2,500
	MOV	i3,500
	MOV	i4,500
	JMP	@-3		 
	DAT	0,0
i1	DAT	4000,4000
begin	MOV	-1 , @1
i2	MOV	-2 ,-557 
i3	ADD.AB	#5 , -1
i4	JMP	-3 , > -7
	end	start	

