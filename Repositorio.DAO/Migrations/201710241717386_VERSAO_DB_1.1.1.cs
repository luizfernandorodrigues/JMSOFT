namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_111 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.A22",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        A22_001_c = c.String(nullable: false, maxLength: 100),
                        A22_002_c = c.String(nullable: false, maxLength: 4),
                        A22_003_c = c.String(maxLength: 400),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey);
            
            CreateTable(
                "dbo.A23",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        A23_001_c = c.String(nullable: false, maxLength: 2),
                        A23_002_c = c.String(nullable: false, maxLength: 30),
                        A23_003_c = c.String(maxLength: 2),
                        A23_004_c = c.String(maxLength: 400),
                        Timestamp = c.DateTime(nullable: false),
                        A22_ukey = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.A22", t => t.A22_ukey, cascadeDelete: true)
                .Index(t => t.A22_ukey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.A23", "A22_ukey", "dbo.A22");
            DropIndex("dbo.A23", new[] { "A22_ukey" });
            DropTable("dbo.A23");
            DropTable("dbo.A22");
        }
    }
}
