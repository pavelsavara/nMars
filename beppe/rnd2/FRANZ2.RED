Here's my second round warrior. Simple reason why I chose it, It does good
against everything but paper ... and I don't expect paper on limited
proccess :) In fact it beats all the non-paper Wilkie banchmark warriors
and it also beats paper-one ... it didn't fare as well on the hill getting
around 124 ... which is not that bad ... i expect it to win mainly against
scissors and scanners ... it is also fairly good against imps especially
the ones that fit in 8 proccesses.

It's strategy is an airbag type stone with speeds of .6c (clean no self
splitting or missing instructions) ... the check is achieved by having 6
procceses roam the stone and increment decrement a check location in front
of the stone ... if the stone is hit, the check will allways fail unless
the jmz is hit ... the core clear is also triggered if an imp overruns the
cehckpoint .... ANY imp. the coreclear is a standard d-clear, which
should kill most imps and warriors. the bomber is mod-4 and bombs itself
to fail the check and go to coreclear ... I have tried to make it as
bombproof as it can be but currently i think that there are about 3.5
locations which will wound the warrior .. and 2 that will kill it ... 3.5
means only some bombs will wound that 4th location ... all other locations
are failry expendible. I try to use placement of at least 40 apart for
important stuff since if one gets hit all get hit by a mod-4 mod-5 mod-8
mod-10 ... bomber if they don't then we have a good chance of winning ...

ok here goes ...

;redcode-94lp
;name Golden Gate 3.1
;author Franz
;strategy Airbag bomber falls to a d-clear
;strategy a bit better then the hill version
;rating 140 Wilkies
;url http://www.azstarnet.com/~franz
;assert CORESIZE==8000 && MAXPROCESSES>=8

opt EQU 2365
stbm EQU 2
INSTALL EQU 2335
check EQU align-78

        org boot

boot    

;boot the stone
p for 8
        mov }si,>si
rof

;set up the checkpoint
        mov.f #333,align-80+INSTALL
        mov.i gate,align-78+INSTALL

;set up bomb for coreclear
        mov dbomb,align+40+INSTALL

;set up 6 proccesses for the bomber
        spl 5,>1000
        spl 7,>3000
        spl 2,>4000
        jmp }ji,>-1500
        jmp }ji,>-2500
        spl 2,>-1000
        jmp }ji,>1500
        jmp }ji,>3500
        spl 2,>-3000
        jmp }ji,>-3500
        jmp stone+INSTALL,>-2000

;the boot pointers
si      dat stone,stone+INSTALL
ji      dat stone+INSTALL,0

;the bomb itself plus this is the checkpoint
gate    dat     opt+1,    -1

;bomb for the coreclear
dbomb   dat >2667,>50

;the stone itself, could not optimize and bombproof it any more
;and I don't think it can really be done
stone   mov.i check,<where
where   mov.i >stbm+opt,{stbm+(opt*2)+1
        add.f jump,where
        mov.i >check,{where
align   jmz.f stone,<check              ;this is the label used to align
                                        ;the whole warrior after boot

;fairly standard d-clear
jump    spl #opt*3+1, >opt*3+1
clr     mov.i align+40, >align-40
        djn.f clr, >align-40

        end



