;redcode-94
;name     Lestat Incarnation0.2
;author   anders scholl
;contact anders@kamsc.seds.org
;strategy B-field scanning vampire; searches for Claudia to help him.

org       loner

pointer   dat       $0, -40             ;0 pointer
loner     jmz       $0, <pointer        ;1 if place is 0, start over
          sne       @pointer, #-20      ;2 if non-0 is -20,
          jmp       switch              ;3 do claudia routine
          sub.ba    $pointer, vpointer  ;4 fix pointer
          mov.i     vpointer, @pointer  ;5 drop pointer
          sub.a     $pointer, $vpointer ;6
          jmp       loner, $0           ;7 jump to loner

vpointer  jmp       $17, $0             ;8 where to put the victims

switch    sub.ba    $pointer, @pointer  ;9
          add.a     #13, @pointer       ;10

united    spl       $0, $0              ;11 split off for long life
          jmz       $0, <pointer        ;12 if 0 do next
          sub.ba    $pointer, vpointer  ;13 fix pointer
          mov.i     vpointer, @pointer  ;14 drop victim pointer
          sub.a     $pointer, vpointer  ;15 fix pointer again
          jmp       united, $0          ;16 jmp back

victims   spl       $0, $0              ;17
          mov.i     clear_1, @1+7994    ;18
          djn       victims, #7975      ;19
          mov.i     clear_2, @1-5       ;21
          djn       $-1, #7983          ;22  

clear_1   spl       $0, $0              ;23
clear_2   dat       $0, $0              ;24
