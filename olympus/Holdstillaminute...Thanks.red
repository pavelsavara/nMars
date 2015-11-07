;redcode-94x verbose
;assert CORESIZE == 55440
;name Hold still a minute...Thanks
;author Dave Hillis
;kill test +
;strategy -  Another abusive warrior
;strategy - updated to catch some of the warriors
;strategy - that boot away quickly.
;for -F 27723
; 
;
ORG START
_RESULT     equ #0 ;P-space cell 0: last round result
_STRATEGY   equ #21345    ;user-defined
off         equ 0       ;100
_COUNTER    equ # 200 ; doubles as a bombing offset
WRAP        equ   125
STEP        equ   11    ;4

target1     equ target2-1
target2 dat _COUNTER, _COUNTER
START
thecnt  ldp _COUNTER, #0     ;increment a round counter
        add.b     -1, b ;
 stp.b  $ b, _COUNTER   
        slt.ab # WRAP, $ b
        jmp bomber
        add.ab # -WRAP,  b
        mov.x @ b, @ b

bomber  mov.a @     b    , $   target1  
        sub.ab $  target1, $   target1
        add.f $ target1, target2
        
;Get in a quick shot
        mov.i -200, * target2   
        mov.i -200, @ target2
;== now am I the first warrior or the second?
;== scan till I find something, then attack
;
        
;switch mov.x $ target1, $ target1 ; I must be the second warrior
;       mov.x $ target2, $ target2


; 3/28/01 adjust boot distance relative to the enemy
        add.a  $ target1, $ tBoot
        add.ab $ target1, $ tBoot       
attack  
        mov.i   < target2 , }  target1 
        mov.i   { target2 , >  target1   
        mov.i   }  target1, <  target2     
        mov.i   >  target1, {  target2
for 1
        mov.i   < target2 , }  target1 
        mov.i   { target2 , >  target1   
        mov.i   }  target1, <  target2     
        mov.i   >  target1, {  target2
rof
        add.i #  -STEP,$ target2
        add.i # STEP,$ target1
        djn.b $  attack, # 13 ;52

; Now to mop up.
; Boot the scanner to a favorable location relative to the 
; enemy. If I lost or tied last round, try a new relative location.
; 1=win, 2=tie, 0=loss

res     ldp     #0,     0
strat   ldp     _STRATEGY,      0
        sne.ab    # 1,  $ res   ; if I won, use same location
        jmp      $ adj
change  
        mul.ab   #    41, $ strat
        add.ab   # 25442, $ strat
        stp.b    $ strat,  _STRATEGY

adj     
        add.ba  $ strat, $ tBoot
        add.b   $ strat, $ tBoot       
        ;jmp w1

; ==========================================
w1 equ tStart
tStart  mov    tMov             , tDist+tCheck+1
        spl    2                , {17843
        spl    1                , {18326
        spl    1                , {13965
        mov    {tStart          , <tBoot
        mov    {tStart          , <tBoot
tBoot   jmp    >tDist+tSplx+1    , tDist+tMov

; -- I think I got this from Katafutr

tStep   equ    16134
tTime   equ    9241
tGate   equ    (tWipex-3)
tCheck  equ    (tHit+23)
;tDist   equ    9362
tDist   equ    0; 100  ;25442

tWipex   dat    1                , tClear+5-tGate
tSplx    spl    #tStep+1         , tClear+5-tGate
        mov.i  }tCheck          , #0
tPtrx    mov    tHit-tTime*tStep , *tHit-(tTime-2)*tStep
        add    tInc             , tPtrx
        mov    tSplx             , *tPtrx
        mov    }tCheck          , @tPtrx
tHit    jmn.a  tPtrx             , {tCheck
tInc    spl    #3*tStep         , <3*tStep
tClear  mov    *tWipex           , >tGate
        mov    *tWipex           , >tGate
        djn.f  tClear           , }tSplx
tMov    mov    -tStep           , }-tStep
;for 5 
;       dat 0, 0
;rof 

b       mov.i  # target2, > 1
spl.i # 27723 + off, < 24071  + off ;   1
mov.i # 14697 + off, < 21365  + off ;   2
mov.i # 13135 + off, < 26769  + off ;   3
mov.i # 26113 + off, < 9150  + off ;   4
mov.i # 29291 + off, < 36914  + off ;   5
mov.i # 469 + off, < 11357  + off ;   6
mov.i # 20894 + off, < 7136  + off ;   7
mov.i # 50452 + off, < 9306  + off ;   8
mov.i # 45250 + off, < 40755  + off ;   9
mov.i # 30769 + off, < 51580  + off ;   10
mov.i # 17013 + off, < 1817  + off ;   11
mov.i # 29014 + off, < 30467  + off ;   12
mov.i # 52081 + off, < 2076  + off ;   13
mov.i # 12106 + off, < 584  + off ;   14
mov.i # 11941 + off, < 53165  + off ;   15
mov.i # 27499 + off, < 36531  + off ;   16
mov.i # 28170 + off, < 37223  + off ;   17
mov.i # 7661 + off, < 33809  + off ;   18
mov.i # 4766 + off, < 42223  + off ;   19
mov.i # 17315 + off, < 33701  + off ;   20
mov.i # 25455 + off, < 23898  + off ;   21
mov.i # 1439 + off, < 24670  + off ;   22
mov.i # 47464 + off, < 6877  + off ;   23
mov.i # 649 + off, < 28448  + off ;   24
mov.i # 34267 + off, < 44860  + off ;   25
mov.i # 33015 + off, < 50086  + off ;   26
mov.i # 38426 + off, < 33334  + off ;   27
mov.i # 13980 + off, < 20606  + off ;   28
mov.i # 23270 + off, < 5948  + off ;   29
mov.i # 27195 + off, < 14965  + off ;   30
mov.i # 25945 + off, < 33327  + off ;   31
mov.i # 38933 + off, < 40606  + off ;   32
mov.i # 49815 + off, < 10439  + off ;   33
mov.i # 53912 + off, < 41273  + off ;   34
mov.i # 27707 + off, < 12810  + off ;   35
mov.i # 32608 + off, < 15544  + off ;   36
mov.i # 30299 + off, < 24537  + off ;   37
mov.i # 35631 + off, < 27653  + off ;   38
mov.i # 22844 + off, < 18611  + off ;   39
mov.i # 38444 + off, < 25292  + off ;   40
mov.i # 34122 + off, < 9164  + off ;   41
mov.i # 40106 + off, < 55170  + off ;   42
mov.i # 18301 + off, < 28683  + off ;   43
mov.i # 43318 + off, < 21653  + off ;   44
mov.i # 3007 + off, < 11201  + off ;   45
mov.i # 31603 + off, < 8849  + off ;   46
mov.i # 15338 + off, < 21861  + off ;   47
mov.i # 14417 + off, < 48722  + off ;   48
mov.i # 25400 + off, < 13865  + off ;   49
mov.i # 54975 + off, < 10844  + off ;   50
mov.i # 13135 + off, < 44056  + off ;   51
mov.i # 48493 + off, < 8524  + off ;   52
mov.i # 10490 + off, < 16953  + off ;   53
mov.i # 3428 + off, < 27811  + off ;   54
mov.i # 47289 + off, < 29398  + off ;   55
mov.i # 44037 + off, < 35285  + off ;   56
mov.i # 49935 + off, < 37559  + off ;   57
mov.i # 5176 + off, < 18980  + off ;   58
mov.i # 7638 + off, < 13866  + off ;   59
mov.i # 46612 + off, < 49690  + off ;   60
mov.i # 8705 + off, < 39552  + off ;   61
mov.i # 37793 + off, < 17793  + off ;   62
mov.i # 25466 + off, < 19105  + off ;   63
mov.i # 23485 + off, < 514  + off ;   64
mov.i # 49559 + off, < 35416  + off ;   65
mov.i # 41630 + off, < 25237  + off ;   66
mov.i # 17131 + off, < 31224  + off ;   67
mov.i # 8499 + off, < 18464  + off ;   68
mov.i # 2764 + off, < 47850  + off ;   69
mov.i # 37862 + off, < 3343  + off ;   70
mov.i # 48428 + off, < 11113  + off ;   71
mov.i # 48566 + off, < 54809  + off ;   72
mov.i # 12498 + off, < 53184  + off ;   73
mov.i # 8508 + off, < 14819  + off ;   74
mov.i # 44393 + off, < 8221  + off ;   75
mov.i # 53429 + off, < 17267  + off ;   76
mov.i # 17398 + off, < 22020  + off ;   77
mov.i # 314 + off, < 30120  + off ;   78
mov.i # 15757 + off, < 18810  + off ;   79
mov.i # 795 + off, < 6853  + off ;   80
mov.i # 18526 + off, < 9597  + off ;   81
mov.i # 49251 + off, < 7553  + off ;   82
mov.i # 387 + off, < 34049  + off ;   83
mov.i # 34561 + off, < 53034  + off ;   84
mov.i # 35607 + off, < 5804  + off ;   85
mov.i # 43881 + off, < 36890  + off ;   86
mov.i # 54033 + off, < 37269  + off ;   87
mov.i # 39328 + off, < 32422  + off ;   88
mov.i # 9226 + off, < 43519  + off ;   89
mov.i # 11707 + off, < 24338  + off ;   90
mov.i # 11231 + off, < 23498  + off ;   91
mov.i # 27952 + off, < 13096  + off ;   92
mov.i # 51451 + off, < 24398  + off ;   93
mov.i # 8365 + off, < 8422  + off ;   94
mov.i # 29899 + off, < 21802  + off ;   95
mov.i # 36944 + off, < 39224  + off ;   96
mov.i # 52714 + off, < 50677  + off ;   97
mov.i # 5807 + off, < 37392  + off ;   98
mov.i # 15521 + off, < 24488  + off ;   99
mov.i # 45032 + off, < 51938  + off ;   100
mov.i # 40740 + off, < 6629  + off ;   101
mov.i # 52789 + off, < 19075  + off ;   102
mov.i # 25878 + off, < 5756  + off ;   103
mov.i # 7412 + off, < 30190  + off ;   104
mov.i # 13384 + off, < 21312  + off ;   105
mov.i # 36466 + off, < 47786  + off ;   106
mov.i # 28854 + off, < 20929  + off ;   107
mov.i # 55154 + off, < 25579  + off ;   108
mov.i # 36416 + off, < 15363  + off ;   109
mov.i # 43733 + off, < 17880  + off ;   110
mov.i # 4724 + off, < 43506  + off ;   111
mov.i # 54950 + off, < 36615  + off ;   112
mov.i # 42358 + off, < 22313  + off ;   113
mov.i # 54983 + off, < 36018  + off ;   114
mov.i # 34488 + off, < 3557  + off ;   115
mov.i # 25840 + off, < 25026  + off ;   116
mov.i # 15988 + off, < 50647  + off ;   117
mov.i # 51304 + off, < 49743  + off ;   118
mov.i # 43006 + off, < 36191  + off ;   119
mov.i # 37424 + off, < 54904  + off ;   120
mov.i # 36630 + off, < 20129  + off ;   121
mov.i # 35973 + off, < 28775  + off ;   122
mov.i # 50991 + off, < 8512  + off ;   123
mov.i # 35197 + off, < 6297  + off ;   124
mov.i # 26935 + off, < 14171  + off ;   125
