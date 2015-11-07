Greets... Here my entry for round 5 of RM, the ICWS'88 part. It will
most probably be utterly pounded into the ground :-( despite the hours
I have spent on it. I began writing it last October/November, and
have been gradually improving it. I'm pleased with it even though it
isn't even slightly competitive...
Cheers, John

;redcode
;name SNOWMAN v3.15
;author John Metcalf
;assert CORESIZE==8000
mov @6,<5
mov <5,<4
djn $-2,$4
mov $9,$2004
mov $2,$2004
jmp $1003,$1012
djn $-1,<10
sub $8,@3
jmz $-1,@8
slt #-10,$7
mov @0,@6
jmz $-4,$-5
spl $0,<-1001
mov $2,<-2
jmp $-1,<-110
dat <3094,<-3094
jmp $-2103,$3094
end

--
  Fidonet:  John Metcalf 2:254/269
  Internet: john.metcalf@bsm-bbs.demon.co.uk

  Standard disclaimer : The views of this user are strictly their own.
  Don't delay, call today - Boiled Sweets Music BBS +44 (0)171 686 0135/6


