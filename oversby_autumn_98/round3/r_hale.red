;redcode-94
;name Seeing Eye
;author Robert Hale
;assert 1
;strategy p-space scanner and duct tape.
;strategy scanner is 66% due to space limitations.
;strategy duct tape is a self repairing core clear.
;strategy
;strategy Did you know you can use duct tape to repair duct tape?
;strategy
;strategy A 80% oneshot scanner worked better against my test suite 
;strategy but I hope this is a better all around warrior.
;strategy 

;3 instr
;duct tape	
;it simply overwrites the clears djn with a -1.
;since in this round you can kill by jumping your enemy into 
;the rest of the core.  A occasional overwrite of a -1
;for the djn can stop some of that :)

duct	spl	clr
	mov.a	1, dajmp 
	jmp	-1


;8 instr
_RES    equ 0           ;here pmars loads results
_STR    equ 1           ;here I store my strategy 

res     ldp.ab  _RES,   res      ;load result last match
str     ldp.a   _STR,   str1    ;load strategy in use
        sne.ab  20,     res     ;check result, win or tie OK
lost    add.a   str,  str1    ;lost change
        mod.a   modit,  str1    ;secure jump     
win     stp.ab  str1,   _STR    ;save strategy
str1    jmp     @0,     spot
modit   dat     2,      duct


;5 instr
;oneshot scanner
start	equ	16
size	equ	16
num	equ	((800-start)/size)-2

step    dat     size, size
inc     add.f   step, spot     
spot    sne.f   start, start+size/2
        djn.b   inc, clr
        sub.f   step, spot	;this sub insures that we hit 
				;the front of the warrior. 
				;it made a big difference in scores
				
				; for M. Joonas Pihlajas 
				; this was the trick
				; I was talking about

;4 instr
;continuous clear
clr     spl     0, num
        mov.f   wipe, >spot
dajmp   djn.f   -1, >step
wipe    dat.f    {60, <60
	
	end	res
==
Robert G. Hale
rghale@earthlink.net
rg_hale@yahoo.com

_________________________________________________________
DO YOU YAHOO!?
Get your free @yahoo.com address at http://mail.yahoo.com

