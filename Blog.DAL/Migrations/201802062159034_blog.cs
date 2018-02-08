namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Iletisim",
                c => new
                    {
                        MailId = c.Int(nullable: false, identity: true),
                        IletisimKonu = c.String(),
                        IletisimMail = c.String(),
                        Mesaj = c.String(),
                    })
                .PrimaryKey(t => t.MailId);
            
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(maxLength: 50),
                        Aciklama = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Makale",
                c => new
                    {
                        MakaleId = c.Int(nullable: false, identity: true),
                        Baslik = c.String(maxLength: 500),
                        Icerik = c.String(),
                        EklenmeTarihi = c.DateTime(),
                        KategoriId = c.Int(),
                        KullaniciId = c.Int(),
                        ResimId = c.Int(),
                    })
                .PrimaryKey(t => t.MakaleId)
                .ForeignKey("dbo.Kategori", t => t.KategoriId)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciId)
                .ForeignKey("dbo.Resim", t => t.ResimId)
                .Index(t => t.KategoriId)
                .Index(t => t.KullaniciId)
                .Index(t => t.ResimId);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Soyadi = c.String(nullable: false, maxLength: 50),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        Parola = c.String(nullable: false, maxLength: 50),
                        MailAdres = c.String(nullable: false, maxLength: 50),
                        Cinsiyet = c.Boolean(),
                        DogumTarihi = c.DateTime(),
                        KayitTarihi = c.DateTime(),
                        Onaylandi = c.Boolean(),
                        Aktif = c.Boolean(),
                        Yazar = c.Boolean(),
                        ResimId = c.Int(),
                        Aciklama = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.KullaniciId)
                .ForeignKey("dbo.Resim", t => t.ResimId)
                .Index(t => t.ResimId);
            
            CreateTable(
                "dbo.KullaniciRol",
                c => new
                    {
                        KullaniciRolId = c.Int(nullable: false, identity: true),
                        RolId = c.Int(),
                        KullaniciId = c.Int(),
                    })
                .PrimaryKey(t => t.KullaniciRolId)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciId)
                .ForeignKey("dbo.Rol", t => t.RolId)
                .Index(t => t.RolId)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        RolAdi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.Resim",
                c => new
                    {
                        ResimId = c.Int(nullable: false, identity: true),
                        ResimYolu = c.String(),
                    })
                .PrimaryKey(t => t.ResimId);
            
            CreateTable(
                "dbo.Yorum",
                c => new
                    {
                        YorumId = c.Int(nullable: false, identity: true),
                        YorumIcerigi = c.String(),
                        MakaleId = c.Int(),
                        EklenmeTarihi = c.DateTime(),
                        AdSoyad = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.YorumId)
                .ForeignKey("dbo.Makale", t => t.MakaleId)
                .Index(t => t.MakaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorum", "MakaleId", "dbo.Makale");
            DropForeignKey("dbo.Makale", "ResimId", "dbo.Resim");
            DropForeignKey("dbo.Makale", "KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.Kullanici", "ResimId", "dbo.Resim");
            DropForeignKey("dbo.KullaniciRol", "RolId", "dbo.Rol");
            DropForeignKey("dbo.KullaniciRol", "KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.Makale", "KategoriId", "dbo.Kategori");
            DropIndex("dbo.Yorum", new[] { "MakaleId" });
            DropIndex("dbo.KullaniciRol", new[] { "KullaniciId" });
            DropIndex("dbo.KullaniciRol", new[] { "RolId" });
            DropIndex("dbo.Kullanici", new[] { "ResimId" });
            DropIndex("dbo.Makale", new[] { "ResimId" });
            DropIndex("dbo.Makale", new[] { "KullaniciId" });
            DropIndex("dbo.Makale", new[] { "KategoriId" });
            DropTable("dbo.Yorum");
            DropTable("dbo.Resim");
            DropTable("dbo.Rol");
            DropTable("dbo.KullaniciRol");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Makale");
            DropTable("dbo.Kategori");
            DropTable("dbo.Iletisim");
        }
    }
}
