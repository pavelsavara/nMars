;
;    Warrior: ZD
;  File name: zd.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Douglas McDaniels
;
start    SPL     stb
         SPL     ste
         SPL     sth
         SPL     stk
         SPL     stc
         SPL     stf
         SPL     sti
         SPL     stl
         SPL     std
         SPL     stg
         SPL     stj
         SPL     stm
sta      ADD   #-28,       a
         MOV     a,      @ a
         JMP     sta
a        DAT             -512
stb      ADD   #-28,       b
         MOV     b,      @ b
         JMP     stb
b        DAT             -1024
stc      ADD   #-28,       c
         MOV     c,      @ c
         JMP     stc
c        DAT             -1536
std      ADD   #-28,       d
         MOV     d,      @ d
         JMP     std
d        DAT             -2048
ste      ADD   #-28,       e
         MOV     e,      @ e
         JMP     ste
e        DAT             -2560
stf      ADD   #-28,       f
         MOV     f,      @ f
         JMP     stf
f        DAT             -3072
stg      ADD   #-28,       g
         MOV     g,      @ g
         JMP     stg
g        DAT             -3584
sth      ADD   #-28,       h
         MOV     h,      @ h
         JMP     sth
h        DAT             -4096
sti      ADD   #-28,       i
         MOV     i,      @ i
         JMP     sti
i        DAT             4608
stj      ADD   #-28,       j
         MOV     j,      @ j
         JMP     stj
j        DAT             -5120
stk      ADD   #-28,       k
         MOV     k,      @ k
         JMP     stk
k        DAT             -5632
stl      ADD   #-28,       l
         MOV     l,      @ l
         JMP     stl
l        DAT             -6144
stm      ADD   #-28,       m
         MOV     m,      @ m
         JMP     stm
m        DAT             -6656
         END     start
