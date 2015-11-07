;redcode-94
;name Little Flea v1.2
;author Michael Constant
;kill Little Flea
;strategy  spl-bomber with gate
;macro

step    equ     3044

split   spl     #0,     <-20
stone   mov.i   split,  hit+step
bar     add     #step,  stone
hit     djn.f   stone,  <-3000
        mov.i   foo,    <bar
foo     dat     <-21,   <-22
