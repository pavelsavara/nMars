// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara
// This is DLL wrapper around pMars

#include "pMarsDll.h"

#ifdef _MANAGED
#pragma managed(push, off)
#endif

#ifdef _MANAGED
#pragma managed(pop)
#endif

PMARSDLL_API warrior_struct* pMarsParse(int argc, char** argv, char* errFile)
{
	warrior_struct* res=NULL;
	freopen( errFile, "w", stderr );
	if (parse_param(argc,argv)==SUCCESS) 
	{
		reset_regs();
		init();
		if (assemble(warrior[0].fileName,0)==SUCCESS) 
		{
			res=&warrior[0];
		}
	}
	freopen( "CON", "w", stderr );
	if (res!=NULL)
	{
		remove(errFile);
	}
	return res;
}

PMARSDLL_API void pMarsFreeParsed()
{
	body_finalize();
}


PMARSDLL_API int pMarsBeginMatch(int argc, char** argv, char* errFile)
{
	freopen( errFile, "w", stderr );
	if (parse_param(argc,argv)==SUCCESS) 
	{
		reset_regs();
		init();
		body_load();
		if (errorcode != SUCCESS)
		{
			freopen( "CON", "w", stderr );
			return 2;
		}
		if (rounds!=0) 
		{
			begin_match();
		}
	}
	else
	{
		freopen( "CON", "w", stderr );
		return 1;
	}
	return 0;
}


PMARSDLL_API void pMarsWatchMatch(mem_struct** aCore, int* aCoreSize, long** aCyclesLeft, int** aRound,
								  warrior_struct** aWarriors, int* aWarriorsCount, 
								  int*** aPSpaces,
								  int** aWarriorsLeft, warrior_struct*** aNextWarrior, //warriors
								  int** aTaskQueue, int** aEndQueue //tasks
								  )
{
	*aCore=memory;
	*aCoreSize=coreSize;
	*aWarriors=warrior;
	*aWarriorsCount=warriors;
	*aTaskQueue=taskQueue;
	*aEndQueue=endQueue;
	*aWarriorsLeft=&warriorsLeft;
	*aCyclesLeft=&cycle;
	*aNextWarrior=&W;
	*aRound=&round;
	*aPSpaces=pSpace;
}

PMARSDLL_API int pMarsStepMatch()
{
	return step_match();
}

PMARSDLL_API void pMarsResultsMatch()
{
	body_results();
}

PMARSDLL_API void pMarsEndMatch()
{
	end_match();
	body_finalize();
	freopen( "CON", "w", stderr );
}


BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 )
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
		break;
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
    return TRUE;
}
