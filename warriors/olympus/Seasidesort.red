;redcode
;name Seaside sort
;author Brian Haskin
;strategy Walking by the sea one day
;strategy I saw a shell by the way
;strategy Then looking inside there to my suprise
;strategy It was sorting and ordering in ascending
;strategy Ok, so I write terrible poems.
;strategy Hopefully I did a little better on the program. :)
;strategy shell sort
;assert 1

tmp equ (back-10)
LAST equ (ITEMLIST+ITEMS-1)
SDIST equ ((ITEMS/3)+1)

        org comp

back    add.f const, comp
        mov.i bjmp,ljmp
comp    slt.b LAST-SDIST, LAST
        sne.b *comp,@comp
ljmp    djn.f comp,comp
        slt.a #-comp+ITEMLIST-1,comp
        jmp cdist
        slt.f hgh,comp
        mov.f comp,hgh
        mov.i *comp,tmp
        mov.i @comp,*comp
        mov.i tmp,@comp
retr    slt.ab #-comp+LAST-SDIST,comp
        jmp back
snorm   mov.i njmp, ljmp
        mov.f hgh,comp
        djn.f comp,comp
hgh     dat #-comp+LAST,#-comp+LAST

cdist   slt.a #1,const
const   dat SDIST,SDIST        
        div.f dvc,const
        mov.f lstc,comp
        sub.a const,comp
        mov.a #-comp+LAST,retr
        sub.a const,retr
        mov lstc,hgh
        jmp comp
bjmp    jmp -ljmp+snorm
njmp    djn.f -ljmp+comp,-ljmp+comp
lstc    dat #-comp+LAST,#-comp+LAST
dvc     dat #2,#2

end
