;redcode-94
;name bunker
;kill bunker
;author P.Kline
;strategy self-repair pair [94]
space    equ 4000
boot     equ 0
rp       equ (rkill-1)
copyf    dat #(re+1)
copyt1   dat #(re+1+space+boot)
copyt2   dat #(re+1+boot)

rkill    mov    re,>rp                ; kill partner
         mov    rc,>rclr+200          ; wait for him to die
         mov    <rkill+space,<rp      ; restore partner
         spl    set+space,<-1004
set      mov    initrp,@1             ; initialize b-op total and pointer
         sub.ba <rp,rp                ; subtract partner's b-operands
         jmn.a  @0,@rkill             ; check for zero-sum
rclr     mov    rc,>200               ; slow core-clear
         jmp    set,>rclr+200         ; advance core-clear a bit
initrp   dat    #0-388,#re-rp+1+space ; a = b-op sum,  b = ptr to partner
rc       dat    <2667,#1              ; core-clear bomb
re       dat    <2667,#space+1-rkill  ; erase partner and pointer back to self
         
start    mov #0,rclr+boot+space+200   ; offset core-clears, so we don't
         mov #100,rclr+boot+200       ; overwrite both partners at the same time
         spl 1                        ; create 12 processes
         mov -1,0
         spl 1
         spl 1
         mov <copyf,<copyt1           ; copy 2nd partner
         spl s2
         jmp set+space+boot           ; start 'em up
s2       jmp set+boot
         end start
