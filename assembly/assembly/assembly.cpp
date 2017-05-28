

#include "stdafx.h"

extern "C" void deneme(); // assembly olarak yazaca��m�z fonksiyonu dahil ettik


int _tmain(int argc, _TCHAR* argv[])
{

	deneme(); // dahil etti�imiz assembly ile yaz�lan fonksiyonu �a��r�yoruz


	printf(" - Registerler - \n"); // artistik bir ba�l�k :D

	int eeax,eebx,eecx,eedx; // registerleri okutaca��m�z de�i�kenler

	__asm { // assembly kod ba�lang�c� ( bu kodlar "deneme()" fonksiyonuyla ba�lant�s� yok farkl� bir deneme daha )
		mov eeax,eax // eax � al eeax de�i�kenine koy
		mov eebx,ebx // ebx i al eebx de�i�kenine koy
		mov eecx,ecx // ecx i al eecx de�i�kenine koy
		mov eedx,edx // edx i al eedx de�i�kenine koy
	}

	printf("EAX - %d\nEBX - %d\nECX - %d\nEDX - %d\n",eeax,eebx,eecx,eedx); // ald���m�z register bilgilerini ekrana yaz

	scanf(" "); // bir tu�a bas beklesin

   return 0;

}

