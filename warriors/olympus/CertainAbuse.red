;redcode-94
;name Certain Abuse
;author Dave Hillis
;strategy - Takes advantage of the fact that the 94 hill and the
;strategy - Beginners hill both used -F 4000. It uses a P-space
;strategy - round counter and a look-up table to tell where the
;strategy - second warrior will be loaded into core. This version
;strategy - is only effective when challenging the hill. To fight
;strategy - as a defender, you have to use the negatives of the
;strategy - table values. The program is optimized to kill the
;strategy - published warriors that were on the 94 hill.
;assert CORESIZE==8000

  org START
counter equ #-109
off     equ 100
wrap    equ 87
target1 equ target2-1
target2 equ thecnt

START
thecnt  ldp    counter,  #0       ; increment a round counter
        add    #1,       thecnt
        stp.b  thecnt,   counter
        add.ba thecnt,   bomber
        slt.ab #wrap,    thecnt
        jmp    bomber
        add.a  #-wrap,   bomber
        mov.x  *bomber,  *bomber

bomber  mov.i  b-1,      target1
        add.f  target1,  target2

; target2 and target1 hold the start and end points of the other warrior.
; Attack it by shuffling lines from both ends working towards the middle

attack  mov.i  }target2, {target1
        mov.i  {target1, }target2
        djn.b  attack,   #121
b
spl.i #4000+off,<4994+off ; The abuse table. The A
mov.i #3398+off,<4539+off ; fields hold the address
mov.i #1376+off,<7816+off ; where the second warrior
mov.i #5987+off,<2824+off ; will be loaded for the
mov.i #5790+off,<2940+off ; first 87 rounds. The B
mov.i #3395+off,<2733+off ; fields hold the next 87
mov.i #5616+off,<1379+off ; rounds. Too bad there
mov.i # 814+off,<7391+off ; isn't more space.
mov.i #7121+off,<2951+off
mov.i #5830+off,< 931+off ; If he's still alive, I'm
mov.i #3869+off,<7713+off ; in big trouble. The table
mov.i #3471+off,<1780+off ; also serves as a weak
mov.i #7762+off,<7881+off ; secondary attack.
mov.i #2070+off,<2024+off
mov.i #6979+off,<2084+off ; After the 174 addresses
mov.i #2079+off,<1846+off ; in the table have been
mov.i #4453+off,<5856+off ; attacked, Certain Abuse
mov.i # 550+off,<6438+off ; over-runs the table and
mov.i #1679+off,<1828+off ; becomes suicidal for the
mov.i #2659+off,< 824+off ; remaining 26 rounds.
mov.i #4787+off,<3687+off
mov.i #7122+off,< 975+off ; If I'm brainwashed, I'm
mov.i # 883+off,<7598+off ; dead :-(
mov.i #7790+off,<1584+off
mov.i #3545+off,<6654+off ; 1. Can you find a small
mov.i #3796+off,<5890+off ; tweak which makes CA no
mov.i #2095+off,<4361+off ; longer suicidal?
mov.i # 641+off,<6573+off
mov.i #3683+off,<1985+off ; 2. Can you rewrite CA in
mov.i #6044+off,<5245+off ; less instructions? This
mov.i #5408+off,<2925+off ; would leave extra space
mov.i #6589+off,<4831+off ; to store addresses.
mov.i #4857+off,<6367+off
mov.i #1223+off,< 197+off ; The best answers received
mov.i #4383+off,<1682+off ; will appear in the next
mov.i #6986+off,<4269+off ; issue of Core Warrior.
mov.i #5201+off,<6114+off
mov.i #2305+off,<3660+off
mov.i #3504+off,<2859+off
mov.i #7537+off,<2207+off
mov.i #5916+off,<7442+off
mov.i #5407+off,<6033+off
mov.i #6594+off,< 763+off
mov.i #1368+off,<3047+off
mov.i #6857+off,<6168+off
mov.i #4688+off,<6931+off
mov.i #7356+off,<1920+off
mov.i #3598+off,< 936+off
mov.i #5554+off,<4051+off
mov.i #3339+off,<4276+off
mov.i #6573+off,<5107+off
mov.i #4775+off,<2222+off
mov.i #4278+off,<1909+off
mov.i #6361+off,<5736+off
mov.i #7292+off,<1549+off
mov.i # 725+off,< 885+off
mov.i #3918+off,<2196+off
mov.i #4530+off,<3107+off
mov.i #5390+off,<4534+off
mov.i # 938+off,<5850+off
mov.i #1410+off,<2977+off
mov.i #1401+off,<5795+off
mov.i #4866+off,<7546+off
mov.i #4106+off,<5453+off
mov.i # 738+off,<4532+off
mov.i #1270+off,<1729+off
mov.i #6140+off,<5937+off
mov.i #6405+off,<2776+off
mov.i #6037+off,<1089+off
mov.i #4151+off,<5250+off
mov.i # 852+off,<4742+off
mov.i #5383+off,<5278+off
spl.i #3697+off,<2274+off
mov.i # 634+off,<6877+off
mov.i #7482+off,<6348+off
mov.i #7415+off,<4642+off
mov.i #1340+off,< 915+off
mov.i #1324+off,<3501+off
mov.i #2170+off,<6361+off
mov.i #4755+off,<6072+off
mov.i #2057+off,<5768+off
mov.i #4292+off,<5303+off
mov.i #1737+off,<6608+off
mov.i #7174+off,<1307+off
mov.i #6066+off,<6804+off
spl.i #1563+off,<1276+off
mov.i #6238+off,<1774+off
end
