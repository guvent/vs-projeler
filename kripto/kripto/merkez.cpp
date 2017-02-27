#include<stdio.h>
#include<math.h>

#define __DLLEXP __declspec(dllexport)

extern "C" 
{

	__DLLEXP int rakam(char *);
	__DLLEXP char* yazi();
	__DLLEXP char* oku(char*);
	__DLLEXP char* k_sifrele(char veri[]);
	__DLLEXP char* k_sifrecoz(char veri[]);
	__DLLEXP int k_denetle(char veri1[],char veri2[]);

}

int rakam(char veri[])
{
	int i=0;

	while (veri[i] != '\0')
	{
		i++;
	}


	return i;
}

char* yazi()
{
	return "bu bir yazýdýr";
}

char* oku(char* yaz)
{
	return yaz;
}

char* k_sifrele(char veri[])
{
	int i=0;
	int a,b,c;

	int rakam[1024];

	while(veri[i] != '\0')
	{

		a = veri[i];

		c = a - 12;

		veri[i] = c;

		i++;

	}


	return veri;
}

char* k_sifrecoz(char veri[])
{
	int i=0;
	int a,b,c;

	int rakam[1024];

	while(veri[i] != '\0')
	{

		a = veri[i];

		c = a + 12;

		veri[i] = c;

		i++;

	}

	return veri;
}

int k_denetle(char veri1[],char veri2[])
{
	int r = 0;
	int i = 0;

	int a = 0, b = 0, c = 0;

	while(veri1[i] != '\0')
	{

		a = veri1[i];

		b = 12 + veri2[i];

		if(a != b) { r = 1; }
		
		i++;

	}


	return r;
}