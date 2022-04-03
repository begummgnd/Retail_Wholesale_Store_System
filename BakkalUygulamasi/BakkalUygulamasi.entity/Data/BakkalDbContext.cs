using System;
using System.Threading;
using System.Threading.Tasks;
using EntityFrameworkCore.Triggers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class BakkalDbContext : DbContext
    
    {
        public BakkalDbContext()
        {
        }

        public BakkalDbContext(DbContextOptions<BakkalDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategori> Kategoris { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.SaveChangesWithTriggersAsync(base.SaveChangesAsync, acceptAllChangesOnSuccess: true, cancellationToken: cancellationToken);
        }
        public virtual DbSet<KategoriLogInsDel> KategoriLogInsDels { get; set; }
        public virtual DbSet<KategoriLogUp> KategoriLogUps { get; set; }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciLogInsDel> KullaniciLogInsDels { get; set; }
        public virtual DbSet<KullaniciLogUp> KullaniciLogUps { get; set; }
        public virtual DbSet<Kullaniciler> Kullanicilers { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<MarkaLogInsDel> MarkaLogInsDels { get; set; }
        public virtual DbSet<MarkaLogUp> MarkaLogUps { get; set; }
        public virtual DbSet<Markalar> Markalars { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolLogInsDel> RolLogInsDels { get; set; }
        public virtual DbSet<RolLogUp> RolLogUps { get; set; }
        public virtual DbSet<Roller> Rollers { get; set; }
        public virtual DbSet<Sati> Satis { get; set; }
        public virtual DbSet<SatisLogInsDel> SatisLogInsDels { get; set; }
        public virtual DbSet<SatisLogUp> SatisLogUps { get; set; }
        public virtual DbSet<SatisMaddeleri> SatisMaddeleris { get; set; }
        public virtual DbSet<Satisler> Satislers { get; set; }
        public virtual DbSet<Smaddeleri> Smaddeleris { get; set; }
        public virtual DbSet<SmaddeleriLogInsDel> SmaddeleriLogInsDels { get; set; }
        public virtual DbSet<SmaddeleriLogUp> SmaddeleriLogUps { get; set; }
        public virtual DbSet<Stok> Stoks { get; set; }
        public virtual DbSet<StokLogInsDel> StokLogInsDels { get; set; }
        public virtual DbSet<StokLogUp> StokLogUps { get; set; }
        public virtual DbSet<Stoklar> Stoklars { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<UrunLogInsDel> UrunLogInsDels { get; set; }
        public virtual DbSet<UrunLogUp> UrunLogUps { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source = DESKTOP-U89VVTM\\MSSQLSERVER1; Initial Catalog =BakkalDb;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.ToTable("kategori");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.KAdi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("k_adi");
            });

            modelBuilder.Entity<KategoriLogInsDel>(entity =>
            {
                entity.HasKey(e => e.KalidId);

                entity.ToTable("kategori_log_ins_del");

                entity.Property(e => e.KalidId).HasColumnName("kalid_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.IslemTuru)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("islem_turu");

                entity.Property(e => e.KAdi)
                    .HasMaxLength(255)
                    .HasColumnName("k_adi");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");
            });

            modelBuilder.Entity<KategoriLogUp>(entity =>
            {
                entity.HasKey(e => e.KaluIp);

                entity.ToTable("kategori_log_up");

                entity.Property(e => e.KaluIp).HasColumnName("kalu_ip");

                entity.Property(e => e.EskiKAdi)
                    .HasMaxLength(255)
                    .HasColumnName("eski_k_adi");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.YeniKAdi)
                    .HasMaxLength(255)
                    .HasColumnName("yeni_k_adi");
            });

            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => e.KategoriId);

                entity.ToTable("kategoriler");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.KAdi).HasColumnName("k_adi");
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.ToTable("kullanici");

                entity.HasIndex(e => e.KKullaniciadi, "UK_kullaniciadi_kullanici")
                    .IsUnique();

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.KAdi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("k_adi");

                entity.Property(e => e.KDurum).HasColumnName("k_durum");

                entity.Property(e => e.KEposta)
                    .HasMaxLength(255)
                    .HasColumnName("k_eposta");

                entity.Property(e => e.KKullaniciadi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("k_kullaniciadi");

                entity.Property(e => e.KParola)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("k_parola");

                entity.Property(e => e.KSoyadi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("k_soyadi");

                entity.Property(e => e.KTelefon)
                    .HasMaxLength(50)
                    .HasColumnName("k_telefon");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Kullanicis)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kullanici_rol");
            });

            modelBuilder.Entity<KullaniciLogInsDel>(entity =>
            {
                entity.HasKey(e => e.KlidIp);

                entity.ToTable("kullanici_log_ins_del");

                entity.Property(e => e.KlidIp).HasColumnName("klid_ip");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.IslemTuru)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("islem_turu");

                entity.Property(e => e.KAdi)
                    .HasMaxLength(50)
                    .HasColumnName("k_adi");

                entity.Property(e => e.KDurum).HasColumnName("k_durum");

                entity.Property(e => e.KEposta)
                    .HasMaxLength(255)
                    .HasColumnName("k_eposta");

                entity.Property(e => e.KKullaniciadi)
                    .HasMaxLength(255)
                    .HasColumnName("k_kullaniciadi");

                entity.Property(e => e.KParola)
                    .HasMaxLength(50)
                    .HasColumnName("k_parola");

                entity.Property(e => e.KSoyadi)
                    .HasMaxLength(50)
                    .HasColumnName("k_soyadi");

                entity.Property(e => e.KTelefon)
                    .HasMaxLength(50)
                    .HasColumnName("k_telefon");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");
            });

            modelBuilder.Entity<KullaniciLogUp>(entity =>
            {
                entity.HasKey(e => e.KluId);

                entity.ToTable("kullanici_log_up");

                entity.Property(e => e.KluId).HasColumnName("klu_id");

                entity.Property(e => e.EskiKAdi)
                    .HasMaxLength(50)
                    .HasColumnName("eski_k_adi");

                entity.Property(e => e.EskiKDurum).HasColumnName("eski_k_durum");

                entity.Property(e => e.EskiKEposta)
                    .HasMaxLength(255)
                    .HasColumnName("eski_k_eposta");

                entity.Property(e => e.EskiKKullaniciadi)
                    .HasMaxLength(255)
                    .HasColumnName("eski_k_kullaniciadi");

                entity.Property(e => e.EskiKParola)
                    .HasMaxLength(50)
                    .HasColumnName("eski_k_parola");

                entity.Property(e => e.EskiKSoyadi)
                    .HasMaxLength(50)
                    .HasColumnName("eski_k_soyadi");

                entity.Property(e => e.EskiKTelefon)
                    .HasMaxLength(50)
                    .HasColumnName("eski_k_telefon");

                entity.Property(e => e.EskiRolId).HasColumnName("eski_rol_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.YeniKAdi)
                    .HasMaxLength(50)
                    .HasColumnName("yeni_k_adi");

                entity.Property(e => e.YeniKDurum).HasColumnName("yeni_k_durum");

                entity.Property(e => e.YeniKEposta)
                    .HasMaxLength(255)
                    .HasColumnName("yeni_k_eposta");

                entity.Property(e => e.YeniKKullaniciadi)
                    .HasMaxLength(255)
                    .HasColumnName("yeni_k_kullaniciadi");

                entity.Property(e => e.YeniKParola)
                    .HasMaxLength(50)
                    .HasColumnName("yeni_k_parola");

                entity.Property(e => e.YeniKSoyadi)
                    .HasMaxLength(50)
                    .HasColumnName("yeni_k_soyadi");

                entity.Property(e => e.YeniKTelefon)
                    .HasMaxLength(50)
                    .HasColumnName("yeni_k_telefon");

                entity.Property(e => e.YeniRolId).HasColumnName("yeni_rol_id");
            });

            modelBuilder.Entity<Kullaniciler>(entity =>
            {
                entity.HasKey(e => e.KullaniciId);

                entity.ToTable("kullaniciler");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.KAdi).HasColumnName("k_adi");

                entity.Property(e => e.KDurum).HasColumnName("k_durum");

                entity.Property(e => e.KEposta).HasColumnName("k_eposta");

                entity.Property(e => e.KKullaniciadi).HasColumnName("k_kullaniciadi");

                entity.Property(e => e.KParola).HasColumnName("k_parola");

                entity.Property(e => e.KSoyadi).HasColumnName("k_soyadi");

                entity.Property(e => e.KTelefon).HasColumnName("k_telefon");

                entity.Property(e => e.RolId).HasColumnName("rol_id");
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.ToTable("marka");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.MAdi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("m_adi");
            });

            modelBuilder.Entity<MarkaLogInsDel>(entity =>
            {
                entity.HasKey(e => e.MlidId);

                entity.ToTable("marka_log_ins_del");

                entity.Property(e => e.MlidId).HasColumnName("mlid_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.IslemTuru)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("islem_turu");

                entity.Property(e => e.MAdi)
                    .HasMaxLength(255)
                    .HasColumnName("m_adi");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");
            });

            modelBuilder.Entity<MarkaLogUp>(entity =>
            {
                entity.HasKey(e => e.MluId);

                entity.ToTable("marka_log_up");

                entity.Property(e => e.MluId).HasColumnName("mlu_id");

                entity.Property(e => e.EskiMAdi)
                    .HasMaxLength(255)
                    .HasColumnName("eski_m_adi");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.YeniMAdi)
                    .HasMaxLength(255)
                    .HasColumnName("yeni_m_adi");
            });

            modelBuilder.Entity<Markalar>(entity =>
            {
                entity.HasKey(e => e.MarkaId);

                entity.ToTable("markalar");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.MAdi).HasColumnName("m_adi");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("rol");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.RAdi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("r_adi");
            });

            modelBuilder.Entity<RolLogInsDel>(entity =>
            {
                entity.HasKey(e => e.RlidId);

                entity.ToTable("rol_log_ins_del");

                entity.Property(e => e.RlidId).HasColumnName("rlid_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.IslemTuru)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("islem_turu");

                entity.Property(e => e.RAdi)
                    .HasMaxLength(50)
                    .HasColumnName("r_adi");

                entity.Property(e => e.RolId).HasColumnName("rol_id");
            });

            modelBuilder.Entity<RolLogUp>(entity =>
            {
                entity.HasKey(e => e.RluId);

                entity.ToTable("rol_log_up");

                entity.Property(e => e.RluId).HasColumnName("rlu_id");

                entity.Property(e => e.EskiRAdi)
                    .HasMaxLength(50)
                    .HasColumnName("eski_r_adi");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.YeniRAdi)
                    .HasMaxLength(50)
                    .HasColumnName("yeni_r_adi");
            });

            modelBuilder.Entity<Roller>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.ToTable("roller");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.RAdi).HasColumnName("r_adi");
            });

            modelBuilder.Entity<Sati>(entity =>
            {
                entity.HasKey(e => e.SatisId);

                entity.ToTable("satis");

                entity.Property(e => e.SatisId).HasColumnName("satis_id");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.SDurum)
                    .HasMaxLength(50)
                    .HasColumnName("s_durum");

                entity.Property(e => e.STarih)
                    .HasColumnType("date")
                    .HasColumnName("s_tarih");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Satis)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_satis_kullanici");
            });

            modelBuilder.Entity<SatisLogInsDel>(entity =>
            {
                entity.HasKey(e => e.SlidId);

                entity.ToTable("satis_log_ins_del");

                entity.Property(e => e.SlidId).HasColumnName("slid_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.IslemTuru)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("islem_turu");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.SDurum)
                    .HasMaxLength(50)
                    .HasColumnName("s_durum");

                entity.Property(e => e.STarih)
                    .HasColumnType("date")
                    .HasColumnName("s_tarih");

                entity.Property(e => e.SatisId).HasColumnName("satis_id");
            });

            modelBuilder.Entity<SatisLogUp>(entity =>
            {
                entity.HasKey(e => e.SluId);

                entity.ToTable("satis_log_up");

                entity.Property(e => e.SluId).HasColumnName("slu_id");

                entity.Property(e => e.EskiKullaniciId).HasColumnName("eski_kullanici_id");

                entity.Property(e => e.EskiSDurum)
                    .HasMaxLength(50)
                    .HasColumnName("eski_s_durum");

                entity.Property(e => e.EskiSTarih)
                    .HasColumnType("date")
                    .HasColumnName("eski_s_tarih");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.YeniKullaniciId).HasColumnName("yeni_kullanici_id");

                entity.Property(e => e.YeniSDurum)
                    .HasMaxLength(50)
                    .HasColumnName("yeni_s_durum");

                entity.Property(e => e.YeniSTarih)
                    .HasColumnType("date")
                    .HasColumnName("yeni_s_tarih");
            });

            modelBuilder.Entity<SatisMaddeleri>(entity =>
            {
                entity.HasKey(e => e.SmId);

                entity.ToTable("satis_maddeleri");

                entity.Property(e => e.SmId).HasColumnName("sm_id");

                entity.Property(e => e.SatisId).HasColumnName("satis_id");

                entity.Property(e => e.SiFiyat).HasColumnName("si_fiyat");

                entity.Property(e => e.SiIskonto).HasColumnName("si_iskonto");

                entity.Property(e => e.SiMiktar).HasColumnName("si_miktar");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.HasOne(d => d.Satis)
                    .WithMany(p => p.SatisMaddeleris)
                    .HasForeignKey(d => d.SatisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_satis_maddeleri_satis");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.SatisMaddeleris)
                    .HasForeignKey(d => d.UrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_satis_maddeleri_urun");
            });

            modelBuilder.Entity<Satisler>(entity =>
            {
                entity.HasKey(e => e.SatisId);

                entity.ToTable("satisler");

                entity.Property(e => e.SatisId).HasColumnName("satis_id");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.SDurum).HasColumnName("s_durum");

                entity.Property(e => e.STarih).HasColumnName("s_tarih");
            });

            modelBuilder.Entity<Smaddeleri>(entity =>
            {
                entity.HasKey(e => e.SmId);

                entity.ToTable("smaddeleri");

                entity.Property(e => e.SmId).HasColumnName("sm_id");

                entity.Property(e => e.SatisId).HasColumnName("satis_id");

                entity.Property(e => e.SiFiyat).HasColumnName("si_fiyat");

                entity.Property(e => e.SiIskonto).HasColumnName("si_iskonto");

                entity.Property(e => e.SiMiktar).HasColumnName("si_miktar");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<SmaddeleriLogInsDel>(entity =>
            {
                entity.HasKey(e => e.SmlidId);

                entity.ToTable("smaddeleri_log_ins_del");

                entity.Property(e => e.SmlidId).HasColumnName("smlid_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.IslemTuru)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("islem_turu");

                entity.Property(e => e.SatisId).HasColumnName("satis_id");

                entity.Property(e => e.SiFiyat).HasColumnName("si_fiyat");

                entity.Property(e => e.SiIskonto).HasColumnName("si_iskonto");

                entity.Property(e => e.SiMiktar).HasColumnName("si_miktar");

                entity.Property(e => e.SmId).HasColumnName("sm_id");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<SmaddeleriLogUp>(entity =>
            {
                entity.HasKey(e => e.SmluId);

                entity.ToTable("smaddeleri_log_up");

                entity.Property(e => e.SmluId).HasColumnName("smlu_id");

                entity.Property(e => e.EskiSatisId).HasColumnName("eski_satis_id");

                entity.Property(e => e.EskiSiFiyat).HasColumnName("eski_si_fiyat");

                entity.Property(e => e.EskiSiIskonto).HasColumnName("eski_si_iskonto");

                entity.Property(e => e.EskiSiMiktar).HasColumnName("eski_si_miktar");

                entity.Property(e => e.EskiUrunId).HasColumnName("eski_urun_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.YeniSatisId).HasColumnName("yeni_satis_id");

                entity.Property(e => e.YeniSiFiyat).HasColumnName("yeni_si_fiyat");

                entity.Property(e => e.YeniSiIskonto).HasColumnName("yeni_si_iskonto");

                entity.Property(e => e.YeniSiMiktar).HasColumnName("yeni_si_miktar");

                entity.Property(e => e.YeniUrunId).HasColumnName("yeni_urun_id");
            });

            modelBuilder.Entity<Stok>(entity =>
            {
                entity.ToTable("stok");

                entity.Property(e => e.StokId)
                    .ValueGeneratedNever()
                    .HasColumnName("stok_id");

                entity.Property(e => e.SAdedi).HasColumnName("s_adedi");

                entity.Property(e => e.SBitisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("s_bitis_tarihi");

                entity.Property(e => e.SGirisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("s_giris_tarihi");
            });

            modelBuilder.Entity<StokLogInsDel>(entity =>
            {
                entity.HasKey(e => e.StlidId);

                entity.ToTable("stok_log_ins_del");

                entity.Property(e => e.StlidId).HasColumnName("stlid_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.IslemTuru)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("islem_turu");

                entity.Property(e => e.SAdedi).HasColumnName("s_adedi");

                entity.Property(e => e.SBitisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("s_bitis_tarihi");

                entity.Property(e => e.SGirisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("s_giris_tarihi");

                entity.Property(e => e.StokId).HasColumnName("stok_id");
            });

            modelBuilder.Entity<StokLogUp>(entity =>
            {
                entity.HasKey(e => e.StluIp);

                entity.ToTable("stok_log_up");

                entity.Property(e => e.StluIp).HasColumnName("stlu_ip");

                entity.Property(e => e.EskiSAdedi).HasColumnName("eski_s_adedi");

                entity.Property(e => e.EskiSBitisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("eski_s_bitis_tarihi");

                entity.Property(e => e.EskiSGirisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("eski_s_giris_tarihi");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.YeniSAdedi).HasColumnName("yeni_s_adedi");

                entity.Property(e => e.YeniSBitisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("yeni_s_bitis_tarihi");

                entity.Property(e => e.YeniSGirisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("yeni_s_giris_tarihi");
            });

            modelBuilder.Entity<Stoklar>(entity =>
            {
                entity.HasKey(e => e.StokId);

                entity.ToTable("stoklar");

                entity.Property(e => e.StokId).HasColumnName("stok_id");

                entity.Property(e => e.SAdedi).HasColumnName("s_adedi");

                entity.Property(e => e.SBitisTarihi).HasColumnName("s_bitis_tarihi");

                entity.Property(e => e.SId).HasColumnName("s_id");
            });

            modelBuilder.Entity<Urun>(entity =>
            {
                entity.ToTable("urun");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.StokId).HasColumnName("stok_id");

                entity.Property(e => e.UAdi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("u_adi");

                entity.Property(e => e.UAgirlik).HasColumnName("u_agirlik");

                entity.Property(e => e.UBarkodu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("u_barkodu");

                entity.Property(e => e.UFiyat).HasColumnName("u_fiyat");

                entity.Property(e => e.URengi)
                    .HasMaxLength(50)
                    .HasColumnName("u_rengi");

                entity.Property(e => e.UTuketimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("u_tuketim_tarihi");

                entity.Property(e => e.UUretimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("u_uretim_tarihi");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Uruns)
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_urun_kategori");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Uruns)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_urun_marka");

                entity.HasOne(d => d.Stok)
                    .WithMany(p => p.Uruns)
                    .HasForeignKey(d => d.StokId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_urun_stok");
            });

            modelBuilder.Entity<UrunLogInsDel>(entity =>
            {
                entity.HasKey(e => e.UlidId);

                entity.ToTable("urun_log_ins_del");

                entity.Property(e => e.UlidId).HasColumnName("ulid_id");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.IslemTuru)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("islem_turu");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.StokId).HasColumnName("stok_id");

                entity.Property(e => e.UAdi)
                    .HasMaxLength(255)
                    .HasColumnName("u_adi");

                entity.Property(e => e.UAgirlik).HasColumnName("u_agirlik");

                entity.Property(e => e.UBarkodu)
                    .HasMaxLength(255)
                    .HasColumnName("u_barkodu");

                entity.Property(e => e.UFiyat).HasColumnName("u_fiyat");

                entity.Property(e => e.URengi)
                    .HasMaxLength(50)
                    .HasColumnName("u_rengi");

                entity.Property(e => e.UTuketimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("u_tuketim_tarihi");

                entity.Property(e => e.UUretimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("u_uretim_tarihi");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<UrunLogUp>(entity =>
            {
                entity.HasKey(e => e.UluId);

                entity.ToTable("urun_log_up");

                entity.Property(e => e.UluId).HasColumnName("ulu_id");

                entity.Property(e => e.EskiKategoriId).HasColumnName("eski_kategori_id");

                entity.Property(e => e.EskiMarkaId).HasColumnName("eski_marka_id");

                entity.Property(e => e.EskiStokId).HasColumnName("eski_stok_id");

                entity.Property(e => e.EskiUAdi)
                    .HasMaxLength(255)
                    .HasColumnName("eski_u_adi");

                entity.Property(e => e.EskiUAgirlik).HasColumnName("eski_u_agirlik");

                entity.Property(e => e.EskiUBarkodu)
                    .HasMaxLength(255)
                    .HasColumnName("eski_u_barkodu");

                entity.Property(e => e.EskiUFiyat).HasColumnName("eski_u_fiyat");

                entity.Property(e => e.EskiURengi)
                    .HasMaxLength(50)
                    .HasColumnName("eski_u_rengi");

                entity.Property(e => e.EskiUTuketimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("eski_u_tuketim_tarihi");

                entity.Property(e => e.EskiUUretimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("eski_u_uretim_tarihi");

                entity.Property(e => e.IslemIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("islem_ip");

                entity.Property(e => e.IslemTarihi)
                    .HasColumnType("date")
                    .HasColumnName("islem_tarihi");

                entity.Property(e => e.YeniKategoriId).HasColumnName("yeni_kategori_id");

                entity.Property(e => e.YeniMarkaId).HasColumnName("yeni_marka_id");

                entity.Property(e => e.YeniStokId).HasColumnName("yeni_stok_id");

                entity.Property(e => e.YeniUAdi)
                    .HasMaxLength(255)
                    .HasColumnName("yeni_u_adi");

                entity.Property(e => e.YeniUAgirlik).HasColumnName("yeni_u_agirlik");

                entity.Property(e => e.YeniUBarkodu)
                    .HasMaxLength(255)
                    .HasColumnName("yeni_u_barkodu");

                entity.Property(e => e.YeniUFiyat).HasColumnName("yeni_u_fiyat");

                entity.Property(e => e.YeniURengi)
                    .HasMaxLength(50)
                    .HasColumnName("yeni_u_rengi");

                entity.Property(e => e.YeniUTuketimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("yeni_u_tuketim_tarihi");

                entity.Property(e => e.YeniUUretimTarihi)
                    .HasColumnType("date")
                    .HasColumnName("yeni_u_uretim_tarihi");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("urunler");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.StokId).HasColumnName("stok_id");

                entity.Property(e => e.UAdi).HasColumnName("u_adi");

                entity.Property(e => e.UAgirlik).HasColumnName("u_agirlik");

                entity.Property(e => e.UBarkodu).HasColumnName("u_barkodu");

                entity.Property(e => e.UFiyat).HasColumnName("u_fiyat");

                entity.Property(e => e.URengi).HasColumnName("u_rengi");

                entity.Property(e => e.UTuketimTarihi).HasColumnName("u_tuketim_tarihi");

                entity.Property(e => e.UUretimTarihi).HasColumnName("u_uretim_tarihi");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
