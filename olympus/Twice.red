;redcode
;name Twice
;author W. Mintardjo

bptr  DAT #split
split SPL split, bptr-core+1
      MOV @bptr, <core
jump  JMP -1
core  DAT #bptr+bptr+1

end split
