// pMarsDll.cpp : Defines the entry point for the DLL application.
//

#include "pMarsDll.h"


#ifdef _MANAGED
#pragma managed(push, off)
#endif

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 )
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
    return TRUE;
}

#ifdef _MANAGED
#pragma managed(pop)
#endif

PMARSDLL_API warrior_struct* pMarsParse(int argc, char** argv, char* errFile)
{
	warrior_struct* res=NULL;
	freopen( errFile, "w", stderr );
	warrior[0].offset=0;
	warrior[0].instLen=0;
	delete warrior[0].authorName;
	delete warrior[0].fileName;
	delete warrior[0].date;
	delete warrior[0].version;
	delete warrior[0].name;
	delete warrior[0].instBank;
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
