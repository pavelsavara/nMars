;redcode-94
;name redos bomber
;author test
;assert CORESIZE==8000

A equ stone+2-4899
;4899 = (1161*459)%8000
step equ 1161

bomb  jmp   #A,    A
stone spl   #step, step
      add.f stone, bomb
      mov    bomb, *bomb
      jmp      -2, 0

end stone
