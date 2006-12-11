OK here's the semi-final warrior ..

This is the best warrior I could do with the bans ... I banned the $
addressing mode in hopes of doing a paper, and din't expect SPL to be
banned ... I ended up doing a bomber ... since i tried to keep the
footprint to a minimum since even like this scanners are possible and have
the same speed I have (almost 60%-66%)... well we'll see ... this warrior
has slight decrement protection, but is pretty easily killable due to the
no split rule ...

It gets 72 wilkies, it dies fast against papers but tehre are none in this
round, against scanners it's fairly good due to some core-trashing and
fast speed (scanners don't use self splitting so a dat bomb kills)

I expect to fight a 66% scanner or a dat bomber, and since there aren't
faster bombers then 60% I don't expect something faster then me. Maybe a
jmz scanner but that should be slower then me.

The only possible imp (a-driven dewdney type imp) it beats a lot of times
and it ties a lot of times ... so it wins ...

;redcode
;name Choped
;author Franz
;strategy Chopped it is because a bunch of things are "chopped" off :)
;strategy 60% dat bomber, dat clear
;strategy SPL,SEQ,.AB,.F,>,$ are banned, man this is hard ...
;assert CORESIZE==8000

step equ 2365
stbm equ (adder+step)
gate equ (adder-20)

org bomber

steps    nop.i <step*3,<step*3
bomber   mov.i @bomb,*bomber3
bomber2  mov.i *bomber,@bomber3
bomber3  mov.i }stbm,@stbm+step
adder    add.i @ccj,@bomber2    ;add to bomber 3
jumper   djn.b *bomber2,#530
cc       mov.i *bomber,}gate
ccj      jmp.i *adder-50,<steps
bomb     dat.i <52,}step

end



