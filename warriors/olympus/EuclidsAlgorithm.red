;redcode-94esoteric
;name  Euclid's Algorithm
;author  Steven Morrell
;strategy  Find lcd of a,b and die.

a equ 1001
b equ 99 ;may not work if 0, depending on your definition of lcd(a,0).

org data

data sne.x #a,#b     ;these first two lines make it work when a=b.
     jmp done        ;
loop mod.x data,data
     jmn.f loop,data
     jmn.b done,data ;these two lines get the lcd into the B-field when a>b.
     mov.x data,data ;
done mod.x #0,#0

end
