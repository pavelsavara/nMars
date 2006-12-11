 ;redcode-94
 ;name Paranoid
 ;author Calvin Loh
 ;Warrior that plays the game of Paper-Scissors-Stone in NSFCWT round 5
 ;Needs to be paired with one opponent exactly half the coresize apart (-d 4000)
 ;assert WARRIORS==1 || (WARRIORS == 2 && MINDISTANCE == CORESIZE/2)
 ;assert VERSION >= 80
 ;strategy Keeps hand only on a draw.
 ;strategy Assumes typical(?) enemy: changes hand only on a loss.
 ;strategy Paranoid changes to counter enemy's hand on a loss,
 ;strategy and changes to counter enemy's most often used strategy on a win.
 ;my/your_hand are used to communicate between players
 your_hand   equ (my_hand+CORESIZE/2)
 PAPER       equ #1              ;some useful constants
 SCISSORS    equ #2
 STONE       equ #3

 BEGIN       equ #-1

 RESULT      equ 0
 STRTGY      equ 4

 E_PPR       equ 5
 E_SCSSR     equ 6
 E_STN       equ 7

 org         start
 my_hand     dat 0,0
 ;
 ;           Variable part starts here. This is were I decide what hand to
 ;           use next. I can use the value of the RESULTS cell (0 if lost,
 ;           1 if won, 2 if tied last round) and any other values I chose
 ;           to store in pspace. The hand I decide to show is stored in the
 ;           B-field of instruction 'my_hand'.
 ;---BEGIN-VARIABLE-PART-----------------------------------------------------

 start       jmp    result 

 ;loads all p-space variables into core.
 result      ldp.ab RESULT,#0
 strtgy      ldp.ab STRTGY,#0
 e_ppr       ldp.ab E_PPR,#0
 e_scssr     ldp.ab E_SCSSR,#0
 e_stn       ldp.ab E_STN,#0 

 ;evaluates result and chooses strategy.
 eval        sne.ab #0,result
             jmp    loss
             sne.ab #1,result
             jmp    win
             sne.ab #2,result
             jmp    draw

 ;begin : sets STRTGY to PAPER.
 begin       mov.ab PAPER,my_hand
             jmp    done

 ;draw : STRTGY is unchanged, and is copied to my_hand
 draw        mov.b  strtgy,my_hand
             sne.ab PAPER,strtgy
             add.ab #1,e_ppr
             sne.ab SCISSORS,strtgy
             add.ab #1,e_scssr
             sne.ab STONE,strtgy
             add.ab #1,e_stn            
             jmp    done

 ;loss : STRTGY is changed, and is copied to my_hand.
 ;if STRTGY == PAPER then { ++e_scssr && STRTGY := STONE }
 ;else if STRTGY == SCISSORS then { ++e_stn && STRTGY := PAPER }
 ;else if STRTGY == STONE then { ++e_ppr && STRTGY := SCISSORS }
 loss        sne.ab PAPER,strtgy
             jmp    p_loss
             sne.ab SCISSORS,strtgy
             jmp    sc_loss
 st_loss     add.ab #1,e_ppr
             mov.ab SCISSORS,my_hand
             jmp    done
 sc_loss     add.ab #1,e_stn
             mov.ab PAPER,my_hand
             jmp    done
 p_loss      add.ab #1,e_scssr
             mov.ab STONE,my_hand
             jmp    done

 ;win : STRTGY is changed, and is copied to my_hand.
 ;if STRTGY == PAPER then ++e_stn
 ;if STRTGY == SCISSORS then ++e_ppr
 ;if STRTGY == STONE then ++e_scssr
 win         sne.ab PAPER,strtgy
             add.ab #1,e_stn
             sne.ab SCISSORS,STRTGY
             add.ab #1,e_ppr
             sne.ab STONE,STRTGY
             add.ab #1,e_scssr

 ;find max( E_PPR, E_SCSSR, E_STN )
 ;if max == E_PPR then STRTGY := SCISSORS  
 ;else if max == E_SCSSR then STRTGY := STONE
 ;else if max == E_STN then STRTGY := PAPER
 max         mov.b  e_ppr,max
 maxstr      mov.ab SCISSORS,my_hand
 tst_scssr   slt.b  e_scssr,max           
             jmp    change1
 tst_stn     slt.b  e_stn,max
             mov.ab PAPER,my_hand 
             jmp    done
 change1     mov.b  e_scssr,max
             mov.ab STONE,my_hand
             jmp    tst_stn
             
 ;copies (all) core variables back to p-space.
 done        stp.b  my_hand,STRTGY
             stp.b  e_ppr,E_PPR
             stp.b  e_scssr,E_SCSSR
             stp.b  e_stn,E_STN 
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
                
             end start

