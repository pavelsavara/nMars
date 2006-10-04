;redcode-94
;name bunker
;kill bunker
;author P.Kline
;strategy self-repair pair [94]
space    equ 4000
boot     equ -500
rp       equ (re+2100)
copyf    dat #(re+1)
copyt1   dat #(re+1+space+boot)
copyt2   dat #(re+1+boot)

rb       dat    <2667,#space           ; pointer to partner
rkill    mov    re,>rb                 ; kill partner
         mov    rb,>rclr+200           ; wait for partner to die
         mov    <rb+space,<rb          ; restore partner
         spl    set+space,#5           ; start him (no zero b-operands allowed!)
         mov    rb,rb+space            ; correct partner's rb
set      mov    initrp,rp              ; initialize monitoring
         sub.ba <rp,rp                 ; check partner
rpptr    jmn.a  rkill,rp               ; jump to rkill if he is damaged
rclr     mov    rc,>200                ; slow forward core-clear
         jmp    set,#1010
initrp   dat    #0-2353,#re-rp+1+space
rc       dat    <2667,#1               ; imp-killing, plus djn-stream disrupt
re       dat    <2667,#re-rb+1+space   ; for quick restore of partner
         
st       mov #0,rclr+boot+space+200
         mov #100,rclr+boot+200
         spl 1                         ; create 14 processes
         spl 1
         mov -1,0
         spl 1
         spl s2
         mov <copyf,<copyt1            ; copy and start partners
         jmp set+space+boot
s2       mov @copyf,<copyt2
         jmp set+boot
         end st
