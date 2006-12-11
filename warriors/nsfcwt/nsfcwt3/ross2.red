;redcode

;name Mister Neat
;NSFCWT Round 3

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Stun the opposition with SPL bombs ...
;strategy ... while searching for Mr Tidy ...
;strategy ... If Mr Tidy can't be found ...
;strategy ... start an SPL/SPL/DAT core clear.
;strategy Written in '94 code.
;strategy Submitted to NSFCWT Round 3: 27 October 1995

;assert 1

gap1    equ 14
first   equ 100
signal  equ -117
        
gate    spl #-1, -1
        
        for gap1
        dat 1, 1
        rof
        
        for gap1
        dat 0, 0
        rof

ally    spl #signal                     ;do this only if we have no other friends
        mov.i *aim, <aim                ;do multiple core clear
        djn.f ally, gate                ;add some anti imp protection
kill    dat.f kill-aim, ally-aim
stun2   spl #kill-aim, ally-aim         ;second clear is with more spl's
aim     dat stun-aim, gate-aim          ;third clear is with dat's
stun    spl #stun2-aim, gate-aim        ;first clear is with spl's 

        for gap1*3
        dat 0, 0
        rof

stop    dat 0, 0  
safety  spl @scan
        mov.i stop, scan 
scan    add.ab #gap1, #first            ;fscan forwards through core
        jmz.f scan, @scan               ;looking for nonzero
        sne.a #signal, @scan            ;check for friend or foe
        jmp safety                      ;  looks like a friend
hit     mov.i gate, >scan               ;it's a foe so hit it
        jmn.f hit, @scan                ;repeat until the end of the enemy
        jmp scan                        ;fscan for more targets

        end scan

 MicroSoft Network may not carry this message without license
 to do so.  License to carry this message requires a fee of 
 $1000, payable within 30 days to Derek Ross.  Appearance of this 
 message on MicroSoft Network constitutes an agreement to terms.




 MicroSoft Network may not carry this message without license
 to do so.  License to carry this message requires a fee of 
 $1000, payable within 30 days to Derek Ross.  Appearance of this 
 message on MicroSoft Network constitutes an agreement to terms.


