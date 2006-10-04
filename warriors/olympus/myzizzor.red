From news-rocq.inria.fr!univ-lyon1.fr!in2p3.fr!oleane!plug.news.pipex.net!pipex!tank.news.pipex.net!pipex!usenet.eel.ufl.edu!newsfeed.internetmci.com!in2.uu.net!spcuna!news.stormking.com!mpn@ifm.liu.se Thu Oct 26 15:01:21 1995
Article: 2678 of rec.games.corewar
Path: news-rocq.inria.fr!univ-lyon1.fr!in2p3.fr!oleane!plug.news.pipex.net!pipex!tank.news.pipex.net!pipex!usenet.eel.ufl.edu!newsfeed.internetmci.com!in2.uu.net!spcuna!news.stormking.com!mpn@ifm.liu.se
From: Magnus Paulsson <mpn@ifm.liu.se>
Newsgroups: rec.games.corewar
Subject: Re: Is Pizza overloaded ? myZizzor
Date: 26 Oct 1995 04:13:39 -0400
Organization: Storm King Ind. Inc.
Lines: 44
Sender: server@news.stormking.com
Distribution: world
Message-ID: <199510260755.IAA01477@bottom.ifm.liu.se>
Reply-To: mpn@ifm.liu.se
NNTP-Posting-Host: valhalla.stormking.com
Originator: corewar-l@stormking.com

> If you could do something like ";fight myZizzor" in your warrior,
> and have it just fight that one thing, so you could do a quick test?
> 
> That'd be mega-niftoramic...
> 
> -- 
>  /     John K. Wilkinson     -    jwilkinson@mail.utexas.edu     \
> | "I don't have the power because I've got the monkeys.  I've got |
>  \  the power because I'll set the monkeys LOOSE."  -Dave Foley  /

Here, be my guest.
The only thing I changed was a imp bomb.

/Magnus
(sorry, it's 9 bytes, not 8 as I wrote in the previous post)
--------------------------------------------
;redcode-94
;name myZizzor
;author Paulsson
;strategy Cissors (or whatever way you spell it)
;startegy One pass -> coreclear. Tiny I'd say.
;strategy Let's se how hard Die Hard is this time :-)
;assert CORESIZE > 1

org start
step    	equ             8
i for step
                dat             1,1
rof
check   	dat             1,0
i for 40
                dat             0,0
rof

start
p               add.ab  #step,#check+100
rep             jmz.f   p,@p			;scan
                mov.i   b2,>p			;carpet
                jmz.b   rep,check
b2      spl     #b3-p,b1-p+2			;coreclear
                mov.i   *p,>p
                djn.f   -1, <p-b1+p-2
b3      dat.f   <-2666, <2667			;Imp bomb! Kills theMystery, Die Hard, cic-test (sometimes)
b1      spl     #b2-p,b1-p+2			;but not Cotton-DH (don't know why)


