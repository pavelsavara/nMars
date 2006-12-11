Okay, yet another quick-and-dirty, promptly-pounded out entry. }:>
Hopefully I'll do a bit better this round than last. }:>

Prolly not the toughest strategy, being a simple "check every 180th or so
location" typeof quick-scan, but hopefully it will prove moderately
effective at helping my score along.

*sigh* I'm beginning to wish I hadn't allowed my p-switcher to switch
to the stone. That seems to have done more harm than good with the
prolific amounts of papers the last round seemed to stick to. *bleah*
             _
     _     _|_  WolfWings ShadowFlight
| | | | | | | | wolfwings@lightspeed.net
| | | | | | | | "How good an actor do you
|_|_| |_|_| | |  have to be to play God?"
 _           /    - Bob Dylan
 \-.______,-'

;redcode
;assert (CORESIZE==8000)
;name Shoot from the hip
;author WolfWings
;strategy One-shot CMP/MOV Scan
;strategy N	FOR	48
;strategy	CMP	bomb+(N*1840)%3840,	bomb+((N*1840)%3840)+4000
;strategy	MOV	bomb,	bomb+(N*1840)%3840
;strategy	ROF

;strategy Night Crawler Stone
;strategy NCS:	SPL	0,	<-1001
;strategy	MOV	<21,	1+2234
;strategy	SUB	1,	-1
;strategy	DJN	-2,	<-2234
;strategy bomb:	END	START

START:
N	FOR	48
	CMP	bomb+(N*1840)%3840,	bomb+((N*1840)%3840)+4000
	MOV	bomb,	bomb+(N*1840)%3840
	ROF

NCS:	SPL	0,	<-1001
	MOV	<21,	1+2234
	SUB	1,	-1
	DJN	-2,	<-2234
bomb:	END	START


