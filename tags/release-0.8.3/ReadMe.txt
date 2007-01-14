
    nMars - Corewars MARS for .NET
    
---------------------------------------

Currently it consist of
- Redcode definitions library
- Parser
- Engine core simulator    
- Parser & core engine unit tests
- Library of warriors
- Modularized/SDL/Windows/Dll 0.9.3-a pMars
- Console debugger, with IronPython as command line language
- Graphical IDE

* More info about Corewars can be found here http://www.koth.org/, http://groups.google.com/group/rec.games.corewar

  Usage
--------------------
Usage manual can be found here
https://nmars.svn.sourceforge.net/svnroot/nmars/trunk/Usage.txt


  Download 
--------------------
https://sourceforge.net/project/showfiles.php?group_id=174312


  Console
--------------------
nMars.exe is commandline interface similar to pMars.exe, it is parser and engine.


  IDE
--------------------
Is extesible graphical framework with editor, compiler and debugger integrated.


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


  Debugger
--------------------
Basic debugger, currently console UI. IronPython as optional extension.
Still in developement.


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
Currently engine is 99% compatible and parser should be polished a bit.


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
0.9 - graphical IDE framework, draft of editor, draft of core viewers
1.0 - stabilization


  Contributions
--------------------
I would love to hear your opinion. 
Let's open new thread on rec.games.corewar on following topics or send me email.
If you would like to contribute more, there are some tasks:
 - Bugs - please feed it into bugzilla (preferably) or send it by email
 - Code review
   - I'm used to use some parts of extreme programming, code review is one. 
     If you can spend some time to review my code I will be very happy. 
     Pleas drop me an email before you start, so I can tell you what needs your attention.
 - Code contribution
   - I'm open for code contribution to nMars, send me an email to agree on it.
 - Links
   - If you like my effort, please add link to your pages to http://nmars.sourceforge.net/
 + Looking forward to hear you opinion, Thanks !


  Contact
--------------------
Project home is currently at
http://sourceforge.net/projects/nmars

Source code can be found at
https://nmars.svn.sourceforge.net/svnroot/nmars/trunk

Ideas, contributions and bug reports are welcome.
Pavel Savara
pavel (dot) savara (at) gmail (dot) com