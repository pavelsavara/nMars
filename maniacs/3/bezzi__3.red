;redcode-94
;name Sorry Paul for stealing your code :-)
;author Beppe Bezzi
;assert CORESIZE == 8000
;strategy redcode maniacs tournament round 3
;strategy 80% f-scanner switches from SPL to DAT carpet
;strategy I feel ashamed to write my name on author
;strategy considering I changed very little from Paul's HSA
;strategy but little time to search something new and also to fine tune.

org scan

ptr     dat    100 ,4100-4
          dat    0,0
          dat    0,0
          dat    0,0
          dat    0,0
          dat    0,0

          
wipe    mov     stun,   <ptr
        mov     >ptr,   >ptr
        jmn.f   wipe,   >ptr
          
scan    sub.x   #-13,   ptr             ;#-12, -9 step
        sne     *ptr,   @ptr
        sub.x   *pscan, @scan
        jmn.f   check,  @ptr
        jmz.f   scan,   *ptr
pscan   mov.x   @scan,  @scan
check   slt.b   @scan,  #last+4-ptr
        djn     wipe,   @scan
        djn     *pscan, #14
        
        jmp     *pscan, }wipe
        dat     0,0
stun    spl     #1,{1
        dat     0,0
        dat     0,0
last    dat     0,0
          
for 80-4
        dat     0,0
rof

for MAXLENGTH-CURLINE
        spl     0,0             ;something to bite for qscan and slow a bit wounded papers
rof


