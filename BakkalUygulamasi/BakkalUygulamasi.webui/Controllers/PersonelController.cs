
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Data.SqlClient;

using Microsoft.EntityFrameworkCore;
using BakkalUygulamasi.entity.Data;

using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace BakkalUygulamasi.webui.Controllers
{
    [Authorize]
    public class PersonelController:Controller
    {

       //Kategori listesini döndüren controller methodudur
        public IActionResult KategoriListesi() 
        {
            List<Kategori> model = new List<Kategori>();
            BakkalDbContext context = new BakkalDbContext();
            // veri tabanında oluşturmuş olduğumuz stored procedure'lerden bize kategori listesini dönecek olan procedürü çağırırız
            model = context.Kategoris.FromSqlRaw<Kategori>($"exec proc_kategori_list").ToList();
            //Views'da bulunan KategoriListesi.cshtml dosyasına model bilgisi atılır.
            return View(model);
        }

        //Kategori bilgilerini güncellemek için yazmış olduğumuz bir get http türlü controller methodur
         [HttpGet]
        public IActionResult KategoriGuncelle(int KategoriId)
        {
            BakkalDbContext context = new BakkalDbContext();
            Kategori category=new Kategori();
            // veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz id bilgisine göre bize veri tabanında bulunan ilgili kayıdı getiren procedürü çağırırız
            category = context.Kategoris.FromSqlRaw($"exec proc_kategori_get_by_id {KategoriId}").AsEnumerable().FirstOrDefault();
            if (category == null)
            {
                return NotFound();
            }
            //Views'da bulunan KategoriListesi.cshtml dosyasına procedürden döndürülen kayıdın bilgisi atılır.
            return View(category);
        }

        //Kategori bilgilerini güncellemek için yazmış olduğumuz bir post http türlü controller methodur
        [HttpPost]
        public IActionResult KategoriGuncelle(Kategori category)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz parametre bilgilerini kullanarak kategori bilgilerinde güncelleme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw("proc_kategori_update @kategori_id={0} ,@k_adi={1}",category.KategoriId,category.KAdi);
            //kullanıcıyı personel kategori listesi sayfasına yönlendirir
            return Redirect("/Personel/KategoriListesi");
        }

        //Veri tabanından kategori silmek için yazmış olduğumuz bir controller methodur. silinecek olan kategorinin id numrasını parametre olarak alır
        public IActionResult KategoriSil(int kategoriId)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, seçmiş olduğumuz kategorinin id bilgisini kullanarak veri tabanından kategori silme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw($"proc_kategori_delete {kategoriId}");
            return Redirect("/Personel/KategoriListesi");
        }

        //Kategori bilgileri eklemek için yazmış olduğumuz bir get http türlü controller methodur
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        //Kategori bilgileri eklemek için yazmış olduğumuz bir post http türlü controller methodur
        [HttpPost]
        public IActionResult KategoriEkle(Kategori category)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz parametre bilgilerini kullanarak kategori ekleme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw("exec proc_kategori_insert @k_adi= {0}",category.KAdi);
            return Redirect("/Personel/KategoriListesi");
        }

        //Marka bilgileri eklemek için yazmış olduğumuz bir get http türlü controller methodur
        [HttpGet]
        public IActionResult MarkaEkle()
        {
            return View();
        }
        //Marka bilgileri eklemek için yazmış olduğumuz bir post http türlü controller methodur
        [HttpPost]
        public IActionResult MarkaEkle(Marka brand)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz parametre bilgilerini kullanarak marka ekleme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw("exec proc_marka_insert @m_adi={0}",brand.MAdi);
            return Redirect("/Personel/MarkaListesi");
        }


        //Veri tabanından marka silmek için yazmış olduğumuz bir controller methodur. silinecek olan markanın id numrasını parametre olarak alır
        public IActionResult MarkaSil(int markaId)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, seçmiş olduğumuz stoğun id bilgisini kullanarak veri tabanından stok silme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw($"proc_marka_delete {markaId}");
            return Redirect("/Personel/MarkaListesi");
        }

        //Marka listesini döndüren controller methodudur
        public IActionResult MarkaListesi()
        {
            List<Marka> model = new List<Marka>();
            BakkalDbContext context = new BakkalDbContext();
            // veri tabanında oluşturmuş olduğumuz stored procedure'lerden bize marka listesini dönecek olan procedürü çağırırız
            model = context.Markas.FromSqlRaw<Marka>($"exec proc_marka_list").ToList();
            //Views'da bulunan MarkaListesi.cshtml dosyasına model bilgisi atılır.
            return View(model);
        }

        //Marka bilgilerini güncellemek için yazmış olduğumuz bir get http türlü controller methodur
        [HttpGet]
        public IActionResult MarkaGuncelle(int MarkaId)
        {
            BakkalDbContext context = new BakkalDbContext();
            Marka brand = new Marka();
            // veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz id bilgisine göre bize veri tabanında bulunan ilgili kayıdı getiren procedürü çağırırız
            brand = context.Markas.FromSqlRaw($"exec proc_marka_get_by_id {MarkaId}").AsEnumerable().FirstOrDefault();
            if (brand == null)
            {
                return NotFound();
            }
            return View(brand);
        }
        //Marka bilgilerini güncellemek için yazmış olduğumuz bir post http türlü controller methodur
        [HttpPost]
        public IActionResult MarkaGuncelle(Marka brand)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz parametre bilgilerini kullanarak marka bilgilerinde güncelleme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw("proc_marka_update @marka_id={0}, @m_adi={1}",brand.MarkaId,brand.MAdi);
            return Redirect("/Personel/MarkaListesi");
        }

        //Stok bilgileri eklemek için yazmış olduğumuz bir get http türlü controller methodur
        [HttpGet]
        public IActionResult StokEkle()
        {
            return View();
        }
        //Stok bilgileri eklemek için yazmış olduğumuz bir post http türlü controller methodur
        [HttpPost]
        public IActionResult StokEkle(Stok stock)
        {
            BakkalDbContext context = new BakkalDbContext();

            var data = context.Database.ExecuteSqlRaw("exec proc_stok_insert @s_adedi= {0}, @s_giris_tarihi = {1}, @s_bitis_tarihi={2}",stock.SAdedi,stock.SGirisTarihi,stock.SBitisTarihi);
            return Redirect("/Personel/StokListesi");
        }

        //Veri tabanından stok silmek için yazmış olduğumuz bir controller methodur. silinecek olan stok id numrasını parametre olarak alır
        public IActionResult StokSil(int stokId)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, seçmiş olduğumuz stoğun id bilgisini kullanarak veri tabanından stok silme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw($"proc_stok_delete {stokId}");
            return Redirect("/Personel/StokListesi");
        }
        public IActionResult StokListesi()
        {
            List<Stok> model = new List<Stok>();
            BakkalDbContext context = new BakkalDbContext();
            // veri tabanında oluşturmuş olduğumuz stored procedure'lerden bize stok listesini dönecek olan procedürü çağırırız
            model = context.Stoks.FromSqlRaw<Stok>($"exec proc_stok_list").ToList();
            //Views'da bulunan StokListesi.cshtml dosyasına model bilgisi atılır.
            return View(model);
        }

        //Stok bilgilerini güncellemek için yazmış olduğumuz bir get http türlü controller methodur
        [HttpGet]
        public IActionResult StokGuncelle(int stokId)
        {
            BakkalDbContext context = new BakkalDbContext();
            Stok stock = new Stok();
            // veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz id bilgisine göre bize veri tabanında bulunan ilgili kayıdı getiren procedürü çağırırız
            stock = context.Stoks.FromSqlRaw($"exec proc_stok_get_by_id {stokId}").AsEnumerable().FirstOrDefault();
            //eğer herhangi bir stok kaydı bulunamamışsa sayfa bulunamadı döndürülür
            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);
        }
        //Stok bilgilerini güncellemek için yazmış olduğumuz bir post http türlü controller methodur
        [HttpPost]
        public IActionResult StokGuncelle(Stok stock)
        {
            BakkalDbContext context = new BakkalDbContext();
      
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz parametre bilgilerini kullanarak stok bilgilerinde güncelleme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw("proc_stok_update @stok_id={0}, @s_adedi={1}, @s_giris_tarihi={2}, @s_bitis_tarihi={3}",stock.StokId,stock.SAdedi,stock.SGirisTarihi,stock.SBitisTarihi);
            return Redirect("/Personel/StokListesi");
        }
        [HttpGet]
        public IActionResult UrunEkle()
        {
            BakkalDbContext context = new BakkalDbContext();
            ViewBag.Markas = context.Markas.FromSqlRaw<Marka>($"exec proc_marka_list").ToList();
            ViewBag.Kategoris = context.Kategoris.FromSqlRaw<Kategori>($"exec proc_kategori_list").ToList();
            return View();
        }
        [HttpPost]
        public IActionResult UrunEkle(Urun product)
        {
            BakkalDbContext context = new BakkalDbContext();
           
            var data = context.Database.ExecuteSqlRaw("exec proc_urun_insert @u_adi= {0}, @u_barkodu = {1}, @u_uretim_tarihi = {2},@u_tuketim_tarihi={3}, @u_fiyat={4}, @u_agirlik={5},@u_rengi={6},@marka_id={7},@kategori_id={8}, @stok_id={9} ",product.UAdi,product.UBarkodu,product.UUretimTarihi,product.UTuketimTarihi,product.UFiyat,product.UAgirlik,product.URengi,product.MarkaId,product.KategoriId,product.StokId);
            return Redirect("/Personel/UrunListesi");
        }

        public IActionResult UrunSil(int urunId)
        {
            BakkalDbContext context = new BakkalDbContext();
            var data = context.Database.ExecuteSqlRaw($"proc_urun_delete {urunId}");
            return Redirect("/Personel/UrunListesi");
        }
        public IActionResult UrunListesi()
        {
            List<Urun> model = new List<Urun>();
            BakkalDbContext context = new BakkalDbContext();
            model = context.Uruns.FromSqlRaw<Urun>($"exec proc_urun_list").ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult UrunGuncelle(int urunId)
        {
            BakkalDbContext context = new BakkalDbContext();
            Urun product = new Urun();
            product= context.Uruns.FromSqlRaw($"exec proc_urun_get_by_id {urunId}").AsEnumerable().FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
          
            ViewBag.Markas = context.Markas.FromSqlRaw<Marka>($"exec proc_marka_list").ToList();
            ViewBag.Kategoris = context.Kategoris.FromSqlRaw<Kategori>($"exec proc_kategori_list").ToList();
            return View(product);
        }
        [HttpPost]
        public IActionResult UrunGuncelle(Urun product)
        {
            BakkalDbContext context = new BakkalDbContext();
          
         
            var data = context.Database.ExecuteSqlRaw("proc_urun_update @urun_id={0} ,@u_adi= {1}, @u_barkodu = {2}, @u_uretim_tarihi = {3},@u_tuketim_tarihi={4}, @u_fiyat={5}, @u_agirlik={6},@u_rengi={7},@marka_id={8},@kategori_id={9}, @stok_id={10}",product.UrunId, product.UAdi, product.UBarkodu, product.UUretimTarihi, product.UTuketimTarihi, product.UFiyat, product.UAgirlik, product.URengi, product.MarkaId, product.KategoriId, product.StokId);
            return Redirect("/Personel/UrunListesi");
        }
        [HttpGet]
        public IActionResult SatisEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SatisEkle(Sati sales)
        { 
            BakkalDbContext context = new BakkalDbContext();
          
            var data = context.Database.ExecuteSqlRaw("exec proc_satis_insert @s_tarih= {0}, @s_durum= {1}, @kullanici_id = {2}",sales.STarih,sales.SDurum,sales.KullaniciId);
            return Redirect("/Personel/SatisListesi");
    }
        public IActionResult SatisSil(int satisId)
        {
            BakkalDbContext context = new BakkalDbContext();
            var data = context.Database.ExecuteSqlRaw($"proc_satis_delete {satisId}");
            return Redirect("/Personel/SatisListesi");
        }
        public IActionResult SatisListesi()
        {
            List<Sati> model = new List<Sati>();
            BakkalDbContext context = new BakkalDbContext();
            model = context.Satis.FromSqlRaw<Sati>($"exec proc_satis_list").ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult SatisGuncelle(int satisId)
        {
            BakkalDbContext context = new BakkalDbContext();
            Sati sales = new Sati();
            sales = context.Satis.FromSqlRaw($"exec proc_satis_get_by_id {satisId}").AsEnumerable().FirstOrDefault();
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost]
        public IActionResult SatisGuncelle(Sati sales)
        {
            BakkalDbContext context = new BakkalDbContext();
           
            var data = context.Database.ExecuteSqlRaw("proc_satis_update @satis_id={0}, @s_tarih={1}, @s_durum={2}, @kullanici_id={3}",sales.SatisId,sales.STarih,sales.SDurum,sales.KullaniciId);
            return Redirect("/Personel/SatisListesi");
        }
        [HttpGet]
        public IActionResult SatisMaddeleriEkle()
        {
            BakkalDbContext context = new BakkalDbContext();
            ViewBag.Uruns = context.Uruns.FromSqlRaw<Urun>($"exec proc_urun_list").ToList();
            return View();
        }
        [HttpPost]
        public IActionResult SatisMaddeleriEkle(SatisMaddeleri items)
        {
            BakkalDbContext context = new BakkalDbContext();
           
            var data = context.Database.ExecuteSqlRaw("exec proc_satismaddeleri_insert @si_miktar= {0}, @si_fiyat= {1}, @si_iskonto = {2}, @satis_id={3},@urun_id={4} ",items.SiMiktar,items.SiFiyat,items.SiIskonto,items.SatisId,items.UrunId);
            return Redirect("/Personel/SatisMaddeleriListesi");
        }
        public IActionResult SatisMaddeleriSil(int smId)
        {
            BakkalDbContext context = new BakkalDbContext();
            var data = context.Database.ExecuteSqlRaw($"proc_satismaddeleri_delete {smId}");
            return Redirect("/Personel/SatisMaddeleriListesi");
        }
        public IActionResult SatisMaddeleriListesi()
        {
            List<SatisMaddeleri> model = new List<SatisMaddeleri>();
            BakkalDbContext context = new BakkalDbContext();
            model = context.SatisMaddeleris.FromSqlRaw<SatisMaddeleri>($"exec proc_satismaddeleri_list").ToList();
            return View(model);
        }
          [HttpGet]
       public IActionResult SatisMaddeleriGuncelle(int smId)
        {
            BakkalDbContext context = new BakkalDbContext();
            SatisMaddeleri sm = new SatisMaddeleri();
            sm = context.SatisMaddeleris.FromSqlRaw($"exec proc_satismaddeleri_get_by_id {smId}").AsEnumerable().FirstOrDefault();
            if (sm == null)
            {
                return NotFound();
            }
          
            ViewBag.Uruns = context.Uruns.FromSqlRaw<Urun>($"exec proc_urun_list").ToList();
            return View(sm);
       }
        [HttpPost]
        public IActionResult SatisMaddeleriGuncelle(SatisMaddeleri sm)
        {
            BakkalDbContext context = new BakkalDbContext();
        
            var data = context.Database.ExecuteSqlRaw("proc_satismaddeleri_update @sm_id={0}, @si_miktar={1}, @si_fiyat={2}, @si_iskonto={3}, @satis_id={4}, @urun_id={5}",sm.SmId,sm.SiMiktar,sm.SiFiyat,sm.SiIskonto,sm.SatisId,sm.UrunId);
            return Redirect("/Personel/SatisMaddeleriListesi");
        }


        public IActionResult Fatura(int UrunId, int SatisId, int SmId)
        {
           
            BakkalDbContext context = new BakkalDbContext();
            ViewBag.Uruns = context.Uruns.FromSqlRaw<Urun>($"exec proc_urun_list").ToList();
            ViewBag.Satis = context.Satis.FromSqlRaw<Sati>($"exec proc_satis_list").ToList();
            SatisMaddeleri sm = new SatisMaddeleri();
            sm = context.SatisMaddeleris.FromSqlRaw($"exec proc_satismaddeleri_get_by_id {SmId}").AsEnumerable().FirstOrDefault();
            return View(sm);

            }

        }


}
