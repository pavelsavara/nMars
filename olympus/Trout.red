;
;    Warrior: Trout
;  File name: trout.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: C Butcher / New Zealand
;
time       dat  #0
compare    cmp  #0,       @20  ;was cmp @20 #0 - CWS'88 violation
           jmp  bomb
           mov  @18,      @a
           add  #5,       a
checktime  jmp  compare
bomb       mov  create,   @a
           add  #1,       a
           mov  jump,     @a
           mov  #100,     time
           djn  -1,       time
           mov  #20,      time
           mov  #0,       <a
           djn  -1,       time
           jmp  compare
create     spl  0
jump       jmp  -1
a          dat  #28
           end  compare
