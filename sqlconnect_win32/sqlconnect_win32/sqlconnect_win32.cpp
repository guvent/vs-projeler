// sqlconnect_win32.cpp : Defines the entry point for the application.
//

#include "stdafx.h"
#include "sqlconnect_win32.h"

//SQL için gereken header dosyalarý
#include <sql.h>
#include <sqlext.h>
#include <sqltypes.h>

// printf falan..
#include <iostream>


#define MAX_LOADSTRING 100


/* 
--------------------------------------------------------------------------------------
	Bu kodlar Visual Studio tarafýndan otomatik oluþtu..
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
	Bu kodlar Visual Studio tarafýndan otomatik oluþtu..

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
   HWND hWnd; // VStudio oluþturdu..
   HWND hbutton; // VStudio oluþturdu..
    
   // Komut istemi penceresi için gerekli olanlar
   	AllocConsole(); // konsol penceresini aç
	freopen("CONIN$", "r",stdin); // stdin komutlarýný göster
	freopen("CONOUT$", "w",stdout); // stdout komutlarýný göster
	freopen("CONOUT$", "w",stderr); // strerr komutlarýný göster
	

   hInst = hInstance; // Store instance handle in our global variable
   // VStudio oluþturdu..
   

   hWnd = CreateWindow(szWindowClass, szTitle, WS_EX_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, 800, 500, NULL, NULL, hInstance, NULL);
	// Pencere çiziliyor ve handle olarak "hWnd" deðiþkeni belirtiliyor.. 


   CreateWindow(TEXT("Button"),TEXT("Tamam"),BS_DEFPUSHBUTTON | WS_VISIBLE | WS_CHILD ,600,300,100,50,hWnd,(HMENU) 9001,0,0);
   // Buton Çiz "Tamam" adýnda "Button" sýnýfýnda , WS_CHILD olarak "hWnd" penceresine çiziliyor ve { (HMENU)9001 } olarak kimlik veriliyor

   CreateWindow(TEXT("Button"),TEXT("Ýptal"),BS_DEFPUSHBUTTON | WS_VISIBLE | WS_CHILD ,600,250,100,50,hWnd,(HMENU) 9002,0,0);
   // Buton Çiz "Ýptal" adýnda "Button" sýnýfýnda , WS_CHILD olarak "hWnd" penceresine çiziliyor ve { (HMENU)9002 } olarak kimlik veriliyor


   CreateWindow(TEXT("Edit"),TEXT(""),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_BORDER ,150,100,200,25,hWnd,(HMENU) 9003,0,0);
   // Editbox çiz "Edit" sýnýfýnda içerik boþ , WS_CHILD olarak "hWnd" penceresine çiziliyor ve { (HMENU)9003 } olarak kimlik veriliyor

   CreateWindow(TEXT("Edit"),TEXT("Ýsim : "),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_DISABLED,50,100,100,25,hWnd,0,0,0);
   // Editbox çiz "Edit" sýnýfýnda içerikte "Ýsim : " yazacak , WS_CHILD olarak "hWnd" penceresine çiziliyor ve kimlik verilmiyor


   CreateWindow(TEXT("Edit"),TEXT(""),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_BORDER ,150,150,200,25,hWnd,(HMENU) 9004,0,0);
   // Editbox çiz "Edit" sýnýfýnda içerik boþ , WS_CHILD olarak "hWnd" penceresine çiziliyor ve { (HMENU)9004 } olarak kimlik veriliyor

   CreateWindow(TEXT("Edit"),TEXT("Soyisim : "),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_DISABLED ,50,150,100,25,hWnd,0,0,0);
   // Editbox çiz "Edit" sýnýfýnda içerikte "Soyisim : " yazacak , WS_CHILD olarak "hWnd" penceresine çiziliyor ve kimlik verilmiyor


   CreateWindow(TEXT("Edit"),TEXT(""),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_BORDER ,150,200,200,25,hWnd,(HMENU) 9005,0,0);
   // Editbox çiz "Edit" sýnýfýnda içerik boþ , WS_CHILD olarak "hWnd" penceresine çiziliyor ve { (HMENU)9005 } olarak kimlik veriliyor

   CreateWindow(TEXT("Edit"),TEXT("Telefon : "),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_DISABLED ,50,200,100,25,hWnd,0,0,0);
   // Editbox çiz "Edit" sýnýfýnda içerikte "Telefon : " yazacak , WS_CHILD olarak "hWnd" penceresine çiziliyor ve kimlik verilmiyor


   CreateWindow(TEXT("Edit"),TEXT(""),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_BORDER  ,150,250,200,100,hWnd,(HMENU) 9006,0,0);
   // Editbox çiz "Edit" sýnýfýnda içerik boþ , WS_CHILD olarak "hWnd" penceresine çiziliyor ve { (HMENU)9006 } olarak kimlik veriliyor

   CreateWindow(TEXT("Edit"),TEXT("Adres : "),BS_TEXT | WS_VISIBLE | WS_CHILD | WS_DISABLED ,50,250,100,25,hWnd,0,0,0);
   // Editbox çiz "Edit" sýnýfýnda içerikte "Adres : " yazacak , WS_CHILD olarak "hWnd" penceresine çiziliyor ve kimlik verilmiyor


   if (!hWnd)
   {
      return FALSE; // Vstudio oluþturdu "hWnd" penceresini çizemezse porgram kapanacak..
   }

   


   ShowWindow(hWnd, nCmdShow); // "hWnd" penceresini göster
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

void sqlbaglan(HWND); // sql baðlantýsý için yazdýðýmýz fonksiyonun öntanýmý..

/*  
	Vstudio oluþturdu "WndProc()" fonksiyonu 
	"WNDCLASSEX" sýnýfýnda "wcex.lpfnWndProc" parametresine gösterildi
	"MyRegisterClass()" fonksiyonu yukarýda açýklamasý ile mevcut.
*/
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	int wmId, wmEvent; 
	// wmId olayý gerçekleþtiren pencere veya componentlerin kimliði
	// wmEvent component in oluþturduðu olay
	
	PAINTSTRUCT ps;
	HDC hdc;

	char msg[100]; //char* uzunluðu belli olmayaný kabul etmez


	switch (message) // message deðiþkeni pencereden dönen mesajý temsil eder
	{
	case WM_COMMAND: // pencere olayý : WM_COMMAND pencereye veya içeriðine ait komutun geldiði anlamýna gelir
		wmId    = LOWORD(wParam); // 16 bitlik wParam deðiþkeni ilk 8 biti kimlik bilgisi taþýr , wmId e alýnýyor
		wmEvent = HIWORD(wParam); // 16 bitlik wParam deðiþkeni son 8 biti olay bilgisi taþýr , wmEvent e alýnýyor
		// Parse the menu selections:


		switch (wmId) // kimlik kimin sorusu soruluyor..
		{
		
		case 9001: // (HMENU)9001 : bu "Tamam" adýný verdiðimiz buton

			//GetWindowText(GetDlgItem(hWnd,9003),(LPWSTR)msg,100);
			//GetDlgItemText(hWnd,9003,(LPWSTR)msg,100);
			//MessageBox(hWnd,(LPCWSTR)msg,L"Mesaj : ",0);

			sqlbaglan(hWnd); // sqlbaglan() fonksiyonunu çalýþtýrýr.

			break;

		case 9002: // (HMENU)9002 : bu "Ýptal" adýný verdiðimiz buton
			DestroyWindow(hWnd); // pencereyi kapatýr..
			break;

		case IDM_ABOUT: // Vstudio oluþturdu gizlediðimiz pencereye ait komutu çaðýrýyor
			DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About); // Hakkýnda penceresini çaðýrýr.
			break;
		case IDM_EXIT:  // Vstudio oluþturdu gizlediðimiz pencereye ait komutu çaðýrýyor
			DestroyWindow(hWnd);
			break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam); // Vstudio oluþturdu fonksiyon yenilensin diye prosesi tekrar oluþturuyor.
		}
		break;
	case WM_PAINT: // pencere olayý : WM_PAINT pencere çiziirken iþlenecek komutlarý yazmak için yakalanýr
		hdc = BeginPaint(hWnd, &ps); // pencere çizilmeye baþlar

		// BURAYA : Eklemek istediðiniz kodlar buraya...
		// TODO: Add any drawing code here...

		EndPaint(hWnd, &ps); // pencere çizimi bitti
		break;
	case WM_DESTROY: // pencere olayý : WM_DESTROY pencere kapanma aþamasýnda iken iþlenecek komutlar
		PostQuitMessage(0); // çýkýþ mesajý gönder..
		break;
	default:
		return DefWindowProc(hWnd, message, wParam, lParam); 
	}
	return 0;
}

/* 
	Bu kodlar Visual Studio tarafýndan otomatik oluþtu..

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
	Bu kodlar Visual Studio tarafýndan otomatik oluþtu..

	<< Buraya Kadar
--------------------------------------------------------------------------------------
	*/

void sqlbaglan(HWND hdlg)
{

	// SQLHENV henv; SQLHDBC hdbc; SQLHSTMT hstmt;    <-- bunu kabul etmedi.!!	
	SQLHANDLE henv; SQLHANDLE hdbc; SQLHANDLE hstmt;
	// Environment , DB Connection , STMT oluþturuluyor
	

	SQLWCHAR* sdata = (SQLWCHAR*)L"Driver=SQL Server;SERVER=DESKTOP-LI6D0Q5\\SQLEXPRESS;DATABASE=deneme;UID=sa;PWD=102030-g;";
	// baðlantý þemasý "sdata" ya yazýlýyor

	SQLRETURN sr1,sr2,sr3;
	// komutlar için sonuç deðiþkenleri

	SQLAllocHandle(SQL_HANDLE_ENV,SQL_NULL_HANDLE,&henv); // Environment yerleþtiriliyor
	SQLSetEnvAttr(henv,SQL_ATTR_ODBC_VERSION,(SQLPOINTER)SQL_OV_ODBC3,0); // ODBC versiyon belirleniyor
	SQLAllocHandle(SQL_HANDLE_DBC,henv,&hdbc); // Enviroment DB Connection ile iliþtiriliyor

	SQLSetConnectAttr(hdbc,SQL_LOGIN_TIMEOUT,(SQLPOINTER)5,0); // Baðlantý zaman aþýmý belirleniyor

	SQLWCHAR retconstring[1024]; // baðlantý hakkýnda geribildirim için deðiþken tanýmlanýyor

	RETCODE conn = SQLDriverConnect( // Sql baðlantý kuruluyor
	hdbc, // DB Connection nesnesi
    NULL, // baðlý çalýþtýðý pencere
	sdata, // baðlantý þemasý belirleniyor
    SQL_NTS, // baðlantý þemasý uzunluðu - NotTextSize
    retconstring, // baðlantý hakkýnda geribildirim
    1024,// geribildirim uzunluðu
    NULL, //
    SQL_DRIVER_NOPROMPT // baðlantý için ODBC ayar penceresini göster
	);

	
	if(conn == SQL_SUCCESS || conn == SQL_SUCCESS_WITH_INFO) // SUCCESS tamam , SUCCESS_INFO ayrýntýlý tamam ; sqldriverconnect() fonksiyonu baþarýlý ise
	{
		//MessageBox(hdlg,L"Baðlandý",L"",0);
		printf("Baðlandý : %d \n",conn); 

		SQLCHAR okunanlar[240]; // okunan veriler için deðiþken tanýmlanýyor
		SQLINTEGER ptrokunanlar; // okunan veriler için numaralý katar deðiþkeni tanýmlanýyor (ptr on string muhabbeti)

		SQLWCHAR* komut = (SQLWCHAR*)L"Select  * From tablo"; // sql komutu tanýmlanýyor

		if(SQL_SUCCESS == SQLAllocHandle(SQL_HANDLE_STMT,hdbc,&hstmt)) // STMT DB Connect e gösterililyor
		{
			if(SQL_SUCCESS == SQLExecDirect(hstmt,komut,SQL_NTS)) // Sql komutu uygulanýyor
			{
				printf(" Okunanlar \n");
				while(SQL_SUCCESS == SQLFetch(hstmt)) // Sýrayla veri çekiliyor
				{
					SQLGetData( // veri çek fonksiyonu
						hstmt, // STMT nesnesi
						1, // Sütun numarasý
						SQL_CHAR, // veri tipi
						okunanlar, // okunan veri
						240, // okunan veri uzunluðu
						&ptrokunanlar // okunan veri numaralý katarý
						);

					printf(" - %s",okunanlar); // okunan veri komut penceresinde

					// ayný bilgiler aþaðýdaki benzer komutlar içinde ayný

					SQLGetData(
						hstmt,
						2,
						SQL_CHAR,
						okunanlar,
						240,
						&ptrokunanlar
						);

					printf(" - %s",okunanlar);

					SetDlgItemTextA(hdlg,9003,(LPCSTR)okunanlar); // SetDlgItemTextW : unicode utf-8 için, program utf-8 formatýnda fakat
					// sql server ANSI kodlamaya ayarlý olduðu için ANSI kodlama tipindeki veri için SetDlgTextA fonksiyonunu kullanýyoruz

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
			} else { printf("Komut Hatasý! \n"); } 
		} else { printf("HSTMT Hatasý! \n"); }

	}
	else
	{

		//MessageBox(hdlg,L"Baðlanamadý",L"",0);
		printf("Baðlanamadý : %d \n",conn);

	}
	SQLFreeHandle(SQL_HANDLE_DBC,hdbc); // DB Connection sil
	SQLFreeHandle(SQL_HANDLE_ENV,henv); // Enivronment sil
	SQLFreeHandle(SQL_HANDLE_STMT,hstmt); // STMT sil
	SQLFreeConnect(hdbc); // baðlantýyý kapat
}
