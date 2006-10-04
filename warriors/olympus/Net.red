;
;    Warrior: Net
;  File name: Net.red
; Tournament: ICWST'90
;   Standard: CWS'88
;     Author: Sasha Wait
;     Branch: Lisgar Collegiate Institute
;
          JMP seek
srch      DAT 0,              1
          JMP trap
seek      ADD #61,            srch
          JMZ seek,           <srch
          MOV srch,           scn
detour    JMP newScan
newScan   SPL scan,           scan
          MOV rstLoop,        detour
rstLoop   JMP -3
stn       SPL stn,            stn
net       JMP @net,           -2
splt      SPL trap,           trap
          MOV zero,           <smash
          JMP splt
trap      DJN splt,           count
          MOV zero,           splt
scn       DAT 0,              1024
zero      DAT 0,              0
plcTrap   ADD #1,             scn
          MOV net,            @scn
          SUB scn,            @scn
          JMP next
stun      MOV stn,            @scn
next      JMN stun,           <scn
          MOV stn,            @scn
          JMP scan
reset     MOV #-16,           scn
scan      JMZ scan,           <scn
          CMP smash,          @scn
          JMP plcTrap
count     JMP reset,          64
smash     JMP reset,          srch
          END seek
