

using BakkalUygulamasi.entity.Data;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BakkalUygulamasi.webui.Controllers
{
    
    public class HesapController:Controller

    {
       
        BakkalDbContext context = new BakkalDbContext();
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        //Authentication işlemleri için geliştirmiş olduğumuz Login isimli post http istek türünde controller methodumuz.Authentication ile kullanıcılar için kimlik 
        //doğrulama işlemleri başarılı bir şekilde yürütülmektedir.
        [HttpPost]
        public async Task<IActionResult> Login(Kullanici kullanici)
        {
            //Web sayfasının login bölümünde giriş bilgilerini giren kullanıcıların kimlik doğrulama işlemlerinin yapılması 
            var user = context.Kullanicis.FirstOrDefault(x => x.KKullaniciadi == kullanici.KKullaniciadi && x.KParola == kullanici.KParola);

            //Kullanıcı veri tabanında kayıtlı ise authorization işlemi başarıyla yürütülür ve kullanıcının authentication yapmış olması sağlanır.
            if (user != null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,kullanici.KKullaniciadi)
                };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                //Kimlik doğrulaması başarıyla gerçekleşmiş kullanıcı, home controller altında bulunan Index methoduna yöneltilir.
                return Redirect("/Home/Index/" + user.KullaniciId);
             
            }

            //Eğer giriş bilgileri girilen kullanıcı veri tabanında bulunamamışsa Authentication işlemi başarısız sonuçlanır ve kullanıcı login sayfasına tekrardan yönlendirilir.
            else
            {
                ViewBag.Mesaj=("Geçersiz kullanıcı adı veya şifre");
                return View();
            }
            
       //Sistemden çıkış için controller methodu
        }
        [HttpGet]
        public async Task< IActionResult> Logout()
        {
            //Cookieleri geçersiz kılıyoruz ve böylelikle kullanıcının giriş bilgileri sistemden siliniyor.
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
            public IActionResult KullaniciEkle()
            {
                return View();
            }


        //Sisteme kullanıcı kayıt aşaması
        [HttpPost]
        public IActionResult KullaniciEkle(Kullanici user)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz parametre bilgilerini kullanarak kullanıcı ekleme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw("exec proc_kullanici_insert @k_kullaniciadi={0},@k_parola={1},@k_adi={2},@k_soyadi={3},@k_eposta={4},@k_telefon={5},@k_durum={6},@rol_id={7}",  user.KKullaniciadi, user.KParola, user.KAdi, user.KSoyadi, user.KEposta, user.KTelefon, user.KDurum, user.RolId);
            return Redirect("/Hesap/KullaniciListesi");
        }

        //Veri tabanından kullanıcı silmek için yazmış olduğumuz bir controller methodur. silinecek olan kullanıcıya ait kullanıcı id numrasını parametre olarak alır
        public IActionResult KullaniciSil(int kullaniciId)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, seçmiş olduğumuz kullanıcının id bilgisini kullanarak veri tabanından kullanıcı silme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw($"proc_kullanici_delete {kullaniciId}");
            return Redirect("/Hesap/KullaniciListesi");
        }


        public IActionResult KullaniciListesi()
        {
            List<Kullanici> model = new List<Kullanici>();
            BakkalDbContext context = new BakkalDbContext();
            // veri tabanında oluşturmuş olduğumuz stored procedure'lerden bize kullanıcıların listesini dönecek olan procedürü çağırırız
            model = context.Kullanicis.FromSqlRaw<Kullanici>($"exec proc_kullanici_list").ToList();
            //Views'da bulunan KullaniciListesi.cshtml dosyasına model bilgisi atılır.
            return View(model);
        }

        //Kullanıcı bilgilerini güncellemek için yazmış olduğumuz bir get http türlü controller methodur
        [HttpGet]
        public IActionResult KullaniciGuncelle(int kullaniciId)
        {
            BakkalDbContext context = new BakkalDbContext();
            Kullanici user = new Kullanici();
            // veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz id bilgisine göre bize veri tabanında bulunan ilgili kayıdı getiren procedürü çağırırız
            user = context.Kullanicis.FromSqlRaw($"exec proc_kullanici_get_by_id {kullaniciId}").AsEnumerable().FirstOrDefault();
            if (user == null)    //eğer herhangi bir kullanıcı kaydı bulunamamışsa sayfa bulunamadı döndürülür
            {
                return NotFound();
            }
            return View(user);
        }

        //Kullanıcı bilgilerini güncellemek için yazmış olduğumuz bir post http türlü controller methodur
        [HttpPost]
        public IActionResult KullaniciGuncelle(Kullanici user)
        {
            BakkalDbContext context = new BakkalDbContext();
            //veri tabanında oluşturmuş olduğumuz stored procedure'lerden, vermiş olduğumuz parametre bilgilerini kullanarak kullanıcı bilgilerinde güncelleme işlemini yapacak olan procedürü çağırırız
            var data = context.Database.ExecuteSqlRaw("exec proc_kullanici_update @kullanici_id={0}, @k_kullaniciadi={1},@k_parola={2},@k_adi={3},@k_soyadi={4},@k_eposta={5},@k_telefon={6},@k_durum={7},@rol_id={8}",user.KullaniciId,user.KKullaniciadi,user.KParola,user.KAdi,user.KSoyadi,user.KEposta,user.KTelefon,user.KDurum,user.RolId);
            return Redirect("/Hesap/KullaniciListesi");
        }
        [HttpGet]
        public IActionResult RolEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RolEkle(Rol role)
        {
            BakkalDbContext context = new BakkalDbContext();
            var prm1 = new SqlParameter("@r_adi", role.RAdi);
            var data = context.Database.ExecuteSqlRaw("exec proc_rol_insert @r_adi={0}", role.RAdi);
            return Redirect("/Hesap/RolListesi");
        }
        public IActionResult RolSil(int rolId)
        {
            BakkalDbContext context = new BakkalDbContext();
            var data = context.Database.ExecuteSqlRaw($"proc_rol_delete {rolId}");
            return Redirect("/Hesap/RolListesi");
        }
        public IActionResult RolListesi()
        {
            List<Rol> model = new List<Rol>();
            BakkalDbContext context = new BakkalDbContext();
            model = context.Rols.FromSqlRaw<Rol>($"exec proc_rol_list").ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult RolGuncelle(int rolId)
        {
            BakkalDbContext context = new BakkalDbContext();
            Rol role = new Rol();
            role = context.Rols.FromSqlRaw($"exec proc_rol_get_by_id {rolId}").AsEnumerable().FirstOrDefault();
            if (role == null)
            {
                return NotFound();
            }
            return View(role);
        }
        [HttpPost]
        public IActionResult RolGuncelle(Rol role)
        {
            BakkalDbContext context = new BakkalDbContext();
          
            var data = context.Database.ExecuteSqlRaw("exec proc_rol_update @rol_id={0}, @r_adi={1}",role.RolId,role.RAdi);
            return Redirect("/Hesap/RolListesi");
        }
    }
}
