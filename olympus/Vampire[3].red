; name Vampire
inc   dat #3364,#-3364
fang  jmp trap,4

start spl 0
      add inc,fang
      mov fang,@fang
      jmp -2

trap  mov 10,<-10
      spl -1
      jmp -2
end   start
