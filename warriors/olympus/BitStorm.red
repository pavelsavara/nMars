; Bit Storm
; by Steve Bonner
NIMBUS    DAT                   801
START     ADD       # 200,       NIMBUS
          MOV         STONE,   @ NIMBUS
          MOV         HAIL,    < NIMBUS
          SPL                  @ NIMBUS
          JMP         START
HAIL      ADD       # 1691,      -1
STONE     DJN         -1,      @ -2
          END       START