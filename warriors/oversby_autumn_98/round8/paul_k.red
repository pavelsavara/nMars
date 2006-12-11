;redcode
;name 5 minute warrior
;author Paul-V Khuong
;assert 1

step equ 2366

spl 1
spl 1
spl 1
spl 1
spl 1
spl 1

mov.i jb, *2
mov.i jb, @1
mov.i 0,  @2366
add.f inc,-1
jmn.a @0, -4
mov.i db, >-3
mov.i db, >-4
djn.f -2, >-5
jmp   -3
jb jmp #0,2366
db dat.f >6402,9
inc dat.f 2366*3, 2366*3
end