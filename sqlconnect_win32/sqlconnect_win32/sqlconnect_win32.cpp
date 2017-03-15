// sqlconnect_win32.cpp : Defines the entry point for the application.
//

#include "stdafx.h"
#include "sqlconnect_win32.h"

//SQL i�in gereken header dosyalar�
#include <sql.h>
#include <sqlext.h>
#include <sqltypes.h>

// printf falan..
#include <iostream>


#define MAX_LOADSTRING 100


/* 
--------------------------------------------------------------------------------------
	Bu kodlar Visual Studio taraf�ndan otomatik olu�tu..
	Buradan >>
*/

// Global Variables:
HINSTANCE hInst;								// current instance
TCHAR szTitle[MAX_LOADSTRING];					// The title bar text
TCHAR szWindowClass[MAX_LOADSTRING];			// the main window class name

// Forward declarations of functions included in this code module:
ATOM				MyRegisterClass(HINSTANCE hInstance);
BOOL				InitInstance(HINSTANCE, int);
LRESULT CALLBACK	WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK	About(HWND, UINT, WPARAM, LPARAM);

int APIENTRY _tWinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPTSTR    lpCmdLine,
                     int       nCmdShow)
{
	UNREFERENCED_PARAMETER(hPrevInstance);
	UNREFERENCED_PARAMETER(lpCmdLine);

 	// TODO: Place code here.
	MSG msg;
	HACCEL hAccelTable;

	// Initialize global strings
	LoadString(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
	LoadString(hInstance, IDC_SQLCONNECT_WIN32, szWindowClass, MAX_LOADSTRING);
	MyRegisterClass(hInstance);

	// Perform application initialization:
	if (!InitInstance (hInstance, nCmdShow))
	{
		return FALSE;
	}

	hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_SQLCONNECT_WIN32));

	// Main message loop:
	while (GetMessage(&msg, NULL, 0, 0))
	{
		if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}

	return (int) msg.wParam;
}



//
//  FUNCTION: MyRegisterClass()
//
//  PURPOSE: Registers the window class.
//
//  COMMENTS:
//
//    This function and its usage are only necessary if you want this code
//    to be compatible with Win32 systems prior to the 'RegisterClassEx'
//    function that was added to Windows 95. It is important to call this function
//    so that the application will get 'well formed' small icons associated
//    with it.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
	WNDCLASSEX wcex;

	wcex.cbSize = sizeof(WNDCLASSEX);

	wcex.style			= CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc	= WndProc;
	wcex.cbClsExtra		= 0;
	wcex.cbWndExtra		= 0;
	wcex.hInstance		= hInstance;
	wcex.hIcon			= LoadIcon(hInstance, MAKEINTRESOURCE(IDI_SQLCONNECT_WIN32));
	wcex.hCursor		= LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground	= (HBRUSH)(COLOR_WINDOW+1);
	wcex.lpszMenuName	= MAKEINTRESOURCE(IDC_SQLCONNECT_WIN32);
	wcex.lpszClassName	= szWindowClass;
	wcex.hIconSm		= LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

	return RegisterClassEx(&wcex);
}

/* 
	Bu kodlar Visual Studio taraf�ndan otomatik olu�tu..

	<< Buraya Kadar
--------------------------------------------------------------------------------------
	*/


//
//   FUNCTION: InitInstance(HINSTANCE, int)
//
//   PURPOSE: Saves instance handle and creates main window
//
//   COMMENTS:
//
//        In this function, we save the instance handle in a global variable and
//        create and display the main program window.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   HWND hWnd; // VStudio olu�turdu..
   HWND hbutton; // VStudio olu�turdu..
    
   // Komut istemi penceresi i�in gerekli olanlar
   	AllocConsole(); // konsol penceresini a�
	freopen("CONIN$", "r",stdin); // stdin komutlar�n� g�ster
	freopen("CONOUT$", "w",stdout); // stdout komutlar�n� g�ster
	freopen("CONOUT$", "w",stderr); // strerr komutlar�n� g�ster
	

   hInst = hInstance; // Store instance handle in our global variable
   // VStudio olu�turdu..
   

   hWnd = CreateWindow(szWindowClass, szTitle, WS_EX_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, 800, 500, NULL, NULL, hInstance, NULL);
	// Pencere �iziliyor ve handle olarak "hWnd" de�i�keni belirtiliyor.. 


   CreateWindow(TEXT("Button"),TEXT("Tamam"),BS_DEFPUSHBUTTON | WS_VISIBLE | WS_CHILD ,600,300,100,50,hWnd,(HMENU) 9001,0,0);
   // Buton �iz "Tamam" ad�nda "Button" s�n�f�nda , WS_CHILD olarak "hWnd" penceresine �iziliyor ve { (HMENU)9001 } olarak kimlik veriliyor

   CreateWindow(TEXT("Button"),TEXT("�ptal"),BS_DEFPUSHBUTTON | WS_VISIBLE | WS_CHILD ,600,250,100,50,hWnd,(HMENU) 9002,0,0);
   // Buton �iz "�ptal" ad�nda "Button" s�n�f�nda , WS_CHILD olarak "hWnd" penceresine �iziliyor ve { (HMENU)9002 } olarak kimlik veriliyor


   CreateWindow(TEXT("Edit"),TEXT(""),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_BORDER ,150,100,200,25,hWnd,(HMENU) 9003,0,0);
   // Editbox �iz "Edit" s�n�f�nda i�erik bo� , WS_CHILD olarak "hWnd" penceresine �iziliyor ve { (HMENU)9003 } olarak kimlik veriliyor

   CreateWindow(TEXT("Edit"),TEXT("�sim : "),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_DISABLED,50,100,100,25,hWnd,0,0,0);
   // Editbox �iz "Edit" s�n�f�nda i�erikte "�sim : " yazacak , WS_CHILD olarak "hWnd" penceresine �iziliyor ve kimlik verilmiyor


   CreateWindow(TEXT("Edit"),TEXT(""),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_BORDER ,150,150,200,25,hWnd,(HMENU) 9004,0,0);
   // Editbox �iz "Edit" s�n�f�nda i�erik bo� , WS_CHILD olarak "hWnd" penceresine �iziliyor ve { (HMENU)9004 } olarak kimlik veriliyor

   CreateWindow(TEXT("Edit"),TEXT("Soyisim : "),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_DISABLED ,50,150,100,25,hWnd,0,0,0);
   // Editbox �iz "Edit" s�n�f�nda i�erikte "Soyisim : " yazacak , WS_CHILD olarak "hWnd" penceresine �iziliyor ve kimlik verilmiyor


   CreateWindow(TEXT("Edit"),TEXT(""),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_BORDER ,150,200,200,25,hWnd,(HMENU) 9005,0,0);
   // Editbox �iz "Edit" s�n�f�nda i�erik bo� , WS_CHILD olarak "hWnd" penceresine �iziliyor ve { (HMENU)9005 } olarak kimlik veriliyor

   CreateWindow(TEXT("Edit"),TEXT("Telefon : "),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_DISABLED ,50,200,100,25,hWnd,0,0,0);
   // Editbox �iz "Edit" s�n�f�nda i�erikte "Telefon : " yazacak , WS_CHILD olarak "hWnd" penceresine �iziliyor ve kimlik verilmiyor


   CreateWindow(TEXT("Edit"),TEXT(""),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_BORDER  ,150,250,200,100,hWnd,(HMENU) 9006,0,0);
   // Editbox �iz "Edit" s�n�f�nda i�erik bo� , WS_CHILD olarak "hWnd" penceresine �iziliyor ve { (HMENU)9006 } olarak kimlik veriliyor

   CreateWindow(TEXT("Edit"),TEXT("Adres : "),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_DISABLED ,50,250,100,25,hWnd,0,0,0);
   // Editbox �iz "Edit" s�n�f�nda i�erikte "Adres : " yazacak , WS_CHILD olarak "hWnd" penceresine �iziliyor ve kimlik verilmiyor


   if (!hWnd)
   {
      return FALSE; // Vstudio olu�turdu "hWnd" penceresini �izemezse porgram kapanacak..
   }

   


   ShowWindow(hWnd, nCmdShow); // "hWnd" penceresini g�ster
   UpdateWindow(hWnd); // "hWnd" penceresini yenile

   return TRUE;
}

//
//  FUNCTION: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  PURPOSE:  Processes messages for the main window.
//
//  WM_COMMAND	- process the application menu
//  WM_PAINT	- Paint the main window
//  WM_DESTROY	- post a quit message and return
//
//

void sqlbaglan(HWND); // sql ba�lant�s� i�in yazd���m�z fonksiyonun �ntan�m�..

/*  
	Vstudio olu�turdu "WndProc()" fonksiyonu 
	"WNDCLASSEX" s�n�f�nda "wcex.lpfnWndProc" parametresine g�sterildi
	"MyRegisterClass()" fonksiyonu yukar�da a��klamas� ile mevcut.
*/
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	int wmId, wmEvent; 
	// wmId olay� ger�ekle�tiren pencere veya componentlerin kimli�i
	// wmEvent component in olu�turdu�u olay
	
	PAINTSTRUCT ps;
	HDC hdc;

	char msg[100]; //char* uzunlu�u belli olmayan� kabul etmez


	switch (message) // message de�i�keni pencereden d�nen mesaj� temsil eder
	{
	case WM_COMMAND: // pencere olay� : WM_COMMAND pencereye veya i�eri�ine ait komutun geldi�i anlam�na gelir
		wmId    = LOWORD(wParam); // 16 bitlik wParam de�i�keni ilk 8 biti kimlik bilgisi ta��r , wmId e al�n�yor
		wmEvent = HIWORD(wParam); // 16 bitlik wParam de�i�keni son 8 biti olay bilgisi ta��r , wmEvent e al�n�yor
		// Parse the menu selections:


		switch (wmId) // kimlik kimin sorusu soruluyor..
		{
		
		case 9001: // (HMENU)9001 : bu "Tamam" ad�n� verdi�imiz buton

			//GetWindowText(GetDlgItem(hWnd,9003),(LPWSTR)msg,100);
			//GetDlgItemText(hWnd,9003,(LPWSTR)msg,100);
			//MessageBox(hWnd,(LPCWSTR)msg,L"Mesaj : ",0);

			sqlbaglan(hWnd); // sqlbaglan() fonksiyonunu �al��t�r�r.

			break;

		case 9002: // (HMENU)9002 : bu "�ptal" ad�n� verdi�imiz buton
			DestroyWindow(hWnd); // pencereyi kapat�r..
			break;

		case IDM_ABOUT: // Vstudio olu�turdu gizledi�imiz pencereye ait komutu �a��r�yor
			DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About); // Hakk�nda penceresini �a��r�r.
			break;
		case IDM_EXIT:  // Vstudio olu�turdu gizledi�imiz pencereye ait komutu �a��r�yor
			DestroyWindow(hWnd);
			break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam); // Vstudio olu�turdu fonksiyon yenilensin diye prosesi tekrar olu�turuyor.
		}
		break;
	case WM_PAINT: // pencere olay� : WM_PAINT pencere �iziirken i�lenecek komutlar� yazmak i�in yakalan�r
		hdc = BeginPaint(hWnd, &ps); // pencere �izilmeye ba�lar

		// BURAYA : Eklemek istedi�iniz kodlar buraya...
		// TODO: Add any drawing code here...

		EndPaint(hWnd, &ps); // pencere �izimi bitti
		break;
	case WM_DESTROY: // pencere olay� : WM_DESTROY pencere kapanma a�amas�nda iken i�lenecek komutlar
		PostQuitMessage(0); // ��k�� mesaj� g�nder..
		break;
	default:
		return DefWindowProc(hWnd, message, wParam, lParam); 
	}
	return 0;
}

/* 
	Bu kodlar Visual Studio taraf�ndan otomatik olu�tu..

	<< Buraya Kadar
--------------------------------------------------------------------------------------
	*/

// Message handler for about box.
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		return (INT_PTR)TRUE;

	case WM_COMMAND:
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		break;
	}
	return (INT_PTR)FALSE;
}


/* 
	Bu kodlar Visual Studio taraf�ndan otomatik olu�tu..

	<< Buraya Kadar
--------------------------------------------------------------------------------------
	*/

void sqlbaglan(HWND hdlg)
{

	// SQLHENV henv; SQLHDBC hdbc; SQLHSTMT hstmt;    <-- bunu kabul etmedi.!!	
	SQLHANDLE henv; SQLHANDLE hdbc; SQLHANDLE hstmt;
	// Environment , DB Connection , STMT olu�turuluyor
	

	SQLWCHAR* sdata = (SQLWCHAR*)L"Driver=SQL Server;SERVER=DESKTOP-LI6D0Q5\\SQLEXPRESS;DATABASE=deneme;UID=sa;PWD=102030-g;";
	// ba�lant� �emas� "sdata" ya yaz�l�yor

	SQLRETURN sr1,sr2,sr3;
	// komutlar i�in sonu� de�i�kenleri

	SQLAllocHandle(SQL_HANDLE_ENV,SQL_NULL_HANDLE,&henv); // Environment yerle�tiriliyor
	SQLSetEnvAttr(henv,SQL_ATTR_ODBC_VERSION,(SQLPOINTER)SQL_OV_ODBC3,0); // ODBC versiyon belirleniyor
	SQLAllocHandle(SQL_HANDLE_DBC,henv,&hdbc); // Enviroment DB Connection ile ili�tiriliyor

	SQLSetConnectAttr(hdbc,SQL_LOGIN_TIMEOUT,(SQLPOINTER)5,0); // Ba�lant� zaman a��m� belirleniyor

	SQLWCHAR retconstring[1024]; // ba�lant� hakk�nda geribildirim i�in de�i�ken tan�mlan�yor

	RETCODE conn = SQLDriverConnect( // Sql ba�lant� kuruluyor
	hdbc, // DB Connection nesnesi
    NULL, // ba�l� �al��t��� pencere
	sdata, // ba�lant� �emas� belirleniyor
    SQL_NTS, // ba�lant� �emas� uzunlu�u - NotTextSize
    retconstring, // ba�lant� hakk�nda geribildirim
    1024,// geribildirim uzunlu�u
    NULL, //
    SQL_DRIVER_NOPROMPT // ba�lant� i�in ODBC ayar penceresini g�ster
	);

	
	if(conn == SQL_SUCCESS || conn == SQL_SUCCESS_WITH_INFO) // SUCCESS tamam , SUCCESS_INFO ayr�nt�l� tamam ; sqldriverconnect() fonksiyonu ba�ar�l� ise
	{
		//MessageBox(hdlg,L"Ba�land�",L"",0);
		printf("Ba�land� : %d \n",conn); 

		SQLCHAR okunanlar[240]; // okunan veriler i�in de�i�ken tan�mlan�yor
		SQLINTEGER ptrokunanlar; // okunan veriler i�in numaral� katar de�i�keni tan�mlan�yor (ptr on string muhabbeti)

		SQLWCHAR* komut = (SQLWCHAR*)L"Select  * From tablo"; // sql komutu tan�mlan�yor

		if(SQL_SUCCESS == SQLAllocHandle(SQL_HANDLE_STMT,hdbc,&hstmt)) // STMT DB Connect e g�sterililyor
		{
			if(SQL_SUCCESS == SQLExecDirect(hstmt,komut,SQL_NTS)) // Sql komutu uygulan�yor
			{
				printf(" Okunanlar \n");
				while(SQL_SUCCESS == SQLFetch(hstmt)) // S�rayla veri �ekiliyor
				{
					SQLGetData( // veri �ek fonksiyonu
						hstmt, // STMT nesnesi
						1, // S�tun numaras�
						SQL_CHAR, // veri tipi
						okunanlar, // okunan veri
						240, // okunan veri uzunlu�u
						&ptrokunanlar // okunan veri numaral� katar�
						);

					printf(" - %s",okunanlar); // okunan veri komut penceresinde

					// ayn� bilgiler a�a��daki benzer komutlar i�inde ayn�

					SQLGetData(
						hstmt,
						2,
						SQL_CHAR,
						okunanlar,
						240,
						&ptrokunanlar
						);

					printf(" - %s",okunanlar);

					SetDlgItemTextA(hdlg,9003,(LPCSTR)okunanlar); // SetDlgItemTextW : unicode utf-8 i�in, program utf-8 format�nda fakat
					// sql server ANSI kodlamaya ayarl� oldu�u i�in ANSI kodlama tipindeki veri i�in SetDlgTextA fonksiyonunu kullan�yoruz

					SQLGetData(
						hstmt,
						3,
						SQL_CHAR,
						okunanlar,
						240,
						&ptrokunanlar
						);

					printf(" - %s",okunanlar);

					SetDlgItemTextA(hdlg,9004,(LPCSTR)okunanlar);

					SQLGetData(
						hstmt,
						4,
						SQL_CHAR,
						okunanlar,
						240,
						&ptrokunanlar
						);

					printf(" - %s",okunanlar);

					SetDlgItemTextA(hdlg,9005,(LPCSTR)okunanlar);

					SQLGetData(
						hstmt,
						5,
						SQL_CHAR,
						okunanlar,
						240,
						&ptrokunanlar
						);

					printf(" - %s",okunanlar);

					SetDlgItemTextA(hdlg,9006,(LPCSTR)okunanlar);

					SQLGetData(
						hstmt,
						6,
						SQL_CHAR,
						okunanlar,
						240,
						&ptrokunanlar
						);

					printf(" - %s \n",okunanlar);

					SetDlgItemTextA(hdlg,9005,(LPCSTR)okunanlar);

				}
			} else { printf("Komut Hatas�! \n"); } 
		} else { printf("HSTMT Hatas�! \n"); }

	}
	else
	{

		//MessageBox(hdlg,L"Ba�lanamad�",L"",0);
		printf("Ba�lanamad� : %d \n",conn);

	}
	SQLFreeHandle(SQL_HANDLE_DBC,hdbc); // DB Connection sil
	SQLFreeHandle(SQL_HANDLE_ENV,henv); // Enivronment sil
	SQLFreeHandle(SQL_HANDLE_STMT,hstmt); // STMT sil
	SQLFreeConnect(hdbc); // ba�lant�y� kapat
}
