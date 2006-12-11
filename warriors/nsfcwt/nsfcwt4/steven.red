;redcode-94
;name  Sort of
;author  Steven Morrell
;contact  morrell@math.utah.edu
;NSCWT Round 4
;assert VERSION>=63

;strategy Use quicksort algorithm found in K&R II, p.87

org begin

data equ (first+3994)
key equ (first+3995)
fsame equ (first+3996)
leftright equ (first+3997)   ;left,right
lasti equ (first+3998)       ;last,i
temp equ (first+3999)
flag equ (first+4000)
sortdata equ (first+4001)

first   dat sortdata-leftright,sortdata-leftright         
stack   dat 0,-1

begin   mov.f range,leftright
getend  seq.i data,@leftright
          jmp getend,>leftright
        nop <leftright
        jmz.b qsort,flag
          mov.i decrease1,increase1
          mov.i decrease2,increase2  
qsort   mov.ba leftright,lasti
        add.a leftright,lasti
        div.a #2,lasti
        mov.i {lasti,key
        mov.i *leftright,*lasti
        mov.a leftright,lasti
        mov.ab leftright,lasti
loop    slt.b lasti,leftright
        jmp endloop
increase1 slt.b @lasti,key
          jmp 2
range     jmp if,sortdata+10-leftright  ;if == sortdata-leftright
          sne.b @lasti,key
increase2 slt.a @lasti,key
          jmp loop,>lasti
if          mov.i @lasti,temp
            mov.i *lasti,@lasti
            mov.i temp,}lasti
          jmp loop,>lasti

decrease1 slt.b key-increase1,@lasti-increase1
decrease2 slt.a key-increase2,@lasti-increase2

endloop mov.i {lasti,*leftright
        mov.i key,*lasti
        mov.a lasti,<stack
        add.a #2,@stack
        mov.b leftright,@stack
        mov.ab lasti,leftright
        slt.ab leftright,leftright
pop     mov.f >stack,leftright
        slt.ab leftright,leftright
        jmn.b pop,stack
        jmn.b qsort,stack
        jmz.a data,flag
          mov.i data,flag                  ;mark the left boundary
squish      mov.i *leftright,>leftright
nocopy      seq.f }leftright,*leftright
            jmp squish
          mov.ba leftright,fsame
matches     sne.i *leftright,*fsame
            jmp finish
            sne.f *leftright,{fsame
            jmp matches
          jmp squish

finish    seq.i *leftright,data
          jmp nocopy
;         dat 0,0   

end
