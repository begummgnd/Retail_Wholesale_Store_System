# Retail_Wholesale_Store_System
Asp .Net Core’da projemi gelistirme surecimde, oncesinde SQL Server'da hazirlanmis olan BakkalDb isimli veri tabanininin projenin kod tarafina aktarim islemleri, scaffolding ile basariyla gerceklestirilmistir ve boylelikle BakkalDb veri tabanindaki tum entity ve DBContext icerikleri asagidaki komutlari Visual Studio’nun terminalinde uygulayaraktan aktarim islemi basariyla gerceklestirilmistir.
Projenin BakkalUygulamasi.entity konumunda;
dotnet ef dbcontext scaffold "Data Source = DESKTOP-U89VVTM\MSSQLSERVER1; Initial Catalog =BakkalDb;Integrated Security=True;" "Microsoft.EntityFrameworkCore.SqlServer" --output-dir "Data" --context BakkalDbContext --startup-project BakkalUygulamasi.webui 
komutu calistirilir. Sonuc olarak veri tabanina ait olan tum entityler BakkalUygulamasi.entity konumundaki Data klasoru altina yerlestirilir.
Projenin calismasinda gorevli olan butun paketler BakkalUygulamasi.webui.csproj ve BakkalUygulamasi.entity.csproj dosyasi icerisinde bulunmaktadir.
Uygulamanin sayfalarinda gerceklestirilen islemler sonucunda veri tabaninda meydana gelen degisikliklerin tumu log tablolarinda triggerlar ile kaydedilmektedir. (ekleme, silme ve guncelleme islemleri)
Uygulama icerisinde gerceklestirilen tum veri tabani islemleri (ekleme, silme, guncelleme vb.) yalnizca stored procedurler kullanilarak gerceklestirilmistir. Proje icerinde kesinlikle herhangi bir sorgu bulunmamaktadir.
Veri tabani ile alakali dosyalarda yazmis oldugum triggerlar ve stored procedureler bulunmaktadir.(.mdf ve .ldf uzantili dosyalari)
Yazmis oldugum Stored Procedurler BakkalDb>Programmabilty>Stored Procedures konumunda yer almaktadir.
Yazmis oldugum Triggerlar BakkalDb>Tables>"tablo ismi">Triggers konumunda yer almaktadir.
 ######Web Application
