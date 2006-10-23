// pMarsDll.cpp : Defines the entry point for the DLL application.
//

#include "pMarsDll.h"


#ifdef _MANAGED
#pragma managed(push, off)
#endif

#ifdef _MANAGED
#pragma managed(pop)
#endif

void initWarrior(int w)
{
	warrior[w].offset=0;
	warrior[w].instLen=0;
	warrior[w].authorName=NULL;
	warrior[w].fileName=NULL;
	warrior[w].date=NULL;
	warrior[w].version=NULL;
	warrior[w].name=NULL;
	warrior[w].instBank=NULL;
}

void cleanWarrior(int w)
{
	warrior[w].offset=0;
	warrior[w].instLen=0;
	delete warrior[w].authorName;
	delete warrior[w].fileName;
	delete warrior[w].date;
	delete warrior[w].version;
	delete warrior[w].name;
	delete warrior[w].instBank;
}
void initAllWarriors()
{
	for(int w=0;w<MAXWARRIOR;w++)
	{
		initWarrior(w);
	}
}
void cleanAllWarriors()
{
	for(int w=0;w<MAXWARRIOR;w++)
	{
		cleanWarrior(w);
	}
}

PMARSDLL_API warrior_struct* pMarsParse(int argc, char** argv, char* errFile)
{
	warrior_struct* res=NULL;
	cleanAllWarriors();
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


PMARSDLL_API int pMarsBeginMatch(int argc, char** argv, char* errFile)
{
	cleanAllWarriors();
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


PMARSDLL_API int pMarsStepMatch()
{
	return step_match();
}

PMARSDLL_API void pMarsEndMatch()
{
	end_match();
	body_results();
	freopen( "CON", "w", stderr );
	cleanAllWarriors();
}


PMARSDLL_API void pMarsGetCore(mem_struct** core, int* size)
{
	*core=memory;
	*size=coreSize;
}


BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 )
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
		initAllWarriors();
		break;
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
    return TRUE;
}
