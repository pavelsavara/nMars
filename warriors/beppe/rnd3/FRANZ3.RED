Well, I'm not much of an '88 coder so this is something that I slapped
together quickly. It IS my best '88 warrior getting 109 on Wilkies, and a
similiar score on the '88 standard hill. I don't expect much from it. It's
small fast (.5) and starts immediatelly (no qscans) so i thought of this
as an adventage. It can tie many papers and can actually kill some of them
the older style ones ... otherwise it's main strengh is killing stones and
scissors. It's quite small and hard to find, yet deadly. If my opponent
puts together a qscan i think i could make it through and kill him since
my warrior is small and hard to find and will have time adventage. The
bomb should get a little work but I didn't have time to fiddle with the
constants so much so the carpet is 155 instructions long and growing which
is dangerous but this really did work better then my other bombs.

;redcode
;name Zippo Lighter
;author Franz
;strategy 50%c stone
;assert CORESIZE==8000

step equ 155

sp      spl 0,#step
stone   mov mv,@jump+(step*2)
clrs    mov sp,@stone
        add #step*2,stone
jump    jmp stone,<jump-20
mv      mov -step,<-step 
        djn -1,<-4001

        end sp





