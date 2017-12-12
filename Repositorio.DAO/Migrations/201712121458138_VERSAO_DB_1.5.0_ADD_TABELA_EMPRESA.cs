namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_150_ADD_TABELA_EMPRESA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.A10",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        A10_001_c = c.String(nullable: false, maxLength: 20),
                        A10_002_c = c.String(nullable: false, maxLength: 80),
                        A10_003_c = c.String(nullable: false, maxLength: 80),
                        A10_004_c = c.String(nullable: false, maxLength: 40),
                        A10_005_c = c.String(nullable: false, maxLength: 10),
                        A10_006_c = c.String(nullable: false, maxLength: 50),
                        A10_007_c = c.String(maxLength: 60),
                        A10_009_c = c.String(nullable: false, maxLength: 20),
                        A10_010_c = c.String(maxLength: 20),
                        A10_011_c = c.String(maxLength: 20),
                        A10_012_c = c.String(maxLength: 80),
                        A10_013_c = c.String(maxLength: 20),
                        A10_014_d = c.DateTime(nullable: false),
                        A10_015_c = c.String(nullable: false, maxLength: 20),
                        A10_016_c = c.String(nullable: false, maxLength: 20),
                        A10_017_c = c.String(nullable: false, maxLength: 20),
                        A10_018_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_019_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_020_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_021_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_022_c = c.String(nullable: false, maxLength: 100),
                        A10_023_c = c.String(maxLength: 50),
                        A10_024_c = c.String(maxLength: 20),
                        A10_025_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_026_c = c.Binary(nullable: false, storeType: "image"),
                        A10_027_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_028_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_029_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_031_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_032_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A10_038_c = c.String(maxLength: 20),
                        A10_039_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A25_ukey = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        User_note = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.A25", t => t.A25_ukey, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.User_note, cascadeDelete: true)
                .Index(t => t.A25_ukey)
                .Index(t => t.User_note);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.A10", "User_note", "dbo.Usuarios");
            DropForeignKey("dbo.A10", "A25_ukey", "dbo.A25");
            DropIndex("dbo.A10", new[] { "User_note" });
            DropIndex("dbo.A10", new[] { "A25_ukey" });
            DropTable("dbo.A10");
        }
    }
}
