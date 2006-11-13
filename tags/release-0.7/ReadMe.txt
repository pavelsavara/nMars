
    nMars - Corewars MARS for .NET 
    
---------------------------------------

Currently it consist of
- Redcode definitions library
- Parser
- Engine core simulator    
- Parser & core engine unit tests
- Library of warriors
- Modularized/SDL/Windows/Dll 0.9.2 pMars

Planned components are
- simple IDE with debuger
- hill - competition engine
- evolver - engine for Darwinistic evolution
- screensaver - visualisation for evolver
- p2p evolver - distributed version of evolver
- faster core engine - array of C# delegates as implementation of instructions
- wrappers for other engines and parsers
- constant optimizer

* More info about Corewars can be found here http://www.koth.org/, http://groups.google.com/group/rec.games.corewar

  Usage
--------------------
Usage manual can be found here
https://svn.sourceforge.net/svnroot/nmars/trunk/Usage.txt


  Parser
--------------------
Targeting to be full ICWS '94 RedCode specification compliant.

Current implementation doesn't support (yet)
 - EQU substitutions 
   - instructions in EQU
   - modifiers in EQU
 - FOR 0 comment-block ROF
 - in-place assignments (k=k+1)
 - comments asserts

Is based on GOLD parser by Devin Cook
http://www.devincook.com/goldparser/
And Calitha .NET Engine for GOLD parser by Robert van Loenhout
http://www.xs4all.nl/~rvanloen/goldparser.html
which was little bit modified.


  Engine
--------------------
Is full ICWS '94 RedCode specification compliant and pMars compatible.

Basic idea is to be easily comprehensible and maintainable.
There is no efort to make it fast.
This implementation support interfaces for watching, debugging - still in developement.


  RedCode - common library
--------------------
Contain shared definitions of types and interfaces.
 - interfaces IParser, IEngine, 
 - classes Warrior, Instruction, Mode, Modifier, Rules, Project
 - other reusable classes
 - support for modularity, see ModuleRegister, IModule


  pMars
--------------------
 - I included pMARS 0.9.2 modified by M Joonas Pihlaja.
 - I modularized it and wrapped into DLL and .NET component
 - I'm prepared to merge it back to pMARS CVS in near future if owners allow


  Unit tests
--------------------
Are included to verify that my implementation is working same as original pMars.
Currently engine is 100% compatible and parser should be polished a bit.


  Architecture
--------------------
I'm trying to make it
- easy to read
- extensible, easy to build on top of it
- portable to Mono


  License
--------------------
nMars is Licensed under GNU Lesser General Public License
which can be found here: http://www.gnu.org/licenses/lgpl.txt


  Road map
--------------------
0.7 - Current, see https://svn.sourceforge.net/svnroot/nmars/trunk/Changes.txt
0.8 - react to your feedback, finalize debug interfaces on engine, console debuger, similar to pMars one
0.9 - graphical IDE framework, draft of editor, draft of core viewers
1.0 - stabilization
I will have a week of vacations for that, so I can move it forward! Soon.


  Contributions
--------------------
I would love to hear your opinion. 
Let's open new thread on rec.games.corewar on following topics or send me email.
If you would like to contribute more, there are some tasks:
 - Bugs - please feed it into bugzilla (preferably) or send it by email
 - Let's talk about specification of evolvers, IDE and hill engine
   - feature requests, ideas, opinions
   - design of interfaces of component
 - Wrap existing engines
   - create module similar to pMars.DllWrapper around existing engines
   - we will get unit tests for it for free
   - fMars, qMars or any fast one
   - pMars.so - same as pMArs.dll but for Linux
 - Code review
   - I'm used to use some parts of extreme programming, code review is one. 
     If you can spend some time to review my code I will be very happy. 
     Pleas drop me an email before you start, so I can tell you what needs your attention.
 - Code contribution
   - I'm open for code contribution to nMars, send me an email to agree on it.
 - Documentation & Home page
   - Currently there is only basic info about nMars, let's extend it
   - I feel we need some Wiki for CoreWars
   - There is neglect page on wikipedia, but that's not vehicle for more focused content
   - Anyone should be able to update pages about strategies, software links, personal corewars pages, warriors library
   - Let's update content on koth.org
 - Logo & Icons
   - We need some nice graphics to promote corewars
   - Propose some great idea, maybe I can persuade my coleague to do it for us
 - Links
   - If you like my effort, please add link to your pages to http://nmars.sourceforge.net/
 + Looking forward, Thanks !


  Contact
--------------------
Project home is currently at
http://sourceforge.net/projects/nmars

Source code can be found at
https://svn.sourceforge.net/svnroot/nmars/trunk

Ideas, contributions and bug reports are welcome.
Pavel Savara
pavel (dot) savara (at) gmail (dot) com