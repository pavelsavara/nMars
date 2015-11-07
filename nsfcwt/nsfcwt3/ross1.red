Return-Path: <@kate.ibmpcug.co.uk:rossd@arbroath.win-uk.net>
Received: from vuse.vanderbilt.edu ([129.59.100.1]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA00165; Wed, 1 Nov 95 12:47:49 CST
Received: from ctrvx1.Vanderbilt.Edu by vuse.vanderbilt.edu (8.7.1/SMI-4.1/VUSE-1.18)
	id MAA04379; Wed, 1 Nov 1995 12:55:50 -0600 (CST)
Resent-Date: Wed, 1 Nov 1995 12:55:50 -0600 (CST)
Resent-From: "<"<@kate.ibmpcug.co.uk:rossd<@arbroath.win-uk.net>
Received: from ctrvax.Vanderbilt.Edu by ctrvax.Vanderbilt.Edu
 (PMDF V5.0-5 #11488) id <01HX4OELFXMG8X2USE@ctrvax.Vanderbilt.Edu> for
 stst@vuse.vanderbilt.edu; Wed, 01 Nov 1995 12:54:31 -0600 (CST)
Received: from helios (helios.Vanderbilt.Edu)
 by ctrvax.Vanderbilt.Edu (PMDF V5.0-5 #11488)
 id <01HX4OD7S4408X11YG@ctrvax.Vanderbilt.Edu> for
 stracks@ctrvax.Vanderbilt.Edu; Wed, 01 Nov 1995 12:53:24 -0600 (CST)
Received: by helios (5.0/SMI-SVR4) id AA03482; Wed, 01 Nov 1995 12:53:09 +0600
Received: from ibmPCUG.CO.UK (Alice.ibmPCUG.CO.UK) by helios (5.0/SMI-SVR4)
 id AA03472; Wed, 01 Nov 1995 12:53:04 +0600
Received: from kate.ibmpcug.co.uk by alice.ibmPCUG.CO.UK id aa21399; Wed,
 01 Nov 1995 18:52 +0000 (GMT)
Received: from arbroath by kate.ibmpcug.co.uk id aa14713; Wed,
 01 Nov 1995 19:52 -0300 (BST)
Received: by win-uk.net!arbroath; Wed, 01 Nov 1995 18:43:56 -0300
Date: Wed, 01 Nov 1995 18:43:55 +0000
From: Derek Ross <rossd@arbroath.win-uk.net>
Subject: Entry for NSFCWT Round 3 - Mister Tidy (fwd)
Resent-To: stst@vuse.vanderbilt.edu
To: Stefan.Strack@vanderbilt.edu
Reply-To: Derek Ross <rossd@arbroath.win-uk.net>
Resent-Message-Id: <01HX4OELH07E8X2USE@ctrvax.Vanderbilt.Edu>
Message-Id: <280@arbroath.win-uk.net>
X-Vms-To: IN%"Stefan.Strack@vanderbilt.edu"
Mime-Version: 1.0
X-Mailer: WinNET Mail, v2.60
Content-Type: TEXT/PLAIN; CHARSET=US-ASCII
Content-Transfer-Encoding: 7BIT
X-Ph: V4.4@helios
Status: R


FORWARDED MAIL -------
From: rossd@arbroath.win-uk.net (Derek Ross)
Date: 27 Oct 95
Originally To: Stefan.Strack@vanderbilt.edu

;redcode   

;name Mister Tidy
;NSFCWT Round 3

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Start an SPL/SPL/DAT coreclear ...
;strategy ... If Mr Neat finds me ...
;strategy ... he will start an impgate.
;strategy Written in '94 code.
;strategy Submitted to NSFCWT Round 3: 27 October 1995

;assert 1

gap1    equ 14
signal  equ -117
        

        for gap1-1
        dat 1, 1
        rof

gate    dat -1, -1
        
        for gap1
        dat 0, 0
        rof

entry   mov.i #signal, #ally
next    jmp @entry
begin   dat 0, gate
kill    dat 0, next-check
part2   spl #0, gate-check
stun    spl #0, gate-check
loop    mov.i @bomb, <check
        djn.b loop, <begin
bomb    dat 0, stun
        
ally    spl #0, <gate
        mov.i brick, gate
brick   dat <gate, <gate-2667
check   dat 0, gate-check

        end stun

 MicroSoft Network may not carry this message without license
 to do so.  License to carry this message requires a fee of 
 $1000, payable within 30 days to Derek Ross.  Appearance of this 
 message on MicroSoft Network constitutes an agreement to terms.




 MicroSoft Network may not carry this message without license
 to do so.  License to carry this message requires a fee of 
 $1000, payable within 30 days to Derek Ross.  Appearance of this 
 message on MicroSoft Network constitutes an agreement to terms.


