;redcode
;name Miss Careless
;author Derek Ross
;contact rossd@arbroath.win-uk.net
;NSFCWT Round 1
;strategy 75% bomb/scan once through core.  
;strategy Then SPL carpet followed by SPL/DAT coreclear ...
;strategy Tuned against scanners then tweaked.
;strategy Still needs to improve against imps.
;strategy Written in '88 code.
;strategy Submitted to KoTH:            3 September 1995
;strategy Submitted to NSFCWT Round 1: 13 October   1995

;assert CORESIZE>1

gap1    equ 39                                           ;scanning gap
gap2    equ 12                                           ;scanning offset
gap1st  equ 200                                          ;don't bother scanning first 200
multipl equ ((CORESIZE-gap1st)-((CORESIZE-gap1st)%gap1)) ;make scan independent of CORESIZE
first   equ (check+multipl)                              ;set first scan position
        
begin   dat #-1, #-(gap2*1)                 ;bomb for scanning phase
kill    dat #0, #stun-check                 ;code for final coreclear
clear2  spl 0, begin-check                  ;code for second coreclear
stun    spl 0, begin-check                  ;build processes, also code for first coreclear 
loop    mov @bomb, <check                   ;clears core with appropriate bomb
bomb    djn loop, <stun                     ;changes the coreclear we are doing

;  The last two instructions work together.  The 'djn' decrements the whole of core and
;  eventually its own b-field.  When this happens then b-field points to 'clear2'.
;  So the 'mov' instruction starts core clearing with 'clear2'.  Also the 'mov' uses the
;  'check' b-field to find out where to send the coreclear bomb.  Eventually the 'check'
;  b-field is bombed by the coreclear.  This resets it to point past Miss Careless so that
;  it doesn't clear itself!
                                             
shift   dat #-gap1, #-gap1                  ;negative shift so that we scan down memory
check   cmp <(first-(gap2*2)), <first       ;mess up core while scanning for non-zeroes
        jmp stun                            ;if found non zero, start first spl-coreclear
start   add shift, check                    ;shift back to next pair of scan positions
        mov begin, @check                   ;mess up core with dat-bomb, set offset for cmp 
        djn check, <500                     ;lay djn stream, limit number of scans done
        jmp stun                            ;time to start first spl-coreclear

        end start
