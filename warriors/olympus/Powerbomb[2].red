outptr		DAT	0
scan		ADD	#108,outptr
		JMZ	scan,@outptr
		MOV	outptr,@outptr
		JMP	scan
		END	scan
