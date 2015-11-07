;redcode-icws
;name Agony T
;author Stefan Strack
;strategy Small-interval CMP scanner that bombs with a SPL 0 carpet.
;strategy 2.0: smaller
;strategy 2.1: larger, but should tie less; changed scan constants
;strategy 2.2a: smaller
;strategy 2.3a: mutagenizes core
;strategy 2.4: smaller CMP interval, spends less time bombing
;strategy 2.4b: mutagenize constant optimized
;strategy 3.0: long scan with anti-imp constants (a la Charon v8.0+)
;strategy 3.1: zero bfield bombs again: more robust
;strategy T: version 8192 core (ICWST'94)
;strategy Submitted: @date@

CDIST	equ 12
IVAL	equ 25
FIRST	equ (scan+OFFSET+IVAL)
OFFSET	equ (12*IVAL)
DJNOFF	equ 7437

scan	sub incr,comp
comp	cmp FIRST-CDIST, FIRST
	slt #incr-comp+CDIST+(bptr-comp)+1,comp
	djn scan,<FIRST+DJNOFF
	mov #CDIST+(bptr-comp)+1,count
	mov comp,bptr
bptr	dat #0
split	mov bomb,bptr
count	djn split,#0
	jmz scan,scan-1
bomb	spl 0,<0-IVAL+1
	mov incr,<count
incr	dat <0-IVAL,<0-IVAL
	end comp
