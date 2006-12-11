Return-Path: <@kate.ibmpcug.co.uk:rossd@arbroath.win-uk.net>
Received: from vuse.vanderbilt.edu ([129.59.100.1]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA23493; Fri, 20 Oct 95 02:04:58 CDT
Resent-From: @kate.ibmpcug.co.uk:rossd@arbroath.win-uk.net
Received: from ctrvx1.Vanderbilt.Edu by vuse.vanderbilt.edu (8.6.12/SMI-4.1/VUSE-1.15)
	id CAA18851; Fri, 20 Oct 1995 02:12:57 -0500
Resent-Date: Fri, 20 Oct 1995 02:12:57 -0500
Received: from ctrvax.Vanderbilt.Edu by ctrvax.Vanderbilt.Edu
 (PMDF V5.0-5 #11488) id <01HWNAHA3OK28XMKJS@ctrvax.Vanderbilt.Edu> for
 stst@vuse.vanderbilt.edu; Fri, 20 Oct 1995 02:12:19 -0500 (CDT)
Received: from helios (helios.Vanderbilt.Edu)
 by ctrvax.Vanderbilt.Edu (PMDF V5.0-5 #11488)
 id <01HWNAH3K6K08XJH53@ctrvax.Vanderbilt.Edu> for
 stracks@ctrvax.Vanderbilt.Edu; Fri, 20 Oct 1995 02:12:10 -0500 (CDT)
Received: by helios (5.0/SMI-SVR4) id AA02055; Fri, 20 Oct 1995 02:12:37 +0600
Received: from ibmPCUG.CO.UK (Alice.ibmPCUG.CO.UK) by helios (5.0/SMI-SVR4)
 id AA02050; Fri, 20 Oct 1995 02:12:34 +0600
Received: from kate.ibmpcug.co.uk by alice.ibmPCUG.CO.UK id aa04281; Fri,
 20 Oct 1995 08:12 -0300 (BST)
Received: from arbroath by kate.ibmpcug.co.uk id aa03977; Fri,
 20 Oct 1995 08:11 -0300 (BST)
Received: by win-uk.net!arbroath; Fri, 20 Oct 1995 08:14:29 -0300
Date: Fri, 20 Oct 1995 08:14:29 +0000
From: Derek Ross <rossd@arbroath.win-uk.net>
Subject: Entry for NSFCWT - Mister Speculative
Resent-To: stst@vuse.vanderbilt.edu
To: Stefan.Strack@vanderbilt.edu
Reply-To: Derek Ross <rossd@arbroath.win-uk.net>
Resent-Message-Id: <01HWNAHA4HHW8XMKJS@ctrvax.Vanderbilt.Edu>
Message-Id: <270@arbroath.win-uk.net>
X-Vms-To: IN%"Stefan.Strack@vanderbilt.edu"
Mime-Version: 1.0
X-Mailer: WinNET Mail, v2.30
Content-Type: TEXT/PLAIN; CHARSET=US-ASCII
Content-Transfer-Encoding: 7BIT
X-Ph: V4.4@helios
Status: R

;Bit short of time this week and that is one tough opponent!

;redcode-94
;name Mr Speculative
;NSFCWT Round 2

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Scan, Carpet Bomb, Faster Core Clear ...
;strategy Written in '94 code
;strategy Submitted to NSFCWT Round 2: 20 October 1995

;assert 1

gap1    equ 39
gap2    equ 36
gap1st  equ 200
multipl equ ((CORESIZE-gap1st)-((CORESIZE-gap1st)%gap1))
first   equ (check+multipl)
        


check   cmp <(first-(gap2*2/3)), <first
        jmp found
        add aim, check
start   mov bomb, @check
        djn check, <-100
found   mov.b check, aim
        jmp loop
bomb    jmp bomb, #-(gap2*1/3)
begin   dat #stun-begin, #begin-aim+1
kill    dat #begin-begin+1, #begin-aim+1
clear   spl #kill-begin+1, begin-aim+1
stun    spl #clear-begin+1, begin-aim+1
loop    mov }begin, <aim
        jmp loop, {begin
aim     dat #-gap1, #-gap1
        
        end start



