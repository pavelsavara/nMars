;redcode-94
;contact <bremermr@ecn.purdue.edu>
;nsfcwt round2
;name Futility 
;author M R Bremer
;strategy redundance
;strategy
;strategy Two multi-pass coreclears.  Either one
;strategy can do the job but sometimes the processes
;strategy in the clear get jumped into my split carpet
;strategy when one of the componenents is overwritten
;strategy by the white warrior
;strategy
;strategy This is the best I could do :-(
;assert CORESIZE==8000

SPACE EQU 16
        spl a1
        jmp b1

ptr1    dat a1, ptr2+100
a4      dat 0,  ptr2+2+1
a3      dat 1,  ptr2+2+2
a2      spl #2,  ptr2+2+3
a1      spl #3, ptr2+2+4
        mov *ptr1, >ptr1
        mov *ptr1, >ptr1
        mov *ptr1, >ptr1
        djn.f -3, <4000
for SPACE
        dat 0, 0
rof

b5      dat 0, 0
b4      dat b5-ptr2, ptr1-2-8
b3      dat b4-ptr2, ptr1-2-7
b2      spl #b3-ptr2, ptr1-2-6
b1      spl #b2-ptr2, ptr1-2-5
        mov *ptr2, <ptr2
        mov *ptr2, <ptr2
        mov *ptr2, <ptr2
        djn.f -3, <6000
ptr2    dat b1, -100+ptr1
