
PUBLIC deneme	; fonksiyonu hariciye ��kart�yoruz 
				;bu fonksiyonu c++ da �a��rabilmemiz i�in gerekli

.686	; x86 intel kodlamam taban� .386, .586 da olabilir

.MODEL FLAT, C		; direktif flat (genelde flat kullan�l�r) mod�l olarak ise C ekledik
	option casemap:none		; b�y�k k���k harf duyarl�l���
	printf proto c :vararg		; C mod�l�n�n printf fonksiyonunu se�tik v(ararg arg�man� oluyor)
	getchar proto c		; C mod�l�n�n getchar fonksiyonunu da se�tik

.DATA		; sabitler buraya
	message db 'Mesaj�m�z',13,10,0		; message sabitine { 'Mesaj�m�z�', sat�r sonu, katar sonu, son } �eklinde yerle�tirdik

.CODE		; kodlar buraya

deneme PROC			; deneme ad�nda bir fonksiyon olu�turduk
	invoke printf,OFFSET message		; printf fonksiyonunu �a��rd�k ve arg�mana mesaj sabitinin adresini verdik
	invoke getchar		; getchar fonksiyonunu �a��rd�k bu "Enter" tu�una basmam�z� bekleycek
	ret			; deneme fonksiyonu i�in return
deneme ENDP			; deneme fonksiyonu sonu

END		; bitti

