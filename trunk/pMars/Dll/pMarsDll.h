// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the PMARSDLL_EXPORTS
// symbol defined on the command line. this symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// PMARSDLL_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef PMARSDLL_EXPORTS
#define PMARSDLL_API __declspec(dllexport)
#else
#define PMARSDLL_API __declspec(dllimport) 
#endif


#include "stdafx.h"
extern "C"
{
	#include "..\src\global.h"
	#include "..\src\sim.h"

	PMARSDLL_API warrior_struct* pMarsParse(int argc, char** argv, char* errFile);
    PMARSDLL_API void pMarsFreeParsed();
	PMARSDLL_API int pMarsBeginMatch(int argc, char** argv, char* errFile);
	PMARSDLL_API int pMarsStepMatch();
	PMARSDLL_API void pMarsWatchMatch(mem_struct** aCore, int* aCoreSize, long** aCyclesLeft, int** aRound,
									  warrior_struct** aWarriors, int* aWarriorsCount, 
									  int** aWarriorsLeft, warrior_struct*** aNextWarrior,//warriors
									  int** aTaskQueue, int** aEndQueue //tasks
									  );
	PMARSDLL_API void pMarsEndMatch();
}
