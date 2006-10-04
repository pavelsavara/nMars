;redcode
;name Killer instinct
;author Anders Ivner

step    equ     3044       ; Kindly provided by Anders himself.  Thanks.
away    equ     -103
found   equ     last-1+away+step

boot    mov     @spt,   last+away
        mov     <spt,   <boot
        mov     <spt,   <boot
        mov     <spt,   <boot
spt     jmp     @boot,  last

        add     2,      	1
        mov     <-99,		2
        jmz     -2,     	<step
last    jmp     paper-away

paper   spl     l000
        add     @found,         a2b
        mov     #found-a2b,     a2b
a2b     add     #5,             0
        mov     -30,            <found
        jmp     -1

l000    spl     1
        spl     1
        spl     1

        spl     l100
        spl     l010
        spl     l001

        mov     #8,     0
        mov     <-1,    <1
        spl     @0,     5300
        mov     3,      <-1
        mov     3,      <-2
        jmz     -5,     -5
        dat     <2667,  <5334
        mov     0,      <1

	dat		#1		;bomb here

l001    mov     #8,     0
        mov     <-1,    <1
        spl     @0,     5700
        mov     3,      <-1
        mov     3,      <-2
        jmz     -5,     -5
        dat     <2667,  <5334
        mov     0,      <1

l010    spl     l011
        mov     #8,     0
        mov     <-1,    <1
        spl     @0,     5900
        mov     3,      <-1
        mov     3,      <-2
        jmz     -5,     -5
        dat     <2667,  <5334
        mov     0,      <1

l011    mov     #8,     0
        mov     <-1,    <1
        spl     @0,     6100
        mov     3,      <-1
        mov     3,      <-2
        jmz     -5,     -5
        dat     <2667,  <5334
        mov     0,      <1

l100    spl     l110
        spl     l101

        mov     #8,     0
        mov     <-1,    <1
        spl     @0,     6300
        mov     3,      <-1
        mov     3,      <-2
        jmz     -5,     -5
        dat     <2667,  <5334
        mov     0,      <1

l101    mov     #8,     0
        mov     <-1,    <1
        spl     @0,     6700
        mov     3,      <-1
        mov     3,      <-2
        jmz     -5,     -5
        dat     <2667,  <5334
        mov     0,      <1

	dat		#1
	dat		#1
	dat		#1
	dat		#1
	dat		#1		;bomb here
l110    spl     l111

        mov     #8,     0
        mov     <-1,    <1
        spl     @0,     6900
        mov     3,      <-1
        mov     3,      <-2
        jmz     -5,     -5
        dat     <2667,  <5334
        mov     0,      <1

l111    mov     #8,     0
        mov     <-1,    <1
        spl     @0,     7100
        mov     3,      <-1
        mov     3,      <-2
        jmz     -5,     -5
        dat     <2667,  <5334
        mov     0,      <1


        end     boot
