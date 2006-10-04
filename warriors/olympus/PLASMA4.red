;redcode verbose
;name PLASMA 4
;author Wayne Sheppard
;strategy Scanner-Replicator
;strategy Better killing Process
;kill PLASMA
bomb      equ start-1    ;this should point to dat 0 , 0
start     add #3039,loc  ;best increment size
loc       jmz start,-1
          cmp #-1,@loc   ;don't look at DJN trails
          slt #100,loc   ;program length
          jmp start
          mov bomb,@loc  ;bomb whatever I found
          cmp <loc,bomb  ;is next location dat 0,0
          jmp -2         ;bomb more of program


rep       spl rep2      ;Replicator from FlashPaper
          spl 1         ;   by Matt Hastings
          spl 1
          spl paper4
          spl paper3
          spl paper2
          mov #8,8
paper1    mov <-1,<2
          mov <-2,<1
          spl @0,-2340
          mov <-1,<1020
          jmz -5,-5
          mov 0,-1
          dat #0,#1
          dat #0,#1
          mov #8,8
paper2    mov <-1,<2
          mov <-2,<1
          spl @0,5823
          mov <-1,<-740
          jmz -5,-5
          mov 0,-1
          dat #0,#1
          dat #0,#1
          mov #8,8
paper3    mov <-1,<2
          mov <-2,<1
          spl @0,1000
          mov <-1,<-3690
          jmz -5,-5
          mov 0,-1
          dat #0,#1
          dat #0,#1
          mov #8,8
paper4    mov <-1,<2
          mov <-2,<1
          spl @0,6109
          mov <-1,<1873
          jmz -5,-5
          mov 0,-1
          dat #0,#1
          dat #0,#1
          mov #8,8
rep2      spl 1
          spl 1
          spl paper8
          spl paper7
          spl paper6
paper5    mov <-1,<2
          mov <-2,<1
          spl @0,3009
          mov <-1,<-200
          jmz -5,-5
          mov 0,-1
          dat #0,#1
          dat #0,#1
          mov #8,8
paper6    mov <-1,<2
          mov <-2,<1
          spl @0,4832
          mov <-1,<-1830
          jmz -5,-5
          mov 0,-1
          dat #0,#1
          dat #0,#1
          mov #8,8
paper7    mov <-1,<2
          mov <-2,<1
          spl @0,1080
          mov <-1,<4096
          jmz -5,-5
          mov 0,-1
          dat #0,#1
          dat #0,#1
          mov #8,8
paper8    mov <-1,<2
          mov <-2,<1
          spl @0,-3040
          mov <-1,<-195
          jmz -5,-5
          mov 0,-1
          dat #0,#1
          dat #0,#1
