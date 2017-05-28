
PUBLIC deneme	; fonksiyonu hariciye çýkartýyoruz 
				;bu fonksiyonu c++ da çaðýrabilmemiz için gerekli

.686	; x86 intel kodlamam tabaný .386, .586 da olabilir

.MODEL FLAT, C		; direktif flat (genelde flat kullanýlýr) modül olarak ise C ekledik
	option casemap:none		; büyük küçük harf duyarlýlýðý
	printf proto c :vararg		; C modülünün printf fonksiyonunu seçtik v(ararg argümaný oluyor)
	getchar proto c		; C modülünün getchar fonksiyonunu da seçtik

.DATA		; sabitler buraya
	message db 'Mesajýmýz',13,10,0		; message sabitine { 'Mesajýmýzý', satýr sonu, katar sonu, son } þeklinde yerleþtirdik

.CODE		; kodlar buraya

deneme PROC			; deneme adýnda bir fonksiyon oluþturduk
	invoke printf,OFFSET message		; printf fonksiyonunu çaðýrdýk ve argümana mesaj sabitinin adresini verdik
	invoke getchar		; getchar fonksiyonunu çaðýrdýk bu "Enter" tuþuna basmamýzý bekleycek
	ret			; deneme fonksiyonu için return
deneme ENDP			; deneme fonksiyonu sonu

END		; bitti

