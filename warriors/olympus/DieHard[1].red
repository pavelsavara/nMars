;Address PDK@ADMIN.DRAKE.EDU
;redcode-94m quiet
;name Die Hard
;kill Die Hard
;author P.Kline
;strategy minimal kill, maximal survival
space    equ (-40*127)

step     equ 3315
bomb     equ fang
ind      equ (pit+7000)

         dat    -100,100
gate     dat    -100,100
         dat    -100,100
start2   spl    s4,2000
         spl    s3,2000
         spl    s2,2000
         spl    s1,2000
         mov    #-7000,ind
         jmp    -1,2000
     for 3
         dat    1000,-1000
     rof
s1       spl    #step,#-step
         mov    3,@3
         add    -2,2
         djn    -2,#1000
         jmp    @ind-pt+(step*6000),0+pt-(step*6000)
     for 10
         dat    1000,-1000
     rof
s2       spl    #step,#-step
         mov    3,@3
         add    -2,2
         djn    -2,#1000
         jmp    @ind-pt+(step*4000),0+pt-(step*4000)
     for 10
         dat    1000,-1000
     rof
s3       spl    #step,#-step
         mov    3,@3
         add    -2,2
         djn    -2,#1000
         jmp    @ind-pt+(step*2000),0+pt-(step*2000)
     for 10
         dat    1000,-1000
     rof
s4       spl    #step,#-step
         mov    3,@3
         add    -2,2
         djn    -2,#1000
         jmp    @ind-pt+(step*7000),0+pt-(step*7000)
     for 10
         dat    1000,-1000
     rof
         dat    #-100,#wipe1-gate
wipe3    dat    #-100,#wipe1-gate
wipe2    dat    #-5000,#100
wipe1    div.x  #-4000,#100

pt       dat    #1000,#-1000
         
pit      spl    #-1000,#1000
         spl    -1,3000
         mov    @1,>gate
         djn.b  -1,{wipe1
     for 5
         dat    0,0
     rof
         
start    spl 1,>-2002
         spl 1,>-2001
         mov -1,0
         djn c0,#1
         jmp start2

c0       spl   @0,space
         mov   }c0,>c0
cs       spl   #0
         spl   imp+5334
         spl   imp+2667
imp      mov.i #2667 ,*0

         end start
