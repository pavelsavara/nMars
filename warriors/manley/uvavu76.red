;redcode-b
;name Uvavu
;author Scott Manley
;Strategy 0.5 c stone
;strategy Wilkinson Benchmark score 38.0
;strategy Percentage record        11/84/5 

start	SNE	-100,-200
	SEQ	-300,-400
	MOV.A	#-400,tar
	SNE	-500,-600
	SEQ	-705,-805
	MOV.A	#-800,tar
	SNE	-905,-1005
	SEQ	-1105,-1205
	MOV.A	#-1200,tar
	SNE	-1310,-1410
	SEQ	-1510,-1610
	MOV.A	#-1600,tar
	SNE	-1710,-1810
	SEQ	-1910,-2010
	MOV.A	#-2000,tar
	SNE	-2115,-2215
	SEQ	-2315,-2415
	MOV.a	#-2400,tar
	SNE	-2515,-2615
	SEQ	-2715,-2815
	MOV.a	#-2800,tar
	SNE	-2920,-3020
	SEQ	-3120,-3220
	MOV.a	#-3200,tar
	SNE	-3320,-3420
	SEQ	-3520,-3620
	MOV.a	#-3600,tar
	SNE	-3725,-3825
	SEQ	-3925,-4025
	MOV.a	#-4000,tar
	SNE	-4125,-4225
	SEQ	-4325,-4425
	MOV	#-4400,tar	
	SNE	-4530,-4630
	SEQ	-4730,-4830
	MOV	#-4800,tar
	SNE	-4930,-5030
	SEQ	-5130,-5230
	MOV	#-5200,tar
	SNE	-5335,-5435
	SEQ	-5535,-5635
	MOV	#-5600,tar
	SNE	-5735,-5835
	SEQ	-5935,-6035
	MOV	#-6000,tar
	SNE	-6140,-6240
	SEQ	-6340,-6440
	MOV	#-6400,tar
	SNE	-6540,-6640
	SEQ	-6740,-6840
	MOV	#-6800,tar
	SNE	-6945,-7045
	SEQ	-7145,-7245
	MOV	#-7200,tar
	SNE	-7345,-7445
	SEQ	-7545,-7645
	MOV	#-7600,tar
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
i2	MOV	-2 ,-587 
i3	ADD.AB	#5 , -1
i4	JMP	-3 , > -7
        end     start
