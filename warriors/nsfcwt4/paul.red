;redcode-94
;name PaulSort
;kill PaulSort
;author P.Kline
;contact pk6811s@acad.drake.edu
;NSFCWT Round 4
;strategy quick-sort - step increments 256/64/16/4/1
;strategy - skip too-large starting steps on short lists
;strategy - use same code for ascending and descending sorts
;strategy - squeeze duplicates after sorting
;strategy - use flag location as convenient pointer

          org start
ptr       equ (start+4000)        ; same as flag location
saveopts  equ (start+200)
datzero   equ (start+202)
swapper   equ (start+203)
initptr   equ (start+204)

start     mov    ptr,saveopts     ; put opts in a safe location
          
firstinc  mov    incr,ptr         ;
          div    factor,ptr       ; find best starting incr
          sne    @ptr,datzero     ;
          jmp    -2
          jmz.f  alldone,ptr      ; check for zero-length list
          mov    ptr,incr
;******************************************************************
nextincr  jmz.f  postsort,incr    ; when finished go to squeeze
          mov.b  incr,srtfrom
add1      add    #1,srtfrom       ; 1,1 operands used elsewhere
srtfrom   djn    setptr,#0        ; select next sublist
          div    factor,incr      ; next step size
          jmp    nextincr
setptr    mov.ba srtfrom,initptr  ; set ptr a/b values
          mov.b  srtfrom,initptr  ;   ptr.a -> element N
          add.b  incr   ,initptr  ;   ptr.b -> element N+incr
          sub    incr   ,initptr  ;
          jmz.b  fwdpass,saveopts ; if descending order
          mov.x  initptr,initptr  ; make two adjustments
          mov    compinvt,compdone;
          jmp    fwdpass          ;
          
forward   sne    swapper,datzero  ; if swapper is still null
sortrtrn  jmp    srtfrom          ; then sublist is sorted
fwdpass   mov    initptr,ptr
          mov    datzero,swapper  ; set swapper to null
          
comp      add.f  incr,ptr         ; next pair in sublist
compdone  sne    @ptr,datzero     ; if end of sublist
          jmp    forward          ; then -> check if it is sorted
          
          slt.b  @ptr,*ptr        ;
          jmp    2                ;
          jmp    swap             ; compare two elements
          slt.b  *ptr,@ptr        ;
          slt.a  @ptr,*ptr        ;
          jmp    comp             ;
          
swap      mov    @ptr,swapper     ;
          mov    *ptr,@ptr        ; swap two elements and mark swapper
          mov    swapper,*ptr     ;
          jmp    comp             ;
;******************************************************************
postsort  jmz.a  alldone,saveopts ; if dups are allowed go to finish
          mov.f  add1,ptr
squeeze   mov    >ptr,*ptr        ; remove duplicates
          sne    *ptr,datzero
          jmp    alldone          ; they're gone
          sne    *ptr,@ptr        ; find 'em
          jmp    -1,>ptr          ; skip 'em
          jmp    squeeze,}ptr

compinvt  sne    *ptr-compdone,datzero-compdone
factor    dat       4,   4
incr      dat    1024,1024
alldone   mov    saveopts,ptr     ; restore flag instruction and die
