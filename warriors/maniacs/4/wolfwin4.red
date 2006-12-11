Well, my area fell prey to El Nino so I couldn't submit the warrior I had
for Round 3 (which, FYI, wasn't any relation to HSA. :) but here's a Round
4 submission. }:> Went solely for speed-of-boot instead of bothering to
implement a switching routine that could take 20-30 cycles to run, brought
it down to a 'nieve' switcher with only 7 cycles. }:>
             _
     _     _|_  WolfWings ShadowFlight
| | | | | | | | wolfwings@lightspeed.net
| | | | | | | | "In order to be a veteran,
|_|_| |_|_| | |  first ya' gotta be a beginner.
 _           /   But if ya' keep on pushing,
 \-.______,-'    ya' can be a winner." - Coolio

;redcode-b
;assert 1
;name Circle of Life
;author WolfWings
;strategy Well, my area fell prey to El Nino's powers, so I missed entering
;strategy round 3, but here's a round 4 entry. Just cycles through the
;strategy available components based on win/tie/loss.
;strategy Takes 7 cycles to decide+launch. Didn't bother with booting or
;strategy decoy's, figured I'd get a few extra scans/bombs/copies done
;strategy before those that did, which might be enough of an edge to win.
;strategy Nieve switching method (I can think of dozens of improvements):
;strategy  tie=bomb->copy->scan->bomb
;strategy loss=bomb->scan->copy->bomb
;strategy Lose As  | Tie As   | Win As   | Switch To
;strategy Stone    | Paper    | Scissors | Scissors
;strategy Paper    | Scissors | Stone    | Stone
;strategy Scissors | Stone    | Paper    | Paper

CELL	EQU	18

	ORG	start

start:	ldp.a	#CELL,	cycle
	ldp.a	#0,	#0
	add.a	-1,	cycle
	add.a	#2,	cycle
	mod.a	#3,	cycle
	stp.ab	cycle,	#CELL
cycle:	jmp.a	@0,	copy
	dat.f	$0,	scan
	dat.f	$0,	bomb

copy:	spl.b	1,	<-200
	spl.b	1,	<-300
	mov.i	-1,	0
	spl.b	@0,	}1800
	mov.i	}-1,	>-1
	spl.b	@0,	}3740
	mov.i	}-1,	>-1
	mov.i	{-1870,	<1870
	mov.i	{-3,	<1
	jmp.b	@0,	>-1922

scan:	spl.b	#1,	{1
	mov.i	-1,	<-6
	mov.i	>-7,	>-7
	jmn.f	-2,	>-8
	add.ab	#10,	@-2
	jmz.f	-1,	<-10
	slt.b	@-4,	#17
	djn.b	-6,	@-5
	djn.b	-4,	#16
	jmp.b	-5,	{-8

	dat.f	>-1,	>1
bomb:	spl.b	#0,	<-100
	mov.i	-2,	-1499
	add.ab	#197,	-1
	djn.f	-2,	<-1151
