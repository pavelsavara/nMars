;minidwarf
start   mov bomb,@-50
        jmp start,<start
bomb    dat #0,#-1
