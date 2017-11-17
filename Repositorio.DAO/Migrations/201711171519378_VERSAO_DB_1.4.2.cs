namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_142 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Ssl", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Ssl", c => c.Int(nullable: false));
        }
    }
}
