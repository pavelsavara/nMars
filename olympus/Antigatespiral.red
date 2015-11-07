inc1 equ 3
inc2 equ 4
inc3 equ 7

imp1 equ imp+2667
imp2 equ imp+2667+2667

start mov imp,imp1
      mov imp,imp2

      spl 8
      spl 4
      spl 2
      jmp imp
      jmp imp1+1
      spl 2
      jmp imp2
      jmp imp+1
      spl 4
      spl 2
      jmp imp1
      jmp imp2+1
      spl 2
      dat #0

      spl 8
      spl 4
      spl 2
      jmp imp+inc1
      jmp imp1+1+inc1
      spl 2
      jmp imp2+inc1
      jmp imp+1+inc1
      spl 4
      spl 2
      jmp imp1+inc1
      jmp imp2+1+inc1
      spl 2
      dat #0

      spl 8
      spl 4
      spl 2
      jmp imp+inc2
      jmp imp1+1+inc2
      spl 2
      jmp imp2+inc2
      jmp imp+1+inc2
      spl 4
      spl 2
      jmp imp1+inc2
      jmp imp2+1+inc2
      spl 2
      dat #0
      dat #0

imp   mov 0,2668
      mov 0,2668

      end start
