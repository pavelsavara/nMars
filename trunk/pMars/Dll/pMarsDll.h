// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara
// This is DLL wrapper around pMars

#pragma once

#ifndef WINVER				// Allow use of features specific to Windows XP or later.
#define WINVER 0x0501		// Change this to the appropriate value to target other versions of Windows.
#endif
#ifndef _WIN32_WINNT		// Allow use of features specific to Windows XP or later.                   
#define _WIN32_WINNT 0x0501	// Change this to the appropriate value to target other versions of Windows.
#endif						
#ifndef _WIN32_WINDOWS		// Allow use of features specific to Windows 98 or later.
#define _WIN32_WINDOWS 0x0410 // Change this to the appropriate value to target Windows Me or later.
#endif
#ifndef _WIN32_IE			// Allow use of features specific to IE 6.0 or later.
#define _WIN32_IE 0x0600	// Change this to the appropriate value to target other versions of IE.
#endif

#define WIN32_LEAN_AND_MEAN		// Exclude rarely-used stuff from Windows headers
#include <windows.h>

#ifdef PMARSDLL_EXPORTS
#define PMARSDLL_API __declspec(dllexport)
#else
#define PMARSDLL_API __declspec(dllimport) 
#endif

extern "C"
{
	#include "..\src\global.h"
	#include "..\src\sim.h"

	PMARSDLL_API warrior_struct* pMarsParse(int argc, char** argv, char* errFile);
    PMARSDLL_API void pMarsFreeParsed();
	PMARSDLL_API int pMarsBeginMatch(int argc, char** argv, char* errFile);
	PMARSDLL_API int pMarsStepMatch();
	PMARSDLL_API void pMarsResultsMatch();
	PMARSDLL_API void pMarsWatchMatch(mem_struct** aCore, int* aCoreSize, long** aCyclesLeft, int** aRound,
									  warrior_struct** aWarriors, int* aWarriorsCount, 
									  int*** aPSpaces,
									  int** aWarriorsLeft, warrior_struct*** aNextWarrior,//warriors
									  int** aTaskQueue, int** aEndQueue //tasks
									  );
	PMARSDLL_API void pMarsEndMatch();
}
