


using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;


namespace BakkalUygulamasi.webui
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
         //Authentication iþlemleri ve cookie (çerez) ekleme
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Hesap/Login"; //Giriþ sayfasýnýn yol bilgisi
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(30); //Cookie'nin tarayýcý üzerinde canlý kalacaðý süre bilgisi
                         options.Cookie = new CookieBuilder  //Cookie oluþturma
                        {
                              HttpOnly = true, // cookie yalnýzca bir Http talebi ile elde edilir
                             Name=".BakkalUygulamasi.Cookie"  //tarayýcýda oluþturulacak cookie'nin ismi
                          };
                         });
           
          

            services.AddControllersWithViews();
            
           
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
         
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
             
                app.UseHsts();
            }
          
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
             app.UseAuthorization();

          //web uygulamasýndaki sayfa yönlendiricilerimiz
                app.UseEndpoints(endpoints =>
            {


        endpoints.MapControllerRoute(
            name: "fatura",
            pattern: "/personel/fatura/yazdir",
            defaults: new { controller = "Personel", action = "Fatura" }
        );

                endpoints.MapControllerRoute(
           name: "personelmarkaguncelle",
           pattern: "personel/marka/guncelle/{MarkaId?}",
           defaults: new { controller = "Personel", action = "MarkaGuncelle" }
         );
                endpoints.MapControllerRoute(
           name: "personelmarkalistesi",
           pattern: "personel/marka/liste",
           defaults: new { controller = "Personel", action = "MarkaListesi" }
         );
        
                endpoints.MapControllerRoute(
           name: "personelstokguncelle",
           pattern: "personel/stok/guncelle/{stokId?}",
           defaults: new { controller = "Personel", action = "StokGuncelle" }
         );
        
                endpoints.MapControllerRoute(
           name: "personelstoklistesi",
           pattern: "personel/stok/liste",
           defaults: new { controller = "Personel", action = "StokListesi" }
         );
                endpoints.MapControllerRoute(
           name: "personelurunguncelle",
           pattern: "personel/urun/guncelle/{urunId?}",
           defaults: new { controller = "Personel", action = "UrunGuncelle" }
         );
     
       
                endpoints.MapControllerRoute(
              name: "personelurunlistesi",
              pattern: "personel/urun/liste",
              defaults: new { controller = "Personel", action = "UrunListesi" }
            );

                endpoints.MapControllerRoute(
               name: "personelkategorilistesi",
               pattern: "personel/kategori/liste",
               defaults: new { controller = "Personel", action = "KategoriListesi" }
             );

                 endpoints.MapControllerRoute(
                name: "personelkategoriguncelle",
                pattern: "personel/kategori/guncelle/{KategoriId?}",
                defaults: new { controller="Personel", action="KategoriGuncelle"}
              );
                endpoints.MapControllerRoute(
                name: "satismaddeleriliste",
                pattern: "personel/satismaddeleri/liste",
                defaults: new { controller = "Personel", action = "SatisMaddeleriListesi" }
          );
                  endpoints.MapControllerRoute(
                name: "satismaddeleriguncelle",
                pattern: "personel/satismaddeleri/guncelle/{smId?}",
                defaults: new { controller = "Personel", action = "SatisMaddeleriGuncelle" }
          );

                endpoints.MapControllerRoute(
                name: "satismaddeleriekle",
                pattern: "personel/satismaddeleri/ekle",
                defaults: new { controller = "Personel", action = "SatisMaddeleriEkle" }
          );
                    endpoints.MapControllerRoute(
              name: "satisliste",
              pattern: "personel/satis/liste",
              defaults: new { controller = "Personel", action = "SatisListesi" }
         );
                    endpoints.MapControllerRoute(
              name: "satisguncelle",
              pattern: "personel/satis/guncelle/{satisId?}",
              defaults: new { controller = "Personel", action = "SatisGuncelle" }
         );
                endpoints.MapControllerRoute(
                name: "satisekle",
                pattern: "personel/satis/ekle",
                defaults: new { controller = "Personel", action = "SatisEkle" }
           );
                endpoints.MapControllerRoute(
            name: "rollistesi",
            pattern: "hesap/rol/liste",
            defaults: new { controller = "Hesap", action = "RolListesi" }
        );
                endpoints.MapControllerRoute(
            name: "rolguncelle",
            pattern: "hesap/rol/guncelle/{rolId?}",
            defaults: new { controller = "Hesap", action = "RolGuncelle" }
        );
                endpoints.MapControllerRoute(
                name: "rolekle",
                pattern: "hesap/rol/ekle",
                defaults: new { controller = "Hesap", action = "RolEkle" }
            );
                endpoints.MapControllerRoute(
                name: "kullanicilistesi",
                pattern: "hesap/kullanýcý/liste",
                defaults: new { controller = "Hesap", action = "KullaniciListesi" }
            );
                endpoints.MapControllerRoute(
                name: "kullaniciguncelle",
                pattern: "hesap/kullanýcý/guncelle/{kullaniciId?}",
                defaults: new { controller = "Hesap", action = "KullaniciGuncelle" }
            );
                endpoints.MapControllerRoute(
                name: "kullaniciekle",
                pattern: "hesap/kullanýcý/ekle",
                defaults: new { controller = "Hesap", action = "KullaniciEkle" }
            );
                endpoints.MapControllerRoute(
                name: "personelmarkaekle",
                pattern: "personel/marka/ekle",
                defaults: new { controller = "Personel", action = "MarkaEkle" }
            );
            
              
                    endpoints.MapControllerRoute(
                name: "personelkategoriekle",
                pattern: "personel/stok/ekle",
                defaults: new { controller = "Personel", action = "StokEkle" }
            );
                endpoints.MapControllerRoute(
                name: "personelkategoriekle",
                pattern: "personel/urun/ekle",
                defaults: new { controller = "Personel", action = "UrunEkle" }
            );
            endpoints.MapControllerRoute(
            name: "personelkategoriekle",
            pattern: "personel/kategori/ekle",
            defaults: new { controller = "Personel", action = "KategoriEkle" }
        );

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
        }
    }
}
