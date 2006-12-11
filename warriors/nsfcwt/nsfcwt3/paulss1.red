;redcode-94
;name theMystery2.0 1
;author Paulsson
;strategy One step further, changed a lot!
;strategy Looking gooood, could it be somthing that begins
;strategy with an i and ends with p?
;assert CORESIZE ==8000
;contact mpn@ifm.liu.se
;NSFCWT Round 3

;------------theMystery2.0-----------
;I tried at least, that is I realy tried to make a warior
;that cooperated with it's brother. It didn't make out.
;So I'll submitt theMyster2.0 instead.
;Actually just a imp, stone.
;-------------------------

org start

step    equ     268
                mov.i   -1,>1           ;Weak stone
bmber   spl     -1,2                    ;suicidal
                add.ab  #step-1,-1      ;with core clear
                djn.f   -2,<-3000       ;and djn
i for 60
                dat.f 0,0
rof

start   spl     1,<-1000                ;Nice way to launch
                spl     1,<-2000                ;some 50 imp rings or so
                spl     bmber,<2000
                mov.i   {p2,<p2
                spl     third,<-3000
                spl     second,<1000
hej             nop             <-1500,<1500
;---------------------------------
impy    spl             @0,2183                 ;paper ?
                mov.i   }-1,>-1                 ;that ?
                mov.i   #100,2667               ;imps ?
;---------------------------------
                dat             <8001/7,<8001/7*2
second  djn.f   @p2,hej
third   mov.i   {p3,<p3
                djn.f   @p3,hej
                
p2              dat     impy+4,impy+4+2667
p3              dat     impy+4,impy+4+2667*2

