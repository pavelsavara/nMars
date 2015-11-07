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
