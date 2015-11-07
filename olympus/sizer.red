;redcode-94
;name sizer
;strategy Get an idea how large core is (within a power of 2)

        org sizer

cs      dat #-1         ;This is coresize-1
sizer   div #2,cs
        add #1,case
        jmn sizer,cs
case    jmp @case       ;jump somewhere depending on coresize

;trace on
ge1     jmp 0           ;core=  1-2  (we would jump to somewhere useful here)
ge3     jmp 0           ;       3-4
ge5     jmp 0           ;       5-8
ge9     jmp 0           ;       9-16
ge17    jmp 0           ;       17-32
ge33    jmp 0           ;       33-64
ge65    jmp 0           ;       65-128
ge129   jmp 0           ;       129-256
ge257   jmp 0           ;       257-512
ge513   jmp 0           ;       513-1024
ge1025  jmp 0           ;       1025-2048
ge2049  jmp 0           ;       2049-4096
ge4097  jmp 0           ;       4097-8192
ge8193  jmp 0           ;       8193-16384
ge16385 jmp 0           ;       16385-32768
ge32769 jmp 0           ;       32769-65536
