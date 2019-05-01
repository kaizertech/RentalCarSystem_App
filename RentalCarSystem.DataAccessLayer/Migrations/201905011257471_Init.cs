namespace RentalCarSystem.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Araba_ID = c.Int(nullable: false, identity: true),
                        Sirket_id = c.Int(nullable: false),
                        Araba_Ad = c.String(),
                        Araba_Model = c.String(),
                        Araba_GunlukKmSiniri = c.Int(nullable: false),
                        Araba_AirBag = c.Boolean(nullable: false),
                        Araba_BagajHacmi = c.Int(nullable: false),
                        Araba_KoltukSayisi = c.Int(nullable: false),
                        Araba_GunlukKira = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Araba_ID)
                .ForeignKey("dbo.Companies", t => t.Sirket_id, cascadeDelete: true)
                .Index(t => t.Sirket_id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Sirket_ID = c.Int(nullable: false, identity: true),
                        Sirket_Ad = c.String(),
                        Sirket_Sehir = c.String(),
                        Sirket_Adres = c.String(),
                        Sirket_AracSayisi = c.Int(nullable: false),
                        SirketPuan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sirket_ID);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Kiralama_ID = c.Int(nullable: false, identity: true),
                        Musteri_id = c.Int(nullable: false),
                        Araba_id = c.Int(nullable: false),
                        BaslangicTarihi = c.DateTime(nullable: false),
                        BitisTarihi = c.DateTime(nullable: false),
                        VerilisKM = c.Int(nullable: false),
                        AlisKm = c.Int(nullable: false),
                        Ucret = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Kiralama_ID)
                .ForeignKey("dbo.Cars", t => t.Araba_id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Musteri_id, cascadeDelete: true)
                .Index(t => t.Musteri_id)
                .Index(t => t.Araba_id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Musteri_ID = c.Int(nullable: false, identity: true),
                        Musteri_Ad = c.String(),
                        Musteri_Soyad = c.String(),
                        Musteri_TC = c.String(),
                        Musteri_KullaniciAdi = c.String(),
                        Musteri_Sifre = c.String(),
                    })
                .PrimaryKey(t => t.Musteri_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Musteri_id", "dbo.Customers");
            DropForeignKey("dbo.Transactions", "Araba_id", "dbo.Cars");
            DropForeignKey("dbo.Cars", "Sirket_id", "dbo.Companies");
            DropIndex("dbo.Transactions", new[] { "Araba_id" });
            DropIndex("dbo.Transactions", new[] { "Musteri_id" });
            DropIndex("dbo.Cars", new[] { "Sirket_id" });
            DropTable("dbo.Customers");
            DropTable("dbo.Transactions");
            DropTable("dbo.Companies");
            DropTable("dbo.Cars");
        }
    }
}
