namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_121 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.A24",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        A24_001_c = c.String(nullable: false, maxLength: 80),
                        A24_002_c = c.String(nullable: false, maxLength: 3),
                        A24_003_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A24_007_n = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A24_008_c = c.String(nullable: false, maxLength: 7),
                        Timestamp = c.DateTime(nullable: false),
                        A23_ukey = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.A23", t => t.A23_ukey, cascadeDelete: true)
                .Index(t => t.A23_ukey);
            
            CreateTable(
                "dbo.A25",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        A25_001_c = c.String(nullable: false, maxLength: 8),
                        A25_002_c = c.String(maxLength: 80),
                        A25_003_c = c.String(maxLength: 60),
                        Timestamp = c.DateTime(nullable: false),
                        A24_ukey = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.A24", t => t.A24_ukey, cascadeDelete: true)
                .Index(t => t.A24_ukey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.A25", "A24_ukey", "dbo.A24");
            DropForeignKey("dbo.A24", "A23_ukey", "dbo.A23");
            DropIndex("dbo.A25", new[] { "A24_ukey" });
            DropIndex("dbo.A24", new[] { "A23_ukey" });
            DropTable("dbo.A25");
            DropTable("dbo.A24");
        }
    }
}
