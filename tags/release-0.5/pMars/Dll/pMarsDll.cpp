// pMarsDll.cpp : Defines the entry point for the DLL application.
//

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
		init();
		body_load();
		if (errorcode != SUCCESS)
		{
			return 2;
		}
		if (rounds!=0) 
		{
			begin_match();
		}
	}
	else
	{
		return 1;
	}
	return 0;
}


PMARSDLL_API void pMarsWatchMatch(mem_struct** aCore, int* aCoreSize, long** aCyclesLeft, int** aRound,
								  warrior_struct** aWarriors, int* aWarriorsCount, 
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
}

PMARSDLL_API int pMarsStepMatch()
{
	return step_match();
}

PMARSDLL_API void pMarsEndMatch()
{
	end_match();
	if(errorcode == SUCCESS)
	{
		body_results();
	}
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
