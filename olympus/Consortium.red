;redcode-94
;name Consortium
;kill Consortium
;author Randy Graham
;contact hp715!rgraham@peridot.spawar.navy.mil
;NSFCWT round 4
;assert 1
;strategy Use an iterative (non-recursive) quicksort to sort data
;strategy Uses lg n stack space and O(n lg n) average run-time
;strategy To speed up on sorted list, do a one pass bubble.  Skip
;strategy to delete routine if no swaps or qsort if there are swaps.

FLAGS     equ    (first+4000)
DATA      equ    (FLAGS+1)
STACK     equ    first
CLEAROUT  equ    fini+1

first     dat.f  0,         DATA    ;a - stack pointer, b - end of data
dat_ptr   dat.f  DATA,      first-1 ;contains start & end of partition
bubl_ptr  dat.f  DATA,      DATA-1
bubl_new  sne.i  (CLEAROUT-bubl_dwn2), @(bubl_ptr-bubl_dwn2)

;first get our data list size, then sort
begin     seq.i  CLEAROUT,  @first   ;once we find end, don't change it
bloop     jmp.a  begin,     >first
          
;bubble sort check is written assuming a decreasing sort
sortbubl  jmn.b  bubl_dwn,  FLAGS
          mov.x  bubl_ptr,  bubl_ptr   ;got to change - sort increasing
ptr2      mov.i  bubl_new,  bubl_dwn2
bubl_dwn  nop.a  }bubl_ptr, >bubl_ptr
bubl_dwn2 sne.i  CLEAROUT,  *bubl_ptr
ptr1      jmp.a  chk_del,   bubl_new   ;we got here if there were no swaps
          slt.b  @bubl_ptr, *bubl_ptr
jmp_bubl  jmp.a  2,         0
jmp_bubl2 jmp.a  qsort,     0
          sne.b  @bubl_ptr, *bubl_ptr
          slt.a  @bubl_ptr, *bubl_ptr
          jmp.a  bubl_dwn,  0

qsort     add.b  first,     dat_ptr
qsetup    mov.i  dat_ptr,   {first     ;start our stack
          jmn.b  sorter,    FLAGS
          mov.x  <decr1a,   <decr1b    ;this wastes two cycles, but
          mov.x  <decr2a,   <decr2b    ;saves one line
          djn.b  -2,        #2         ;do above twice
          mov.x  delta1,    delta1
          mov.x  delta4,    delta4
sorter    jmz.a  chk_del,   first      ;sort until the stack is empty
pop_off   mov.i  }first,    dat_ptr    ;Set up our data pointer
breaks    mov.i  dat_ptr,   bloop      ;use these references later
          mov.i  dat_ptr,   sortbubl
          slt.ab dat_ptr,   dat_ptr    ;while(top < bottom)
          jmp.a  sorter,    0

partition mov.i  *dat_ptr,  bubl_new   ;get instruction to part around
check_up  slt.ab dat_ptr,   dat_ptr    ;while they haven't met
          jmp.a  done_up,   0
delta1    slt.b  @ptr1,     @dat_ptr
decr1a    jmp.a  2,         delta3+1
decr1b    jmp.a  done_up,   delta3+1
delta2    sne.b  @ptr1,     @dat_ptr
delta3    slt.a  @ptr1,     @dat_ptr
          jmp.a  check_up,  <dat_ptr
done_up   mov.i  @dat_ptr,  *dat_ptr

check_dwn slt.ab dat_ptr,   dat_ptr    ;now, while they still don't match
          jmp.a  done_dwn,  0
delta4    slt.b  *dat_ptr,  *ptr2
decr2a    jmp.a  2,         delta6+1
decr2b    jmp.a  done_dwn,  delta6+1
delta5    sne.b  *dat_ptr,  *ptr2
delta6    slt.a  *dat_ptr,  *ptr2
          jmp.a  check_dwn, }dat_ptr
done_dwn  mov.i  *dat_ptr,  @dat_ptr
check_all seq.ab dat_ptr,   dat_ptr    ;go until pointers match
          jmp.a  check_up,  0
fini_part mov.i  bubl_new,  @dat_ptr   ;restore saved instruction

fini_sort mov.a  dat_ptr,   bloop      ;done partitioning, now see
          mov.b  dat_ptr,   sortbubl   ;which partition to sort and
          mov.i  bloop,     jmp_bubl   ;which to save
          sub.ab jmp_bubl,  jmp_bubl 
          mov.i  sortbubl,  dat_ptr    ;assume we'll work with this one
          sub.ab sortbubl,  sortbubl   ;b-field is size of second  
          nop.i  }bloop,    <dat_ptr   ;reset pointers to new partitions
          slt.b  jmp_bubl,  sortbubl   ;save larger, work with smaller
          jmp.a  save1,     0
save2     mov.i  dat_ptr,   {first
          mov.i  bloop,     dat_ptr
          jmp.a  breaks,    0
save1     mov.i  bloop,     {first
          jmp.a  breaks,    0

;Here we delete duplicates if necessary          
chk_del   add.b  first,     counter    ;pointer to end of data
no_delete jmz.a  CLEAROUT,        FLAGS
counter   jmp.a  setup,     first-checkline  ;will point to ending line
checkline dat.f  DATA,      DATA
setup     sne.b  checkline, counter          
          jmp.a  closeup,   0
          mov.ba checkline, checkline
deldups   mov.i  }checkline,chk_del
          sne.i  CLEAROUT,  chk_del    ;don't test blank lines
          jmp.a  setup,     >checkline
check_end sne.ab checkline, counter    ;make sure not at end of list
          jmp.a  setup,     >checkline
check_emp sne.i  CLEAROUT,  *checkline ;don't compare blank lines
          jmp.a  check_end, }checkline
check_dif seq.f  *checkline,chk_del    ;make sure still could match
          jmp.a  setup,     >checkline
          seq.i  *checkline,chk_del    ;clear out duplicates
          jmp.a  check_end, }checkline
matches   mov.i  CLEAROUT,  *checkline
          jmp.a  check_end, }checkline
               
   ;now close up holes in data
closedat  dat.f  DATA,      DATA
closeup   sub.ab #(closedat-checkline), counter  ;pointer to end
chk_close sne.ab closedat,  counter    ;end on time          
at_last   jmp.a  fini,      0
          seq.i  CLEAROUT,  *closedat
          mov.i  *closedat, >closedat
          jmp.a  chk_close, }closedat
fini      mov.i  CLEAROUT,  @closedat

end begin
