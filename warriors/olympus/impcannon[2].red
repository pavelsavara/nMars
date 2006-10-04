;
; The imp cannon fires off an imp every
; so often.
;
timer dat 0,400
;
lup   djn lup,timer
;
fire  mov #400,timer
      spl imp,0
      jmp lup,0
;
imp   mov 0,1
end   lup