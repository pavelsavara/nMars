>I will be nice if with you warrior you send a short note, telling why you
>have chosen it and what you expect to fight.

Why I have chosen this.... it is my only semi-good warrior.  This does not 
have the qscan because two tests on the 94 hill a short time ago had a non 
qscan version getting 10 _more_ points.

What I expect to fight.... some warrior that is better than this.  :(
Hopefully though, paper or stone since this does badly against scanners.

Why I have entered.... "Beginners are strongly invited to join the 
tournament, the luck omponent is high"  :-)

Justin


;redcode-94b
;name Yet 4b Clear
;author Justin Kao
;strategy This is Yet Another core clear wo/quickscan
;assert 1

sep     EQU 17

        ORG     clear

movptr  dat     {4000,   {200
djnptr  dat     {4000,   {200

	for     sep
        dat     0,      0
	rof

        dat     {sep+9,    {1
clear   spl     #sep+12,    1
        mov     clear,   }-2-sep-2
        mov     clear,   }-3-sep-2
        djn.a   -2,     >-4-sep-1


