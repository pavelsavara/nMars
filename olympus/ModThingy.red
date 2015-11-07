;redcode-94esoteric
;name  Mod Thingy
;author  Steven Morrell
;strategy  Find "mod" value of step and die.
;strategy  Technically, the "mod" value of 0 should be CORESIZE, but that
;strategy  won't fit in the B-field, so we use 0 instead.

step equ 3056

org data

data sne.x #-step,#step    ;these first two lines make it work when step is
     jmp done              ;zero or CORESIZE/2
loop mod.x data,data
     jmn.f loop,data
     jmn.b done,data       ;these two lines get the answer in the B-field
     mov.x data,data       ;when step is less than CORESIZE/2
done mod.x #0,#0

end
