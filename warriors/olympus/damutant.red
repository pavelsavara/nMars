step equ 3510
dat.f 0,1
add.f inc, 1
bmb mov.i {3+step, <0-step+1
jmz.f -2, <-1
mov.a -2, sb1
inc spl #step,-step+1
mov.i @2,>bmb 
mov.i @1,>bmb
djn.b -2,{sb1
dat.f -7,10
spl #-8,10
sb1 spl #0,9
end bmb 
