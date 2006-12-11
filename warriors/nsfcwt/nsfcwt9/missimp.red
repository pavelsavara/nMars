Return-Path: <@kate.ibmpcug.co.uk:rossd@arbroath.win-uk.net>
Received: from helios.Vanderbilt.Edu ([129.59.1.25]) by idnsun.gpct.Vanderbilt.Edu.noname (4.1/SMI-4.1)
	id AA12872; Fri, 15 Dec 95 19:53:21 CST
Received: (from daemon@localhost) by helios.Vanderbilt.Edu (8.7.1/8.7.1) id SAA17423 for stst@idnsun.gpct.vanderbilt.edu; Fri, 15 Dec 1995 18:57:56 -0600 (CDT)
Received: from ibmPCUG.CO.UK (mmdf@Alice.ibmPCUG.CO.UK [192.68.174.66]) by helios.Vanderbilt.Edu (8.7.1/8.7.1) with SMTP id SAA17420 for <Stefan.Strack@vanderbilt.edu>; Fri, 15 Dec 1995 18:57:53 -0600 (CDT)
Received: from kate.ibmpcug.co.uk by alice.ibmPCUG.CO.UK id aa05740;
          16 Dec 95 2:00 GMT
Received: from arbroath by kate.ibmpcug.co.uk id aa12016; 16 Dec 95 2:00 GMT
Received: by win-uk.net!arbroath;  Sat, 16 Dec 1995 01:56:13
X-Mailer: WinNET Mail, v2.60
Message-Id: <379@arbroath.win-uk.net>
Reply-To: Derek Ross <rossd@arbroath.win-uk.net>
Originally-To: Stefan.Strack@vanderbilt.edu
To: <stst@idnsun.gpct.vanderbilt.edu>
Cc: sieben@imap1.asu.edu
Date: Sat, 16 Dec 1995 01:56:13
Subject: Entry for NSFCWT Round 9 - Miss Impertinent
From: Derek Ross <rossd@arbroath.win-uk.net>
Status: R

Return-Receipt-To: rossd@arbroath.win-uk.net

;Nandor, please forward this to Stefan, Just in Case ...   Thanks.

;redcode
;name Miss Impertinent
;kill Miss Impertinent
;NSFCWT Round 9

;author Derek Ross
;contact rossd@arbroath.win-uk.net

;strategy Written in '88 code.
;strategy Submitted to NSFCWT Round 9: 15th December 1995
;strategy Imp bomber with jumping copy ...
;strategy Unfortunately ran out of time before
;strategy completion so it's just cannon fodder this time ...

;assert CORESIZE > 1000
;assert VERSION >= 80

impGap  equ ((CORESIZE+1)/3)


start   spl launch

fire1   mov bomb1, @fire2
fire2   mov one, @impGap+90
        add bomb2, fire2
        cmp fire1-200, imp
bomb1   jmp @bomb1, #fire1
boot    spl 1
        add one, copy
        mov boot, 0
        mov boot, 0
        spl 1
        mov boot, 0
        spl copy
        sub one, copy
here    mov bomb2, here
        jmp @copy
bomb2   dat #0, #impGap+5
one     dat #1, #1
copy    mov copy, copy+impGap-200
        mov 0, copy
        
        for 30
        dat #0, #0
        rof

launch  mov imp, imp-impGap
        spl imp-impGap
        spl imp+impGap
imp     mov imp, imp+impGap

        end start




