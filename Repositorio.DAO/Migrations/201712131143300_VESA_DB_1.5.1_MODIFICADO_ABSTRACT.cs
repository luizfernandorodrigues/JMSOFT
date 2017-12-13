namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VESA_DB_151_MODIFICADO_ABSTRACT : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.A10", "Cia_ukey", c => c.Guid(nullable: false));
            AddColumn("dbo.T01", "Cia_ukey", c => c.Guid(nullable: false));
            AddColumn("dbo.T02", "Cia_ukey", c => c.Guid(nullable: false));
            CreateIndex("dbo.A10", "Cia_ukey");
            CreateIndex("dbo.T01", "Cia_ukey");
            CreateIndex("dbo.T02", "Cia_ukey");
            AddForeignKey("dbo.A10", "Cia_ukey", "dbo.A10", "Ukey");
            AddForeignKey("dbo.T01", "Cia_ukey", "dbo.A10", "Ukey", cascadeDelete: false);
            AddForeignKey("dbo.T02", "Cia_ukey", "dbo.A10", "Ukey", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T02", "Cia_ukey", "dbo.A10");
            DropForeignKey("dbo.T01", "Cia_ukey", "dbo.A10");
            DropForeignKey("dbo.A10", "Cia_ukey", "dbo.A10");
            DropIndex("dbo.T02", new[] { "Cia_ukey" });
            DropIndex("dbo.T01", new[] { "Cia_ukey" });
            DropIndex("dbo.A10", new[] { "Cia_ukey" });
            DropColumn("dbo.T02", "Cia_ukey");
            DropColumn("dbo.T01", "Cia_ukey");
            DropColumn("dbo.A10", "Cia_ukey");
        }
    }
}
