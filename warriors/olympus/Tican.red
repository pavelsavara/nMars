;contact jwilkinson@mail.utexas.edu
;NSFCWT Round 3
;redcode-94
;name Tican
;author John Wilkinson
;strategy Paperish.  Tuned against scanners...
;strategy Added another stone, cannonade.  I want to make sure the
;strategy core gets flooded fast, to prevent scanners from locking
;strategy on...  Plus, these two stones can get some nice wins...

stinc    equ 190
TSTEP equ 1800
CSTEP equ 3740
NSTEP equ -1922
FSTEP equ 1870
S     equ tim1+3820

org warrior

tim1	spl	@tim1,		}TSTEP
	mov.i	}tim1,		>tim1
cel1	spl	@cel1,		}CSTEP
	mov.i	}cel1,		>cel1
	mov.i	{-FSTEP,	<FSTEP
	mov.i	{cel1,		<ncl1
ncl1	jmp	@ncl1,		>NSTEP

st for 49
	dat.f	0,		0
rof

ptr:     dat.f stone, S
stone    mov   <stspl+5+(stinc*800),stspl
stspl    spl   -1,<2
stadd    add   3,stone
         djn   -2,<5141+1
         dat   0, 0
inc      mov   stinc,<-stinc

st for 23
	dat.f	0,		0
rof

warrior	mov     }ptr,           >ptr
        djn     -1,             #6
        spl     S+1,            <-500

	spl	1,		<-200
	spl	1,		<-300
        mov.i   -1,             0

        spl	tim1,           <-400

tim2	spl	@tim2,		}TSTEP
	mov.i	}tim2,		>tim2
cel2	spl	@cel2,		}CSTEP
	mov.i	}cel2,		>cel2
	mov.i	<-FSTEP,	{FSTEP
	mov.i	{cel2,		<ncl2
ncl2	jmp	@ncl2,		>NSTEP
