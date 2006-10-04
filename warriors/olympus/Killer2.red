;  Killer 2     by ThM
;
           JMP   Start
Ptr1       Dat   111
Ptr2       Dat   11
Ptr3       Dat   5
Start      Mov   #-250,    ptr1
           Mov   #11,      ptr2
           Mov   #8,       ptr3
           Mov   <ptr3,    <ptr1
           Djn   -1,       ptr2
           Spl   -269
           Mov   0,        1
           End   start
