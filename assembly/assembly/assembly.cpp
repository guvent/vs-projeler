

#include "stdafx.h"

extern "C" void deneme(); // assembly olarak yazacaðýmýz fonksiyonu dahil ettik


int _tmain(int argc, _TCHAR* argv[])
{

	deneme(); // dahil ettiðimiz assembly ile yazýlan fonksiyonu çaðýrýyoruz


	printf(" - Registerler - \n"); // artistik bir baþlýk :D

	int eeax,eebx,eecx,eedx; // registerleri okutacaðýmýz deðiþkenler

	__asm { // assembly kod baþlangýcý ( bu kodlar "deneme()" fonksiyonuyla baðlantýsý yok farklý bir deneme daha )
		mov eeax,eax // eax ý al eeax deðiþkenine koy
		mov eebx,ebx // ebx i al eebx deðiþkenine koy
		mov eecx,ecx // ecx i al eecx deðiþkenine koy
		mov eedx,edx // edx i al eedx deðiþkenine koy
	}

	printf("EAX - %d\nEBX - %d\nECX - %d\nEDX - %d\n",eeax,eebx,eecx,eedx); // aldýðýmýz register bilgilerini ekrana yaz

	scanf(" "); // bir tuþa bas beklesin

   return 0;

}

