	----Ders 1

	/Operasyonlar Veri �leti�im Katman�ndad�r. Class library Class'lar� i�erisinde bar�nd�ran K�t�phane, Dll Dosyas� ==> 
    //B�t�n Platformalr�n (Web, Mobil, Destkop) == Veri �leti�im Katman�na Yaz�rl�r.

    //Bir Kural Getirerek �rne�in �r�nleri Listeleyecek ama �u birimde �al���yor ise Listeyebilir. Yani �nsan kaynaklar� �r�nleri Listeleyemesin
    //Ama �retim Birimi �r�nleri listeyebilsin. Burada Bizim S�re�lerimiz ile ilgili kodlar olu�uyor bunada i� katman� deniliyor.

    //Temel Olarak �� Katman Vard�r.
    //Aray�z Katman�        ==> Textbox'lar, Label'lar, Gridler vs.
    //�� Katman� Katman�    ==> �� Katman� bizim i� kurallar�m�z� i�erir. �rne�in �nsan Kaynaklar� Data'lara Eri�ebilsin ama di�erleri eri�emessin gibi.
    //Veri �leti�im Katman� ==> Veriyi listeledi�imiz yerdir. Yani Veritaban�na kodu g�nderdi�imiz yerdir.

    //�steki katmanlar temel 3 katmanl� mimarilerdir.


    //Zamanla araya Servis odakl� mimariler geldi�inde, aralara bu katmanlarda koyulabildi�i i�in, Art�k o 3 katmanl� mimari �ok katmanl� mimari 
    //yani nLayer application ==! �ok katmanl� mimariler denir.
    //Aray�z katman� == M��teri Listeler G�r�nt�ler, Bilgileri Al�r vs.
    //�� Katman� M��terinin == o kurala uyup uymad���n� kontrol eder.
    //Veri �leti�im Katman� == Data access ise veritaban�na m��teri kay�t eder, Siler yada g�nceller.





	----Ders 2 
	//Bo� bir solotion a��l�r. Ders ==� 122
	//Class Library (.Net Framework)

	//Bir Aray�z Katman�, Bir Varl�k Katman�, Bir �� Katman�, Bir Veri�leti�im Katman�
	//Proje �smi (Northwind.Entites) �eklinde Olmal�.  ===Proje �smi.Katman ismi=== (Pascal Case)

	//ProductDal == Dal ==> Data Access Layer

	//DataAccess Katman�nda Entity Framework Eklemek ��in "Northwind.DataAccess" �zerine Sa� T�klay�p "Manage Nuget Packages" ��ersinden "Browse" Sekmesinden EntityFrameWork'den Se�memiz Gerekir.
	//Sonra Alt�ndan Using Diyerek Kod ��erinde Tan�mlanmas� yap�l�r.
	//Sonras�nda Northwind.WebFormsUI �zerinde Add diyip Sonras�nda Referans b�l�m�nden Project ��erisinde Enties'i Eklememiz Gerekir.

	----Ders 3
	//Yaz�l� Geli�tirme S�re�leri Solid Prensibindeki O Harfi ==> Open Closed Principle ==! Bir uygulamaya yeni bir �zellik eklendi�inde Mevcutta olan kodlara dokunulmaz, Conmfigrasyon hari�.
	//Yaz�l� Geli�tirme S�re�leri Solid Prensibindeki D Harfi ==> Bir Katman Di�er Katman� New'leyemez yani instance �retemez. Ba��ml� olursunuz, Ve Ba��ml�l��� ortadan kald�r�n demek istiyor.
	//Code Smell Refactoring ��lemi kodlar�n d�zenlenmesi anlam�na gelir.

	----Ders 4
	//Dependency Containe == Form1'de Newleme Yapmay�z

	----Ders 5
	//129. Dersi Muhakkak bir daha izle


	----Ders 6
	//Category G�re Search Etme
	//Entities ==> Concrete ==>> Category.cs : IEntity �mplemente Etmeyi Unutma .... Generic K�s�tlamalar ��in Gereklidir.
	//Entities ==> Concrete ==>> Category.cs Veritaban�na Kar��l�k Gelecek Sutunlar� Eklemeyi Unutma
	//DataAccess ==> Abstract ==> ICategoryDal.cs : IEntityRepository Imlemente Edilecek
	//DataAccess ==> Concrete ==> EntityFramework ==> NorthwindContext.cs >>>>>>>>>>Public DBSet<Category> Categories {get; set;} Entity Framework Mapping ��lemi
	//DataAccess ==> Concrete ==> EntityFramework  ==> EfCategoryDal.cs : EfEntityRepositoryBase yada �nherit Edilecek
	/*************�nterface'ler �mplementasyon , Abstract Class'lar �nherit(�nheritasyon) Edilir.*************/
	//Business ==> Abstract ==> ICategoryServices.cs (interface) >>>>>>>>> �� Katman� Operasyonunu Tan�mla
	//Business ==> Concrete ==> ICategoryManager.cs : ICategoryService �mplemente Et
	//Business ==> Concrete ==> ICategoryManager.cs : Constructors'den ICategoryDal Field'�n� Referans Ver.


	----Ders 7
	//Defansing Programing == Null De�erli kontrol�
	//Fori key hatas� == bak�lacak
	//Business Katman�na Entity FrameWork Eklenmez SAdece Kod B�t�nli�i i�in Ekledik...
	//Hata Y�netimi sadece Aray�zde g�stermek i�in kullan�l�r.
	//Kurunmsal Mimarilerde Hata Y�netimi Business Katman�na Yaz�l�r. == Sadece G�stermek i�in aray�ze koyulur.
	//Bu prensip Solid'den Gelir.

	----Ders 8 
	//Validation
	//Aray�z katman�nda input giri�lerine s�n�rlamalar koyma i�lemine validation denir. �� katman�na yaz�l�r. �rne�in �sminin 10 harfli olucak gibi.
	//Kurallar ==> fluentValidation arac� ile yap�l�r.
	//Business katman�na bu kurallar yaz�l�r.
	//Ctor Constructor ifade eder // Tab Tab :) == (Visual Studio Snippet) diye bir kavramd�r.
	//Fluent Validation i�in Fluent Validation D�k�mantasyonuna Bak�lacak



	
