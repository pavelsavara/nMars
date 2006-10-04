; Hi, don't even try to understand how it works :-)
;even I don't know anymore...

;redcode-94
;name ?{whateverCT#$~S|[]~+'i"Ycc }
;author Paulsson
;Warrior that plays the game of Paper-Scissors-Stone in NSFCWT round 5
;Needs to be paired with one opponent exactly half the coresize apart (-d 4000)
;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
;assert VERSION >= 80
;contact mpn@ifm.liu.se
;NSFCWT Round 6

;my/your_hand are used to communicate between players
your_hand   equ (my_hand+CORESIZE/2)
PAPER       equ #1              ;some useful constants
SCISSORS    equ #2
STONE       equ #3

org         start
my_hand     dat 0,0
;
;           Variable part starts here. This is were I decide what hand to
;           use next. I can use the value of the RESULTS cell (0 if lost,
;           1 if won, 2 if tied last round) and any other values I chose
;           to store in pspace. The hand I decide to show is stored in the
;           B-field of instruction 'my_hand'.
;---BEGIN-VARIABLE-PART-----------------------------------------------------
seed    equ             23*11*13
        
start           
result  ldp.ab  #0,#0
                sne.ab  #-1,result
                jmp             init
counter ldp.ab  #1,#0
winn    ldp.ab  #2,#0
loss    ldp.ab  #3,#0
rand    ldp.ab  #4,#0
mlh             ldp.ab  #5,#0
lh              nop             #0,#0
mslh    ldp.ab  #7,#0
slh             ldp.ab  #8,#0
msslh   ldp.ab  #9,#0
sslh    ldp.ab  #10,#0
                sne.ab  #-1,result
                jmp     acont
                jmz.b   aloss,result
                sne.ab  #1,result
                jmp             awinn
atie    mov.b   mlh,lh
                jmp             acont
                
awinn   nop             >winn
                stp.b   winn,#2
                mov.b   mlh,lh
                nop             >lh
                mod.ab  #3,lh   
                nop             >lh
                jmp             acont
                                
aloss   nop             >loss
                stp.b   loss,#3
                mov.b   mlh,lh
                mod.ab  #3,lh
                nop             >lh
                
acont   nop             >counter
                stp.b   counter,#1
                slt.ab  #3,counter
                jmp             random
                
s1              mul.b   msslh,#3
                add.b   slh,s1
                mul.ab  #3,s1
                add.b   mslh,s1 
                mul.ab  #3,s1
                add.b   mlh,s1
ptr             add.b   result,#0
                mul.ab  #3,ptr
                add.b   lh,ptr
                add.ab  #tabel-1-ptr,ptr
                add.b   @ptr,s1
hej             ldp.b   s1,#0
                nop             >hej
                stp.b   hej,s1
s2              mul.b   mslh,#3
s22             add.b   lh,s2
s23             mul.ab  #3,s2
                add.b   mlh,s2  
                mul.ab  #3,s2
                add.ab  #100,s2
                mov.b   s2,s22          
                mov.b   s2,s23
                nop             >s22
                nop             >s23,>s23
                ldp.ba  s2,s2
                ldp.ba  s22,s22
                ldp.ba  s23,s23
sum             

                add.ab  s2,#0
                add.ab  s22,sum
                add.ab  s23,sum
scale   div.b   sum,#4000
                mul.ba  scale,s2                
                mul.ba  scale,s22               
                mul.ba  scale,s23
                add.ab  #seed,rand
                mod.ab  #4000,rand
                stp.b   rand,#4
                sub.ab  s2,rand         
                slt.b   rand,#4000
                jmp             bpaper
                sub.ab  s22,rand                
                slt.b   rand,#4000
                jmp             bzizz
                mov.ab  #3,my_hand
                jmp     hhhej
bpaper  mov.ab  #1,my_hand
                jmp             hhhej
bzizz   mov.ab  #2,my_hand
                
hhhej   stp.ba  mslh,msslh
                stp.ba  mlh,mslh
                stp.ba  slh,sslh
                stp.ba  lh,slh
                stp.ba  my_hand,mlh                             
                jmp             wait            

init    stp.ab  #1,#4*4*4*4+100
                nop             <init
                djn.b   init,#4*4*4*4+1
                jmp             counter

tabel   dat             0,1+100         ;loss p
                dat             0,-2+100        ;loss z
                dat             0,-2+100        ;loss s
                dat             0,-1+100        ;w p
                dat             0,-1+100        ;w z
                dat             0,-1+100        ;w s
                dat             0,0     +100    ;t p
                dat             0,0     +100    ;t z
                dat             0,-3+100        ;t s

random  mov.a   #1,s2
                mov.a   #1,s22
                mov.a   #1,s23
                jmp             sum



;---END-VARIABLE PART-------------------------------------------------------
;           End of variable part. I wait for the other player to show his hand.
;           I then analyze the outcome of the game.
;
wait        jmz.b wait,your_hand
work        mov.b your_hand,#work
            sub.b my_hand,work          ;your_hand minus my_hand, loss=1,-2
            add #2,work                 ;loss=3,0
            mod #3,work                 ;loss=0
live        jmn live,work               ;die if lost, live if won or tied

            end


