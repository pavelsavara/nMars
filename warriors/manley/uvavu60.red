;redcode-b
;name Uvavu
;author Scott Manley
;Strategy 0.5 c stone
;strategy Wilkinson Benchmark score 42.5
;strategy Percentage record	    13/82/5

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
	SNE	-2115,-2215
	SEQ	-2315,-2415
	MOV.a	#-2415,tar
	SNE	-2515,-2615
	SEQ	-2715,-2815
	MOV.a	#-2815,tar
	SNE	-2920,-3020
	SEQ	-3120,-3220
	MOV.a	#-3220,tar
	SNE	-3320,-3420
	SEQ	-3520,-3620
	MOV.a	#-3620,tar
	SNE	-3725,-3825
	SEQ	-3925,-4025
	MOV.a	#-4025,tar
	SNE	-4125,-4225
	SEQ	-4325,-4425
	MOV	#-4425,tar	
	SNE	-4530,-4630
	SEQ	-4730,-4830
	MOV	#-4830,tar
	SNE	-4930,-5030
	SEQ	-5130,-5230
	MOV	#-5230,tar
	SNE	-5335,-5435
	SEQ	-5535,-5635
	MOV	#-5635,tar
	SNE	-5735,-5835
	SEQ	-5935,-6035
	MOV	#-6035,tar
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
        end     start
