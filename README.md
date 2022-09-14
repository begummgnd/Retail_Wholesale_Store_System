## Retail Wholesale Store System


Proje geliştirme süreci, Asp .Net Core ile gerçekleştirilmiştir. Veri tabanının sisteme entegresi SQL Server'da önceden hazırlanmış olan bir veri tabanı kullanılaraktan scaffolding ile gerceklestirilmistir.
Scaffolding ile veri tabanının sisteme entegresi için komut satırından gerçekleştirmiş olduğum kodlar;
Projenin BakkalUygulamasi.entity konumunda;
dotnet ef dbcontext scaffold "Data Source = DESKTOP-U89VVTM\MSSQLSERVER1; Initial Catalog =BakkalDb;Integrated Security=True;" "Microsoft.EntityFrameworkCore.SqlServer" --output-dir "Data" --context BakkalDbContext --startup-project BakkalUygulamasi.webui 
komutu calistirilir. 

Sonuc olarak veri tabanina ait olan tum entityler BakkalUygulamasi.entity konumundaki Data klasoru altina yerlestirilir.

Uygulamanin sayfalarinda gerceklestirilen islemler sonucunda veri tabaninda meydana gelen degisikliklerin tumu log tablolarinda triggerlar ile kaydedilmektedir. (ekleme, silme ve guncelleme islemleri)

Uygulama icerisinde gerceklestirilen tum veri tabani islemleri (ekleme, silme, guncelleme vb.) yalnizca Sql Server'da yazmış olduğum stored procedurler kullanilarak gerceklestirilmistir. Kod bölümünde stored procedurler ilgili komutlarla çağrılmıştır.

Veri tabanı ile alakali dosyalarda yazmis oldugum triggerlar ve stored procedureler yer almaktadır. (.mdf ve .ldf uzantili dosyalari)

Yazmis oldugum Stored Procedurler BakkalDb>Programmabilty>Stored Procedures konumunda yer almaktadir.
Yazmis oldugum Triggerlar BakkalDb>Tables>"tablo ismi">Triggers konumunda yer almaktadir.

Projenin calismasinda gorevli olan butun paketler BakkalUygulamasi.webui.csproj ve BakkalUygulamasi.entity.csproj dosyasi icerisinde bulunmaktadir.


#####  Web Application
