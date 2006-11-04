
    nMars - Corewars MARS for .NET 
    
---------------------------------------

Currently it consist of
- Redcode Definitions
- Parser
- Simple Engine core simulator    
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

* More info about Corewars can be found here http://www.koth.org/, http://groups.google.com/group/rec.games.corewar


Redcode Definitions library
--------------------
Contain shared definitions of types and interfaces.
 - Instruction and its properies
 - Warrior - instructions, start address, name
 - Rules - core setup
 - IEngine - engine interface
 - IParser - parser interface


Parser
--------------------
Targeting to be full ICWS '94 RedCode specification compliant.

Current implementation doesn't support (yet?)
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
Targeting to be full ICWS '94 RedCode specification compliant and pMars compatible.
Current implementation has probably serious defects and is expected to evolve.

Basic idea is to be easily comprehensible and maintainable.
There is no efort to make it fast.
This implementation will support most interfaces for watching, debugging, etc.


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


Contact
--------------------
Project home is currently at
http://sourceforge.net/projects/nmars

Source code can be found at
https://svn.sourceforge.net/svnroot/nmars/trunk

Ideas, contributions and bug reports are welcome.
Pavel Savara
pavel (dot) savara (at) gmail (dot) com