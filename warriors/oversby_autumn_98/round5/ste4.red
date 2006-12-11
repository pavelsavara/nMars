;redcode
;name He scans in a bunch 1
;author Steve Gunnell
;strategy Mini HSA scanner. This copy probably came from
;strategy Nomolos by Ian Oversby.
;assert 1

mst  equ   9
ptr  equ   (bomb-5)

bomb spl   #1,      {1
kill mov   bomb,    <ptr
mptr mov   >ptr,    >ptr
     jmn.f kill,    >ptr
a    add   #mst+1,  @mptr
scan jmz.f a,       <ptr
     slt   @mptr,   #btm-ptr+3
     djn   kill,    @mptr
     djn   a,       #16
btm  jmp   a,       {kill
     end  kill
