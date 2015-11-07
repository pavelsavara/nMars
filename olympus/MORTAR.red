;Mortar
;Ray Cromwell
 
start mov b, @a
      add a, b
      mov @a, a
      jmp start
a     dat #5
b     dat #8
      end start
